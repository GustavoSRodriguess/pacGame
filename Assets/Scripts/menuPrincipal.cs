using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
    public GameObject menu, options, credits;
    public string gameScene;

    public void openOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }

    public void openCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void goBack()
    {
        options.SetActive(false);
        credits.SetActive(false);
        menu.SetActive(true);
    }

    public void sair()
    {
        Application.Quit();
    }

    public void jogar()
    {
        options.SetActive(false );
        credits.SetActive(false);
        SceneManager.LoadScene(gameScene);
    }

}
