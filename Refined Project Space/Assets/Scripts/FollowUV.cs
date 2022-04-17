using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUV : MonoBehaviour
{

    float parralax = 1.5f;

    // Update is called once per frame
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        //ensures that only the material attached to the game object is changed
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.x = transform.position.x / transform.localScale.x / parralax; 
        offset.y = transform.position.y / transform.localScale.y / parralax; 

        mat.mainTextureOffset = offset;

    }
}
