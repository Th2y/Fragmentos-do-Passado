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
        PlayerPrefs.DeleteKey("Escolha");
    }

    public void Termo()
    {
        PlayerPrefs.SetString("Termo", "Sim");
    }
}
