 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
      //  sr = GetComponent<SpriterRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
      //  Flip();
      Reflect();
       Jump();
       CheckingGround();
    }
      public Vector2 moveVector;
     public float speed = 2f;
     //------- Функция/метод для перемещения персонажа по горизонтали ---------
    void Walk()
            {
           moveVector.x = Input.GetAxisRaw("Horizontal");
                rb.velocity = new Vector2(moveVector.x *speed, rb.velocity.y);
                       // rb.AddForce(moveVector * speed); //  2 вид движения по инерции, why not work ..... // need increase a speed
                       anim.SetFloat("moveX", Mathf.Abs(moveVector.x));   
            }
            //------- Функция/метод для отражения персонажа по горизонтали ---------
        public bool faceRight = true;
            void Reflect()
                {
                    if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
                 {
                    transform.localScale *= new Vector2(-1, 1);
                    faceRight = !faceRight;
                 }
                }

        
       
        public int jumpForce = 10;
              void Jump()
{
          if (onGround && Input.GetKeyDown(KeyCode.Space))
{
       rb.velocity = new Vector2(rb.velocity.x, jumpForce);
}
}
                     public bool onGround;
                    public Transform GroundCheck;
                    public float GroundCheckRadius = 0.5f;
                     public LayerMask Ground;

              void CheckingGround()
        {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);
        anim.SetBool("onGround", onGround);
        }
}
