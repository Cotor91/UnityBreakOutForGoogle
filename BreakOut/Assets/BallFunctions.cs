using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFunctions : MonoBehaviour
{

    public GameObject plankPiece;
    public GameObject blockPiece;
    public GameObject scoreCount;
    public bool bouncing;
    public Vector2 position;
    public double height;
    public double sides;
    public double rightEdge;
    public double leftEdge;
    public double topSide;
    public double bottomSide;
    public float checkIt;
    public float invertBounce;



    private GameObject spherePiece;

    // Use this for initialization
    void Start () {
        gameObject.transform.localScale = new Vector3(2, 2);
        plankPiece = GameObject.Find("PlankPiece");
        blockPiece = GameObject.Find("BlockPiece");
        scoreCount = GameObject.Find("Score");
        invertBounce = 64;
        

}

    // Update is called once per frame
    void Update()
    {
        position = this.transform.position;
        height = position.y;
        sides = position.x;
        rightEdge = plankPiece.transform.position.x + 24;
        leftEdge = plankPiece.transform.position.x - 24;
        topSide = plankPiece.transform.position.y + 4;
        bottomSide = plankPiece.transform.position.y;



        if (this.transform.position.x > leftEdge && this.transform.position.x < rightEdge && this.transform.position.y < topSide && this.transform.position.y > bottomSide)
        {
            bouncing = true;
            checkIt = this.transform.position.x - plankPiece.transform.position.x;
            Debug.Log(checkIt + "..." + checkIt * 3);
            Debug.Log("Woohoo");
        }

        if (invertBounce > GameObject.FindGameObjectsWithTag("Block Piece").Length)
        {
            if (bouncing == true)
            {
                bouncing = false;
            }
            else
            {
                bouncing = true;
            }
            invertBounce = GameObject.FindGameObjectsWithTag("Block Piece").Length;

                checkIt = Random.Range(-24, 24);
        }


        if (bouncing == true)
        {
            directBall(new Vector2(checkIt, 20));

            if (height > 67)
            {
                bouncing = false;
            };
        };

        if (sides < -120 && checkIt < 0)
        {
            checkIt = checkIt * -1;
        };

        if (sides > 120 && checkIt > 0)
        {
            checkIt = checkIt * -1;
        };


        if (bouncing == false)
        {

            directBall(new Vector2(checkIt, -20));


            if (height < -70)
            {
                transform.position = new Vector2(plankPiece.transform.position.x, -33);
            };

            
        }



    }

    void directBall(Vector2 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }

}

