using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring_y : MonoBehaviour
{
    private Vector3 scaleChange;
    private float a = 0;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(500, 500);
        Destroy(gameObject, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        a = (float)(a + 0.005);
        scaleChange = new Vector3(a, a);
        transform.localScale = scaleChange;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "destroyer")
        {
            Destroy(gameObject);
        }
    }
}
