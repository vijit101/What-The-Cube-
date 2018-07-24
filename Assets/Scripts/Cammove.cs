using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class Cammove : MonoBehaviour {
    [SerializeField] GameObject myplay;
    Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - myplay.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = myplay.transform.position + offset;
	}
}
