// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Controler : MonoBehaviour
// {
// //------- Функция/метод, выполняемая при запуске игры ---------
// public Rigidbody2D rb;
// public Animator anim;
// void Start()
// {
// rb = GetComponent<Rigidbody2D>();
// //anim = GetComponent<Animator>();
// //-v- Для автоматического присваивания в переменную, радиуса коллайдера объекта «GroundCheck»
// GroundCheckRadius = GroundCheck.GetComponent<CircleCollider2D>().radius;
// }
// //------- Функция/метод, выполняемая каждый кадр в игре ---------
// void Update()
// {
// Walk();
// Reflect();
// Jump();
// CheckingGround();
// }
// //------- Функция/метод для перемещения персонажа по горизонтали ---------
// public Vector2 moveVector;
// public int speed = 3;
// void Walk()
// {
// moveVector.x = Input.GetAxisRaw("Horizontal");
// rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
// //anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
// }
// //------- Функция/метод для отражения персонажа по горизонтали ---------
// public bool faceRight = true;
// void Reflect()
// {
// if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
// {
// transform.localScale *= new Vector2(-1, 1);
// faceRight = !faceRight;
// }
// }
// //------- Функция/метод для прыжка ---------
// public int jumpForce = 10;
// void Jump()
// {
// if ( Input.GetKeyDown(KeyCode.Space) && onGround )
// {
// rb.velocity = new Vector2(rb.velocity.x, jumpForce);
// }
// }

// //------- Функция/метод для обнаружения земли ---------
// public bool onGround;
// public Transform GroundCheck;
// public float GroundCheckRadius = 0.5f;
// public LayerMask Ground;


// void CheckingGround()
// {
// onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);
// //anim.SetBool("onGround", onGround);
// }
// //-----------------------------------------------------------------
// }

// /*public float maxSpeed = 10f;
//     ptivate bool flipRight = true;
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float move = Input.GetAxis("Horizontal");
//         GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

//         if (move > 0 && !flipRight)
//         {
//             Flip();
//         }
//         else if (move  0 && flipRight)
//         {
//             Flip();
//         }

//     }
//     private void Flip()
//     {
//         flipRight = !flipRight;
//         Vector3 theScale = transform.localScale;
//         theScale.x *= -1;
//         transform.localScale = theScale;
//     }*/

