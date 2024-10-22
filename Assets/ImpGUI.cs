using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{

    public string playerStats = "Player Stats";

    int playerOneAttack = 100;
    int playerOneDefense = 50;
    int playerOneSpeed = 60;
    int playerOneLuck = 10;
    int playerOneIntelligence = 95;
    int playerOneSpecial = 20;

    int playerTwoAttack = 250;
    int playerTwoDefense = 250;
    int playerTwoSpeed = 30;
    int playerTwoLuck = 50;
    int playerTwoIntelligence = 60;
    int playerTwoSpecial = 70;

    int playerThreeAttack = 250;
    int playerThreeDefense = 250;
    int playerThreeSpeed = 30;
    int playerThreeLuck = 50;
    int playerThreeIntelligence = 60;
    int playerThreeSpecial = 70;
    private void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 1370, 620), "Player List");

        if (GUI.Button(new Rect(70, 100, 400, 100), "Player One"))
        {
            playerStats = "Player One\r\nName: Christian Bum" + "\r\nAttack: " + playerOneAttack + "\r\nDefense: " + playerOneDefense + "\r\nSpeed: " + playerOneSpeed + "\r\nLuck: " + playerOneLuck + "\r\nIntelligence: " + playerOneIntelligence + "\r\nSpecial: " + playerOneSpecial;
        }

        if (GUI.Button(new Rect(70, 300, 400, 100), "Player Two"))
        {
            playerStats = "Player Two\r\nName: Sam Sulking" + "\r\nAttack: " + playerTwoAttack + "\r\nDefense: " + playerTwoDefense + "\r\nSpeed: " + playerTwoSpeed + "\r\nLuck: " + playerTwoLuck + "\r\nIntelligence: " + playerTwoIntelligence + "\r\nSpecial: " + playerTwoSpecial;
        }

        if (GUI.Button(new Rect(70, 500, 400, 100), "Player Three"))
        {
            playerStats = "Player Three\r\nName: Greg Dookie" + "\r\nAttack: " + playerThreeAttack + "\r\nDefense: " + playerThreeDefense + "\r\nSpeed: " + playerThreeSpeed + "\r\nLuck: " + playerThreeLuck + "\r\nIntelligence: " + playerThreeIntelligence + "\r\nSpecial: " + playerThreeSpecial;
        }

        GUI.Label(new Rect(1000, 250, 150, 200), playerStats);
    }
}
