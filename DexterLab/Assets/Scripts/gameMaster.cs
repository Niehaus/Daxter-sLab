using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameMaster : MonoBehaviour
{

    public Text Texto_Inicial;
    public Text Texto_Info;

    public ProblemDescriptor descriptor;
    private int contador = 1;
    private int inicial = 5;

    public void firstContinue() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void secondContinue() {
        Texto_Inicial.text = ("Vamos começar, este é o problema " + contador + ":");
        Texto_Info.text = ("\n[Problema aqui]\n ");

    }
    public void thirdContinue() {
        Texto_Inicial.text = ("Este é o problema: " + contador);
    }

    public void proxExerc() {
        Debug.Log("case = " + descriptor.contador);
        Debug.Log("cena será: " + inicial + descriptor.contador);
        switch (descriptor.contador)
        {
            case 1:
                Debug.Log("Fui pra cena: " + inicial + descriptor.contador);
                SceneManager.LoadScene(inicial + descriptor.contador);
                break;
            case 2:
                SceneManager.LoadScene(inicial + descriptor.contador);
                break;
            case 3:
                SceneManager.LoadScene(inicial + descriptor.contador);
                break;
            default:
                Debug.Log("Scene não existente");
                Debug.Log("Scene não existente mesmo!");
                break;
        }
    }
    public void tentarNovamente()
    {
        /*
         * Tentar Novamente correto
        SceneManager.LoadScene(inicial + descriptor.contador + 1);
        */
        SceneManager.LoadScene(6);
    }
    public void tentarNovamenteGame()
    {
        SceneManager.LoadScene(1);
    }
    public void verSolution()
    {
        SceneManager.LoadScene(8);
    }
    public void verSolution2()
    {
        SceneManager.LoadScene(9);
    }
    public void verSolution3()
    {
        SceneManager.LoadScene(10);
    }
}
