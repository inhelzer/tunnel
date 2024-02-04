using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polls_spawner : MonoBehaviour
{
    [SerializeField] GameObject pollPrefab;
    [SerializeField] float spownertime;
    Coroutine nameC;
    [SerializeField] GameObject endObject;
    Vector3 endPos;
    // Start is called before the first frame update
    void Start()
    {
        nameC = StartCoroutine(nameF());
        endPos = endObject.transform.position;
    }


    IEnumerator nameF()
    {
        while (true)
        {
            GameObject currentPoll = 
            Instantiate(pollPrefab, transform.position, Quaternion.identity) as GameObject;
            currentPoll.GetComponent<polls>().calculateDirection(endPos);
            yield return new WaitForSeconds(spownertime);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
