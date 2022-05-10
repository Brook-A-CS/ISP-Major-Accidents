using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAttachment : MonoBehaviour
{
    //#nullable enable
    public GameObject equiped;
    //#nullable disable
    public GameObject rectAttach;
    public GameObject cirAttach;
    public GameObject turret;

    // Start is called before the first frame update
    void Start()
    {
        equiped = rectAttach;
    }
    // Update is called once per frame
    void Update()
    {
        //alpha is num row
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            equiped = rectAttach;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            equiped = cirAttach;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            equiped = turret;
        }
        //Debug.Log(equiped);
    }
}
