using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehave : MonoBehaviour
{
    public Rigidbody2D leftBoby;
    public Rigidbody2D rightBoby;
    Rigidbody2D mainBoby;

    public float power;

   
    // Start is called before the first frame update
    void Start()
    {
        mainBoby = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftBoby.AddForce(-transform.up * power, ForceMode2D.Impulse);
            mainBoby.velocity = new Vector3(-power, power, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rightBoby.AddForce(transform.right * power, ForceMode2D.Impulse);
            mainBoby.velocity = new Vector3(power, power, 0);

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
    
        if (other.gameObject.name == "star")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ground")
        {
            SceneManager.LoadScene("GameOver");
        }
    }


}
