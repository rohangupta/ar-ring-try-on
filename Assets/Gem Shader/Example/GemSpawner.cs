using UnityEngine;
using System.Collections;

public class GemSpawner : MonoBehaviour {
	public Transform gem1, gem2, gem3, gem4;
	public float spread = 5;

	void Update () {
		if (Input.GetKey ("1"))
			((Transform)Instantiate (gem1)).position = transform.position + Random.insideUnitSphere * spread;
		if (Input.GetKey ("2"))
			((Transform)Instantiate (gem2)).position = transform.position + Random.insideUnitSphere * spread;
		if (Input.GetKey ("3"))
			((Transform)Instantiate (gem3)).position = transform.position + Random.insideUnitSphere * spread;
		if (Input.GetKey ("4"))
			((Transform)Instantiate (gem4)).position = transform.position + Random.insideUnitSphere * spread;
	}
}
