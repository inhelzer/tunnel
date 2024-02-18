using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_sp_yg : MonoBehaviour
{
    Coroutine g;
    [SerializeField] GameObject go;
    [SerializeField] GameObject candy;
    GameObject[] candyObj = new GameObject[2];
    // Start is called before the first frame update
    void Start()
    {
        candyObj[0] = go;
        candyObj[1] = candy;
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
                Instantiate(candyObj[Random.Range(0,2)], transform.position, Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(1, 7));

            }
        }
            }
}
