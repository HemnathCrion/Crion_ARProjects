using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panal_Detials : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject infobuttonPanel;
    public GameObject infopanel;
    public Button infobutton;
    public GameObject player;
    public Button infocloseButtom;
    public Vector3 offset = new Vector3(0, 1.5f, 0);
    public Transform currentarget;
    public Transform canwastarget;


    private void Start()
    {
        infobuttonPanel.SetActive(false);
        infopanel.SetActive(false);
        infobutton.onClick.AddListener(ShowInfoPanel);
        infocloseButtom.onClick.AddListener(CloseInfoPanel);
    }

    public void OnMouseDown()
    {
        canwastarget.transform.position = currentarget.position + offset;

        infobuttonPanel.SetActive(true);


    }
    public void ShowInfoPanel()
    {
        infobuttonPanel.SetActive(false);
        infopanel.SetActive(true);
    }
    public void CloseInfoPanel()
    {
        infobuttonPanel.SetActive(false);
        infopanel.SetActive(false);
    }
    //public void PanelTransform(Transform target)
    //{
    //    infobuttonPanel.SetActive(true);
        
    //    infobuttonPanel.transform.position = target.position + offset;
    //}

}
