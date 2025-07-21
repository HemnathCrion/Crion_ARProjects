using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float speed;
    private Vector3 MoveDerection;
    //private Rigidbody rb;
    public Transform orientation;
  
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        MoveDerection = new Vector3(hInput,0f, vInput);
        transform.Translate(MoveDerection * speed * Time.deltaTime);
       
    }
  
    
}
