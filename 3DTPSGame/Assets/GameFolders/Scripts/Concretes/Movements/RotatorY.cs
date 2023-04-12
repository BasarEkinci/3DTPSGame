using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Movements;
using TPSGame.Controllers;
using UnityEngine;

namespace TPSGame.Movements
{
    public class RotatorY : IRotator
    {
        private Transform transform;
        private float tilt;
        public RotatorY(PlayerController playerController)
        {
            transform = playerController.TurnTransform;
        }
        
        public void RotationAction(float direction, float speed)
        {
            direction *= speed * Time.deltaTime;
            tilt = Mathf.Clamp(tilt - direction, -30f, 30f);
            transform.localRotation = Quaternion.Euler(tilt,0f,0f);
        }
    }
}
