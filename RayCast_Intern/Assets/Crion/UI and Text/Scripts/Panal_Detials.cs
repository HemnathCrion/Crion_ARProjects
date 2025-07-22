using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Panal_Detials : MonoBehaviour
{
    public GameObject infobuttonPanel;
    public GameObject infopanel;
    public Button infobutton;
    public Button infocloseButtom;

    private void Start()
    {
        
        infobuttonPanel.SetActive(false);
        infopanel.SetActive(false);
        infobutton.onClick.AddListener(ShowInfoPanel);
        infocloseButtom.onClick.AddListener(CloseInfoPanel);
    }

   
    private void ShowInfoPanel()
    {

        infobuttonPanel.SetActive(false);
        infopanel.SetActive(true);
    }

    private void CloseInfoPanel()
    {
        infobuttonPanel.SetActive(false);
        infopanel.SetActive(false);
    }
}