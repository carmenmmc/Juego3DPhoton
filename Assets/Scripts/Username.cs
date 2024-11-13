using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using System;

public class Username : MonoBehaviour
{
    public TMP_InputField inputField;

    void Start()
    {
        if(PlayerPrefs.GetString("Username") == "" || PlayerPrefs.GetString("Username") == null)
        {

        }
        else
        {
            PhotonNetwork.NickName = PlayerPrefs.GetString("Username");

        }
    }

    public void SaveUsername()
    {
        PhotonNetwork.NickName = inputField.text;

        PlayerPrefs.SetString("Username", inputField.text);
    }
}
