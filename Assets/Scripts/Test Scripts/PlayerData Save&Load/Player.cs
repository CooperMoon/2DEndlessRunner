using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class acts as a player controller
public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 55;
    // move()

    public void Save()
    {
        SaveSystem.SavePlayer(this);
    }

    public void Load()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        level = data.health;
        Vector3 pos = new Vector3(data.position[0],
                                  data.position[1],
                                  data.position[2]);
    }
}
