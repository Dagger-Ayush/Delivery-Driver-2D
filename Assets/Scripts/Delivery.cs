using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Sayonara");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the driver touches the package and does not have package
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package Picked Up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        // if the driver touches the package and have a package 
        else if (other.CompareTag("Customer") && hasPackage == true)
        {
            Debug.Log("Delivered to the Customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        // if the driver does not have a package
        else
        {
            Debug.Log("You Don't Have The Package");
        }
    }
}
