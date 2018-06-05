using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundTiles : MonoBehaviour {

    public GameObject[] tile;

    public Vector2 tileStartPos;
    Vector2 tileSpacing;
    public int gridWidth;
    public int gridHeight;

	// Use this for initialization
	void Start () {

        tileSpacing = tile[0].GetComponent<Renderer>().bounds.size;

        for(int i=0; i<gridHeight;i++)
        {
            for (int j = 0; j<gridWidth; j++)
            {
                GameObject go = Instantiate(tile[0], new Vector3(tileStartPos.x + (j * tileSpacing.x), tileStartPos.y + (i * tileSpacing.y)), Quaternion.identity) as GameObject;

                go.transform.parent = GameObject.Find("Tiles").transform;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {

        

    }
}
