using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    [SerializeField]
    public AudioSource audio1;
 
    public void PlayGame()
    {
        audio1.Play();   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        audio1.Play();
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Exercicios()
    {
        audio1.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
}
