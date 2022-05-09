using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Attachments") {
            Debug.Log("hit bitch");
            Destroy(other.gameObject.transform.parent.gameObject);
        }
    }
}
