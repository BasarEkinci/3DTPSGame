using TPSGame.Abstracts.Controllers;
using TPSGame.Abstracts.Movements;
using UnityEngine;


namespace TPSGame.Movements
{
    public class MoveWithCharacterController : IMover
    {
        private CharacterController characterController;
        public MoveWithCharacterController(IEntityController entityController)
        {
            characterController = entityController.transform.GetComponent<CharacterController>();
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

