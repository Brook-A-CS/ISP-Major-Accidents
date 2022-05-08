using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {
    
    public Transform GunSpot;
    public GameObject bulletPrefab;
    int bulletLayer;

    public float fireDelay = 0.50f;
    float cooldownTimer = 0;

    void Start() {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update() {
        cooldownTimer -= Time.deltaTime;

        if( cooldownTimer <= 0) {
            //Shoot
            //Debug.Log ("Pew!");
            cooldownTimer = fireDelay;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = bulletLayer;
        }
    }
}
