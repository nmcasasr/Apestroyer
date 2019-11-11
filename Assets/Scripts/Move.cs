using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    float xMov;
    float yMov; // For Flying feature
    public float speed;
    public float runSpeed;
    public float walkSpeed;
    public float force;
    public bool isGrounded;

    Animator anim;


    SpriteRenderer sr;
    GameObject go;
    bool run;
    float time = 0;
    bool pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        go = gameObject;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    
        //canRun = false; // For this scene, the Rat cannot run. Change to True in the scene where the Rat has the upgrade

    }

    // Update is called once per frame
    void Update()
    {

        xMov = Input.GetAxis("Horizontal") * speed;



        rb.velocity = new Vector2(xMov, rb.velocity.y / speed) * speed;
        //anim.SetFloat("velocidad", Mathf.Abs(xMov));

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
            
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isWalking", false);
        }
        if (xMov < 0.0f)
        {
            
            sr.flipX = true;
            
        }
        else if(xMov > 0.0f)
        {
            sr.flipX = false;
            
        }
        else
        {
            anim.SetBool("isWalking", false);

        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            FindObjectOfType<AudioManager1>().PlayThrowSound();
            anim.SetBool("isTrowing", true);
            pressed = true;
        }
        
        if(pressed)
        {
            time += Time.deltaTime;
            if(time > 0.5)
            {
                anim.SetBool("isTrowing", false);
                pressed = false;
                time = 0;
            }
            
        }
   
        

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = (collision.gameObject.CompareTag("Platform"));
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = !(collision.gameObject.CompareTag("Platform"));
    }
}
