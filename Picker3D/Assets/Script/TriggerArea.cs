using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public float counter = 0;
    public TextMesh text;

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            Destroy(other.gameObject);
            counter++;
            text.text = "" + counter ;
            Invoke("PlaneUp", 2.0f);        }
    }
    void PlaneUp()
    {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

}
