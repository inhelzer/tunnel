using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeFollow : MonoBehaviour
{
    int x = 0;
    int y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 courspos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(courspos.x, courspos.y);

    }
}
