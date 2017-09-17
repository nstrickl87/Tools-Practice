using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DrawGizmoExample {

	[DrawGizmo (GizmoType.NotInSelectionHierarchy
               | GizmoType.InSelectionHierarchy |
               GizmoType.Selected |
               GizmoType.Active |
               GizmoType.Pickable)]

    private static void MyCustomOnDrawGizmos( TargetExample targetExample, GizmoType gizmoType)
    {
        Gizmos.color = Color.white;
        Gizmos.DrawCube(targetExample.transform.position, Vector3.one);
    }

    [DrawGizmo (GizmoType.InSelectionHierarchy| GizmoType.Active)]
    private static void MyCustomOnDrawGizmosSelected(TargetExample target, GizmoType gizmoType)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(target.transform.position, Vector3.one);
    }

}
