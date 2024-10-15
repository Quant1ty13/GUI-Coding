using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{

    public string playerStats = "Player Stats";
    private void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 1370, 620), "Player List");

        if (GUI.Button(new Rect(70, 100, 400, 100), "Player One"))
        {
            playerStats = "Player One\r\nName: Christian Bum\r\nAttack: 100\r\nDefense: 50\r\nSpeed: 60\r\nLuck: 10\r\nIntelligence: 95\r\nSpecial: 20";
        }

        if (GUI.Button(new Rect(70, 300, 400, 100), "Player Two"))
        {
            playerStats = "Player Two\r\nName: Sam Sulking\r\nAttack: 250\r\nDefense: 250\r\nSpeed: 30\r\nLuck: 50\r\nIntelligence: 60\r\nSpecial: 70";
        }

        if (GUI.Button(new Rect(70, 500, 400, 100), "Player Three"))
        {
            playerStats = "Player Three\r\nName: Greg Dookie\r\nAttack: 175\r\nDefense: 200\r\nSpeed: 90\r\nLuck: 100\r\nIntelligence: 100\r\nSpecial: 50";
        }

        GUI.Label(new Rect(1000, 250, 150, 200), playerStats);
    }
}
