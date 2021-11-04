using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody myRb;
    [SerializeField] private float speed;
    private Vector3 movementVector;
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        if (!myRb)
        {
            Debug.LogError("Error: No rigidBody set");
        }
    }

    private void Update()
    {
        movementVector = Vector3.zero;
        movementVector.z = Input.GetAxisRaw("Horizontal") * -1;
        movementVector.x = Input.GetAxisRaw("Vertical");
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        myRb.velocity = movementVector * speed; //when using velocity there is no need for time modifier
    }
}
