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
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
