using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeneralPointCounter : MonoBehaviour
{
    private int points = 25;
    private bool endGame = false;
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

    public void EndGame()
    {
        endGame = true;
    }

    private void Update()
    {
        if(endGame)
        {
            SceneManager.LoadScene("Defeat");
        }
    }



}