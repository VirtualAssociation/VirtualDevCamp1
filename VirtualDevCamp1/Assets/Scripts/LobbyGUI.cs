using UnityEngine;
using System.Collections;

public class LobbyGUI : MonoBehaviour {

    private float margin = 0.01f * Screen.width;

    public float width, height;

    void Start()
    {
        this.gameObject.SetActive(false);
    }

    void OnGUI()
    {

        GUI.Box(new Rect(Screen.width / 2 - width / 2, Screen.height / 2 - height / 2, width, height), "Lobby");

        if (GUI.Button(new Rect(Screen.width / 2 - width / 2 + 10, 30 + Screen.height / 2 - height / 2, width - 20, 20), "Créer Lobby"))
        {
            //todo
        }

        if (GUI.Button(new Rect(Screen.width / 2 - width / 2 + 10, 30 + Screen.height / 2 - height / 2 + 50, width - 20, 20), "Joindre Lobby"))
        {
            //todo
        }

        if (GUI.Button(new Rect(Screen.width / 2 - width / 2 + 10, 30 + Screen.height / 2 - height / 2 + 100, width - 20, 20), "Retour"))
        {
            GameObject.Find("MainMenuGUI").SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
