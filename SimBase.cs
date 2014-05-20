using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SimBase : FilterBehaviour
{

		private List<Task> tasks = new List<Task> ();
		public float tickRate = 1.1f;
	

		// Use this for initialization
		void Start ()
		{
				StartCoroutine (Live ());
				api.ApplyFilters ("get_item", 4);
				api.ApplyFilters ("testfilter", 4, "hurr");
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		IEnumerator Live ()
		{
				while (true) {
						api.DoAction ("live");
						yield return new WaitForSeconds (tickRate);
				}
		}





}

