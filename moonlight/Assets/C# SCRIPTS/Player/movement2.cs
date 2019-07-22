using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpforce;
    [SerializeField] private float raycastdisctance;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 

    }

    private void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed;

        Vector3 newPosition = rb.position + rb.transform.TransformDirection(movement);

        rb.MovePosition(newPosition);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded())
            {
                rb.AddForce(0, jumpforce, 0, ForceMode.Impulse);
            }
            
        }

    }

    private bool IsGrounded()
    {
        Debug.DrawRay(transform.position, Vector3.down * raycastdisctance, Color.blue);
        return Physics.Raycast(transform.position, Vector3.down, raycastdisctance);
    }
}    

