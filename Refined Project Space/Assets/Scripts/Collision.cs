using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Click click;
    //public GameObject parent;
    public GameObject conntectPoint;
    public bool mostRecent;
    public GameObject placeholder;
    void Awake()
    { 
        click = conntectPoint.GetComponent<Click>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //placeholder = conntectPoint.transform.GetChild(0).gameObject;
        if (conntectPoint.transform.childCount > 0)
        {
            //OnTriggerEnter2D cannot be enabled/disabled

            //this.GetComponent<Collider2D>().enabled = false;
            //this.GetComponent<Destroy>().enabled = false;

            //Destroy(this.GetComponent<Destroy>());
        }
    }

}
