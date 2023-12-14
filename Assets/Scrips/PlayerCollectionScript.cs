using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollectionScript : MonoBehaviour
{
    private int points = 0;
    [SerializeField] private TextMeshProUGUI textMesh;



    private void Start()
    {
        textMesh.text = points.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            points++;
            textMesh.text = points.ToString();
            other.gameObject.tag = "Collected";
        }
    }
}
