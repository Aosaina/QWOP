using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            leftBoby.AddForce(-transform.up  * power, ForceMode2D.Impulse);
            mainBoby.velocity = new Vector3(-power, power, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rightBoby.AddForce(transform.right * power, ForceMode2D.Impulse);
            mainBoby.velocity = new Vector3(power, power, 0);
        }

    }
}
