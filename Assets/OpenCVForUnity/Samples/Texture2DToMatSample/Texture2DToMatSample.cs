﻿using UnityEngine;
using System.Collections;

using OpenCVForUnity;

namespace OpenCVForUnitySample
{
		/// <summary>
		/// Texture2D to mat sample.
		/// </summary>
		public class Texture2DToMatSample : MonoBehaviour
		{

				// Use this for initialization
				void Start ()
				{

						Texture2D imgTexture = Resources.Load ("lena") as Texture2D;

						Mat imgMat = new Mat (imgTexture.height, imgTexture.width, CvType.CV_8UC4);

						Utils.texture2DToMat (imgTexture, imgMat);
						Debug.Log ("imgMat dst ToString " + imgMat.ToString ());


						Texture2D texture = new Texture2D (imgMat.cols (), imgMat.rows (), TextureFormat.RGBA32, false);

		
						Utils.matToTexture2D (imgMat, texture);

						gameObject.GetComponent<Renderer> ().material.mainTexture = texture;

				}
	
				// Update is called once per frame
				void Update ()
				{
	
				}

				void OnGUI ()
				{
						float screenScale = Screen.width / 240.0f;
						Matrix4x4 scaledMatrix = Matrix4x4.Scale (new Vector3 (screenScale, screenScale, screenScale));
						GUI.matrix = scaledMatrix;
		
		
						GUILayout.BeginVertical ();
						if (GUILayout.Button ("back")) {
								Application.LoadLevel ("OpenCVForUnitySample");
						}
		
		
						GUILayout.EndVertical ();
				}
		}
}
