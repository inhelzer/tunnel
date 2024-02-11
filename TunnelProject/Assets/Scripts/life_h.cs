using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_h : MonoBehaviour
{
    [SerializeField] int maxlife = 10;
    [SerializeField] GameObject textlife;
    //[SerializeField] GameObject banner;
    //[SerializeField] GameObject icon;
    int currentlife;
    float hitTime;
    float delay = 0.2f;

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

        if(hitTime + delay <= Time.timeSinceLevelLoad)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    public void LooseLife()
    {
        currentlife--;
        GetComponent<SpriteRenderer>().color = Color.red;
        hitTime = Time.timeSinceLevelLoad;
    }
}