using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points_yg : MonoBehaviour
{
    [SerializeField] GameObject textpoint;
    int pointlife;
    // Start is called before the first frame update
    void Start()
    {
        textpoint.GetComponent<Text>().text = pointlife.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addpoints()
    {
        pointlife += 367;
    }



}
