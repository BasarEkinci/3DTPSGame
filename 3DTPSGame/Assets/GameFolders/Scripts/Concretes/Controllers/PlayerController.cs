using System;

using System.Collections.Generic;
using TPSGame.Abstracts.Inputs;
using TPSGame.Abstracts.Movements;
using TPSGame.Animations;
using TPSGame.Movements;
using UnityEngine;

namespace TPSGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Informations")] [SerializeField]
        private float moveSpeed;
        
        private IInputReader input;
        private IMover mover;
        private CharacterAnimation animation;

        private Vector3 direction;
        
        private void Awake()
        {
            input = GetComponent<IInputReader>();
            mover = new MoveWithCharacterController(this);
            animation = new CharacterAnimation(this);
        }
        private void Update()
        {
            direction = input.Direction;
        }

        private void FixedUpdate()
        {
            mover.MoveAction(direction,moveSpeed);
        }

        private void LateUpdate()
        {
            animation.MoveAnimation(direction.magnitude);
        }
    }    
}

