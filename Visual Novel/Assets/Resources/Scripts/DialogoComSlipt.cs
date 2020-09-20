using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class DialogoComSlipt : MonoBehaviour
{
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

    public int i = 0, num = 1;
    private bool[] opcoes = new bool[6];

    public static DialogoComSlipt instancia;

    private void Start()
    {
        instancia = this;
        for(int i = 0; i < opcoes.Length; i++)
        {
            opcoes[i] = false;
        }

        linhasIniciais = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\Conversa.txt");
        for (int i = 0; i < linhasIniciais.Length; i++)
        {
            linhasIniciaisSplit = linhasIniciais[i].Split("_"[0]);
            listaLinhasIniciaisCenario.Add(linhasIniciaisSplit[0]);
            listaLinhasIniciaisPersonagem.Add(linhasIniciaisSplit[1]);
            listaLinhasIniciaisFala.Add(linhasIniciaisSplit[2]);
        }

        linhasA = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoA.txt");
        for (int i = 0; i < linhasA.Length; i++)
        {
            linhasASplit = linhasA[i].Split("_"[0]);
            listaLinhasACenario.Add(linhasASplit[0]);
            listaLinhasAPersonagem.Add(linhasASplit[1]);
            listaLinhasAFala.Add(linhasASplit[2]);
        }

        linhasB = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoB.txt");
        for (int i = 0; i < linhasB.Length; i++)
        {
            linhasBSplit = linhasB[i].Split("_"[0]);
            listaLinhasBCenario.Add(linhasBSplit[0]);
            listaLinhasBPersonagem.Add(linhasBSplit[1]);
            listaLinhasBFala.Add(linhasBSplit[2]);
        }

        linhasBa = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBa.txt");
        for (int i = 0; i < linhasBa.Length; i++)
        {
            linhasBaSplit = linhasBa[i].Split("_"[0]);
            listaLinhasBaCenario.Add(linhasBaSplit[0]);
            listaLinhasBaPersonagem.Add(linhasBaSplit[1]);
            listaLinhasBaFala.Add(linhasBaSplit[2]);
        }

        linhasBb = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBb.txt");
        for (int i = 0; i < linhasBb.Length; i++)
        {
            linhasBbSplit = linhasBb[i].Split("_"[0]);
            listaLinhasBbCenario.Add(linhasBbSplit[0]);
            listaLinhasBbPersonagem.Add(linhasBbSplit[1]);
            listaLinhasBbFala.Add(linhasBbSplit[2]);
        }

        linhasBAa = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBAa.txt");
        for (int i = 0; i < linhasBAa.Length; i++)
        {
            linhasBAaSplit = linhasBAa[i].Split("_"[0]);
            listaLinhasBAaCenario.Add(linhasBAaSplit[0]);
            listaLinhasBAaPersonagem.Add(linhasBAaSplit[1]);
            listaLinhasBAaFala.Add(linhasBAaSplit[2]);
        }

        linhasBAb = File.ReadAllLines("Assets\\Resources\\Dialogos\\Formatados\\OpcaoBAb.txt");
        for (int i = 0; i < linhasBAb.Length; i++)
        {
            linhasBAbSplit = linhasBAb[i].Split("_"[0]);
            listaLinhasBAbCenario.Add(linhasBAbSplit[0]);
            listaLinhasBAbPersonagem.Add(linhasBAbSplit[1]);
            listaLinhasBAbFala.Add(linhasBAbSplit[2]);
        }
    }

    public void Ler()
    {
        //Inicial
        if(opcoes[0])
        {
            for (i = num; i < linhasIniciais.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasIniciaisCenario[i];
                personagem.text = listaLinhasIniciaisPersonagem[i];
                conteudo.text = listaLinhasIniciaisFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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
            for (i = num; i < linhasA.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasACenario[i];
                personagem.text = listaLinhasAPersonagem[i];
                conteudo.text = listaLinhasAFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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
            for (i = num; i < linhasB.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBCenario[i];
                personagem.text = listaLinhasBPersonagem[i];
                conteudo.text = listaLinhasBFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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
            for (i = num; i < linhasBa.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBaCenario[i];
                personagem.text = listaLinhasBaPersonagem[i];
                conteudo.text = listaLinhasBaFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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
            for (i = num; i < linhasBb.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBbCenario[i];
                personagem.text = listaLinhasBbPersonagem[i];
                conteudo.text = listaLinhasBbFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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
            for (i = num; i < linhasBAa.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBAaCenario[i];
                personagem.text = listaLinhasBAaPersonagem[i];
                conteudo.text = listaLinhasBAaFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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
            for (i = num; i < linhasBAb.Length; i++)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                cenarios = listaLinhasBAbCenario[i];
                personagem.text = listaLinhasBAbPersonagem[i];
                conteudo.text = listaLinhasBAbFala[i];

                Imagens.instancia.PosicoesPersonagens();
                Imagens.instancia.MudarCenarios();
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

    public void Comecar()
    {
        opcoes[0] = true;
        BotoesEmJogo.instancia.iniciar.gameObject.SetActive(false);
        BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
        Ler();
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
                opcoes[1] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;
            case "B":
                opcoes[2] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;

            case "Ba":
                opcoes[3] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Bb":
                opcoes[4] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;

            case "BAa":
                opcoes[5] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
            case "BAb":
                opcoes[6] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
        }
    }
}
