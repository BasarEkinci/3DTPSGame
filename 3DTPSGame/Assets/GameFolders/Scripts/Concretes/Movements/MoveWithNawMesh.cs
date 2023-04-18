using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Controllers;
using TPSGame.Abstracts.Movements;
using TPSGame.Controllers;
using UnityEngine;
using UnityEngine.AI;

namespace TPSGame.Movements
{
    public class MoveWithNawMesh : IMover
    {
        private NavMeshAgent navMeshAgent;

        public MoveWithNawMesh(IEntityController entityController)
        {
            navMeshAgent = entityController.transform.GetComponent<NavMeshAgent>();
        }
        
        public void MoveAction(Vector3 direction, float moveSpeed)
        {
            navMeshAgent.SetDestination(direction);
        }
    }
}

