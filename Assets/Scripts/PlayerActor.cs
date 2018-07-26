using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour {

  
    // works when the istrigger is off 
    Rigidbody rgbd;
    Renderer render;
    [SerializeField] Material[] mat;
    private void Awake()
    {
        rgbd = GetComponent<Rigidbody>();
        render = GetComponent<Renderer>();
        render.enabled = true;

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
        colortagchange();
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
    
    public void colortagchange()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            render.material = mat[0];
            tag = "Pink";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            render.material = mat[1];
            tag = "Red";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            render.material = mat[2];
            tag = "Green";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            render.material = mat[3];
            tag = "Blue";
        }
    }
}
