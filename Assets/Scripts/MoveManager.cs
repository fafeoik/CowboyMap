using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveManager : MonoBehaviour
{
    public Color wantedColor;
    public Image receivedImage;

    BoxCollider2D[] colliders;
    public WinButton WinButtonScript;

    public GameObject Background;
    public GameObject ChangePanel;
    private SpriteRenderer backgroundRenderer;
    private bool isNeutral = true;

    public GameObject InfoPanel;

    public JSONReader json;
    void Start()
    {
        colliders = FindObjectsOfType<BoxCollider2D>();
        wantedColor = new Color(0.4f, 0.4f, 0.4f, 1f);
        backgroundRenderer = Background.GetComponent<SpriteRenderer>();
        json = GetComponent<JSONReader>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            TeamColor(1f, 0.5f, 0, 1f, false);
            StartCoroutine(json.RequestUIWebService("http://213.5.52.141/InfoBase1/hs/api/get/team?id=eda88746-e13a-11eb-96b3-18c04d37d9a7"));
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            TeamColor(0, 0.5f, 1f, 1f, false);
            StartCoroutine(json.RequestUIWebService("http://213.5.52.141/InfoBase1/hs/api/get/team?id=71d6aace-d0e5-11eb-96b1-18c04d37d9a7"));
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            TeamColor(0, 1f, 0, 1f, false);
            StartCoroutine(json.RequestUIWebService("http://213.5.52.141/InfoBase1/hs/api/get/team?id=eda88745-e13a-11eb-96b3-18c04d37d9a7"));
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            TeamColor(1f, 1f, 1f, 1f, false);
            StartCoroutine(json.RequestUIWebService("http://213.5.52.141/InfoBase1/hs/api/get/team?id=31278ef0-d434-11eb-96b1-18c04d37d9a7"));

        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            TeamColor(1f, 0, 1f, 1f, false);
            StartCoroutine(json.RequestUIWebService("http://213.5.52.141/InfoBase1/hs/api/get/team?id=c382e528-ee38-11eb-96b7-001a7dda7113"));

        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            TeamColor(0.4f, 0.4f, 0.4f, 1f, true);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            TeamColor(0.7f, 0f, 0f, 1f, true);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangePanel.SetActive(true);
        }
    }

    private void TeamColor(float a, float b, float c, float d, bool x)
    {
        wantedColor = new Color(a, b, c, d);
        backgroundRenderer.color = wantedColor;
        isNeutral = x;
    }

    public void SwitchCollider(bool x)
    {
        foreach (var item in colliders)
        {
            item.enabled = x;
        }
    }

    public void ChangeColor()
    {
        receivedImage.color = wantedColor;
    }
    public void ShowInfoPanel()
    {
        if (!isNeutral)
        {
            InfoPanel.SetActive(true);
            SwitchCollider(false);
        }
        else if (isNeutral)
        {
            ChangeColor();
        }
    }
}
