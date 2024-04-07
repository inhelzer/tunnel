using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyefollowFromPlayer : MonoBehaviour
{
    public GameObject mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eyefollow();
    }
    void eyefollow()
    {
        Vector3 playerpos = mouse.transform.position;

        Vector2 direction = new Vector2 (playerpos.x - transform.position.x, playerpos.y-transform.position.y);
        transform.up = direction;
    }
}
