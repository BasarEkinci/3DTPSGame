using System;
using System.Collections;
using System.Collections.Generic;
using TPSGame.ScriptableObjects;
using Unity.VisualScripting;
using UnityEngine;

namespace TPSGame.Helpers
{
    public class MeleeAttackRangeDisplay : MonoBehaviour
    {
        [SerializeField] private float radius = 1f;
        private void OnDrawGizmos()
        {
            OnDrawGizmosSelected();
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(this.transform.position,radius);
        }
    }    
}


