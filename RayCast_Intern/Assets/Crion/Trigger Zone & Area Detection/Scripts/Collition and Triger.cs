using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionandTriger : MonoBehaviour
{
    public Light[] target;
    public Light[] topLight;
    public GameObject particleSystems;
    public Light fireLight;
    private void Start()
    {
        foreach(Light light in target)
        {
            light.enabled = false;
        }
        foreach(Light light1 in topLight) 
            {
                light1.enabled = false;
            }
      particleSystems.SetActive(false);
        fireLight.enabled = false;
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
        if( other.CompareTag("TopLight"))
        {
            foreach(Light light1 in topLight)
            {
                light1.enabled =true;
                Debug.Log("Enterd");
            }

        }
       



    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            particleSystems.SetActive(true);
            fireLight.enabled = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            particleSystems.SetActive(false);
            fireLight.enabled = false;

        }
    }
}
