using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cap_yg : MonoBehaviour
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
        while(a<=100)
        {
            a = (float)(a + 0.05);
            scaleChange = new Vector3(a, a);
            transform.localScale = scaleChange;
        }
        Destroy(gameObject);



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
}
