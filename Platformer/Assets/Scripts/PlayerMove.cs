using UnityEngine;
using System.Collections;
using UnityEditor.Tilemaps;

public class PlayerMove : MonoBehaviour
{
    public float force;
    public float speed;
    public float moveInput;
    public Rigidbody2D ridbody;
    public SpriteRenderer spriteRen;

    private void Start()
    {
        ridbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Move Character X
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        moveInput = Input.GetAxis("Horizontal");
        ridbody.velocity = new Vector2(moveInput * speed, ridbody.velocity.y);

        //Jump Character Y
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ridbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {

        //Flip Character
        if (moveInput < 0)
        {
            spriteRen.flipX = true;
        }
        if (moveInput > 0)
        {
            spriteRen.flipX = false;
        }

    }
}
