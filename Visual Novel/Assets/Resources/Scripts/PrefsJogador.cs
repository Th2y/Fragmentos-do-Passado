using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefsJogador : MonoBehaviour
{
    public static PrefsJogador instancia;
    public Dropdown[] idioma;
    public ScrollRect[] painelTermoIdioma;
    public Button[] confirmarIdioma;
    public bool mudou = false;

    void Start()
    {
        confirmarIdioma[0].interactable = false;
        confirmarIdioma[1].interactable = false;
        confirmarIdioma[2].interactable = false;

        instancia = this;
    }

    public void CarregarNovoJogo()
    {
        PlayerPrefs.DeleteKey("Escolha");
    }

    public void TermoAceito()
    {
        PlayerPrefs.SetString("Termo", "Sim");
    }

    public void TermoIdioma()
    {
        if (PlayerPrefs.GetString("Idioma") == "Port")
        {
            painelTermoIdioma[0].gameObject.SetActive(true);
            mudou = true;
        }
        else if (PlayerPrefs.GetString("Idioma") == "Esp")
        {
            painelTermoIdioma[1].gameObject.SetActive(true);
            mudou = true;
        }
    }

    public void Idioma()
    {
        switch(idioma[0].value)
        {
            case 0:
                confirmarIdioma[0].interactable = false;
                break;
            case 1:
                PlayerPrefs.SetString("Idioma", "Port");
                Debug.Log(PlayerPrefs.GetString("Idioma"));
                confirmarIdioma[0].interactable = true;
                break;
            case 2:
                PlayerPrefs.SetString("Idioma", "Esp");
                Debug.Log(PlayerPrefs.GetString("Idioma"));
                confirmarIdioma[0].interactable = true;
                break;
        }

        switch (idioma[1].value)
        {
            case 0:
                confirmarIdioma[1].interactable = false;
                break;
            case 1:
                PlayerPrefs.SetString("Idioma", "Port");
                Debug.Log(PlayerPrefs.GetString("Idioma"));
                confirmarIdioma[1].interactable = true;
                break;
            case 2:
                PlayerPrefs.SetString("Idioma", "Esp");
                Debug.Log(PlayerPrefs.GetString("Idioma"));
                confirmarIdioma[1].interactable = true;
                break;
        }

        switch (idioma[2].value)
        {
            case 0:
                confirmarIdioma[2].interactable = false;
                break;
            case 1:
                PlayerPrefs.SetString("Idioma", "Port");
                Debug.Log(PlayerPrefs.GetString("Idioma"));
                confirmarIdioma[2].interactable = true;
                break;
            case 2:
                PlayerPrefs.SetString("Idioma", "Esp");
                Debug.Log(PlayerPrefs.GetString("Idioma"));
                confirmarIdioma[2].interactable = true;
                break;
        }
    }
}
