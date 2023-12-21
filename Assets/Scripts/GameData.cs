using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public int highestScore;
    public string bestPlayer;
}

public class GameData : MonoBehaviour
{
    public PlayerData playerData;
    string savePath;

    private void Awake()
    {
        savePath = Application.dataPath + "/savedData.json";
    }

    public void SaveGame()
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText(savePath, json);
        //Debug.Log("Saved" + json);
    }

    public void LoadGame()
    {
        if(File.Exists(savePath))
        {
            //Debug.Log("Loaded");
            string json = File.ReadAllText(savePath);
            playerData = JsonUtility.FromJson<PlayerData>(json);
        }
        else
        {
            //Debug.Log("Added");
            playerData.bestPlayer = "Player";
            playerData.highestScore = 0;
        }
    }
}
