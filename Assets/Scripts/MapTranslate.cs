using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTranslate : MonoBehaviour {

    public float speed = 5f;
    public int cpt = 0;

	// Use this for initialization
	void Start () {
	}

    void Update()
    {
        transform.Translate(speed,0,0);
        cpt = cpt + 1;
        if (cpt % 200 ==1 )
        {
            Debug.Log(cpt);
        }
    }
}
 