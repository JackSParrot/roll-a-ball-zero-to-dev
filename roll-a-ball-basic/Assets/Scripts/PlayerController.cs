using TMPro;
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float      Speed       = 5f;
    public TMP_Text   ScoreText   = null;
    public TMP_Text   MessageText = null;
    public GameObject Blocked     = null;
    public GameObject Exit        = null;
    public Rigidbody  Rigidbody    = null;
    
    private Vector3   _direction = Vector3.zero;

    private void Awake()
    {
        Blocked.SetActive(true);
        Exit.SetActive(false);
        MessageText.text = "";
        ScoreText.text = "Score: 0/8";
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        _direction = new Vector3(h, 0f, v).normalized;
    }

    private void FixedUpdate()
    {
        Rigidbody.AddForce(_direction * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("blocked"))
        {
            MessageText.text = "You need to pickup all blocks";
            StartCoroutine(HideTextCoroutine());
        }
        else if (other.CompareTag("exit"))
        {
            GameManager.Instance.GoToMenu();
        }
        else if (other.CompareTag("pickup"))
        {
            GameManager.Instance.Score++;
            other.gameObject.SetActive(false);
            ScoreText.text = "Score: " + GameManager.Instance.Score + "/8";
            if (GameManager.Instance.Score == 8)
            {
                Blocked.SetActive(false);
                Exit.SetActive(true);
            }
        }
    }

    private IEnumerator HideTextCoroutine()
    {
        yield return new WaitForSeconds(3f);
        MessageText.text = "";
    }
}
