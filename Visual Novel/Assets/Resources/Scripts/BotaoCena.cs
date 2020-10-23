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

    public void Fase1()
    {
        PlayerPrefs.SetString("Fase", "Fase1");
    }

    public void Fase2()
    {
        PlayerPrefs.SetString("Fase", "Fase2");
    }

    public void CarregarCena()
    {
        if (PlayerPrefs.GetString("Fase") == "Fase1" || !PlayerPrefs.HasKey("Fase"))
        {
            SceneManager.LoadScene("Carregamento");
            Carregamento.cenaACarregar = "Fase1";
        }

        else if (PlayerPrefs.GetString("Fase") == "Fase2")
        {
            SceneManager.LoadScene("Carregamento");
            Carregamento.cenaACarregar = "Fase2";
        }
    }
}
