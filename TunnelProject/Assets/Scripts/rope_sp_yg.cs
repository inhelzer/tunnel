using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope_sp_yg : MonoBehaviour
{
    Coroutine namec;
    [SerializeField] GameObject rope;
    [SerializeField] Weight circle;
    // Start is called before the first frame update
    void Start()
    {
        namec = StartCoroutine(name());

    }
    IEnumerator name()
    {
        while(true)
        {
            GameObject currentRope =  
            Instantiate(rope, transform.position, Quaternion.identity) as GameObject;

            currentRope.GetComponent<Rope>().NewWhight(circle);
            yield return new WaitForSeconds(10); 
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
