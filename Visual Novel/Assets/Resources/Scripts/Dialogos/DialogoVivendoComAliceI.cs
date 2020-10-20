using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class DialogoVivendoComAliceI : MonoBehaviour
{
    public GameObject[] Ayla;
    public GameObject[] Alice;
    public GameObject[] AylaTransparencia;
    public GameObject[] AliceTransparencia;
    public GameObject[] Cenarios;

    string[] linhasIniciais;
    string[] linhasIniciaisSplit;
    List<string> listaLinhasIniciaisPersonagem = new List<string>();
    List<string> listaLinhasIniciaisPersonagemT = new List<string>();
    List<string> listaLinhasIniciaisFala = new List<string>();
    List<string> listaLinhasIniciaisCenario = new List<string>();

    string[] linhasA;
    string[] linhasASplit;
    List<string> listaLinhasAPersonagem = new List<string>();
    List<string> listaLinhasAPersonagemT = new List<string>();
    List<string> listaLinhasAFala = new List<string>();
    List<string> listaLinhasACenario = new List<string>();

    string[] linhasB;
    string[] linhasBSplit;
    List<string> listaLinhasBPersonagem = new List<string>();
    List<string> listaLinhasBPersonagemT = new List<string>();
    List<string> listaLinhasBFala = new List<string>();
    List<string> listaLinhasBCenario = new List<string>();


    string[] linhasAa;
    string[] linhasAaSplit;
    List<string> listaLinhasAaPersonagem = new List<string>();
    List<string> listaLinhasAaPersonagemT = new List<string>();
    List<string> listaLinhasAaFala = new List<string>();
    List<string> listaLinhasAaCenario = new List<string>();

    string[] linhasAb;
    string[] linhasAbSplit;
    List<string> listaLinhasAbPersonagem = new List<string>();
    List<string> listaLinhasAbPersonagemT = new List<string>();
    List<string> listaLinhasAbFala = new List<string>();
    List<string> listaLinhasAbCenario = new List<string>();

    string[] linhasBa;
    string[] linhasBaSplit;
    List<string> listaLinhasBaPersonagem = new List<string>();
    List<string> listaLinhasBaPersonagemT = new List<string>();
    List<string> listaLinhasBaFala = new List<string>();
    List<string> listaLinhasBaCenario = new List<string>();

    string[] linhasBb;
    string[] linhasBbSplit;
    List<string> listaLinhasBbPersonagem = new List<string>();
    List<string> listaLinhasBbPersonagemT = new List<string>();
    List<string> listaLinhasBbFala = new List<string>();
    List<string> listaLinhasBbCenario = new List<string>();


    string[] linhasAAa;
    string[] linhasAAaSplit;
    List<string> listaLinhasAAaPersonagem = new List<string>();
    List<string> listaLinhasAAaPersonagemT = new List<string>();
    List<string> listaLinhasAAaFala = new List<string>();
    List<string> listaLinhasAAaCenario = new List<string>();

    string[] linhasAAb;
    string[] linhasAAbSplit;
    List<string> listaLinhasAAbPersonagem = new List<string>();
    List<string> listaLinhasAAbPersonagemT = new List<string>();
    List<string> listaLinhasAAbFala = new List<string>();
    List<string> listaLinhasAAbCenario = new List<string>();

    string[] linhasAAc;
    string[] linhasAAcSplit;
    List<string> listaLinhasAAcPersonagem = new List<string>();
    List<string> listaLinhasAAcPersonagemT = new List<string>();
    List<string> listaLinhasAAcFala = new List<string>();
    List<string> listaLinhasAAcCenario = new List<string>();

    string[] linhasABa;
    string[] linhasABaSplit;
    List<string> listaLinhasABaPersonagem = new List<string>();
    List<string> listaLinhasABaPersonagemT = new List<string>();
    List<string> listaLinhasABaFala = new List<string>();
    List<string> listaLinhasABaCenario = new List<string>();

    string[] linhasABb;
    string[] linhasABbSplit;
    List<string> listaLinhasABbPersonagem = new List<string>();
    List<string> listaLinhasABbPersonagemT = new List<string>();
    List<string> listaLinhasABbFala = new List<string>();
    List<string> listaLinhasABbCenario = new List<string>();

    string[] linhasBAa;
    string[] linhasBAaSplit;
    List<string> listaLinhasBAaPersonagem = new List<string>();
    List<string> listaLinhasBAaPersonagemT = new List<string>();
    List<string> listaLinhasBAaFala = new List<string>();
    List<string> listaLinhasBAaCenario = new List<string>();

    string[] linhasBAb;
    string[] linhasBAbSplit;
    List<string> listaLinhasBAbPersonagem = new List<string>();
    List<string> listaLinhasBAbPersonagemT = new List<string>();
    List<string> listaLinhasBAbFala = new List<string>();
    List<string> listaLinhasBAbCenario = new List<string>();

    string[] linhasBBa;
    string[] linhasBBaSplit;
    List<string> listaLinhasBBaPersonagem = new List<string>();
    List<string> listaLinhasBBaPersonagemT = new List<string>();
    List<string> listaLinhasBBaFala = new List<string>();
    List<string> listaLinhasBBaCenario = new List<string>();

    string[] linhasBBb;
    string[] linhasBBbSplit;
    List<string> listaLinhasBBbPersonagem = new List<string>();
    List<string> listaLinhasBBbPersonagemT = new List<string>();
    List<string> listaLinhasBBbFala = new List<string>();
    List<string> listaLinhasBBbCenario = new List<string>();

    public TextMeshProUGUI personagem;
    public TextMeshProUGUI conteudo;
    public string cenarios;
    public string personagemSecundario;

    public int num = 1;
    private bool[] opcoes = new bool[20];

    float tempo;
    bool podeLer = true;

    public AudioSource fundo, fundoEscolha;

    public static DialogoVivendoComAliceI instancia;

    public void Awake()
    {
        if (PlayerPrefs.GetString("Idioma") == "Port")
        {
            TextAsset textoInicial = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/Inicio");
            linhasIniciais = textoInicial.text.Split('\n');

            TextAsset textoA = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoA");
            linhasA = textoA.text.Split('\n');
            TextAsset textoB = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoB");
            linhasB = textoB.text.Split('\n');

            TextAsset textoAa = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoAa");
            linhasAa = textoAa.text.Split('\n');
            TextAsset textoAb = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoAb");
            linhasAb = textoAb.text.Split('\n');
            TextAsset textoBa = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoBa");
            linhasBa = textoBa.text.Split('\n');
            TextAsset textoBb = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoBb");
            linhasBb = textoBb.text.Split('\n');

            TextAsset textoAAa = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoAAa");
            linhasAAa = textoAAa.text.Split('\n');
            TextAsset textoAAb = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoAAb");
            linhasAAb = textoAAb.text.Split('\n');
            TextAsset textoAAc = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoAAc");
            linhasAAc = textoAAc.text.Split('\n');
            TextAsset textoABa = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoABa");
            linhasABa = textoABa.text.Split('\n');
            TextAsset textoABb = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoABb");
            linhasABb = textoABb.text.Split('\n');
            TextAsset textoBAa = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoBAa");
            linhasBAa = textoBAa.text.Split('\n');
            TextAsset textoBAb = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoBAb");
            linhasBAb = textoBAb.text.Split('\n');
            TextAsset textoBBa = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoBBa");
            linhasBBa = textoBBa.text.Split('\n');
            TextAsset textoBBb = (TextAsset)Resources.Load("Dialogos/Port/VivendoComAlice_I/OpcaoBBb");
            linhasBBb = textoBBb.text.Split('\n');
        }

        else if (PlayerPrefs.GetString("Idioma") == "Esp")
        {
            TextAsset textoInicial = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/Inicio");
            linhasIniciais = textoInicial.text.Split('\n');
            Debug.Log(textoInicial);

            TextAsset textoA = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoA");
            linhasA = textoA.text.Split('\n');
            TextAsset textoB = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoB");
            linhasB = textoB.text.Split('\n');

            TextAsset textoAa = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoAa");
            linhasAa = textoAa.text.Split('\n');
            TextAsset textoAb = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoAb");
            linhasAb = textoAb.text.Split('\n');
            TextAsset textoBa = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoBa");
            linhasBa = textoBa.text.Split('\n');
            TextAsset textoBb = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoBb");
            linhasBb = textoBb.text.Split('\n');

            TextAsset textoAAa = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoAAa");
            linhasAAa = textoAAa.text.Split('\n');
            TextAsset textoAAb = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoAAb");
            linhasAAb = textoAAb.text.Split('\n');
            TextAsset textoAAc = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoAAc");
            linhasAAc = textoAAc.text.Split('\n');
            TextAsset textoABa = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoABa");
            linhasABa = textoABa.text.Split('\n');
            TextAsset textoABb = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoABb");
            linhasABb = textoABb.text.Split('\n');
            TextAsset textoBAa = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoBAa");
            linhasBAa = textoBAa.text.Split('\n');
            TextAsset textoBAb = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoBAb");
            linhasBAb = textoBAb.text.Split('\n');
            TextAsset textoBBa = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoBBa");
            linhasBBa = textoBBa.text.Split('\n');
            TextAsset textoBBb = (TextAsset)Resources.Load("Dialogos/Esp/ViviendoComAlice_I/OpcaoBBb");
            linhasBBb = textoBBb.text.Split('\n');
        }

        for (int i = 0; i < linhasIniciais.Length; i++)
        {
            linhasIniciaisSplit = linhasIniciais[i].Split("_"[0]);
            listaLinhasIniciaisCenario.Add(linhasIniciaisSplit[0]);
            listaLinhasIniciaisPersonagem.Add(linhasIniciaisSplit[1]);
            listaLinhasIniciaisPersonagemT.Add(linhasIniciaisSplit[2]);
            listaLinhasIniciaisFala.Add(linhasIniciaisSplit[3]);
        }

        for (int i = 0; i < linhasA.Length; i++)
        {
            linhasASplit = linhasA[i].Split("_"[0]);
            listaLinhasACenario.Add(linhasASplit[0]);
            listaLinhasAPersonagem.Add(linhasASplit[1]);
            listaLinhasAPersonagemT.Add(linhasASplit[2]);
            listaLinhasAFala.Add(linhasASplit[3]);
        }
        for (int i = 0; i < linhasB.Length; i++)
        {
            linhasBSplit = linhasB[i].Split("_"[0]);
            listaLinhasBCenario.Add(linhasBSplit[0]);
            listaLinhasBPersonagem.Add(linhasBSplit[1]);
            listaLinhasBPersonagemT.Add(linhasBSplit[2]);
            listaLinhasBFala.Add(linhasBSplit[3]);
        }

        for (int i = 0; i < linhasAa.Length; i++)
        {
            linhasAaSplit = linhasAa[i].Split("_"[0]);
            listaLinhasAaCenario.Add(linhasAaSplit[0]);
            listaLinhasAaPersonagem.Add(linhasAaSplit[1]);
            listaLinhasAaPersonagemT.Add(linhasAaSplit[2]);
            listaLinhasAaFala.Add(linhasAaSplit[3]);
        }
        for (int i = 0; i < linhasAb.Length; i++)
        {
            linhasAbSplit = linhasAb[i].Split("_"[0]);
            listaLinhasAbCenario.Add(linhasAbSplit[0]);
            listaLinhasAbPersonagem.Add(linhasAbSplit[1]);
            listaLinhasAbPersonagemT.Add(linhasAbSplit[2]);
            listaLinhasAbFala.Add(linhasAbSplit[3]);
        }
        for (int i = 0; i < linhasBa.Length; i++)
        {
            linhasBaSplit = linhasBa[i].Split("_"[0]);
            listaLinhasBaCenario.Add(linhasBaSplit[0]);
            listaLinhasBaPersonagem.Add(linhasBaSplit[1]);
            listaLinhasBaPersonagemT.Add(linhasBaSplit[2]);
            listaLinhasBaFala.Add(linhasBaSplit[3]);
        }
        for (int i = 0; i < linhasBb.Length; i++)
        {
            linhasBbSplit = linhasBb[i].Split("_"[0]);
            listaLinhasBbCenario.Add(linhasBbSplit[0]);
            listaLinhasBbPersonagem.Add(linhasBbSplit[1]);
            listaLinhasBbPersonagemT.Add(linhasBbSplit[2]);
            listaLinhasBbFala.Add(linhasBbSplit[3]);
        }

        for (int i = 0; i < linhasAAa.Length; i++)
        {
            linhasAAaSplit = linhasAAa[i].Split("_"[0]);
            listaLinhasAAaCenario.Add(linhasAAaSplit[0]);
            listaLinhasAAaPersonagem.Add(linhasAAaSplit[1]);
            listaLinhasAAaPersonagemT.Add(linhasAAaSplit[2]);
            listaLinhasAAaFala.Add(linhasAAaSplit[3]);
        }
        for (int i = 0; i < linhasAAb.Length; i++)
        {
            linhasAAbSplit = linhasAAb[i].Split("_"[0]);
            listaLinhasAAbCenario.Add(linhasAAbSplit[0]);
            listaLinhasAAbPersonagem.Add(linhasAAbSplit[1]);
            listaLinhasAAbPersonagemT.Add(linhasAAbSplit[2]);
            listaLinhasAAbFala.Add(linhasAAbSplit[3]);
        }
        for (int i = 0; i < linhasAAc.Length; i++)
        {
            linhasAAcSplit = linhasAAc[i].Split("_"[0]);
            listaLinhasAAcCenario.Add(linhasAAcSplit[0]);
            listaLinhasAAcPersonagem.Add(linhasAAcSplit[1]);
            listaLinhasAAcPersonagemT.Add(linhasAAcSplit[2]);
            listaLinhasAAcFala.Add(linhasAAcSplit[3]);
        }
        for (int i = 0; i < linhasABa.Length; i++)
        {
            linhasABaSplit = linhasABa[i].Split("_"[0]);
            listaLinhasABaCenario.Add(linhasABaSplit[0]);
            listaLinhasABaPersonagem.Add(linhasABaSplit[1]);
            listaLinhasABaPersonagemT.Add(linhasABaSplit[2]);
            listaLinhasABaFala.Add(linhasABaSplit[3]);
        }
        for (int i = 0; i < linhasABb.Length; i++)
        {
            linhasABbSplit = linhasABb[i].Split("_"[0]);
            listaLinhasABbCenario.Add(linhasABbSplit[0]);
            listaLinhasABbPersonagem.Add(linhasABbSplit[1]);
            listaLinhasABbPersonagemT.Add(linhasABbSplit[2]);
            listaLinhasABbFala.Add(linhasABbSplit[3]);
        }
        for (int i = 0; i < linhasBAa.Length; i++)
        {
            linhasBAaSplit = linhasBAa[i].Split("_"[0]);
            listaLinhasBAaCenario.Add(linhasBAaSplit[0]);
            listaLinhasBAaPersonagem.Add(linhasBAaSplit[1]);
            listaLinhasBAaPersonagemT.Add(linhasBAaSplit[2]);
            listaLinhasBAaFala.Add(linhasBAaSplit[3]);
        }
        for (int i = 0; i < linhasBAb.Length; i++)
        {
            linhasBAbSplit = linhasBAb[i].Split("_"[0]);
            listaLinhasBAbCenario.Add(linhasBAbSplit[0]);
            listaLinhasBAbPersonagem.Add(linhasBAbSplit[1]);
            listaLinhasBAbPersonagemT.Add(linhasBAbSplit[2]);
            listaLinhasBAbFala.Add(linhasBAbSplit[3]);
        }
        for (int i = 0; i < linhasBBa.Length; i++)
        {
            linhasBBaSplit = linhasBBa[i].Split("_"[0]);
            listaLinhasBBaCenario.Add(linhasBBaSplit[0]);
            listaLinhasBBaPersonagem.Add(linhasBBaSplit[1]);
            listaLinhasBBaPersonagemT.Add(linhasBBaSplit[2]);
            listaLinhasBBaFala.Add(linhasBBaSplit[3]);
        }
        for (int i = 0; i < linhasBBb.Length; i++)
        {
            linhasBBbSplit = linhasBBb[i].Split("_"[0]);
            listaLinhasBBbCenario.Add(linhasBBbSplit[0]);
            listaLinhasBBbPersonagem.Add(linhasBBbSplit[1]);
            listaLinhasBBbPersonagemT.Add(linhasBBbSplit[2]);
            listaLinhasBBbFala.Add(linhasBBbSplit[3]);
        }
    }

    private void Start()
    {
        instancia = this;

        if (PlayerPrefs.HasKey("Escolha_01") == false)
        {
            opcoes[0] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            personagem.text = listaLinhasIniciaisPersonagem[0];
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "BBb")
        {
            opcoes[15] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "BBa")
        {
            opcoes[14] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "BAb")
        {
            opcoes[13] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "BAa")
        {
            opcoes[12] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "ABb")
        {
            opcoes[11] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "ABa")
        {
            opcoes[10] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "AAc")
        {
            opcoes[9] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "AAb")
        {
            opcoes[8] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "AAa")
        {
            opcoes[7] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "Bb")
        {
            opcoes[6] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "Ba")
        {
            opcoes[5] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "Ab")
        {
            opcoes[4] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "Aa")
        {
            opcoes[3] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "B")
        {
            opcoes[2] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else if (PlayerPrefs.GetString("Escolha_01") == "A")
        {
            opcoes[1] = true;
            BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
            Ler();
        }
        else
        {
            conteudo.text = "Erro";
        }
    }

    private void Update()
    {
        if (BotoesEmJogo.instancia.automatico)
        {
            if (podeLer)
            {
                tempo += Time.deltaTime;
                if (tempo >= 20f)
                {
                    num++;
                    Ler();
                    tempo = 0f;
                }
            }
        }
    }

    public void PersonagensTransparentes()
    {
        if(personagemSecundario == "Nada")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if(personagemSecundario == "AylaPadrao")
        {
            AylaTransparencia[0].SetActive(true);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "AylaTriste")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(true);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "AylaIrritada")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(true);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "AlicePadrao")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(true);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "AliceTriste")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(true);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "AliceIrritada")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(true);
        }
        else if (personagemSecundario == "FernandoNormal")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "FernandoTriste")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
        else if (personagemSecundario == "FernandoIrritado")
        {
            AylaTransparencia[0].SetActive(false);
            AylaTransparencia[1].SetActive(false);
            AylaTransparencia[2].SetActive(false);
            AliceTransparencia[0].SetActive(false);
            AliceTransparencia[1].SetActive(false);
            AliceTransparencia[2].SetActive(false);
        }
    }

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

        //Fernando
        else if (personagem.text == "FernandoNormal")
        {
            personagem.text = "Fernando";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "FernandoIrritado")
        {
            personagem.text = "Fernando";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[0].SetActive(false);
            Ayla[0].SetActive(false);
            Ayla[1].SetActive(false);
            Ayla[2].SetActive(false);
        }
        else if (personagem.text == "FernandoTriste")
        {
            personagem.text = "Fernando";
            Alice[0].SetActive(false);
            Alice[1].SetActive(false);
            Alice[2].SetActive(false);
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
                personagemSecundario = listaLinhasIniciaisPersonagemT[i];
                cenarios = listaLinhasIniciaisCenario[i];
                personagem.text = listaLinhasIniciaisPersonagem[i];
                conteudo.text = listaLinhasIniciaisFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasIniciais.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
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
                personagemSecundario = listaLinhasAPersonagemT[i];
                cenarios = listaLinhasACenario[i];
                personagem.text = listaLinhasAPersonagem[i];
                conteudo.text = listaLinhasAFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasA.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
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
                personagemSecundario = listaLinhasBPersonagemT[i];
                cenarios = listaLinhasBCenario[i];
                personagem.text = listaLinhasBPersonagem[i];
                conteudo.text = listaLinhasBFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasB.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[2] = false;
                    num = 0;
                }
                break;
            }
        }

        //Escolha Aa/Ab/Ba/Bb
        else if (opcoes[3])
        {
            for (int i = num; i < linhasAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasAaPersonagemT[i];
                cenarios = listaLinhasAaCenario[i];
                personagem.text = listaLinhasAaPersonagem[i];
                conteudo.text = listaLinhasAaFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAa.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[3] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[4])
        {
            for (int i = num; i < linhasAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasAbPersonagemT[i];
                cenarios = listaLinhasAbCenario[i];
                personagem.text = listaLinhasAbPersonagem[i];
                conteudo.text = listaLinhasAbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAb.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[9].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[10].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[4] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[5])
        {
            for (int i = num; i < linhasBa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasBaPersonagemT[i];
                cenarios = listaLinhasBaCenario[i];
                personagem.text = listaLinhasBaPersonagem[i];
                conteudo.text = listaLinhasBaFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBa.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[11].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[12].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[5] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[6])
        {
            for (int i = num; i < linhasBb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasBbPersonagemT[i];
                cenarios = listaLinhasBbCenario[i];
                personagem.text = listaLinhasBbPersonagem[i];
                conteudo.text = listaLinhasBbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBb.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.escolhas[13].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.escolhas[14].gameObject.SetActive(true);
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[6] = false;
                }
                break;
            }
        }

        //Escolha AAa/AAb/BAa/BAb/BBa/BBb
        else if (opcoes[7])
        {
            for (int i = num; i < linhasAAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasAAaPersonagemT[i];
                cenarios = listaLinhasAAaCenario[i];
                personagem.text = listaLinhasAAaPersonagem[i];
                conteudo.text = listaLinhasAAaFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAAa.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[7] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[8])
        {
            for (int i = num; i < linhasAAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasAAbPersonagemT[i];
                cenarios = listaLinhasAAbCenario[i];
                personagem.text = listaLinhasAAbPersonagem[i];
                conteudo.text = listaLinhasAAbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAAb.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[8] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[9])
        {
            for (int i = num; i < linhasAAc.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasAAcPersonagemT[i];
                cenarios = listaLinhasAAcCenario[i];
                personagem.text = listaLinhasAAcPersonagem[i];
                conteudo.text = listaLinhasAAbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasAAc.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[9] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[10])
        {
            for (int i = num; i < linhasABa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasABaPersonagemT[i];
                cenarios = listaLinhasABaCenario[i];
                personagem.text = listaLinhasABaPersonagem[i];
                conteudo.text = listaLinhasABaFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasABa.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[10] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[11])
        {
            for (int i = num; i < linhasABb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasABbPersonagemT[i];
                cenarios = listaLinhasABbCenario[i];
                personagem.text = listaLinhasABbPersonagem[i];
                conteudo.text = listaLinhasABbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasABb.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[11] = false;
                    num = 0;
                }
                break;
            }
        }

        else if (opcoes[12])
        {
            for (int i = num; i < linhasBAa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasBAaPersonagemT[i];
                cenarios = listaLinhasBAaCenario[i];
                personagem.text = listaLinhasBAaPersonagem[i];
                conteudo.text = listaLinhasBAaFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBAa.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[12] = false;
                }
                break;
            }
        }

        else if (opcoes[13])
        {
            for (int i = num; i < linhasBAb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasBAbPersonagemT[i];
                cenarios = listaLinhasBAbCenario[i];
                personagem.text = listaLinhasBAbPersonagem[i];
                conteudo.text = listaLinhasBAbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBAb.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[13] = false;
                }
                break;
            }
        }

        else if (opcoes[14])
        {
            for (int i = num; i < linhasBBa.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasBBaPersonagemT[i];
                cenarios = listaLinhasBBaCenario[i];
                personagem.text = listaLinhasBBaPersonagem[i];
                conteudo.text = listaLinhasBBaFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBBa.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[14] = false;
                }
                break;
            }
        }

        else if (opcoes[15])
        {
            for (int i = num; i < linhasBBb.Length;)
            {
                if (i >= 1)
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(true);
                else
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                personagemSecundario = listaLinhasBBbPersonagemT[i];
                cenarios = listaLinhasBBbCenario[i];
                personagem.text = listaLinhasBBbPersonagem[i];
                conteudo.text = listaLinhasBBbFala[i];

                PersonagensTransparentes();
                PosicoesPersonagens();
                MudarCenarios();
                if (i >= linhasBBb.Length - 1)
                {
                    fundo.Pause();
                    fundoEscolha.Play();
                    BotoesEmJogo.instancia.proximo.gameObject.SetActive(false);
                    BotoesEmJogo.instancia.anterior.gameObject.SetActive(false);
                    podeLer = false;
                    opcoes[15] = false;
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
        fundo.Play();
        fundoEscolha.Pause();
        switch (escolha)
        {
            case "A":
                PlayerPrefs.SetString("Escolha_01", "A");
                podeLer = true;
                opcoes[1] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;
            case "B":
                PlayerPrefs.SetString("Escolha_01", "B");
                podeLer = true;
                opcoes[2] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[1].gameObject.SetActive(false);
                Ler();
                break;

            case "Aa":
                PlayerPrefs.SetString("Escolha_01", "Aa");
                podeLer = true;
                opcoes[3] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ab":
                PlayerPrefs.SetString("Escolha", "Ab");
                podeLer = true;
                opcoes[4] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ba":
                PlayerPrefs.SetString("Escolha_01", "Ba");
                podeLer = true;
                opcoes[5] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
            case "Bb":
                PlayerPrefs.SetString("Escolha_01", "Bb");
                podeLer = true;
                opcoes[6] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[5].gameObject.SetActive(false);
                Ler();
                break;
            case "AAa":
                PlayerPrefs.SetString("Escolha_01", "AAa");
                podeLer = true;
                opcoes[7] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(false);
                Ler();
                break;
            case "AAb":
                PlayerPrefs.SetString("Escolha_01", "AAb");
                podeLer = true;
                opcoes[8] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(false);
                Ler();
                break;
            case "AAc":
                PlayerPrefs.SetString("Escolha_01", "AAc");
                podeLer = true;
                opcoes[9] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[7].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[8].gameObject.SetActive(false);
                Ler();
                break;
            case "ABa":
                PlayerPrefs.SetString("Escolha_01", "ABa");
                podeLer = true;
                opcoes[10] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[9].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[10].gameObject.SetActive(false);
                Ler();
                break;
            case "ABb":
                PlayerPrefs.SetString("Escolha_01", "ABb");
                podeLer = true;
                opcoes[11] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[9].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[10].gameObject.SetActive(false);
                Ler();
                break;
            case "BAa":
                PlayerPrefs.SetString("Escolha_01", "BAa");
                podeLer = true;
                opcoes[12] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[11].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[12].gameObject.SetActive(false);
                Ler();
                break;
            case "BAb":
                PlayerPrefs.SetString("Escolha_01", "BAb");
                podeLer = true;
                opcoes[13] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[11].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[12].gameObject.SetActive(false);
                Ler();
                break;
            case "BBa":
                PlayerPrefs.SetString("Escolha_01", "BBa");
                podeLer = true;
                opcoes[14] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[13].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[14].gameObject.SetActive(false);
                Ler();
                break;
            case "BBb":
                PlayerPrefs.SetString("Escolha_01", "BBb");
                podeLer = true;
                opcoes[15] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhas[13].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhas[14].gameObject.SetActive(false);
                Ler();
                break;
        }
    }
    
    public void EscolhasEsp(string escolha)
    {
        fundo.Play();
        fundoEscolha.Pause();
        switch (escolha)
        {
            case "A":
                PlayerPrefs.SetString("Escolha_01", "A");
                podeLer = true;
                opcoes[1] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[1].gameObject.SetActive(false);
                Ler();
                break;
            case "B":
                PlayerPrefs.SetString("Escolha_01", "B");
                podeLer = true;
                opcoes[2] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[0].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[1].gameObject.SetActive(false);
                Ler();
                break;

            case "Aa":
                PlayerPrefs.SetString("Escolha_01", "Aa");
                podeLer = true;
                opcoes[3] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ab":
                PlayerPrefs.SetString("Escolha_01", "Ab");
                podeLer = true;
                opcoes[4] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[2].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[3].gameObject.SetActive(false);
                Ler();
                break;
            case "Ba":
                PlayerPrefs.SetString("Escolha_01", "Ba");
                podeLer = true;
                opcoes[5] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[5].gameObject.SetActive(false);
                Ler();
                break;
            case "Bb":
                PlayerPrefs.SetString("Escolha_01", "Bb");
                podeLer = true;
                opcoes[6] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[4].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[5].gameObject.SetActive(false);
                Ler();
                break;
            case "AAa":
                PlayerPrefs.SetString("Escolha_01", "AAa");
                podeLer = true;
                opcoes[7] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[7].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[8].gameObject.SetActive(false);
                Ler();
                break;
            case "AAb":
                PlayerPrefs.SetString("Escolha_01", "AAb");
                podeLer = true;
                opcoes[8] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[7].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[8].gameObject.SetActive(false);
                Ler();
                break;
            case "AAc":
                PlayerPrefs.SetString("Escolha_01", "AAc");
                podeLer = true;
                opcoes[9] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[6].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[7].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[8].gameObject.SetActive(false);
                Ler();
                break;
            case "ABa":
                PlayerPrefs.SetString("Escolha_01", "ABa");
                podeLer = true;
                opcoes[10] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[9].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[10].gameObject.SetActive(false);
                Ler();
                break;
            case "ABb":
                PlayerPrefs.SetString("Escolha_01", "ABb");
                podeLer = true;
                opcoes[11] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[9].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[10].gameObject.SetActive(false);
                Ler();
                break;
            case "BAa":
                PlayerPrefs.SetString("Escolha_01", "BAa");
                podeLer = true;
                opcoes[12] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[11].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[12].gameObject.SetActive(false);
                Ler();
                break;
            case "BAb":
                PlayerPrefs.SetString("Escolha_01", "BAb");
                podeLer = true;
                opcoes[13] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[11].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[12].gameObject.SetActive(false);
                Ler();
                break;
            case "BBa":
                PlayerPrefs.SetString("Escolha_01", "BBa");
                podeLer = true;
                opcoes[14] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[13].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[14].gameObject.SetActive(false);
                Ler();
                break;
            case "BBb":
                PlayerPrefs.SetString("Escolha_01", "BBb");
                podeLer = true;
                opcoes[15] = true;
                BotoesEmJogo.instancia.proximo.gameObject.SetActive(true);
                BotoesEmJogo.instancia.escolhasEsp[13].gameObject.SetActive(false);
                BotoesEmJogo.instancia.escolhasEsp[14].gameObject.SetActive(false);
                Ler();
                break;
        }
    }
}
