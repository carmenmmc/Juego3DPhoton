using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using ParrelSync;
using UnityEngine.UI;



public class MainMenuLauncher : MonoBehaviourPunCallbacks
{
    public TMP_InputField usernameInput;

    public Text buttonText;

    public void OnClickConnect()
    {
        if (usernameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = usernameInput.text;

            PlayerPrefs.SetString("PlayerName", usernameInput.text);

            buttonText.text = "Conectando...";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Map_v1");
    }
}
