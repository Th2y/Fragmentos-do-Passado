using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotoesEmJogo : MonoBehaviour
{
    public static BotoesEmJogo instancia;

    public Button proximo;
    public Button anterior;
    public Button[] escolhas;
    public Button[] escolhasEsp;
    public Button[] auto;
    public bool automatico;

    void Awake()
    {
        instancia = this;

        proximo.gameObject.SetActive(false);
        anterior.gameObject.SetActive(false);

        for(int i = 0; i < escolhas.Length; i++)
        {
            escolhas[i].gameObject.SetActive(false);
        }
        for(int i = 0; i < escolhasEsp.Length; i++)
        {
            escolhasEsp[i].gameObject.SetActive(false);
        }

        auto[0].gameObject.SetActive(true);
        auto[1].gameObject.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AutoSim()
    {
        DialogoComSlipt.instancia.num++;
        DialogoComSlipt.instancia.Ler();
        auto[1].gameObject.SetActive(true);
        auto[0].gameObject.SetActive(false);
        automatico = true;
    }

    public void AutoNao()
    {
        auto[0].gameObject.SetActive(true);
        auto[1].gameObject.SetActive(false);
        automatico = false;
    }
}
