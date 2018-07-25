using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectoncollision : MonoBehaviour {
    private void OnCollisionEnter(Collision col)
    {

        if (col.tag != tag && tag != "safezone")
        {
            Utils.reloadcurrentscene();
        }
        if (col.tag == "Endpad")
        {
            Utils.loadnextscene();
        }
    }
   
}
