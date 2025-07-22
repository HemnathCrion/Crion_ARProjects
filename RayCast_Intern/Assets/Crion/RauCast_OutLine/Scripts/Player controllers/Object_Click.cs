using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Click : MonoBehaviour
{
    public Panal_Detials panal_Detials;
    public Vector3 offset = new Vector3(0, 1.5f, 0);
    public Transform currentarget;
    public GameObject infobuttonPanel;

    public void OnMouseDown()
    {
        infobuttonPanel.SetActive(true);

        infobuttonPanel.transform.position = currentarget.position + offset;

    }
}
