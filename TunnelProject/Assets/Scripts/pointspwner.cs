using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointspwner : MonoBehaviour
{
    
    [SerializeField] GameObject d;
    Coroutine nameC;
    
    // Start is called before the first frame update
    void Start()
    {
        nameC = StartCoroutine(nameF());
    }


    IEnumerator nameF()
    {
        while (true)
        {
            
            Instantiate(d, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0, 10));
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
