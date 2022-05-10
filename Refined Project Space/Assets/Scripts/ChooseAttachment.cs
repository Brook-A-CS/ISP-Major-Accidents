using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseAttachment : MonoBehaviour
{
    //set to 0 by default
    public int equiped;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //alpha is num row
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            equiped = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            equiped = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            equiped = 3;
        }
        //Debug.Log(equiped);
    }
}
