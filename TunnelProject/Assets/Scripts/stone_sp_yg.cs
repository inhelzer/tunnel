using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_sp_yg : MonoBehaviour
{
    Coroutine g;
    [SerializeField] GameObject go;
    
    // Start is called before the first frame update
    void Start()
    {
        g = StartCoroutine(name());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator name()
    {

        {
            while(true)
            {
                Instantiate(go, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(100, 1000));

            }
        }
            }
}
