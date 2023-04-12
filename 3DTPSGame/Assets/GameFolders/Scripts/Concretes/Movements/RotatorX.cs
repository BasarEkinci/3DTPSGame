using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Movements;
using TPSGame.Controllers;
using UnityEngine;

namespace TPSGame.Movements
{
    public class RotatorX : IRotator
    {
        private PlayerController playerController;

        public RotatorX(PlayerController playerController)
        {
            this.playerController = playerController;
        }
        
        public void RotationAction(float direction, float speed)
        {
            playerController.transform.Rotate(Vector3.up * (direction * Time.deltaTime * speed));
        }
    }    
}


