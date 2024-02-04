using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_yg : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(10f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
    }
}
