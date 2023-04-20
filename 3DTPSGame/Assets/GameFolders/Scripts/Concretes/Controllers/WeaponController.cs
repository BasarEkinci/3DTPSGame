using TPSGame.Abstracts.Combats;
using TPSGame.Combats;
using TPSGame.ScriptableObjects;
using UnityEngine;

namespace TPSGame.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        
        [SerializeField] private bool canFire;
        [SerializeField] private Transform transformObject;
        [SerializeField] private AttackSO attackSo;
        
        private float currentTime = 0f;
        private IAttackType attackType;

        private void Awake()
        {
            attackType = attackSo.GetAttackType(transformObject);
        }

        private void Update()
        {
            currentTime += Time.deltaTime;

            canFire = currentTime > attackSo.AttackSpeed;
        }

        public void Attack()
        {
            if (!canFire) return;

            attackType.AttackAction();
            
            currentTime = 0f;
        }
    }    
}


