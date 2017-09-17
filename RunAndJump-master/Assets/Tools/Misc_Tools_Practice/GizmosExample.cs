using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosExample : MonoBehaviour {

    //Method signature public static void DrawCube(Vector3 center, Vector3 size);
    public Vector3 cubeCenter = Vector3.zero;
    public Vector3 cubeSize = Vector3.one;

	//Method signature public static void DrawWireCube(Vector3 center, Vector3 size);
	public Vector3 wireCubeCenter = Vector3.zero;
	public Vector3 wireCubeSize = Vector3.one;

    //Method signature public static void DrawSphere(Vector3 center, float radius);
    public Vector3 sphereCenter = Vector3.zero;
    public float radius = 1f;

	//Method signature public static void DrawWireSphere(Vector 3 center, float radius)
	public Vector3 sphereWireCenter = Vector3.zero;
	public float wireRadius = 1f;

    //Method signature public static void DrawRay(Ray r);
    //public static void DrawRay(Vector3  from, Vector3 direction);
    public Vector3 from = Vector3.zero;
    public Vector3 direction = Vector3.up;


    //Method signature publice statis void DrawLine(Vector3 from, Vector3 to);
    public Vector3 lineFrom = new Vector3(1, 0, 0);
    public Vector3 lineTo = new Vector3(0, 0, 1);

    //Method signature publice static void DrawIon(Vector3 center, string name, bool allowScaling = true);

    //Draw GUITexture
    //Draws texture inside the ScreenRect method on teh Scene View using the XY plane (where the Z coordinate is zero)
    // The Values of the texture rectangle are given in scene units.
    //The optional border values specify an inset from each edge within the rectangle in scene units; the texture is drawn inside the inset rectangle and the edge pixels are repeated outward.

    //Method Signature public void DrawGUITexture(Rect screenRect, Texture texture, Material, mat = null);
    //public static vid DrawGUITexture (Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat =null);
    //public Rect screenRect = new Rect(0, 0, 100, 100);
    //public Texture theTexture;

    // Draw Frustrum
    //Method Signature Public static void DrawFrsutrum(Vector3 center, float foc, float maxRange, float minRange, float aspect);
    public Vector3 center = Vector3.zero;
    public float fov = 60;
    public float maxRange = 1;
    public float minRange = 3;
    public float aspect = 1.3f;

    private void OnDrawGizmos()
    {
        Gizmos.DrawFrustum(center, fov,maxRange,minRange,aspect);
    }

}
