using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMasterA : MonoBehaviour {

    [SerializeField]
    private InputField input;
    [SerializeField]
    private InputField inputMP;
    [SerializeField]
    private InputField inputMT;
    [SerializeField]
    private InputField inputConj;
    [SerializeField]
    private InputField inputADD;
    [SerializeField]
    private ProblemDescriptor descritor;
    [SerializeField]
    private GameObject descAtual;

    public Text score;
    private string respEx;
    private string respGame;
    private static int contadorAcertos = 0;

    string logica1 = "p v q";
    string logica2 = " p -> s";
    string logica3 = "r -> ~s"; 
    string logica4 = "r";
    string logica5;
    string logica6;
    string logica7;
    string logica8;

    public Text fraseGerada1;
    public Text logicaGerada1;

    public Text fraseGerada2;
    public Text logicaGerada2;

    public Text fraseGerada3;
    public Text logicaGerada3;


    private void Awake()
    {
        respEx = descritor.getAwnser();
        respGame = descritor.getAwnserGame();
        score.text = ("Score: " + contadorAcertos);
        Debug.Log("respEx ==" + respEx);
        descritor.contador = contadorAcertos;
  
    }

    public void GetInput(string resposta)
    {
        Debug.Log("You entered " + resposta);
        Debug.Log("RespEx = " + respEx);
        input.text = "";
        if (resposta == respEx)
        {
            Debug.Log("Resposta Certa!");
            descritor.contador = contadorAcertos += 1;
            Debug.Log("Acertos = " + contadorAcertos);
            score.text = ("Score: " + contadorAcertos);
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }

    public void GetInputGame(string resposta)
    {
        Debug.Log("You entered " + resposta);
        Debug.Log("RespEx = " + respGame);
        input.text = "";
        if (resposta == respGame)
        {
            Debug.Log("Resposta Certa!");
            descritor.contador = contadorAcertos += 1;
            Debug.Log("Acertos = " + contadorAcertos);
            score.text = ("Score: " + contadorAcertos);
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }

    public void GetInputMP(string entrada)
    {
        Debug.Log("You entered " + entrada);
        inputMP.text = "";
        char A = '1';
       // char B = '2';
        char C = '3';
       // char D = '4';
        if (entrada.Contains("1") && entrada.Contains("2"))
        { // 1 aplicada em 2 
            //Debug.Log("Entrada tem 1 e 2");
            //Debug.Log("1 caractere = " + entrada[0]);
            if (entrada[0].Equals(A))
            {
                Debug.Log("1 é o primeiro caractere");
                if (logica2.Contains("->") && logica2.Contains(logica1))
                {
                    //logica1 deve ser igual à primeira frase da entrada, se 2 tiver ->, conclui-se 2
                    logicaGerada1.text = (logica1);
                    fraseGerada1.text = ("A testemunha não mentiu.");
                }
                else
                {
                    Debug.Log("Não é possível aplicar a função!");
                }
            }
            else
            { // 2 aplicada em 1 
                Debug.Log("2 é o primeiro caractere -> " + entrada[0]);

                if (logica1.Contains("->") && logica1.Contains(logica2))
                {
                    //logica1 deve ser igual à primeira frase da entrada, se 2 tiver ->, conclui-se 2
                    // logicaGerada1.text = (logica2);
                    // fraseGerada1.text = ("N vai rolar.");
                    Debug.Log("Impossivel nesse problema");
                }
                else
                {
                    Debug.Log("Não é possível aplicar a função!");
                }
            }
        }
        else if(entrada.Contains("3") && entrada.Contains("4"))
        {
            Debug.Log("contem 3 e 4");
            if (entrada[0].Equals(C)) {
                Debug.Log("3 é o primeiro caractere");
                if (logica4.Contains("->") && logica4.Contains(logica3))
                {
                    //logica1 deve ser igual à primeira frase da entrada, se 2 tiver ->, conclui-se 2

                    Debug.Log("Não é valida nesse caso");
                }
                else
                {
                    Debug.Log("Não é possível aplicar a função!");
                }
            }
            else
            { // 4 aplicada em 3 
                Debug.Log("4 é o primeiro caractere -> " + entrada[0]);

                if (logica3.Contains("->") && logica3.Contains(logica4))
                {
                    //logica1 deve ser igual à primeira frase da entrada, se 2 tiver ->, conclui-se 2
                    logicaGerada1.text = (":- ~s");
                    logica5 = logicaGerada1.text;
                    Debug.Log("LOGICA 5 = " + logica5);
                    fraseGerada1.text = ("A testemunha não mentiu.");

                }
                else
                {
                    Debug.Log("4,3");
                    Debug.Log("Não é possível aplicar a função!");
                }
            }
        }
    }

    public void GetInputMT(string entrada)
    {
        Debug.Log("You entered " + entrada);
        inputMT.text = "";
        //char A = '1';
        char B = '2';
        //char C = '3';
        // char D = '4';
        char E = '5';

        if (entrada.Contains("5") && entrada.Contains("2"))
        { // 1 aplicada em 2 
            //Debug.Log(logica2.Contains(logica5));
            Debug.Log("1 caractere = " + entrada[0]);
            if (entrada[0].Equals(E))
            {
                Debug.Log("5 é o primeiro caractere");

                if (logica2.Contains("->") && logica2.Contains("s"))
                {
                    //logica1 deve ser igual à primeira frase da entrada, se 2 tiver ->, conclui-se 2

                    logicaGerada2.text = (":- ~p");
                    fraseGerada2.text = ("O mordomo não é inocente");
                }
                else
                {
                    Debug.Log("Não é possível aplicar a função!");
                  //  Debug.Log(logica5[3]);
                }
            }
            else
            {
                Debug.Log("Not Available in this function");
            }
        }
    }

    public void GetInputConj(string entrada)
    {

    }

    public void GetInputADD(string entrada)
    {

    }
}