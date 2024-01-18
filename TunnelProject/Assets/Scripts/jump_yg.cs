using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_yg : MonoBehaviour
{
    [SerializeField] int xspeed = 1;
    [SerializeField] int yspeed = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(xspeed, yspeed);
        }
    }
}
