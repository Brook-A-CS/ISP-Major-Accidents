using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public Transform connectionPoint;
    public GameObject attachment;

    void Start() 
    {
        Vector3 connectionPointPosition = connectionPoint.position;
        float size = attachment.transform.localScale.x;
        
        connectionPoint.Translate(Vector3.right * size/2);
    }
    // Update is called once per frame
    void Update()
    {
      Place();
    }

    private void Place()
    {
        //0 is left click; 1 is right
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 connectionPointPosition = connectionPoint.position;
            float size = attachment.transform.localScale.x;
            
            //connectionPoint.Translate(Vector3.right * size/2);

            //GameObject newAttachment = Instantiate(attachment, new Vector3(connectionPointPosition.x + (size / 2),connectionPointPosition.y, connectionPointPosition.z ), connectionPoint.rotation);
            GameObject newAttachment = Instantiate(attachment, connectionPointPosition, connectionPoint.rotation);

            newAttachment.transform.SetParent(connectionPoint);
        }
    }
}
