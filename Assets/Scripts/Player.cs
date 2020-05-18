using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Player : MonoBehaviour 
{

    public bool hasSword, hasSpear, hasAx, hasBow, hasBoots, hasGloves, hasRope, hasDash = false;
    public int attLvl, dexLvl, invLvl, spdLvl = 1;

    public int speed, jumpHeight, health, knockback, stun, dmg, invTime;
    public int[] attackFrames;

    private bool isGrounded, isAttacking, isHitstun, isInv;

    public Rigidbody2D rb;
    public Animator anim;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
       
    }

    void FixedUpdate()
    {

    }

    public IEnumerator Attack()
    {
        return null;
    }

    public void TakeDamage()
    {

    }

    
}
