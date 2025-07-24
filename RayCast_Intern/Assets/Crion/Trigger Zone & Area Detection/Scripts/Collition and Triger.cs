using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollitionandTriger : MonoBehaviour
{
    public Light[] target;
    public Light[] topLight;
    public GameObject particleSystems;
    public Light fireLight;
    public TextMeshProUGUI entryText;
    public TextMeshProUGUI labText;
    public TextMeshProUGUI topText;
    public GameObject enterPanel;
    public Loading_Scene scene;
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
                entryText.text = "Welcome You Enterd";
                StartCoroutine(ShowPanel());
                
                Destroy(other.gameObject);
                
            }

        }
        
        if( other.CompareTag("LabTag"))
        {
            enterPanel.SetActive(true);
            labText.text = "Welcome You Have In Lab";
            StartCoroutine(ShowPanel());
            Destroy(other.gameObject);
                
            
        }
        if( other.CompareTag("TopLight"))
        {
            foreach(Light light1 in topLight)
            {
                labText.enabled = false ;
                light1.enabled =true;
                enterPanel.SetActive(true);
                topText.text = "You Have A Topflor";
                StartCoroutine (ShowPanel());
                Destroy(other.gameObject);
            }

        }
        if (other.CompareTag("SceneChange"))
        {
            scene.SceneManage();
            DontDestroyOnLoad(gameObject);
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
    
    public IEnumerator ShowPanel()
    {
        yield return new WaitForSeconds(2f);
        enterPanel.SetActive(false);
        entryText.enabled = false ;
        
    }
    
    //public IEnumerator ShowtopPanel()
    //{
    //    yield return new WaitForSeconds(2f);
    //    enterPanel.SetActive(false);

        
    //}
}
