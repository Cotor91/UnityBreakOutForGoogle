using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

    private GameObject spherePiece;

    // Use this for initialization
    void Start() {
        gameObject.tag = "Block Piece";
            }


    // Update is called once per frame
    void Update () {
        spherePiece = GameObject.Find("SpherePiece");
        Vector2 position = spherePiece.transform.position;
        double rightEdge = spherePiece.transform.position.x + 16.67;
        double leftEdge = spherePiece.transform.position.x - 16.67;
        double topSide = spherePiece.transform.position.y - 5;
        double bottomSide = spherePiece.transform.position.y + 5;



        if (this.transform.position.x > leftEdge && this.transform.position.x < rightEdge && this.transform.position.y < bottomSide && this.transform.position.y > topSide)
        {
            Debug.Log("Whoops");
            Destroy(gameObject);

        }

    }
}
