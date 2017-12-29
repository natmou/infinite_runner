using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject GroundEnemy;
    public GameObject AirEnemy;
    public int cpt = 0;
    public GameObject map;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cpt = cpt + 1;
        if (cpt % 200 == 1)
        {
            GameObject ground_enemy = (GameObject) Instantiate(GroundEnemy);
            ground_enemy.transform.parent = map.transform;
            Debug.Log(cpt);
        }
        if(cpt % 300 == 1)
        {
            GameObject air_enemy = (GameObject) Instantiate(AirEnemy);
            air_enemy.transform.parent = map.transform;
            Debug.Log(cpt);
            air_enemy = (GameObject)Instantiate(AirEnemy, new Vector3(14, 2, 0), Quaternion.identity);
            air_enemy.transform.parent = map.transform;
            Debug.Log(cpt);
        }
    }
}
