using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotaoCena : MonoBehaviour
{
    public GameObject painel;
    public GameObject painelTermo;

    void Start()
    {
        if (PlayerPrefs.GetString("Termo") != "Sim")
            painelTermo.SetActive(true);
        else
            painelTermo.SetActive(false);

        painel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void CarregarCena(string opcoes)
    {
        if (opcoes == "ButtonCena1")
        {
            SceneManager.LoadScene("Carregamento");
            Carregamento.cenaACarregar = "Jogo";
        }
        if (opcoes == "ButtonCreditos")
            painel.SetActive(true);
    }
}
