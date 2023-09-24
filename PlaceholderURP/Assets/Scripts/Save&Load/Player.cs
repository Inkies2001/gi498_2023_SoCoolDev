using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 40;

    public void SavePlayer()
    {
        SaveSystem.SavePlay(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level; 
    }
    
}
