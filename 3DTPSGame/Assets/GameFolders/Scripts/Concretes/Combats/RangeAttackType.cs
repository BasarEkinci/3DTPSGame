using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Combats;
using TPSGame.ScriptableObjects;
using UnityEngine;

namespace TPSGame.Combats
{
    public class RangeAttackType : IAttackType
    {
        private Camera camera;
        private AttackSO attackSo;
        
        public RangeAttackType(Transform transformObject,AttackSO attackSo)
        {
            camera = transformObject.GetComponent<Camera>();
            this.attackSo = attackSo;
        }
        public void AttackAction()
        {
            Ray ray = camera.ViewportPointToRay(Vector3.one / 2f);

            if (Physics.Raycast(ray, out RaycastHit hit,attackSo.FloatValue,attackSo.LayerMask))
            {
                if (hit.collider.TryGetComponent(out IHealth health))
                {
                    health.TakeDamage(attackSo.Damage);
                }
            }
        }
    }    
}


