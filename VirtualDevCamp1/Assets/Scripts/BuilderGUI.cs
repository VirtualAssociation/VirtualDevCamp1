using UnityEngine;
using System.Collections;

public class BuilderGUI : MonoBehaviour {

    private float margin = 0.01f * Screen.width;

    void OnGUI()
    {
        GUI.Label(new Rect(margin + 0.01f * Screen.width, margin + 0.01f * Screen.height, 0.1f * Screen.width, 0.05f * Screen.height), "42 HP");
        GUI.Label(new Rect(margin + 0.01f * Screen.width, margin + 0.04f * Screen.height, 0.1f * Screen.width, 0.05f * Screen.height), "10000 pts");

        GUI.Label(new Rect(Screen.width - 0.2f * Screen.width - margin, margin + 0.01f * Screen.height, 0.2f * Screen.width, 0.05f * Screen.height), "Temps écoulé : 2'45");

    }
}
