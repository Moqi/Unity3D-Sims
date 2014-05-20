using UnityEngine;
using System.Collections;

public class SimInventory : MonoBehaviour
{

		private SimBase simBase;


		void Awake ()
		{
				simBase = gameObject.GetComponent<SimBase> ();
				simBase.AddFilter ("get_item", FindItem);
				simBase.AddFilter ("testfilter", FindItem);

	
		}


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

		}



		public object FindItem (object id)
		{

				Debug.Log ("huhu");
				return null;
		}

		public void Activate ()
		{
		}

		public void Deactivate ()
		{
		}
}
