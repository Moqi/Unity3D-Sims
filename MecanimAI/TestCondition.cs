using UnityEngine;

using System.Collections;



namespace StateMachine.Condition
{
	
		[Info (category = "Physics",    
	       
	       description = "Returns true if there is any collider intersecting the line between start and end.",
	       
	       url = "http://docs.unity3d.com/Documentation/ScriptReference/Physics.Linecast.html")]
	
		[System.Serializable]
	
		public class TestCondition : StateCondition
		{
		
				[FieldInfo(tooltip="Start position.")]
		
				public Vector3Parameter
						start;
		
				[FieldInfo(tooltip="End position.")]
		
				public Vector3Parameter
						end;
		
				[FieldInfo(tooltip="Layer masks can be used selectively filter game objects for example when casting rays.")]
		
				public LayerMask
						layerMask;
		
				[FieldInfo(tooltip="Does the result equals this condition.")]
		
				public BoolParameter
						equals;
		
		
		
		
		
				public override bool Validate ()
				{   
			
						return Physics.Linecast (start.Value, end.Value, layerMask) == equals.Value;
			
				}
		
		}
	
}