using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SimBase : FilterBehaviour
{

		private List<Task> tasks = new List<Task> ();


		// Use this for initialization
		void Start ()
		{
				StartCoroutine (Live ());
				api.ApplyFilters ("get_item", 4);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		IEnumerator Live ()
		{
				while (true) {
						api.DoAction ("live");
						yield return new WaitForSeconds (1);
				}
		}





}

