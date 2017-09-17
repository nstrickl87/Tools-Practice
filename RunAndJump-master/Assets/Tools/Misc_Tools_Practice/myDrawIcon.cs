using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myDrawIcon : MonoBehaviour {

    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position,"icon.png",true);
    }
}
