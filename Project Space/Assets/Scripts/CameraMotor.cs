using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt; 
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate() 
    {
        Vector3 delta = Vector3.zero;

        //check in cam bounds.x  
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }  
        
        //check in cam bounds.y  
        float deltaY = lookAt.position.y - transform.position.y;
        if(deltaY > boundY || deltaY < -boundY)
        {
            if(transform.position.y < lookAt.position.x)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }  

        transform.position += new Vector3(delta.x, delta.y, 0);
    }

}

//1:02:46