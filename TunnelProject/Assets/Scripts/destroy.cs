using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="stone")
        {
            Destroy(other.gameObject);
        }
    }
    */

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "stone")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "candy")
        {
            Destroy(other.gameObject);
        }
    }
}
