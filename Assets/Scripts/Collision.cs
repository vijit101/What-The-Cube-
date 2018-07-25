using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    Collider obstaclecollider;    
    int i = 1;
    [SerializeField]GameObject gmo;
    [SerializeField] GameObject gmo1;
    
    
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
                Destroy(gmo.GetComponent<DetectOntrigger>());
                gmo1.AddComponent<Detectoncollision>();
                   
            }
            else
            {
                obstaclecollider.isTrigger = true;
                i++;
                gmo.AddComponent<DetectOntrigger>();
                Destroy(gmo1.GetComponent<Detectoncollision>());
            }
        }
	}
    
}
