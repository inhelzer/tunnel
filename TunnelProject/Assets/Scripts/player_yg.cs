using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_yg : MonoBehaviour
{
    [SerializeField] int xspeed = 0;
    [SerializeField] int yspeed = 1;
    [SerializeField] GameObject cartobg;
    [SerializeField] bool iscart = false;
    [SerializeField] float dis = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "cart")
        {
            iscart = true;
        }
        if(other.gameObject.tag == "stone")
        {
            Debug.Log(12);
            FindObjectOfType<life_h>().LooseLife();
        }
        if(other.gameObject.tag == "candy")
        {
            FindObjectOfType<life_h>().addlife();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if(iscart)
        {
            transform.position = cartobg.transform.position + new Vector3(0,dis,0);
        }
        if (Input.GetButtonDown("Jump"))
        {
            iscart = false;
            GetComponent<Rigidbody2D>().velocity = new Vector3(xspeed, yspeed);
        }

    }
}
