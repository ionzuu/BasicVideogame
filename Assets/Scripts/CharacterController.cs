using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float dirX, dirY, moveSpeed;
    // Comentario
    Animator anim;

    // Initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
    }

    //Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        dirY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = new Vector2 (transform.position.x + dirX, transform.position.y + dirY);

        /*

        if (dirX != 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("Kick"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetButtonDown("fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("Kick"))
        {
            anim.SetBool("isWalking", false);
            anim.SetTrigger("Hit");
        }
        */
    }

}
