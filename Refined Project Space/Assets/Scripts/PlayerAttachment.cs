using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttachment : MonoBehaviour
{
    public Transform connectionPoint;
    public GameObject connector;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Place();
        }
    }

    void Place()
    {
        Vector3 connectionPointPosition = connectionPoint.position;
        float size = connector.transform.localScale.x;

        GameObject newConnector = Instantiate(connector, new Vector3(connectionPointPosition.x + (size / 2),connectionPointPosition.y, connectionPointPosition.z ), connectionPoint.rotation);

        newConnector.transform.SetParent(connectionPoint);

    }
}
