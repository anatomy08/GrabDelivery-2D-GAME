using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{


    [SerializeField]float SteerSpeed = 1f;
    [SerializeField]float MoveSpeed = 20f;
    [SerializeField]float BoostSpeed = 40f;
    [SerializeField]float SLowSpeed = 8f;
    void Start()
    {
        
    }

    
    void Update()
    {
       float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
       float MoveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
       transform.Rotate(0,0,-SteerAmount);
       transform.Translate(0,MoveAmount,0);
       
    }

    void OnCollisionEnter2D(Collision2D other) // made a bump system collision for Cow if hit it will reduce speed
    {
        if(other.gameObject.CompareTag("CowSlowSpeed"))
        {
            MoveSpeed = SLowSpeed;
            Debug.Log("Avoid Cow, Speed Reduced");
        }
    }
    
    void OnTriggerEnter2D(Collider2D other) // made a trigger collision when get fuel will boost speed
    {
        if(other.tag == "FuelBoost")
        {
            MoveSpeed = BoostSpeed;
            Debug.Log("Speed Boost");
        }
    }
}
