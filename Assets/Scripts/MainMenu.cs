using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject optionsMenu;
    public GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayMaze()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }


    public void OptionsButton()
    {
        optionsMenu.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
    }

    public void BackButton()
    {
        mainMenu.gameObject.SetActive(true);
        optionsMenu.gameObject.SetActive(false);
    }

}
