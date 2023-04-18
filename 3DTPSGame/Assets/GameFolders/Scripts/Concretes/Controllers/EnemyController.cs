using System;
using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Controllers;
using TPSGame.Abstracts.Movements;
using TPSGame.Movements;
using UnityEngine;

namespace TPSGame.Controllers
{
    public class EnemyController : MonoBehaviour,IEntityController
    {
        [SerializeField] private Transform playerPrefab;

        private IMover mover;
        
        private void Awake()
        {
            mover = new MoveWithNawMesh(this);
        }

        private void Update()
        {
            mover.MoveAction(playerPrefab.transform.position,10f);
        }
    }    
}

