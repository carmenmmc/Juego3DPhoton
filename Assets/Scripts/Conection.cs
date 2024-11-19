using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class Conection : MonoBehaviourPunCallbacks
{
    public UnityEngine.UI.Button button;
    private bool loading = false;

    public PhotonView playerPrefab;

    public Transform spawnPoint;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    private void Update()
    {
        if(!loading && PhotonNetwork.IsMasterClient && PhotonNetwork.InRoom && PhotonNetwork.CurrentRoom.PlayerCount > 1)
        {
            loading = true;
            PhotonNetwork.LoadLevel(1);
        }
    }

    override
        public void OnConnectedToMaster()
    {
        button.interactable = true;
    }

    public void PushButton()
    {
        PhotonNetwork.JoinOrCreateRoom("sala1", new RoomOptions(), TypedLobby.Default);

        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);

        player.GetComponent<PhotonView>().RPC("SetNameText", RpcTarget.AllBuffered, PlayerPrefs.GetString("PlayerName"));
    }
}
