using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using SimpleJSON;
using TMPro;
using System.Runtime.InteropServices;

public class JSONReader : MonoBehaviour
{

    public TMP_Text place;
    public TMP_Text description;
    public TMP_Text reward;

    public TMP_Text attack;
    public TMP_Text defence;
    public TMP_Text hp;
    public TMP_Text team_money;

  //  public string changedAttack;
  //  public string changedDefence;
  //  public string changedHp;
  //  public string changedTeam_money;

    string text;
    public string difficultyLvl;

    public void GetJsonData(string lvl)
    {
        StartCoroutine(RequestWebService(lvl));
        difficultyLvl = lvl;
    }

    IEnumerator RequestWebService(string lvl)
     {
        string getDataUrl = "http://213.5.52.141/InfoBase1/hs/api/get/random_place?difficulty=" + lvl;

        using (UnityWebRequest webData = UnityWebRequest.Get(getDataUrl))
         {
             yield return webData.SendWebRequest();
             if (webData.isNetworkError || webData.isHttpError)
             {
                 print("---------------- ERROR ----------------");
                 print(webData.error);
             }
             else
             {
                 if (webData.isDone)
                 {
                     JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));
                    if (jsonData == null)
                     {
                         print("---------------- NO DATA ----------------");
                     }
                     else
                     {
                         print("---------------- JSON DATA ----------------");
                         print("jsonData.Count:" + jsonData.Count);
                         print(getDataUrl);
                        print(jsonData);
                        
                        text = jsonData["place"]["place"];
                        text = text.Replace("\\n", "\n");
                        place.text = text;

                        text = jsonData["place"]["description"];
                        text = text.Replace("\\n", "\n");
                        if(text.Length > 350)
                        {
                            description.fontSize = 30;
                        }
                        else
                        {
                            description.fontSize = 36;
                        }
                        description.text = text;
                        print(text);

                        text = jsonData["place"]["reward"]; ;
                        if (text != null)
                        {
                            text = text.Replace("\\n", "\n");
                        }
                        
                        reward.text = text;
                    }
                 }
             }
         }
     }

    public IEnumerator RequestUIWebService(string url)
    {
        string getUIDataUrl = url;

        using (UnityWebRequest webData = UnityWebRequest.Get(getUIDataUrl))
        {
            yield return webData.SendWebRequest();
            if (webData.isNetworkError || webData.isHttpError)
            {
                print("---------------- UI ERROR ----------------");
                print(webData.error);
            }
            else
            {
                if (webData.isDone)
                {
                    JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));
                    if (jsonData == null)
                    {
                        print("---------------- NO UI DATA ----------------");
                    }
                    else
                    {
                        print("---------------- JSON UI DATA ----------------");
                        print(jsonData);
                        print("jsonData.Count:" + jsonData.Count);
                        print(jsonData["team"][2]);
                        print(jsonData["team"]["attack"]);
                        print(jsonData["team"]["defence"]);
                        print(jsonData["team"]["hp"]);
                        attack.text = jsonData["team"]["attack"];
                        defence.text = jsonData["team"]["defence"];
                        hp.text = jsonData["team"]["hp"];
                        team_money.text = jsonData["team"]["team_money"];
                    }
                }
            }
        }
    }
}
