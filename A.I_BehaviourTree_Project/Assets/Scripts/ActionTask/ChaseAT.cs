using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class ChaseAT : ActionTask
	{
		public NavMeshAgent agent;
		public GameObject player;
		public float speed;

		protected override void OnUpdate() 
		{
			agent.speed = speed;

			agent.SetDestination(player.transform.position);
		}
	}
}