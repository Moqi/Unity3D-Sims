using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimNeeds : MonoBehaviour
{

		private SimBase simBase;
		private List<Need> needs;

		// Use this for initialization
		void Awake ()
		{
				simBase = gameObject.GetComponent<SimBase> ();
				simBase.AddAction ("live", Live);
		}

		void Start ()
		{
				needs = simBase.ApplyFilters ("needs", new List<Need> ()) as List<Need>;
		}

		// Update is called once per frame
		void Live ()
		{

				Debug.Log ("Ich lebe!");
		}
}
