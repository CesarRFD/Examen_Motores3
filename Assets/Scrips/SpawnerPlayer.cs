using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerPref;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;

    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 1f, Random.Range(minZ,maxZ));
        PhotonNetwork.Instantiate(playerPref.name,randomPosition,Quaternion.identity);
    }
}
