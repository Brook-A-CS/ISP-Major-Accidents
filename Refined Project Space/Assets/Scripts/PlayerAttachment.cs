using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttachment : MonoBehaviour
{
    public Transform connectionPoint;
    public GameObject attachment;

    // Update is called once per frame

    void Start() {

        Vector3 connectionPointPosition = connectionPoint.position;
        float size = attachment.transform.localScale.x;
        
        connectionPoint.Translate(Vector3.right * size/2);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Place();
        }
    }

    private void Place()
    {

        Vector3 connectionPointPosition = connectionPoint.position;
        float size = attachment.transform.localScale.x;
        
        //connectionPoint.Translate(Vector3.right * size/2);

        //GameObject newAttachment = Instantiate(attachment, new Vector3(connectionPointPosition.x + (size / 2),connectionPointPosition.y, connectionPointPosition.z ), connectionPoint.rotation);
        GameObject newAttachment = Instantiate(attachment, connectionPointPosition, connectionPoint.rotation);

        newAttachment.transform.SetParent(connectionPoint);

    }
}
