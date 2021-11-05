using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinButton : MonoBehaviour
{
    public MoveManager MoveScript;

    public void ChangeColor(bool isWinButton)
    {
        if (isWinButton)
        {
            MoveScript.ChangeColor();
        }

        MoveScript.SwitchCollider(true);
    }
}
