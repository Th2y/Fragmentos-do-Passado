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
    public Button iniciar;

    void Awake()
    {
        instancia = this;

        iniciar.gameObject.SetActive(true);
        proximo.gameObject.SetActive(false);
        anterior.gameObject.SetActive(false);

        escolhas[0].gameObject.SetActive(false);
        escolhas[1].gameObject.SetActive(false);
        escolhas[2].gameObject.SetActive(false);
        escolhas[3].gameObject.SetActive(false);
        escolhas[4].gameObject.SetActive(false);
        escolhas[5].gameObject.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
