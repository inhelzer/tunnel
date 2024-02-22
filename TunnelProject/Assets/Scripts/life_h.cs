using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class life_h : MonoBehaviour
{
    [SerializeField] int maxlife = 3;
    

    [SerializeField] GameObject textlife;
    [SerializeField] GameObject brused;
    //[SerializeField] GameObject banner;
    //[SerializeField] GameObject icon;
    int currentlife;
    float hitTime = 1000;
    float delay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        currentlife = maxlife;
        brused.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        textlife.GetComponent<Text>().text = currentlife.ToString();
        
        if (currentlife <= 0)
        {
            Debug.Log("game over");
           
        }

        if(Time.timeSinceLevelLoad - delay >= hitTime)
        {
            brused.SetActive(false);
        }
    }

    public void LooseLife()
    {
        Debug.Log("11");
        currentlife--;
        FindObjectOfType<life_img_N>().UpdateLives(currentlife);
        Debug.Log("22");
        brused.SetActive(true);
        Debug.Log("33");
        hitTime = Time.timeSinceLevelLoad;

        
        

    }
    public void addlife()
    {
        currentlife++;
        FindObjectOfType<life_img_N>().UpdateLives(currentlife);

    }
}