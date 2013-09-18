using UnityEngine;
using System.Collections;

public class CrosshairRay : MonoBehaviour {
    
	bool iLookAtSomething = false;
    void OnGUI()
    {
        if (iLookAtSomething) { 
				GUI.Label(new Rect(5, 5, 200, 30), "i look at something"); 
		}
    }
    void Update()
    {
		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Debug.DrawLine (ray.origin, Camera.main.transform.forward * 50000000, Color.red);
    }
}
