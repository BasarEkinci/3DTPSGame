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
        [Header("Movement Informations")] 
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float turnSpeed = 10f;
        [SerializeField] private Transform turnTransform;
        [SerializeField] private WeaponController currentWeapon;
        
        private IInputReader input;
        private IMover mover;
        private IRotator xRotation;
        private IRotator yRotation;
        private CharacterAnimation animation;

        private Vector3 direction;
        private Vector2 rotation;

        public Transform TurnTransform => turnTransform;
        
        private void Awake()
        {
            input = GetComponent<IInputReader>();
            mover = new MoveWithCharacterController(this);
            animation = new CharacterAnimation(this);
            xRotation = new RotatorX(this);
            yRotation = new RotatorY(this);
        }
        private void Update()
        {
            direction = input.Direction;
            rotation = input.Rotation;
            
            xRotation.RotationAction(input.Rotation.x,turnSpeed);
            yRotation.RotationAction(input.Rotation.y,turnSpeed);
            
            if(input.IsAttackButtonPressed)
                currentWeapon.Attack();
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

