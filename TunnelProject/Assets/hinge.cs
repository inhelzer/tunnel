using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinge : MonoBehaviour
{
    private Vector3 scaleChange;
    private float a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject,3);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //Destroy(gameObject);
            Debug.Log("gg");
        }
    }

}
