using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTesting_N : MonoBehaviour
{
    int _lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_lives <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bad")
        {
            _lives--;
            FindObjectOfType<life_img_N>().UpdateLives(_lives);
        }
    }
}
