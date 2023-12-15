using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class PlayerCollectionScript : MonoBehaviour
{
    private int points;
    [SerializeField] private PhotonView view;
    private GeneralPointCounter eSystem;
    private SpawnerPlayer Id;
    private int myID;

    private void Start()
    {
        points = 0;
        eSystem = GameObject.Find("EventSystem").GetComponent<GeneralPointCounter>();
        Id = GameObject.Find("Spawner Player").GetComponent<SpawnerPlayer>();
        myID = Id.ID;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.tag = "Collected";
            points += 1;
        }

        if (points == 10)
        {
            eSystem.ActivateRPC(myID);
        }
    }

    private void Update()
    {
        if (eSystem.endGame)
        {
            if (myID == eSystem.winner)
            {
                SceneManager.LoadScene("Victory");
            }
            else
            {
                SceneManager.LoadScene("Defeat");
            }
        }
        /*
        if (eSystem.endGame)
        {
            if (view.ViewID == eSystem.winner)
            {
                SceneManager.LoadScene("Victory");
            }
            else
            {
                SceneManager.LoadScene("Defeat");
            }
        }*/
    }
}
