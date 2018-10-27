using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuncBotoes : MonoBehaviour {

    public Text funcSelecionada;
    public Text corpoDescricao;

    public void ModusPonnensDesc()
    {
        funcSelecionada.text = ("Função: Modus Ponnens");
        corpoDescricao.text = ("1 - Se eu estudar, eu aprenderei.\n " +
                               "2 - Eu estudei. \n" +
                               "3 - Logo eu aprendi. (Conclusão)\n " + "\n" +
                               "Entrada -> (Frase1,Frase2) -> Conclusão = Frase 3");

    }


    public void ModusTolensDesc()
    {
        funcSelecionada.text = ("Função: Modus Tolens");
        corpoDescricao.text = ("1 - Se fizer sol então irei a praia.\n " +
                               "2 - Eu não fui a praia. \n" +
                               "3 - Logo não fez sol. (Conclusão)\n " + "\n" +
                               "Entrada -> (Frase1,Frase2) -> Conclusão = Frase 3");

    }


    public void ConjDesc()
    {
        funcSelecionada.text = ("Função: Conjunção");
        corpoDescricao.text = ("1 - Hoje vou arrumar a casa.\n " +
                               "2 - Vou ao cinema mais tarde \n" +
                               "3 - Hoje vou arrumar a casa e Vou ao Cinema mais tarde. (Conclusão)\n " + "\n" +
                               "Entrada -> (Frase1,Frase2) -> Conclusão = Frase 3");

    }

    public void AdicaoDesc()
    {
        funcSelecionada.text = ("Função: Adição");
        corpoDescricao.text = ("1 - Hoje vou arrumar a casa.\n " +
                               "2 - Vou ao cinema mais tarde \n" +
                               "3 - Hoje vou arrumar a casa ou Vou ao Cinema mais tarde. (Conclusão)\n " + "\n" +
                               "Entrada -> (Frase1,Frase2) -> Conclusão = Frase 3");

    }
}
