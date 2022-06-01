using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collide2 : MonoBehaviour
{
    public Image img;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            Debug.Log(".");
            img.gameObject.SetActive(true);        }
    }

}

