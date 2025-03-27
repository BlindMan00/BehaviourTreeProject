using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Conditions {

	public class WithinRangeCT : ConditionTask {

		public int sightRange;

		public GameObject player;

		public NavMeshAgent agent;

		protected override bool OnCheck() 
		{
			float distance = Vector3.Distance(agent.transform.position, player.transform.position);

			 Debug.Log("Distance: " + distance);  // Log distance to check if it's calculated correctly
			if (distance <= sightRange)
			{
				return true;
			}
			return false;
		}
	}
}