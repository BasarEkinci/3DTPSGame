using TPSGame.Abstracts.Combats;
using TPSGame.ScriptableObjects;
using UnityEngine;

namespace TPSGame.Combats
{
    public class MeleeAttackType : IAttackType
    {
        private Transform transformObject;
        private AttackSO attackSo;
        public MeleeAttackType(Transform transformObject,AttackSO attackSo)
        {
            this.transformObject = transformObject;
            this.attackSo = attackSo;
        }
        
        public void AttackAction()
        {
            Vector3 attackPoint = transformObject.position;
            Collider[] colliders = Physics.OverlapSphere(attackPoint, attackSo.FloatValue, attackSo.LayerMask);

            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out IHealth health))
                {
                    health.TakeDamage(attackSo.Damage);
                }
            }
        }
    }    
}


