using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private GameObject m_camera;
    private Transform connectionPoint;
    private GameObject attachment;
    //gets var from global script 
    private ChooseAttachment chooseAttachment;
    private int attachIndex;

    void Awake() 
    {
        m_camera = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        chooseAttachment = m_camera.GetComponent<ChooseAttachment>();
    }

    void Start()
    {
    }

    void Update() 
    {
        //array pos key: 
        //0 = circle; 1 = rectangle
        attachment = GameObject.FindGameObjectsWithTag("Attachments")[attachIndex];
        switchAttachment();
    }

    // void LateUpdate()
    // {
    //     if (placed)
    //     {
    //     Debug.Log(placed);
    //     Destroy(this.gameObject);
    //     }
    // }

    private void switchAttachment()
    {
        //Debug.Log(chooseAttac hment.equiped);
        switch (chooseAttachment.equiped)
        {
            case 1:
                attachIndex = 0;
                //Debug.Log("1");
                break;
            case 2:
                attachIndex = 1;
                //Debug.Log("2");
                break;
            default:
                break;
        }
    }

    private void OnMouseDown()
    {
        //0 is left click; 1 is right
        if (Input.GetMouseButtonDown(0)) 
        {
            connectionPoint = this.gameObject.transform;
            float size = attachment.transform.localScale.x;
        
            connectionPoint.Translate(Vector3.right * size/2);
            Vector3 connectionPointPosition = connectionPoint.position;

            GameObject newAttachment = Instantiate(attachment, connectionPointPosition, connectionPoint.rotation);

            newAttachment.transform.SetParent(connectionPoint);

            //placed = true;

        }
    }

}