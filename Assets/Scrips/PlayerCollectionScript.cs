using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollectionScript : MonoBehaviour
{
    private int points;
    [SerializeField] private GameObject eSystem;

    private void Start()
    {
        points = 0;
        eSystem = GameObject.Find("EventSystem");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            points+= 1;
            other.gameObject.tag = "Collected";
        }

        if (points == 10)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
