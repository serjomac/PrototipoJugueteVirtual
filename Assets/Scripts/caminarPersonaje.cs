using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminarPersonaje : MonoBehaviour
{
    Animator myAnimation;

    // Start is called before the first frame update
    void Start()
    {
        //myAnimation = GetComponent<Animator>();
    }

    void FixedUpdate(){
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Time.deltaTime*5, 0, 0);
            //myAnimation.setFloat("Speed", Input.GetAxis("Horizontal"));
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-Time.deltaTime*5, 0,0);
        }
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0, Time.deltaTime*12, 0);
        }
        
    }
}
