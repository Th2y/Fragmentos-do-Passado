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

    public void OpenInstagram()
    {
		openWindow("https://www.instagram.com/lunaestudiogames/");
    }
    public void OpenItch()
    {
        openWindow("https://luna-estudio.itch.io/");
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}
