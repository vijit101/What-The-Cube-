using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnistriggeronoff : MonoBehaviour {
    Collider mycollide;
    int i = 1;
    private void Awake()
    {
        mycollide = GetComponent<Collider>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if ((i % 2) != 0)
            {
                mycollide.isTrigger = false;
                i++;


            }
            else
            {
                mycollide.isTrigger = true;
                i++;
            }
        }
    }
}
