using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_img_N : MonoBehaviour
{
    //משתנים
    [SerializeField] private Sprite[] LivesSprites;
    [SerializeField] private Image _livesImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int currentLives)
    {
        _livesImage.sprite = LivesSprites[currentLives];
    }


}
