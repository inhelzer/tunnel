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
        Destroy(gameObject, 12);
    }

    // Update is called once per frame
    void Update()
    {
        a = (float)(a + 0.005);
        scaleChange = new Vector3(a, a);
        transform.localScale = scaleChange;
    }
}
