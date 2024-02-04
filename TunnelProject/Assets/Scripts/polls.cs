using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polls : MonoBehaviour
{
    private Vector3 scaleChange;
    private float a = 0;
    
    Vector3 endPos;
    float moveSpeed;
    Vector3 moveVector;
    // Start is called before the first frame update
    void Start()
    {
       
        //scaleChange = new Vector3(500, 500);
        Destroy(gameObject, 2.5f);

       
    }
    public void calculateDirection (Vector3 endPosition)
    {
        endPos = endPosition;
        moveVector = (endPos - transform.position).normalized * moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        a = (float)(a + 0.005);
        scaleChange = new Vector3(a, a);
        transform.localScale = scaleChange;

        transform.position += moveVector * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "destroy")
        {
            Debug.Log("working");
            Destroy(gameObject);
        }
    }
}
