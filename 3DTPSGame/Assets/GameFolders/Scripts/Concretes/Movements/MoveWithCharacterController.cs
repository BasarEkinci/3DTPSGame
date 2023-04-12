using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Movements;
using TPSGame.Controllers;
using UnityEngine;


namespace TPSGame.Movements
{
    public class MoveWithCharacterController : IMover
    {
        private CharacterController characterController;
        public MoveWithCharacterController(PlayerController playerController)
        {
            characterController = playerController.GetComponent<CharacterController>();
        }
        
        
        public void MoveAction(Vector3 direction,float moveSpeed)
        {
            if (direction.magnitude == 0) return;
            
            Vector3 worldPos = characterController.transform.TransformDirection(direction);
            Vector3 movement = worldPos * (Time.deltaTime * moveSpeed);
            characterController.Move(movement);
        }
    }    
}

