using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehave : MonoBehaviour
{
    public Rigidbody2D armBoby;
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
        
    }
}
