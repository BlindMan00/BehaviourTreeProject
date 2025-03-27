using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class PatrolAT : ActionTask 
	{
		public NavMeshAgent agent;
		private int currentWaypoint;
		public Transform wayPoints;

		public float patrolTime;

		private float timer = 0;

		protected override void OnUpdate()
		{
			timer += Time.deltaTime;

			if (timer >= patrolTime)
			{
				EndAction(true);
			}
			if(agent.remainingDistance <= 0.2f) 
			{
				currentWaypoint++;
				if (currentWaypoint >= wayPoints.childCount)
				{
					currentWaypoint = 0;
				}
				agent.SetDestination(wayPoints.GetChild(currentWaypoint).position);
			}
		}
	}
}