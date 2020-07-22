using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class Thief : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

     private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            _rigidbody2D.AddForce(Vector2.right * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftArrow))
            _rigidbody2D.AddForce(Vector2.left * Time.deltaTime);
    }
}
