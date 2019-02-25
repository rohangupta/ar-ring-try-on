// Please send feedback or bug reports to npoursin@hotmail.com

using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {
	
	public Vector3 angle;
		
	// Update is called once per frame
	void Update () {
		transform.Rotate( angle * Time.deltaTime );
	}
}
