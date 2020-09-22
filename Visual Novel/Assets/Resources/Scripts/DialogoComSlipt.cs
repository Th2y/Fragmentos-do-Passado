using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class DialogoComSlipt : MonoBehaviour
{
    public GameObject[] Ayla;
    public GameObject[] Alice;
    public GameObject[] Cenarios;

    public string[] linhasIniciais;
    string[] linhasIniciaisSplit;
    List<string> listaLinhasIniciaisPersonagem = new List<string>();
    List<string> listaLinhasIniciaisFala = new List<string>();
    List<string> listaLinhasIniciaisCenario = new List<string>();

    public string[] linhasA;
    string[] linhasASplit;
    List<string> listaLinhasAPersonagem = new List<string>();
    List<string> listaLinhasAFala = new List<string>();
    List<string> listaLinhasACenario = new List<string>();

    public string[] linhasB;
    string[] linhasBSplit;
    List<string> listaLinhasBPersonagem = new List<string>();
    List<string> listaLinhasBFala = new List<string>();
    List<string> listaLinhasBCenario = new List<string>();

    public string[] linhasBa;
    string[] linhasBaSplit;
    List<string> listaLinhasBaPersonagem = new List<string>();
    List<string> listaLinhasBaFala = new List<string>();
    List<string> listaLinhasBaCenario = new List<string>();

    public string[] linhasBb;
    string[] linhasBbSplit;
    List<string> listaLinhasBbPersonagem = new List<string>();
    List<string> listaLinhasBbFala = new List<string>();
    List<string> listaLinhasBbCenario = new List<string>();

    public string[] linhasBAa;
    string[] linhasBAaSplit;
    List<string> listaLinhasBAaPersonagem = new List<string>();
    List<string> listaLinhasBAaFala = new List<string>();
    List<string> listaLinhasBAaCenario = new List<string>();

    public string[] linhasBAb;
    string[] linhasBAbSplit;
    List<string> listaLinhasBAbPersonagem = new List<string>();
    List<string> listaLinhasBAbFala = new List<string>();
    List<string> listaLinhasBAbCenario = new List<string>();

    public TextMeshProUGUI personagem;
    public TextMeshProUGUI conteudo;
    public string cenarios;

    public int num = 1;
    private bool[] opcoes = new bool[6];

    public static DialogoComSlipt instancia;

    public void PosicoesPersonagens()
    {
        //Narrador
        if (personagem.text == "Narrador" || personagem.text == "")
        {
            personagem.text = "Narrador";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagem.text == "AparecerAsDuas")
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
        else if (personagem.text == "AylaPadrao")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(true);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagem.text == "AylaIrritada")
        {
            personagem.text = "Ayla";
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(true);
            Ayla[0].SetActive(false);
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
        }
        else if (personagem.text == "AylaTriste")
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
        else if (personagem.text == "AlicePadrao")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(true);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "AliceIrritada")
        {
            personagem.text = "Alice";
            Alice[0].SetActive(false);
            Alice[1].SetActive(true);
            Alice[0].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "AliceTriste")
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

    public void MudarCenarios()
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

    private void Awake()
    {
        linhasIniciais = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\Conversa.txt");
        linhasA = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoA.txt");
        linhasB = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoB.txt");
        linhasBa = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBa.txt");
        linhasBb = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBb.txt");
        linhasBAa = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBAa.txt");
        linhasBAb = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBAb.txt");
    }

    private void Start()
    {
        instancia = this;
        for(int i = 0; i < opcoes.Length; i++)
        {
            opcoes[i] = false;
        }

        for (int i = 0; i < linhasIniciais.Length; i++)
        {
            linhasIniciaisSplit = linhasIniciais[i].Split("_"[0]);
            listaLinhasIniciaisCenario.Add(linhasIniciaisSplit[0]);
            listaLinhasIniciaisPersonagem.Add(linhasIniciaisSplit[1]);
            listaLinhasIniciaisFala.Add(linhasIniciaisSplit[2]);
        }

        for (int i = 0; i < linhasA.Length; i++)
        {
            linhasASplit = linhasA[i].Split("_"[0]);
            listaLinhasACenario.Add(linhasASplit[0]);
            listaLinhasAPersonagem.Add(linhasASplit[1]);
            listaLinhasAFala.Add(linhasASplit[2]);
        }

        for (int i = 0; i < linhasB.Length; i++)
        {
            linhasBSplit = linhasB[i].Split("_"[0]);
            listaLinhasBCenario.Add(linhasBSplit[0]);
            listaLinhasBPersonagem.Add(linhasBSplit[1]);
            listaLinhasBFala.Add(linhasBSplit[2]);
        }

        for (int i = 0; i < linhasBa.Length; i++)
        {
            linhasBaSplit = linhasBa[i].Split("_"[0]);
            listaLinhasBaCenario.Add(linhasBaSplit[0]);
            listaLinhasBaPersonagem.Add(linhasBaSplit[1]);
            listaLinhasBaFala.Add(linhasBaSplit[2]);
        }

        for (int i = 0; i < linhasBb.Length; i++)
        {
            linhasBbSplit = linhasBb[i].Split("_"[0]);
            listaLinhasBbCenario.Add(linhasBbSplit[0]);
            listaLinhasBbPersonagem.Add(linhasBbSplit[1]);
            listaLinhasBbFala.Add(linhasBbSplit[2]);
        }

        for (int i = 0; i < linhasBAa.Length; i++)
        {
            linhasBAaSplit = linhasBAa[i].Split("_"[0]);
            listaLinhasBAaCenario.Add(linhasBAaSplit[0]);
            listaLinhasBAaPersonagem.Add(linhasBAaSplit[1]);
            listaLinhasBAaFala.Add(linhasBAaSplit[2]);
        }

        for (int i = 0; i < linhasBAb.Length; i++)
        {
            linhasBAbSplit = linhasBAb[i].Split("_"[0]);
            listaLinhasBAbCenario.Add(linhasBAbSplit[0]);
            listaLinhasBAbPersonagem.Add(linhasBAbSplit[1]);
            listaLinhasBAbFala.Add(linhasBAbSplit[2]);
        }

        if (PlayerPrefs.GetString("EscolhaA") != "A" && PlayerPrefs.GetString("EscolhaB") != "B" && PlayerPrefs.GetString("EscolhaBa") != "Ba" && PlayerPrefs.GetString("EscolhaBb") != "Bb" && PlayerPrefs.GetString("EscolhaBAa") != "BAa" && PlayerPrefs.GetString("EscolhaBAb") != "BAb")
        {
            Debug.Log("Nenhuma");
            opcoes[0] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            personagem.text = listaLinhasIniciaisPersonagem[0];
            Ler();
        }

        else if (PlayerPrefs.GetString("EscolhaBAb") == "BAb")
        {
            Debug.Log("BAb");
            opcoes[6] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("EscolhaBAa") == "BAa")
        {
            Debug.Log("BAa");
            opcoes[5] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("EscolhaBb") == "Bb")
        {
            Debug.Log("Bb");
            opcoes[4] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("EscolhaBa") == "Ba")
        {
            Debug.Log("Ba");
            opcoes[3] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("EscolhaB") == "B")
        {
            Debug.Log("B");
            opcoes[2] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("EscolhaA") == "A")
        {
            Debug.Log("A");
            opcoes[1] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
    }

    public void Ler()
    {
        //Inicial
        if(opcoes[0])
        {
            for (int i = num; i < linhasIniciais.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasIniciaisCenario[i];
                personagem.text = listaLinhasIniciaisPersonagem[i];
                conteudo.text = listaLinhasIniciaisFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasIniciais.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[0] = false;
                    num = 0;
                }
                break;
            }
        }

        //Escolha A/B
        else if (opcoes[1])
        {
            for (int i = num; i < linhasA.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasACenario[i];
                personagem.text = listaLinhasAPersonagem[i];
                conteudo.text = listaLinhasAFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasA.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[1] = false;
                }
                break;
            }
        }

        else if (opcoes[2])
        {
            for (int i = num; i < linhasB.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBCenario[i];
                personagem.text = listaLinhasBPersonagem[i];
                conteudo.text = listaLinhasBFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasB.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[2] = false;
                    num = 0;
                }
                break;
            }
        }

        //Escolha Ba/Bb
        else if (opcoes[3])
        {
            for (int i = num; i < linhasBa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBaCenario[i];
                personagem.text = listaLinhasBaPersonagem[i];
                conteudo.text = listaLinhasBaFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBa.Length - 1)
                {
                    BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[3] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[4])
        {
            for (int i = num; i < linhasBb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBbCenario[i];
                personagem.text = listaLinhasBbPersonagem[i];
                conteudo.text = listaLinhasBbFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBb.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[4] = false;
                }
                break;
            }
        }

        //Escolha BAa/BAb
        else if (opcoes[5])
        {
            for (int i = num; i < linhasBAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBAaCenario[i];
                personagem.text = listaLinhasBAaPersonagem[i];
                conteudo.text = listaLinhasBAaFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBAa.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[5] = false;
                }
                break;
            }
        }

        else if (opcoes[6])
        {
            for (int i = num; i < linhasBAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBAbCenario[i];
                personagem.text = listaLinhasBAbPersonagem[i];
                conteudo.text = listaLinhasBAbFala[i];

                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBAb.Length - 1)
                {
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    opcoes[6] = false;
                }
                break;
            }
        }
    }

    public void Anterior()
    {
        num--;
        Ler();
    }

    public void Proximo()
    {
        num++;
        Ler();
    }

    public void Escolhas(string escolha)
    {
        switch (escolha)
        {
            case "A":
                PlayerPrefs.SetString("EscolhaA", "A");
                opcoes[1] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;
            case "B":
                PlayerPrefs.SetString("EscolhaB", "B");
                opcoes[2] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;

            case "Ba":
                PlayerPrefs.SetString("EscolhaBa", "Ba");
                opcoes[3] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Bb":
                PlayerPrefs.SetString("EscolhaBb", "Bb");
                opcoes[4] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;

            case "BAa":
                PlayerPrefs.SetString("EscolhaBAa", "BAa");
                opcoes[5] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
            case "BAb":
                PlayerPrefs.SetString("EscolhaBAb", "BAb");
                opcoes[6] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
        }
    }
}
