using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour {
    Rigidbody rgbd;
    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        moveleft();
        moveright();
        jump();
    }
    public void moveleft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgbd.AddForce(new Vector3(-15, 0, 0));
        }
    }
    public void moveright()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rgbd.AddForce(new Vector3(15, 0, 0));
        }
    }
    public void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rgbd.AddForce(new Vector3(0,10,0),ForceMode.Impulse);
        }
    }
}
