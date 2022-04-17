using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{

    //number of seconds it takes to loop
    private float scrollSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        //ensures that only the material attached to the game object is changed
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.x += Time.deltaTime / scrollSpeed; 

        mat.mainTextureOffset = offset;

    }
}
