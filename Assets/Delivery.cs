using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackagedColor = new Color32 (255,255,255,255); // color if have Package
    [SerializeField] Color32 NoPackageColor = new Color32 (255,0,0,255); // color if noPackage
    
    [SerializeField] float DestroyDelay = 1f; // Serialized a float to destroy()
    bool hasPackage; // make a bool packaged has aquiared 
    
    SpriteRenderer spriteRenderer; // make SpriteRenderer and variable

    void Start() // make a void start for spriteRenderer
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   // get the component of spriterenderer 
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

     void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage) // you can set has package == false as you like
        {
            Debug.Log("Package Pick-Up");
            hasPackage = true; // sets to true if have the package
            // after triggering the object
            Destroy(other.gameObject, DestroyDelay);
            spriteRenderer.color = hasPackagedColor; // if true change color
        }

        if(other.tag == "Customer" && hasPackage) // you can put has package == true as you like
        {
            Debug.Log("Packaged Delivered");
            hasPackage = false; // once deliver package set it to false.
            spriteRenderer.color = NoPackageColor; // if false change color or Basic Color to red.
        }
    }

    

}
