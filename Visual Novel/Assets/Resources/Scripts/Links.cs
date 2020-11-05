using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Links : MonoBehaviour
{
    public void InstagramAndroid()
    {
        Application.OpenURL("https://www.instagram.com/lunaestudiogames/");
    }

    public void ItchAndroid()
    {
        Application.OpenURL("https://luna-estudio.itch.io/");
    }

    public void AllyAndroid()
    {
        Application.OpenURL("https://www.linkedin.com/in/allicya-beatriz-moura-rosa-21712b1b9/");
    }

    public void ThayAndroid()
    {
        Application.OpenURL("https://www.linkedin.com/in/thayane-carvalho-dos-santos-05861a167/");
    }

    public void MioAndroid()
    {
        Application.OpenURL("https://www.linkedin.com/in/yasmin-alexandre-921a45190/");
    }

    public void OpenInstagram()
    {
		openWindow("https://www.instagram.com/lunaestudiogames/");
    }
    public void OpenItch()
    {
        openWindow("https://luna-estudio.itch.io/");
    }
    public void OpenAlly()
    {
        openWindow("https://www.linkedin.com/in/allicya-beatriz-moura-rosa-21712b1b9/");
    }
    public void OpenThay()
    {
        openWindow("https://www.linkedin.com/in/thayane-carvalho-dos-santos-05861a167/");
    }
    public void OpenMio()
    {
        openWindow("https://www.linkedin.com/in/yasmin-alexandre-921a45190/");
    }


    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}
