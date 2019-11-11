using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    public bool isGrounded;
    Rigidbody2D rb;
    public float jumpForce = 5;
    public int extraJumps;
    private int nJumps;
    Animator anim;
    GameObject go;
    bool jump;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        nJumps = 1;
        anim = GetComponent<Animator>();
        go = gameObject;

    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (isGrounded == true)
        {
            extraJumps = nJumps;
            anim.SetBool("isGrounded", isGrounded);
        }

            jump = Input.GetKey(KeyCode.I);

        if (jump && extraJumps > 0)
        {
            isGrounded = false;
            anim.SetBool("isGrounded", isGrounded);
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;


            FindObjectOfType<AudioManager1>().PlayJumpSound();
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = (collision.gameObject.CompareTag("Platform"));
    }
}
