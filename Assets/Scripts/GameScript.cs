using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameScript : MonoBehaviour
{
    [SerializeField] private int[,] minesweeperButtons = new int[5,5];

    // Start is called before the first frame update
    void Start()
    {
        RandomizeMines();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomizeMines()
    {
        int gridX = 0;
        int gridY = 0;
        string output = "";

        for (int i = 0; i < 5; i++)
        {
            gridX = Random.Range(0, 6);
            gridY = Random.Range(0, 6);
            output += (gridX + ", " + gridY + " | ");
        }
        Debug.Log(output);
    }

    public void OnClickTileButton()
    {
        Debug.Log("Tile clicked.");
    }
}
