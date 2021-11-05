using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeStatButton : MonoBehaviour
{
    public TMP_Text Stat;
    public TMP_InputField NewValue;

  //  public MoveManager moveManager;

  //  public string ButtonType;

  //  //Orange team
  //  public string OrangeChangedAttack;
  //  public string OrangeChangedDefence;
  //  public string OrangeChangedHp;
  //  public string OrangeChangedTeam_money;
  // 
  //  //White team
  //  public string WhiteChangedAttack;
  //  public string WhiteChangedDefence;
  //  public string WhiteChangedHp;
  //  public string WhiteChangedTeam_money;
  //                
  //  //Green team       
  //  public string GreenChangedAttack;
  //  public string GreenChangedDefence;
  //  public string GreenChangedHp;
  //  public string GreenChangedTeam_money;
  //                
  //  //Blue team        
  //  public string BlueChangedAttack;
  //  public string BlueChangedDefence;
  //  public string BlueChangedHp;
  //  public string BlueChangedTeam_money;

    public void ChangeStats()
    {
        Stat.text = NewValue.text;
    }
}
