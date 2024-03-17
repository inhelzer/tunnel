using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class real_spwner_y : MonoBehaviour
{
    [SerializeField] GameObject prefub;
    [SerializeField] float spownertime;
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
            Instantiate(prefub, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spownertime);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
