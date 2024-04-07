using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_homepage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Input.GetAxis("Horizontal") * 10, Time.deltaTime * Input.GetAxis("Vertical") * 10,0);
    }
}
