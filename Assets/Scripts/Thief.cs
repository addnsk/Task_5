using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class Thief : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    public bool isHouse { get; private set; }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            _rigidbody2D.AddForce(Vector2.right * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftArrow))
            _rigidbody2D.AddForce(Vector2.left * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isHouse = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isHouse = false;
    }
}
