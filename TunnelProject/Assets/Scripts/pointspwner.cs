using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointspwner : MonoBehaviour
{
    
    [SerializeField] GameObject d;
    Coroutine nameC;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        nameC = StartCoroutine(nameF());
    }


    IEnumerator nameF()
    {
        while (true)
        {
            if(num == 3)
            //Instantiate(d, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        num = Random.Range(Random.Range(0, 10), 10);
    }
}
