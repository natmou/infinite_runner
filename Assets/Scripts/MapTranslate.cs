using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTranslate : MonoBehaviour {

    public float speed = 5f;
    public int cpt = 1;
    public GameObject mapTile;
    public GameObject map;
    public ArrayList TileList;

	// Use this for initialization
	void Start () {
        TileList = new ArrayList();
        GameObject tile = Instantiate(mapTile, new Vector3(8, 0, 0), Quaternion.identity);
        tile.transform.parent = map.transform;
        TileList.Add(tile);
        GameObject tile2 = Instantiate(mapTile, new Vector3(24, 0, 0), Quaternion.identity);
        tile2.transform.parent = map.transform;
        TileList.Add(tile2);
        GameObject tile3 = Instantiate(mapTile, new Vector3(38, 0, 0), Quaternion.identity);
        tile3.transform.parent = map.transform;
        TileList.Add(tile3);
    }

    void Update()
    {
        transform.Translate(speed,0,0);
        cpt += 1;
        if (cpt % 150 == 1)
        {
            GameObject tile = Instantiate(mapTile, new Vector3(38, 0, 0), Quaternion.identity);
            tile.transform.parent = map.transform;
            TileList.Add(tile);
            Destroy((GameObject)TileList[0]);
            TileList.RemoveAt(0);
            Debug.Log("TILE CREATION" + cpt);
        }
    }
}
 