using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GeneralPointCounter : MonoBehaviour
{
    private int points = 25;
    [SerializeField] private TextMeshProUGUI textMesh;



    private void Start()
    {
        textMesh.text = points.ToString();
    }

    public void PointCollected()
    {
        points--;
        textMesh.text = points.ToString();
    }

}