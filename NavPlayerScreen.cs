using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavPlayerScreen : MonoBehaviour
{

[SerializeField] private GameObject TPrincipal;
[SerializeField] private GameObject TAlimentacao;
[SerializeField] private GameObject TMental;
[SerializeField] private GameObject TExercicios;
[SerializeField] private GameObject TEstudos;
[SerializeField] private GameObject TLoja;
[SerializeField] private GameObject TCoins;
[SerializeField] private GameObject TTarefas;

[SerializeField] private GameObject[] telas; 

public void TrocarParaTela(GameObject telaSelecionada){
    foreach(var tela in telas){
        tela.SetActive(tela == telaSelecionada);
       // TPrincipal.SetActive(false);
    }
}

public void TelaPrincipal(){

    TPrincipal.SetActive(true) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(false);
    TExercicios.SetActive(false);
    TEstudos.SetActive(false);
    TLoja.SetActive(false);
    TCoins.SetActive(false);
    TTarefas.SetActive(false);
}

public void TelaTarefas(){

    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(false);
    TExercicios.SetActive(false);
    TEstudos.SetActive(false);
    TLoja.SetActive(false);
    TCoins.SetActive(false);
    TTarefas.SetActive(true);
}

public void TelaAlimentacao(){    
    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(true);
    TMental.SetActive(false);
    TExercicios.SetActive(false);
    TEstudos.SetActive(false);
    TLoja.SetActive(false);
    TCoins.SetActive(false);
    TTarefas.SetActive(false);
}

public void TelaMental(){    
    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(true);
    TExercicios.SetActive(false);
    TEstudos.SetActive(false);
    TLoja.SetActive(false);
    TCoins.SetActive(false);
    TTarefas.SetActive(false);
}

public void TelaExercicios(){   
    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(false);
    TExercicios.SetActive(true);
    TEstudos.SetActive(false);
    TLoja.SetActive(false);
    TCoins.SetActive(false);
    TTarefas.SetActive(false);
}

public void TelaEstudos(){    
    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(false);
    TExercicios.SetActive(false);
    TEstudos.SetActive(true);
    TLoja.SetActive(false);
    TCoins.SetActive(false);
    TTarefas.SetActive(false);
}

public void TelaLoja(){    
    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(false);
    TExercicios.SetActive(false);
    TEstudos.SetActive(false);
    TLoja.SetActive(true);
    TCoins.SetActive(false);
    TTarefas.SetActive(false);
}

public void TelaCesucoins(){    
    TPrincipal.SetActive(false) ;
    TAlimentacao.SetActive(false);
    TMental.SetActive(false);
    TExercicios.SetActive(false);
    TEstudos.SetActive(false);
    TLoja.SetActive(false);
    TCoins.SetActive(true);
    TTarefas.SetActive(false);
}



}
