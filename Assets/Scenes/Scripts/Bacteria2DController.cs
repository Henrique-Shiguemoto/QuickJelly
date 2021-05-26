using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria2DController : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;
    private Vector3 moveDir;
    [SerializeField] private float bactSpeed = 10f;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }

        moveDir = new Vector3(moveX, moveY).normalized;

    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = moveDir*bactSpeed;
    }
}
