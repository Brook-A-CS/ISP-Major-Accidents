using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Click click;
    public GameObject parent;

    void Awake()
    {
        click = parent.GetComponent<Click>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (click.placed)
        {
            this.collider2D.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit bitch");
        Destroy(other.gameObject.transform.parent.gameObject);
    }
}
