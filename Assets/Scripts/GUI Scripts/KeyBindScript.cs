using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindScript : MonoBehaviour
{
    #region Variable List
    public static Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public Text jump; //public Text up, down, left right, jump;

    private GameObject currentKey;

    private Color32 changedKey = new Color32(39,171,249,255);//blue
    private Color32 selectedKey = new Color32(239,116,36,255);//orange
    #endregion

    private void Start()
    {
        keys.Add("Jump", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Jump", "Space")));
        //keys.Add("Up", KeyCode.W)
        //keys.Add("Down", KeyCode.S)
        //keys.Add("Left", KeyCode.A)
        //keys.Add("Right", KeyCode.D)

        jump.text = keys["Jump"].ToString();
        //up.text = keys["Up"].ToString();
        //up.text = keys["Down"].ToString();
        //up.text = keys["Left"].ToString();
        //up.text = keys["Right"].ToString();
    }

    private void OnGUI()
    {
        string newKey = "";
        Event e = Event.current;
        if (currentKey != null)
        {
            if (e.isKey)
            {
                newKey = e.keyCode.ToString();
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                newKey = "LeftShift";
            }
            if (Input.GetKey(KeyCode.RightShift))
            {
                newKey = "RightShift";
            }
            if (newKey != "")
            {
                //we change our dictionary (that means our keybind changes too)
                keys[currentKey.name] = (KeyCode)System.Enum.Parse(typeof(KeyCode), newKey);
                //change the text of our new button
                currentKey.GetComponentInChildren<Text>().text = newKey;
                currentKey.GetComponent<Image>().color = changedKey;
                currentKey = null;
                SaveKeys();
            }
        }
    }

    public void ChangeKey(GameObject clickKey)
    {
        currentKey = clickKey;
        if(clickKey != null)
        {
            currentKey.GetComponent<Image>().color = selectedKey;
        }
    }

    public void SaveKeys()
    {
        foreach(var key in keys)
        {
            PlayerPrefs.SetString(key.Key, key.Value.ToString());
        }
        PlayerPrefs.Save();
    }

}
