using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed;
    Vector3 movementInput = Vector3.zero;
    CharacterController character;
    public Animator animator;
    public float jumpSpeed;
    public float gravity;
    void Start()
    {
        character = GetComponent<CharacterController>();
        
    }

    void Update()
    {
        movementInput = new Vector3(0, movementInput.y, Input.GetAxis("Vertical"));
        movementInput = transform.TransformDirection(movementInput);
        movementInput.z *= speed;
        movementInput.x *= speed;

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (character.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(notJump());
        }

        movementInput.y -= gravity * Time.deltaTime;
        character.Move(movementInput * Time.deltaTime);
    }

    IEnumerator notJump()
    {
        animator.SetBool("Jump", true);
        yield return new WaitForSeconds(0.3f);
        movementInput.y = jumpSpeed;
        yield return new WaitForSeconds(0.2f);
        animator.SetBool("Jump", false);
    }
}
