using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProblemDescriptor : MonoBehaviour {

    public string resposta_correta;
    public string resposta_corretaGame;
    public int contador = 0;

    [SerializeField]
    private PassValues passa;

    public string getAwnser() {

        resposta_correta = "u";

            return resposta_correta;
    }

    public string getAwnserGame()
    {

        resposta_corretaGame = "~p";

        return resposta_corretaGame;
    }

}
