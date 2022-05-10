using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMultiple : MonoBehaviour
{
    #nullable enable
    public GameObject[]? conntectPoints;
    public Click[]? clicks;
    #nullable disable
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");
        foreach(Click click in clicks)
        {
            if (click.placed)
            {
                int arrPosition = System.Array.IndexOf(clicks, click);
                Debug.Log(arrPosition);

                //finds most recently placed object since thats the only one that will be destoryed
                if (conntectPoints[arrPosition].transform.childCount > 0)
                {
                    Debug.Log("cannot place there");
                    Destroy(other.gameObject.transform.parent.gameObject);


                }
            }
        }
    }
}
