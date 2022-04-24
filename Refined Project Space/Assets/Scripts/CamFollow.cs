using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform myTarget;
    //public PlayerSpawner script;

    void Awake () 
    {
        myTarget = GameObject.Find("Playership(Clone)").transform;
	}
    // Update is called once per frame
    void Update() {
        if(myTarget != null) {
            Vector3 targPos = myTarget.position;
            targPos.z = transform.position.z;
            transform.position = targPos;
        }
    }
}
