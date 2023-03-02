using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 speed = Vector3.zero;
    Vector3 fin = new Vector3(0,-3,0);
    void Start(){
    
    }
    void Update()
    {
    transform.position = Vector3.SmoothDamp(transform.position,fin,ref speed, 4f);
    
}
}