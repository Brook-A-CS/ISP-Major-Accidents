using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private Transform connectionPoint;
    public GameObject attachment;
    private ChooseAttachment chooseAttachment;
    [SerializeField] GameObject m_camera;

    void Awake() 
    {
        chooseAttachment = camera.GetComponent<ChooseAttachment>();
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
        }
    }
}
