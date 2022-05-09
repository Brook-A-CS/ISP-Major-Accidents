using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private GameObject m_camera;
    private Transform connectionPoint;
    public GameObject attachment;
    //gets var from global script 
    private ChooseAttachment chooseAttachment;
    private int attachIndex;

    private GameObject? newAttachment;

    public bool placed;

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
        CheckIfStillThere();
    }


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
            case 3:
                attachIndex = 2;
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
            //the ball to place an attchment is still there, but hidden, so there needs to be a way to disable it
            if (!placed) 
            {
            connectionPoint = this.gameObject.transform;
            float size = attachment.transform.localScale.x;
        
            connectionPoint.Translate(Vector3.right * size/2);
            Vector3 connectionPointPosition = connectionPoint.position;

            newAttachment = Instantiate(attachment, connectionPointPosition, connectionPoint.rotation);

            newAttachment.transform.SetParent(connectionPoint);

            placed = true;
            }

        }
    }

    private void CheckIfStillThere()
    {
        //Debug.Log(newAttachment);
        float size = attachment.transform.localScale.x;

        //if collisions activates, move connector back and allow new one to be placed
        if (newAttachment == null && placed == true)
        {
            connectionPoint.Translate(Vector3.left * size/2);
            placed = false;
        }
    }

    

}