using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionandTriger : MonoBehaviour
{
    public Light[] target;
    private void Start()
    {
        foreach(Light light in target)
        {
            light.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if( other.CompareTag("Light"))
        {
            foreach(Light light in target)
            {
                light.enabled =true;
                Debug.Log("Enterd");
            }

        }


    }
}
