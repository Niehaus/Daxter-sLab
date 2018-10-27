using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class playGameMaster : MonoBehaviour {
    //campos do problema
    public Text frase1, frase2, frase3, frase4; 
    public Text logica1, logica2, logica3, logica4;

    private string str_frase1;

    private void Start()
    {
        str_frase1 = ("Se hoje fizer sol e a mãe de pedro chegar cedo, então ele irá a praia.");
     Debug.Log("f1  = " + str_frase1);
        
    }

    public void Conjuncao()
    {
        
    }
}
