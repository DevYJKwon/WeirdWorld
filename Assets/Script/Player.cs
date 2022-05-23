using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed=5f;
    float jumpSpeed=400f;
    bool isAir=false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Time.deltaTime*speed,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Time.deltaTime*-speed,0,0);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(Vector2.up);
            isAir=true;
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Floor"){
            isAir=false;
        }
    }
}
