using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Click click;
    //public GameObject parent;
    public GameObject conntectPoint;
    void Awake()
    { 
        click = conntectPoint.GetComponent<Click>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //finds most recently placed object since thats the only one that will be destoryed
        if (conntectPoint.transform.childCount > 0)
            {
                Debug.Log("cannot place there");
                Destroy(other.gameObject.transform.parent.gameObject);

                //conntectPoint.transform.Translate(Vector3.left * click.attachment.transform.localScale.x/2);

            }
    }
}