using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotaoCena : MonoBehaviour
{
    public GameObject painel;

    void Start()
    {
        painel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void CarregarCena(string opcoes)
    {
        if (opcoes == "ButtonCena1")
            SceneManager.LoadScene("Jogo");
        if (opcoes == "ButtonCreditos")
            painel.SetActive(true);
    }
}
