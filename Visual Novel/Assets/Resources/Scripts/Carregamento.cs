using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Carregamento : MonoBehaviour
{
    public static string cenaACarregar;
    public float TempoFixoSeg = 5;
    public enum TipoCarreg { Carregamento, TempoFixo };
    public TipoCarreg TipoDeCarregamento;
    public Image barraDeCarregamento;
    public Text TextoProgresso;
    private int progresso = 0;

    void Start()
    {
        switch (TipoDeCarregamento)
        {
            case TipoCarreg.Carregamento:
                StartCoroutine(CenaDeCarregamento(cenaACarregar));
                break;
            case TipoCarreg.TempoFixo:
                StartCoroutine(TempoFixo(cenaACarregar));
                break;
        }

        if (barraDeCarregamento != null)
        {
            barraDeCarregamento.type = Image.Type.Filled;
            barraDeCarregamento.fillMethod = Image.FillMethod.Horizontal;
            barraDeCarregamento.fillOrigin = (int)Image.OriginHorizontal.Left;
        }
    }

    IEnumerator CenaDeCarregamento(string cena)
    {
        AsyncOperation carregamento = SceneManager.LoadSceneAsync(cena);
        carregamento.allowSceneActivation = false;
        while (progresso < 89)
        {
            progresso = (int)(carregamento.progress * 100.0f);
            yield return null;
        }
        progresso = 100;
        yield return new WaitForSeconds(2);
        carregamento.allowSceneActivation = true;
    }

    IEnumerator TempoFixo(string cena)
    {
        yield return new WaitForSeconds(TempoFixoSeg);
        SceneManager.LoadSceneAsync(cena);
    }

    void Update()
    {
        switch (TipoDeCarregamento)
        {
            case TipoCarreg.Carregamento:
                break;
            case TipoCarreg.TempoFixo:
                progresso = (int)(Mathf.Clamp((Time.time / TempoFixoSeg), 0.0f, 1.0f) * 100.0f);
                break;
        }

        if (TextoProgresso != null)
            TextoProgresso.text = progresso + "%";

        if (barraDeCarregamento != null)
            barraDeCarregamento.fillAmount = (progresso / 100.0f);
    }
}