using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;


public class Testing : MonoBehaviour
{
    private Grid grid;
    private void Start()
    {
        //grid = new Grid(100,80,5f,new Vector3(0,-80));
        grid = new Grid(80,60,2f,new Vector3(-80,-60));
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            grid.SetValue(UtilsClass.GetMouseWorldPosition(),56);
        }
        
        if(Input.GetMouseButtonDown(1)){
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }

}

/*
static void UpdatePresence()
{
    DiscordRichPresence discordPresence;
    memset(&discordPresence, 0, sizeof(discordPresence));
    discordPresence.state = "Under Development";
    discordPresence.details = "Under Development";
    discordPresence.largeImageKey = "test";
    discordPresence.largeImageText = "Under Development";
    discordPresence.partyId = ".";
    Discord_UpdatePresence(&discordPresence);
}
*/