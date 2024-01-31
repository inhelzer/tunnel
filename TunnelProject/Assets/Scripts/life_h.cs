using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_h : MonoBehaviour
{
    [SerializeField] int maxlife;
    [SerializeField] GameObject textlife;
    int currentlife;
    // Start is called before the first frame update
    void Start()
    {
        currentlife = maxlife;
        
    }

    // Update is called once per frame
    void Update()
    {
        textlife.GetComponent<Text>().text = currentlife.ToString();
        Debug.Log("works");
        if (currentlife == 0)
        {
            FindObjectOfType<level_loder>().LoadNextScene();
        }
    }

    public void LooseLife()
    {
        currentlife--;
    }
}