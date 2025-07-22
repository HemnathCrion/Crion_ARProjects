using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_LookAt : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //transform.rotation = Quaternion.identity;
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180 ,0);
    }
}
