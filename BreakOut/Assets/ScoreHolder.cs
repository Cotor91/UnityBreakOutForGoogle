using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreHolder : MonoBehaviour
{

    public float scoredPoints = 0;
    Text pointsScored;
    public float lives;
    public GameObject spherePiece;


    // Use this for initialization
    void Start()
    {
        pointsScored = GetComponent<Text>();
        spherePiece = GameObject.Find("SpherePiece");
        lives = 5;
    }







    // Update is called once per frame
    void Update()
    {

        if (spherePiece.transform.position.y < -70)
        {
            lives = lives - 1;
        }

        pointsScored.text = "Score: " + scoredPoints + "       " + lives + " Lives";
        scoredPoints = 64 - GameObject.FindGameObjectsWithTag("Block Piece").Length;

        if (scoredPoints == 64)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        if (lives == -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        };
    }
}

