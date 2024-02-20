using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class restartScript : MonoBehaviour
{
    public Slider healthBar;
    public Button restartButton;

    // Update is called once per frame
    void Start()
    {
        restartButton.onClick.AddListener(RestartScene);
    }
    void Update()
    {
        if(healthBar.value == 0 || Input.GetKey("r"))
        {
            RestartScene();
        }
    }
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
