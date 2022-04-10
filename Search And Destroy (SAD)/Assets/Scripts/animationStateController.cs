using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isMovingHash;
    int isJumpHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        isMovingHash = Animator.StringToHash("Ismoving");
        isJumpHash = Animator.StringToHash("Isjump");
        
    }

  
    void Update()
    {
        bool Ismoving = animator.GetBool("Ismoving");
        bool forwardPressed = Input.GetKey("w");

        // if player presses w key 
        if (!Ismoving && forwardPressed) 
        {
            // set moving boolean to true
            animator.SetBool(isMovingHash, true);
        }
        // if player not pressing w key 
        if (Ismoving && !forwardPressed) 
        {
            // set moving boolean to false
            animator.SetBool(isMovingHash, false);
        }

        bool Isjump = animator.GetBool("Isjump");
        bool jumpPressed = Input.GetKey("space");

        // if player presses spacebar key 
        if (!Isjump && jumpPressed)
        {
            // set jump boolean to true
            animator.SetBool(isJumpHash, true);
        }
        // if player not pressing spacebar key 
        if (Isjump && !jumpPressed)
        {
            // set jump boolean to false
            animator.SetBool(isJumpHash, false);
        }
    }
}
