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
			agent.transform.position = Vector3.MoveTowards(agent.transform.position, player.transform.position, speed);
		}
	}
}