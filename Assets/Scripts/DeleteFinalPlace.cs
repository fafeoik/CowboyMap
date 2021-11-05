using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFinalPlace : MonoBehaviour
{
    public MoveManager MoveScript;

    public void DestroyFinalPlace(bool isWinButton)
    {
        if (isWinButton)
        {
            Destroy(this.gameObject);
        }

        MoveScript.SwitchCollider(true);
    }
}
