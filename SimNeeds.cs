using UnityEngine;
using System.Collections;

public class SimNeeds : MonoBehaviour
{

		private SimBase simBase;
	

		// Use this for initialization
		void Awake ()
		{
				simBase = gameObject.GetComponent<SimBase> ();
				simBase.AddAction ("live", Live);
		}
	
		// Update is called once per frame
		void Live ()
		{

				Debug.Log ("Ich lebe!");
		}
}
