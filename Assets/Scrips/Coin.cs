using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    [SerializeField] private GeneralPointCounter remainingScore;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag =="Coin"){
            remainingScore.PointCollected();
        }
    }
}
