﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using System.Collections;


public class MainMenu : MonoBehaviour
{
    //Variable für Übergangseffekt
    public Animator transition;

    //Hauptscene laden
    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
    
    //App beenden
    public void QuitApp()
    {
        Debug.Log("Wird beendet!");
        Application.Quit();
    }

    //Übergange von Scene zu Scene
    IEnumerator LoadScene(int levelIndex)
    {
        //play animation
        transition.SetTrigger("Start");

        //wait 
        yield return new WaitForSeconds(1);

        //load scene
        SceneManager.LoadScene(1);

    }
}