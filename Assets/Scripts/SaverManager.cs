using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SaverManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            SaveAll();
        }

        if (Input.GetKeyDown(KeyCode.F9))
        {
            LoadAll();
        }
    }

    public void SaveAll()
    {
        SaverBase[] bases = FindObjectsOfType<SaverBase>();

        foreach ( var item in bases)
        {
            item.Save();
        }
    }

    public void LoadAll()
    {
        SaverBase[] bases = FindObjectsOfType<SaverBase>();

        foreach (var item in bases)
        {
            item.Load();
        }
    }
}
