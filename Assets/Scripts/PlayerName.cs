using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using ParrelSync;
using UnityEngine.UI;
using static NewBehaviourScript;

public class NewBehaviourScript : MonoBehaviourPunCallbacks
{
    public TMP_Text playerName;
    
    [PunRPC]
    public void SetNameText(string name)
    {
        playerName.text = name;
    }
}