using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rb;
    public int damage = 40;
    //will be used for bullet impactEffect
    //public GameObject impactEffect;


    // Start is called before the first frame update
    void Start()
    {
        //rn it only moves right not where your aiming 
        rb.velocity = transform.up * speed;

        //bullet will disappear after 3 secs
        Destroy(gameObject, 3.0f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    
        //will be used for bullet impactEffect
        //Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
