using UnityEngine;

public class AssetData : MonoBehaviour
{
    public string assetName;
    public string description;
    public Panal_Detials panal_Detials;
    public InfoPanel_UI infoPanel;
    public Vector3 offset = new Vector3(0, 1.5f, 0);
    public Transform canwastarget; // This is where UI will appear

    private void Start()
    {
        panal_Detials.infobuttonPanel.SetActive(false);
        panal_Detials.infopanel.SetActive(false);
    }
    private void OnMouseDown()
    {
        // Move panel near this object
        canwastarget.transform.position = transform.position + offset;
        infoPanel.OnDicidAsset(this);
        // Show the button panel
        panal_Detials.infobuttonPanel.SetActive(true);
        panal_Detials.infopanel.SetActive(false) ;
    }
}
