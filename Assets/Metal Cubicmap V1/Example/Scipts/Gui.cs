using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour {
	
	public Material[] cubmaps;
	public GameObject[] models;
	
	void OnGUI(){
		
		for (int i=0;i<cubmaps.Length/2;i++){
		
			GUI.color = new Color(1f,0.75f,0.5f);
			if (GUI.Button(new Rect( 10,10+i*30,110,20),cubmaps[i].name)){
				for (int g=0;g<models.Length;g++){
					///models[g].renderer.material = cubmaps[i];		
				}
			}
		}
		
		int j=0;
		for (int i=cubmaps.Length/2;i<cubmaps.Length;i++){
			GUI.color = new Color(1f,0.75f,0.5f);
			if (GUI.Button(new Rect( Screen.width-120,10+j*30,110,20),cubmaps[i].name)){
				for (int g=0;g<models.Length;g++){
					//models[g].renderer.material = cubmaps[i];	
				}
			}
			j++;
		}
	}
}
