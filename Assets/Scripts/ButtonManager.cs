using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Image currentImage;
    public MoveManager MoveScript;
    void Start()
    {
        currentImage = GetComponent<Image>();
    }

    public void OnMouseDown()
    {
        MoveScript.receivedImage = currentImage;
        print(gameObject);
    }
}
