using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class DialogoNovoFormato : MonoBehaviour
{
    public GameObject[] Ayla;
    public GameObject[] Alice;
    public GameObject[] Cenarios;

    string cenarios;
    string personagensPoses;
    public TextMeshProUGUI personagem;

    int num;
    List<string> listaLinhasIniciais = new List<string>();
    List<string> listaLinhasA = new List<string>();
    List<string> listaLinhasB = new List<string>();
    List<string> listaLinhasBa = new List<string>();
    List<string> listaLinhasBb = new List<string>();
    List<string> listaLinhasBAa = new List<string>();
    List<string> listaLinhasBAb = new List<string>();

    public TextMeshProUGUI conteudo;
    public Button[] proximo;
    public Button[] escolhas;

    void Start()
    {
        conteudo.text = "No presente...";
        conteudo.alignment = TextAlignmentOptions.TopLeft;
        cenarios = "QuartoAyla";

        //strings[]
        string[] linhasIniciais = File.ReadAllLines("Assets\\Resources\\Dialogos\\Dialogo.txt");
        string[] linhasA = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoA.txt");
        string[] linhasB = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoB.txt");

        string[] linhasBa = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBa.txt");
        string[] linhasBb = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBb.txt");

        string[] linhasBAa = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBAa.txt");
        string[] linhasBAb = File.ReadAllLines("Assets\\Resources\\Dialogos\\OpcaoBAb.txt");


        //fors
        for (int i = 0; i < linhasIniciais.Length; i++)
        {
            listaLinhasIniciais.Add(linhasIniciais[i]);
        }

        for (int i = 0; i < linhasA.Length; i++)
        {
            listaLinhasA.Add(linhasA[i]);
        }
        for (int i = 0; i < linhasB.Length; i++)
        {
            listaLinhasB.Add(linhasB[i]);
        }

        for (int i = 0; i < linhasBa.Length; i++)
        {
            listaLinhasBa.Add(linhasBa[i]);
        }
        for (int i = 0; i < linhasBb.Length; i++)
        {
            listaLinhasBb.Add(linhasBb[i]);
        }

        for (int i = 0; i < linhasBAa.Length; i++)
        {
            listaLinhasBAa.Add(linhasBAa[i]);
        }
        for (int i = 0; i < linhasBAb.Length; i++)
        {
            listaLinhasBAb.Add(linhasBAb[i]);
        }

        proximo[0].gameObject.SetActive(true);
        proximo[1].gameObject.SetActive(false);
        proximo[2].gameObject.SetActive(false);
        proximo[3].gameObject.SetActive(false);
        proximo[4].gameObject.SetActive(false);
        proximo[5].gameObject.SetActive(false);
        proximo[6].gameObject.SetActive(false);

        escolhas[0].gameObject.SetActive(false);
        escolhas[1].gameObject.SetActive(false);
        escolhas[2].gameObject.SetActive(false);
        escolhas[3].gameObject.SetActive(false);
        escolhas[4].gameObject.SetActive(false);
        escolhas[5].gameObject.SetActive(false);
    }

    void PosicoesPersonagens()
    {
        //Narrador
        if (personagensPoses == "Narrador" || personagensPoses == "")
        {
            personagem.text = "Narrador";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagensPoses == "AparecerAsDuas")
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


    public void LerLinhasIniciais()
    {
        if (num == 0)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "Narrador";
            conteudo.text = listaLinhasIniciais[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasIniciais[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "Narrador";
            conteudo.text = listaLinhasIniciais[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "Narrador";
            conteudo.text = listaLinhasIniciais[3];
            num++;
        }
        else if (num == 4)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "";
            conteudo.alignment = TextAlignmentOptions.TopGeoAligned;
            conteudo.text = listaLinhasIniciais[4];
            num = 0;
            proximo[0].gameObject.SetActive(false);
            escolhas[0].gameObject.SetActive(true);
            escolhas[1].gameObject.SetActive(true);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    public void LerLinhasA()
    {
        if (num == 0)
        {
            conteudo.alignment = TextAlignmentOptions.TopLeft;
            cenarios = "QuartoAyla";
            personagensPoses = "Narrador";
            escolhas[0].gameObject.SetActive(false);
            escolhas[1].gameObject.SetActive(false);
            proximo[1].gameObject.SetActive(true);
            conteudo.text = listaLinhasA[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasA[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasA[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "Narrador";
            conteudo.text = listaLinhasA[3];
            num = 0;
            proximo[1].gameObject.SetActive(false);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    public void LerLinhasB()
    {
        if (num == 0)
        {
            conteudo.alignment = TextAlignmentOptions.TopLeft;
            cenarios = "QuartoAyla";
            personagensPoses = "Narrador";
            escolhas[0].gameObject.SetActive(false);
            escolhas[1].gameObject.SetActive(false);
            proximo[2].gameObject.SetActive(true);
            conteudo.text = listaLinhasB[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasB[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAyla";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasB[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "Narrador";
            conteudo.text = listaLinhasB[3];
            num++;
        }
        else if (num == 4)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasB[4];
            num++;
        }
        else if (num == 5)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasB[5];
            num++;
        }
        else if (num == 6)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasB[6];
            num++;
        }
        else if (num == 7)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasB[7];
            num++;
        }
        else if (num == 8)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasB[8];
            num++;
        }
        else if (num == 9)
        {
            conteudo.alignment = TextAlignmentOptions.TopGeoAligned;
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasB[9];
            num = 0;
            proximo[2].gameObject.SetActive(false);
            escolhas[2].gameObject.SetActive(true);
            escolhas[3].gameObject.SetActive(true);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    public void LerLinhasBa()
    {
        if (num == 0)
        {
            conteudo.alignment = TextAlignmentOptions.TopLeft;
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            escolhas[2].gameObject.SetActive(false);
            escolhas[3].gameObject.SetActive(false);
            proximo[3].gameObject.SetActive(true);
            conteudo.text = listaLinhasBa[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBa[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBa[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBa[3];
            num++;
        }
        else if (num == 4)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBa[4];
            num++;
        }
        else if (num == 5)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBa[5];
            num++;
        }
        else if (num == 6)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBa[6];
            num++;
        }
        else if (num == 7)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBa[7];
            num++;
        }
        else if (num == 8)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBa[8];
            num++;
        }
        else if (num == 9)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBa[9];
            num++;
        }
        else if (num == 10)
        {
            conteudo.alignment = TextAlignmentOptions.TopGeoAligned;
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBa[10];
            num = 0;
            proximo[3].gameObject.SetActive(false);
            escolhas[4].gameObject.SetActive(true);
            escolhas[5].gameObject.SetActive(true);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    public void LerLinhasBb()
    {
        if (num == 0)
        {
            conteudo.alignment = TextAlignmentOptions.TopLeft;
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            escolhas[2].gameObject.SetActive(false);
            escolhas[3].gameObject.SetActive(false);
            proximo[4].gameObject.SetActive(true);
            conteudo.text = listaLinhasBb[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AliceTriste";
            conteudo.text = listaLinhasBb[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBb[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AliceTriste";
            conteudo.text = listaLinhasBb[3];
            num++;
        }
        else if (num == 4)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBb[4];
            num++;
        }
        else if (num == 5)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBb[5];
            num++;
        }
        else if (num == 6)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBb[6];
            num++;
        }
        else if (num == 7)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBb[7];
            num++;
        }
        else if (num == 8)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBb[8];
            num++;
        }
        else if (num == 9)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBb[9];
            num++;
        }
        else if (num == 10)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBb[10];
            num++;
        }
        else if (num == 11)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBb[11];
            num++;
        }
        else if (num == 12)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBb[12];
            num++;
        }
        else if (num == 13)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBb[13];
            num++;
        }
        else if (num == 14)
        {
            conteudo.alignment = TextAlignmentOptions.TopGeoAligned;
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBb[14];
            num = 0;
            proximo[4].gameObject.SetActive(false);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    public void LerLinhasBAa()
    {
        if (num == 0)
        {
            conteudo.alignment = TextAlignmentOptions.TopLeft;
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            escolhas[4].gameObject.SetActive(false);
            escolhas[5].gameObject.SetActive(false);
            proximo[5].gameObject.SetActive(true);
            conteudo.text = listaLinhasBAa[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBAa[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAa[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBAa[3];
            num++;
        }
        else if (num == 4)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBAa[4];
            num++;
        }
        else if (num == 5)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBAa[5];
            num++;
        }
        else if (num == 6)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBAa[6];
            num++;
        }
        else if (num == 7)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AlicePadrao";
            conteudo.text = listaLinhasBAa[7];
            num++;
        }
        else if (num == 8)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaPadrao";
            conteudo.text = listaLinhasBAa[8];
            num++;
        }
        else if (num == 9)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAa[9];
            num++;
        }
        else if (num == 10)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAa[10];
            num++;
        }
        else if (num == 11)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAa[11];
            num++;
        }
        else if (num == 12)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAa[12];
            num++;
        }
        else if (num == 13)
        {
            conteudo.alignment = TextAlignmentOptions.TopGeoAligned;
            cenarios = "QuartoAyla";
            personagensPoses = "AparecerAsDuas";
            conteudo.text = listaLinhasBAa[13];
            num = 0;
            proximo[5].gameObject.SetActive(false);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }

    public void LerLinhasBAb()
    {
        if (num == 0)
        {
            conteudo.alignment = TextAlignmentOptions.TopLeft;
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            escolhas[4].gameObject.SetActive(false);
            escolhas[5].gameObject.SetActive(false);
            proximo[6].gameObject.SetActive(true);
            conteudo.text = listaLinhasBAb[0];
            num++;
        }
        else if (num == 1)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AliceTriste";
            conteudo.text = listaLinhasBAb[1];
            num++;
        }
        else if (num == 2)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "AylaTriste";
            conteudo.text = listaLinhasBAb[2];
            num++;
        }
        else if (num == 3)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAb[3];
            num++;
        }
        else if (num == 4)
        {
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAb[4];
            num++;
        }        
        else if (num == 5)
        {
            conteudo.alignment = TextAlignmentOptions.TopGeoAligned;
            cenarios = "QuartoAlice";
            personagensPoses = "";
            conteudo.text = listaLinhasBAb[5];
            num = 0;
            proximo[6].gameObject.SetActive(false);
        }

        PosicoesPersonagens();
        MudarCenarios();
    }


    public void Opcoes(string opcoes)
    {
        switch (opcoes)
        {
            case "A":
                LerLinhasA();
                break;
            case "B":
                LerLinhasB();
                break;

            case "Ba":
                LerLinhasBa();
                break;
            case "Bb":
                LerLinhasBb();
                break;

            case "BAa":
                LerLinhasBAa();
                break;
            case "BAb":
                LerLinhasBAb();
                break;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
