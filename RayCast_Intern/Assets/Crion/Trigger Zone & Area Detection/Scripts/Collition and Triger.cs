using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollitionandTriger : MonoBehaviour
{
    public Light[] target;
    public Light[] topLight;
    public GameObject particleSystems;
    public Light fireLight;
    //public TextMeshProUGUI enteredText;
    public GameObject enterPanel;
    private void Start()
    {
        enterPanel.SetActive(false);
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
                enterPanel.SetActive(true);
                StartCoroutine(WaitAndShow());
                //enteredText.text = "Welcome You Entered";
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
    private IEnumerator WaitAndShow()
    {
        yield return new WaitForSeconds(2);
        enterPanel.SetActive(false);
    }
}
