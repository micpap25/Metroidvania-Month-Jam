using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int health, damage, knockback, stun, inv;

    

    public void TakeDamage(int _damage) {
        health -= _damage;
        //change sprite to stunned and flicker it
        
    }

}
