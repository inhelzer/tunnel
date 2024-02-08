using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class light_sp : MonoBehaviour
{
    Coroutine g;
    [SerializeField] GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        g = StartCoroutine(spawn());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawn()
    {

        
            while (true)
            {
                GameObject currentObject = 
                Instantiate(go, transform.position, Quaternion.identity) as GameObject;
                Destroy(currentObject, 2);
                yield return new WaitForSeconds(Random.Range(5,10));

            }
        
    }
}