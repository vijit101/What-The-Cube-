using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectoncollision : MonoBehaviour {
    private void OnCollisionEnter(UnityEngine.Collision coll)
    {
        if ((coll.gameObject.tag != tag) && (coll.gameObject.tag != "safezone"))
        {
            Utils.reloadcurrentscene();
        }
        if (coll.gameObject.tag == "Endpad")
        {
            Utils.loadnextscene();
        }
    }
}
