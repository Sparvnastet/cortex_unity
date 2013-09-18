using UnityEngine;
using System.Collections;

/**
 * Crosshair script
 * Apply this on the FirstPersonController
 **/

public class Crosshair : MonoBehaviour {
	
	public Texture2D crosshairTexture;
	public int rayLength = 50000;
	private bool isHit = false;
	
	void OnGUI(){
		
		if (isHit){
			// change GUI color when we hit something for the dramatic effect
			GUI.color = new Color(1, 0, 1, 0.5f);	
		}else{
			GUI.color = new Color(0.5f ,0.5f, 0.5f, 0.5f);
		}
		
		float xMin = (Screen.width / 2) - (crosshairTexture.width / 2);
		float yMin = (Screen.height / 2) - (crosshairTexture.height / 2);
		
		GUI.DrawTexture(
			new Rect(xMin, yMin, crosshairTexture.width, crosshairTexture.height), 
			crosshairTexture);					
	}
	// Use this for initialization
	void Start () {
		Debug.Log("start!");
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));
		isHit = false;
		if(Physics.Raycast(ray, out hit, rayLength)){
			if(hit.collider.tag == "moveable"){
				isHit = true;
			}
		}
	}
}
