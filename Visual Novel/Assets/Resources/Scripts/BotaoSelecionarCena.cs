using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BotaoSelecionarCena : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CarregarCenaSelecionada()
    {
        SceneManager.LoadScene("Menu");
    }
}
