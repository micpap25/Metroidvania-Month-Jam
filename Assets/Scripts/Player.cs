using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Player : MonoBehaviour 
{

    //TODO: 
    //make it so gravity doesn't stay constant when going through platforms (l 44, l 50)


    public bool hasSword, hasSpear, hasAx, hasBow, hasBoots, hasGloves, hasRope, hasDash = false;
    public int attLvl, dexLvl, invLvl, spdLvl = 1;

    public int speed, jumpHeight, health, knockback, stun, dmg, invTime;
    public int gravityScale;
    public int[] attackFrames;

    private bool isGrounded, isCrouching, isAttacking, isHitstun, isInv;
    private float x, y;

    public CompositeCollider2D col;
    public Rigidbody2D rb;
    public Animator anim;
    void Start() {
        col = GetComponent<CompositeCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
    }

    void FixedUpdate()
    {
        if (!isAttacking) {
            x = Input.GetAxisRaw("Horizontal");
        }
        y = Input.GetAxisRaw("Vertical");

        isGrounded = Physics2D.Raycast(transform.position - new Vector3(col.bounds.extents.x, col.bounds.extents.y, 0),  Vector2.down, .1f, LayerMask.GetMask("Ground")).collider ||
            Physics2D.Raycast(transform.position + new Vector3(col.bounds.extents.x, -col.bounds.extents.y, 0), Vector2.down, .1f, LayerMask.GetMask("Ground")).collider;

        if (!isGrounded || isGrounded && rb.velocity.y != 0) {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - gravityScale);
        }
        
        if (x != 0.0f)
            rb.velocity = new Vector2(x * speed, rb.velocity.y);
        else
            rb.velocity = new Vector2(0, rb.velocity.y);

        if (y > 0.5f && isGrounded && !isAttacking && !isHitstun && !isCrouching)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if (y < 0.5f)
        {
            //go to crouching animation
        }


    }

    public IEnumerator Attack()
    {
        return null;
    }

    public void TakeDamage()
    {

    }

    
}
