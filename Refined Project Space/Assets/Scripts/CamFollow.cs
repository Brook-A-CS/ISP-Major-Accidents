using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    void LateUpdate() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player != null) {
            Vector3 targPos = player.transform.position;
            targPos.z = transform.position.z;
            transform.position = targPos;
        }
    }

}
