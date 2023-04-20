using System;
using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Combats;
using TPSGame.Abstracts.Controllers;
using TPSGame.Abstracts.Movements;
using TPSGame.Animations;
using TPSGame.Combats;
using TPSGame.Movements;
using UnityEngine;
using UnityEngine.AI;

namespace TPSGame.Controllers
{
    public class EnemyController : MonoBehaviour,IEntityController
    {
        [SerializeField] private Transform playerPrefab;

        private IHealth health;
        private IMover mover;
        private CharacterAnimation animation;
        private NavMeshAgent navMeshAgent;
        
        private void Awake()
        {
            mover = new MoveWithNawMesh(this);
            animation = new CharacterAnimation(this);
            navMeshAgent = GetComponent<NavMeshAgent>();
            health = GetComponent<IHealth>();
        }

        private void Update()
        {
            if (health.IsDead) return;
            
            mover.MoveAction(playerPrefab.transform.position,10f);
        }

        private void LateUpdate()
        {
            animation.MoveAnimation(navMeshAgent.velocity.magnitude);
        }
    }    
}

