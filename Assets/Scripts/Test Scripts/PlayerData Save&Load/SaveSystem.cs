using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        // "c:/windows/something/player.sav"
        // string path = Application.persistentDataPath + "/player.sav";
        string path = Application.dataPath + "/player.sav";

        //Opens the file to be written to
        FileStream stream = new FileStream(path, FileMode.Create);

        //creates the data to be saved
        PlayerData data = new PlayerData(player);

        //writes the data to the file (also converts the data to text)
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.dataPath + "/player.sav";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }

    }
}
