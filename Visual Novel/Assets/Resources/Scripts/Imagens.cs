using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagens : MonoBehaviour
{
    public GameObject[] Ayla;
    public GameObject[] Alice;
    public GameObject[] Cenarios;

    public static Imagens instancia;

    private void Start()
    {
        instancia = this;
    }

    public void PosicoesPersonagens()
    {
        //Narrador
        if (DialogoComSlipt.instancia.personagem.text == "Narrador" || DialogoComSlipt.instancia.personagem.text == "")
        {
            DialogoComSlipt.instancia.personagem.text = "Narrador";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.personagem.text == "AparecerAsDuas")
        {
            DialogoComSlipt.instancia.personagem.text = "Narrador";
            Ayla[0].SetActive(true);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(true);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }

        //Ayla
        else if (DialogoComSlipt.instancia.personagem.text == "AylaPadrao")
        {
            DialogoComSlipt.instancia.personagem.text = "Ayla";
            Ayla[0].SetActive(true);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.personagem.text == "AylaIrritada")
        {
            DialogoComSlipt.instancia.personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(true);
            Ayla[0].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.personagem.text == "AylaTriste")
        {
            DialogoComSlipt.instancia.personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(true);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }

        //Alice
        else if (DialogoComSlipt.instancia.personagem.text == "AlicePadrao")
        {
            DialogoComSlipt.instancia.personagem.text = "Alice";
            Alice[0].SetActive(true);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.personagem.text == "AliceIrritada")
        {
            DialogoComSlipt.instancia.personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(true);
            Alice[0].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.personagem.text == "AliceTriste")
        {
            DialogoComSlipt.instancia.personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(true);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
    }

    public void MudarCenarios()
    {
        if (DialogoComSlipt.instancia.cenarios == "")
        {
            Cenarios[0].SetActive(true);
            Cenarios[1].SetActive(false);
            Cenarios[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.cenarios == "QuartoAyla")
        {
            Cenarios[0].SetActive(false);
            Cenarios[1].SetActive(true);
            Cenarios[2].SetActive(false);
        }
        else if (DialogoComSlipt.instancia.cenarios == "QuartoAlice")
        {
            Cenarios[0].SetActive(false);
            Cenarios[1].SetActive(false);
            Cenarios[2].SetActive(true);
        }
    }
}
