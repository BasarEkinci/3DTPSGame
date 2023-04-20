using System;
using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Controllers;
using TPSGame.Abstracts.Movements;
using TPSGame.Animations;
using TPSGame.Movements;
using UnityEngine;
using UnityEngine.AI;

namespace TPSGame.Controllers
{
    public class EnemyController : MonoBehaviour,IEntityController
    {
        [SerializeField] private Transform playerPrefab;

        private IMover mover;
        private CharacterAnimation animation;
        private NavMeshAgent navMeshAgent;
        
        private void Awake()
        {
            mover = new MoveWithNawMesh(this);
            animation = new CharacterAnimation(this);
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            mover.MoveAction(playerPrefab.transform.position,10f);
        }

        private void LateUpdate()
        {
            animation.MoveAnimation(navMeshAgent.velocity.magnitude);
        }
    }    
}

