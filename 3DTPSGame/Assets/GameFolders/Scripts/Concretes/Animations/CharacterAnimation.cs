using System.Collections;
using System.Collections.Generic;
using TPSGame.Controllers;
using UnityEngine;

namespace TPSGame.Animations
{
    public class CharacterAnimation
    {
        private Animator animator;

        public CharacterAnimation(PlayerController entity)
        {
            animator = entity.GetComponentInChildren<Animator>();
        }

        public void MoveAnimation(float moveSpeed)
        {
            if(animator.GetFloat("moveSpeed") == moveSpeed) return;
            
            animator.SetFloat("moveSpeed",moveSpeed,0.1f,Time.deltaTime);
        }
    }    
}


