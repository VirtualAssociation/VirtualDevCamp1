using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour
{
    public int width, height;
    void OnGUI()
    {
        
        GUI.Box(new Rect(Screen.width/2-width/2, Screen.height/2-height/2, width, height), "Menu Principal");

        if (GUI.Button(new Rect(Screen.width / 2 - width / 2 + 10, 30 + Screen.height / 2 - height / 2, width-20, 20), "Jouer"))
        {
            GameObject.Find("LobbyGUI").SetActive(true);
            this.gameObject.SetActive(false);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - width / 2 + 10, 30 + Screen.height / 2 - height / 2 + 50, width - 20, 20), "Options"))
        {
            //todo
        }

        if (GUI.Button(new Rect(Screen.width / 2 - width / 2 + 10, 30 + Screen.height / 2 - height / 2 + 100, width - 20, 20), "Quitter"))
        {
            Application.Quit();
        }
    }
}