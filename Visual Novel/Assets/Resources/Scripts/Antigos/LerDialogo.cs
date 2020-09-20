using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class LerDialogo : MonoBehaviour
{
    public GameObject[] Ayla;
    public GameObject[] Alice;
    public GameObject[] Cenarios;

    public TextMeshProUGUI dialogo;

    string cenarios;
    string personagensPoses;
    public TextMeshProUGUI personagem;

    //public string textoArquivo;
    public string[] linhasIniciais = File.ReadAllLines("Assets\\Resources\\Dialogos\\Dialogo.txt");
    public string[] linhasA = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoA.txt");
    public string[] linhasB = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoB.txt");

    public string[] linhasBa = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBa.txt");
    public string[] linhasBb = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBb.txt");

    public string[] linhasBAa = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBAa.txt");
    public string[] linhasBAb = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBAb.txt");

    public Button avancar;
    public Button voltar;

    public Button opcaoA, opcaoB;
    public Button opcaoBa, opcaoBb;
    public Button opcaoBAa, opcaoBAb;

    bool opcoesA = false, opcoesB = false;
    bool opcoesBa = false, opcoesBb = false;
    bool opcoesBAa = false, opcoesBAb = false;

    int i = 0;
    public static bool mudarMusica = false;

    void Start()
    {
        voltar.interactable = false;
        dialogo.text = "No presente...";
        dialogo.alignment = TextAlignmentOptions.TopLeft;
        cenarios = "QuartoAyla";

        opcaoA.gameObject.SetActive(false);
        opcaoB.gameObject.SetActive(false);

        opcaoBa.gameObject.SetActive(false);
        opcaoBb.gameObject.SetActive(false);

        opcaoBAa.gameObject.SetActive(false);
        opcaoBAb.gameObject.SetActive(false);

        opcoesA = false;
        opcoesB = false;

        opcoesBa = false;
        opcoesBb = false;

        opcoesBAa = false;
        opcoesBAb = false;
    }

    void Leitura()
    {
        //Inicial
        if (!opcoesA && !opcoesB)
        {
            if (i == 0)
            {
                voltar.interactable = false;
                cenarios = "QuartoAyla";
                personagensPoses = "Narrador";
                dialogo.text = linhasIniciais[0];
            }
            else if (i == 1)
            {
                Handheld.Vibrate();
                voltar.interactable = true;
                cenarios = "QuartoAyla";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasIniciais[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAyla";
                personagensPoses = "Narrador";
                dialogo.text = linhasIniciais[2];
            }
            else if (i == 3)
            {
                cenarios = "QuartoAyla";
                personagensPoses = "Narrador";
                dialogo.text = linhasIniciais[3];
            }
            else if (i == 4)
            {
                cenarios = "QuartoAyla";
                personagensPoses = "";
                dialogo.text = linhasIniciais[4];
                dialogo.alignment = TextAlignmentOptions.TopGeoAligned;

                avancar.interactable = false;
                voltar.interactable = false;

                opcaoA.gameObject.SetActive(true);
                opcaoB.gameObject.SetActive(true);
            }
        }

        //Após escolher entre A e B
        else if (opcoesA)
        {
            if (i == 0)
            {
                dialogo.alignment = TextAlignmentOptions.TopLeft;
                opcaoA.gameObject.SetActive(false);
                opcaoB.gameObject.SetActive(false);
                avancar.interactable = true;

                cenarios = "QuartoAyla";
                personagensPoses = "Narrador";
                dialogo.text = linhasA[0];
            }
            else if (i == 1)
            {
                voltar.interactable = true;

                cenarios = "QuartoAyla";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasA[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAyla";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasA[2];
            }
            else if (i == 3)
            {
                voltar.interactable = false;
                avancar.interactable = false;
                cenarios = "QuartoAyla";
                personagensPoses = "Narrador";
                dialogo.text = linhasA[3];
            }
        }

        else if(opcoesB && !opcoesBa && !opcoesBb)
        {
            if (i == 0)
            {
                dialogo.alignment = TextAlignmentOptions.TopLeft;
                opcaoA.gameObject.SetActive(false);
                opcaoB.gameObject.SetActive(false);
                avancar.interactable = true;

                cenarios = "QuartoAyla";
                personagensPoses = "Narrador";
                dialogo.text = linhasB[0];
            }
            else if(i == 1)
            {
                voltar.interactable = true;

                cenarios = "QuartoAyla";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasB[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAyla";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasB[2];
            }
            else if (i == 3)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "Narrador";
                dialogo.text = linhasB[3];
            }
            else if (i == 4)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasB[4];
            }
            else if (i == 5)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasB[5];
            }
            else if (i == 6)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasB[6];
            }
            else if (i == 7)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasB[7];
            }
            else if (i == 8)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasB[8];
            }
            else if(i == 9)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = "Escolha:";
                dialogo.alignment = TextAlignmentOptions.TopGeoAligned;

                avancar.interactable = false;
                voltar.interactable = false;

                opcaoBa.gameObject.SetActive(true);
                opcaoBb.gameObject.SetActive(true);
            }
        }

        //Após escolher entre Ba e Bb
        else if(opcoesBa && !opcoesBAa && !opcoesBAb)
        {
            if(i == 0)
            {
                dialogo.alignment = TextAlignmentOptions.TopLeft;
                opcaoBa.gameObject.SetActive(false);
                opcaoBb.gameObject.SetActive(false);
                avancar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBa[0];
            }
            else if(i== 1)
            {
                voltar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBa[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBa[2];
            }
            else if (i == 3)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBa[3];
            }
            else if (i == 4)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBa[4];
            }
            else if (i == 5)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBa[5];
            }
            else if (i == 6)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBa[6];
            }
            else if (i == 7)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBa[7];
            }
            else if (i == 8)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBa[8];
            }
            else if (i == 9)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBa[9];
            }
            else if(i == 10)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = "Escolha:";
                dialogo.alignment = TextAlignmentOptions.TopGeoAligned;

                avancar.interactable = false;
                voltar.interactable = false;

                opcaoBAa.gameObject.SetActive(true);
                opcaoBAb.gameObject.SetActive(true);
            }
        }

        else if (opcoesBb)
        {
            if (i == 0)
            {
                dialogo.alignment = TextAlignmentOptions.TopLeft;
                opcaoBa.gameObject.SetActive(false);
                opcaoBb.gameObject.SetActive(false);
                avancar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBb[0];
            }
            else if (i == 1)
            {
                voltar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AliceTriste";
                dialogo.text = linhasBb[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBb[2];
            }
            else if (i == 3)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AliceTriste";
                dialogo.text = linhasBb[3];
            }
            else if (i == 4)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBb[4];
            }
            else if (i == 5)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBb[5];
            }
            else if (i == 6)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBb[6];
            }
            else if (i == 7)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBb[7];
            }
            else if (i == 8)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBb[8];
            }
            else if (i == 9)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBb[9];
            }
            else if (i == 10)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBb[10];
            }
            else if (i == 11)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBb[11];
            }
            else if (i == 12)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBb[12];
            }
            else if (i == 13)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBb[13];
            }
            else if (i == 14)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBb[14];
                dialogo.alignment = TextAlignmentOptions.TopGeoAligned;

                avancar.interactable = false;
                voltar.interactable = false;
            }
        }

        //Após escolher entre BAa e BAb
        else if(opcoesBAa)
        {
            if (i == 0)
            {
                dialogo.alignment = TextAlignmentOptions.TopLeft;
                opcaoBAa.gameObject.SetActive(false);
                opcaoBAb.gameObject.SetActive(false);
                avancar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBAa[0];
            }
            else if (i == 1)
            {
                voltar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBAa[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAa[2];
            }
            else if (i == 3)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBAa[3];
            }
            else if (i == 4)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBAa[4];
            }
            else if (i == 5)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBAa[5];
            }
            else if (i == 6)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBAa[6];
            }
            else if (i == 7)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AlicePadrao";
                dialogo.text = linhasBAa[7];
            }
            else if (i == 8)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaPadrao";
                dialogo.text = linhasBAa[8];
            }
            else if (i == 9)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAa[9];
            }
            else if (i == 10)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAa[10];
            }
            else if (i == 11)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAa[11];
            }
            else if (i == 12)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAa[12];
            }
            else if (i == 13)
            {
                cenarios = "QuartoAyla";
                personagensPoses = "AparecerAsDuas";
                dialogo.text = linhasBAa[13];
                dialogo.alignment = TextAlignmentOptions.TopGeoAligned;

                avancar.interactable = false;
                voltar.interactable = false;
            }
        }

        else if (opcoesBAb)
        {
            if (i == 0)
            {
                dialogo.alignment = TextAlignmentOptions.TopLeft;
                opcaoBAa.gameObject.SetActive(false);
                opcaoBAb.gameObject.SetActive(false);
                avancar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBAb[0];
            }
            else if (i == 1)
            {
                voltar.interactable = true;

                cenarios = "QuartoAlice";
                personagensPoses = "AliceTriste";
                dialogo.text = linhasBAb[1];
            }
            else if (i == 2)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "AylaTriste";
                dialogo.text = linhasBAb[2];
            }
            else if (i == 3)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAb[3];
            }
            else if (i == 4)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAb[4];
            }            
            else if (i == 5)
            {
                cenarios = "QuartoAlice";
                personagensPoses = "";
                dialogo.text = linhasBAb[5];
                dialogo.alignment = TextAlignmentOptions.TopGeoAligned;

                avancar.interactable = false;
                voltar.interactable = false;
            }
        }

        //Por garantia
        else
        {
            cenarios = "";
            personagensPoses = "";
            dialogo.text = "Ocorreu um erro, por favor, retorne ao menu e tente novamente";
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    void PosicoesPersonagens()
    {
        //Narrador
        if(personagensPoses == "Narrador" || personagensPoses == "")
        {
            personagem.text = "Narrador";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if(personagensPoses == "AparecerAsDuas")
        {
            personagem.text = "Narrador";
            Ayla[0].SetActive(true);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(true);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }

        //Ayla
        else if (personagensPoses == "AylaPadrao")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(true);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagensPoses == "AylaIrritada")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(true);
            Ayla[0].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagensPoses == "AylaTriste")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(true);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }

        //Alice
        else if (personagensPoses == "AlicePadrao")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(true);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagensPoses == "AliceIrritada")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(true);
            Alice[0].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagensPoses == "AliceTriste")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(true);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
    }

    void MudarCenarios()
    {
        if (cenarios == "")
        {
            Cenarios[0].SetActive(true);
            Cenarios[1].SetActive(false);
            Cenarios[2].SetActive(false);
        }
        else if (cenarios == "QuartoAyla")
        {
            Cenarios[0].SetActive(false);
            Cenarios[1].SetActive(true);
            Cenarios[2].SetActive(false);
        }
        else if (cenarios == "QuartoAlice")
        {
            Cenarios[0].SetActive(false);
            Cenarios[1].SetActive(false);
            Cenarios[2].SetActive(true);
        }
    }

    public void Proximo()
    {
        Leitura();
        i++;
    }

    public void Anterior()
    {
        Leitura();
        i--;
    }

    public void Opcoes(string opcoes)
    {
        switch(opcoes)
        {
            case "A":
                opcoesA = true;
                i = 0;
                Leitura();
                break;
            case "B":
                opcoesB = true;
                i = 0;
                Leitura();
                mudarMusica = true;
                break;

            case "Ba":
                opcoesBa = true;
                i = 0;
                Leitura();
                break;
            case "Bb":
                opcoesBb = true;
                i = 0;
                Leitura();
                break;

            case "BAa":
                opcoesBAa = true;
                i = 0;
                Leitura();
                break;
            case "BAb":
                opcoesBAb = true;
                i = 0;
                Leitura();
                break;           
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
