using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class life_h : MonoBehaviour
{
    [SerializeField] int maxlife = 10;
    [SerializeField] GameObject textlife;
    [SerializeField] GameObject brused;
    //[SerializeField] GameObject banner;
    //[SerializeField] GameObject icon;
    int currentlife;
    float hitTime;
    float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        currentlife = maxlife;
    }

    // Update is called once per frame
    void Update()
    {
        textlife.GetComponent<Text>().text = currentlife.ToString();
        
        if (currentlife <= 0)
        {
            Debug.Log("g");
           // banner.SetActive(true);
        }

        if(hitTime + delay >= Time.timeSinceLevelLoad)
        {
            //brused.SetActive(false);
        }
    }

    public void LooseLife()
    {
        currentlife--;
        brused.SetActive(true);
        Debug.Log("kkkkkk");
        hitTime = Time.timeSinceLevelLoad;
    }
}