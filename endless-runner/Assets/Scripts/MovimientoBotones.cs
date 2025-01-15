using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBotones : MonoBehaviour
{
    [SerializeField] private GameObject boton; 
    [SerializeField] private float speed; 

    public void Update() 
    { 
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3; 
        boton.transform.position = new Vector3(0, y, 0); 
    }
}
