using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsJogador : MonoBehaviour
{
    public static PrefsJogador instancia;

    void Start()
    {
        instancia = this;
    }

    public void CarregarNovoJogo()
    {
        PlayerPrefs.DeleteKey("EscolhaA");
        PlayerPrefs.DeleteKey("EscolhaB");
        PlayerPrefs.DeleteKey("EscolhaBa");
        PlayerPrefs.DeleteKey("EscolhaBb");
        PlayerPrefs.DeleteKey("EscolhaBAa");
        PlayerPrefs.DeleteKey("EscolhaBAb");
    }

    public void Termo()
    {
        PlayerPrefs.SetString("Termo", "Sim");
    }
}
