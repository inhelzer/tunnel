using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_start : MonoBehaviour
{
    [SerializeField] int back;

    private void OnMouseDown()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -back);

    }
}
