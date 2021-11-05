using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaverBase : MonoBehaviour
{
    public Color color;


    [Multiline(5)]
    public string data;

    void Start() {  
    }
    public void CollectInfo()
    {
        Image but = GetComponent<Image>();
        if (but)
        {
            color = but.color;
        }
    }

    public void SetInfo()
    {
        Image but = GetComponent<Image>();
        if (but)
        {
            but.color = color;
        }
    }
    public void Save()
    {
        CollectInfo();
        data = JsonUtility.ToJson(this,true);
        File.WriteAllText("SaveData/" + gameObject.name + ".TXT", data);
    }

    public void Load()
    {
        data = File.ReadAllText("SaveData/" + gameObject.name + ".TXT");
        JsonUtility.FromJsonOverwrite(data, this);
        SetInfo();
    }
}
