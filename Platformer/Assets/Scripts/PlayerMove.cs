using UnityEngine;
using System.Collections;
using UnityEditor.Tilemaps;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float moveInput;
    private Rigidbody2D ridbody;
    public SpriteRenderer spriteRen;

    private void Start()
    {
        ridbody = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        moveInput = Input.GetAxis("Horizontal");
        ridbody.velocity = new Vector2(moveInput * speed, ridbody.velocity.y);
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
