using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotaoCena : MonoBehaviour
{
    public GameObject painelTermo;
    public GameObject[] painelIdiomaCerto;

    void Start()
    {
        if (PlayerPrefs.GetString("Termo") != "Sim")
            painelTermo.SetActive(true);
        else
            painelTermo.SetActive(false);

        if (PlayerPrefs.GetString("Idioma") == "Port")
        {
            painelIdiomaCerto[0].SetActive(true);
            painelIdiomaCerto[1].SetActive(false);
        }
        else if (PlayerPrefs.GetString("Idioma") == "Esp")
        {
            painelIdiomaCerto[0].SetActive(false);
            painelIdiomaCerto[1].SetActive(true);
        }
    }

    void Update()
    {
        if(PrefsJogador.instancia.mudou)
        {
            if (PlayerPrefs.GetString("Idioma") == "Port")
            {
                painelIdiomaCerto[0].SetActive(true);
                painelIdiomaCerto[1].SetActive(false);
            }
            else if (PlayerPrefs.GetString("Idioma") == "Esp")
            {
                painelIdiomaCerto[0].SetActive(false);
                painelIdiomaCerto[1].SetActive(true);
            }
            PrefsJogador.instancia.mudou = false;
        }
    }

    public void CarregarCena(string opcoes)
    {
        if (opcoes == "Jogo")
        {
            SceneManager.LoadScene("Carregamento");
            Carregamento.cenaACarregar = "Jogo";
        }
    }
}
