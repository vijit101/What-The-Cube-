using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOntrigger : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag != tag && tag != "safezone")
        {
            Utils.reloadcurrentscene();
        }
        if (other.tag == "Endpad")
        {
            Utils.loadnextscene();

        }
    }
}
