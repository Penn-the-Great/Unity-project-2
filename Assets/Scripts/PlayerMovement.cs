using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        public float speed = 10f;
        Rigidbody2D rb;
        public float jumpForce = 5f;
        bool isGrounded = false;

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
                isGrounded = true;
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
                isGrounded = false;
        }

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);

           if (Input.GetKeyDown(KeyCode.W) && isGrounded)
           {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
           }
        }
}
