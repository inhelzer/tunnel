using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_wg : MonoBehaviour
{
    private Vector3 scaleChange;
    private float a = 0;
    [SerializeField] int num_of_wall = 0;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(a<1)
        {
            GetComponent<Collider2D>().enabled=false;
        }
        if(a>1)
        {
            GetComponent<Collider2D>().enabled = true;
        }
        if(a<3)
        {
            a = (float)(a + 0.005);
            if (num_of_wall == 0)
            {
                transform.Translate(0, 1.5f*Time.deltaTime, 0);
                scaleChange = new Vector3(a, a);
                transform.localScale = scaleChange;
            }
            if (num_of_wall == 1)
            {
                transform.Translate(0, -1.5f * Time.deltaTime, 0);
                scaleChange = new Vector3(a, a);
                transform.localScale = scaleChange;
            }
            if(num_of_wall == 2)
            {
                transform.Translate(-3f * Time.deltaTime, 0, 0);
                scaleChange = new Vector3(a, a);
                transform.localScale = scaleChange;
            }
            if(num_of_wall==3)
            {
                transform.Translate(-3f * Time.deltaTime, 0, 0);
                scaleChange = new Vector3(a, a);
                transform.localScale = scaleChange;
            }

        }
         if(a>=3)
        {
            
            Destroy(gameObject);
            
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


}
