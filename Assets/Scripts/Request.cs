using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class Request : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GetRequest("http://213.5.52.141/InfoBase/hs/api/get/team?id=eda88746-e13a-11eb-96b3-18c04d37d9a7"));
    }

    public void Click()
    {
        
    }
    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }
}
