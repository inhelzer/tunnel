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
        scaleChange = new Vector3(1, 1);
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        a = (float)(a + 0.01);
        scaleChange = new Vector3(a, a);
        transform.localScale = scaleChange;
    }
}
