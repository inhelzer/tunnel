using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_level : MonoBehaviour
{
    [SerializeField] int move;
    private void OnMouseDown()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + move);

    }
}
