using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject food;
    private CharacterController controller;
    private Vector3 playerVelocity;

    public bool isMoving;
    public float playerSpeed;
    public float gravityValue = -9.81f;
    public Animator animator;

    public void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        Movement();
        Throwing();
    }

    public void Movement()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Left", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Left", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Right", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Right", false);
        }

        if (move != Vector3.zero)
        {
            gameObject.transform.position = move;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void Throwing()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Throw");
            Instantiate(food, transform.position, transform.rotation);
        }
    }

    
}