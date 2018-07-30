using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionbetter : MonoBehaviour {
    int i = 1;
    Collider obstaclecollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != tag && tag != "safezone")
        {
            Utils.reloadcurrentscene();
        }
        
    }
    private void OnCollisionEnter(UnityEngine.Collision coll)
    {
        if ((coll.gameObject.tag != tag) && (gameObject.tag != "safezone"))
        {
            Utils.reloadcurrentscene();
        }
        
    }
    private void Awake()
    {
        obstaclecollider = GetComponent<Collider>();
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
                obstaclecollider.isTrigger = false;
                i++;
                

            }
            else
            {
                obstaclecollider.isTrigger = true;
                i++;
            }
        }
    }
}
