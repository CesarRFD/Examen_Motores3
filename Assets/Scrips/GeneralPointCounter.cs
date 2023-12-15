using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class GeneralPointCounter : MonoBehaviour
{
    private int points = 25;
    public bool endGame = false;
    public int winner;
    [SerializeField] private TextMeshProUGUI textMesh;
    private PhotonView PV;

    private void Start()
    {
        textMesh.text = points.ToString();
        PV = GetComponent<PhotonView>();
    }

    public void PointCollected()
    {
        points--;
        textMesh.text = points.ToString();
    }
    [PunRPC]
    public void Win(int IDWinner)
    {
        winner = IDWinner;
        endGame = true;
    }
    public void ActivateRPC(int IDWinner)
    {
        PV.RPC("Win", RpcTarget.All,IDWinner);
        //PV.RPC("Win", RpcTarget.All, endGame);
    }
}