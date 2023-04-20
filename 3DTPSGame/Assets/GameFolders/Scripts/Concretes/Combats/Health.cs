using System;
using System.Collections;
using System.Collections.Generic;
using TPSGame.Abstracts.Combats;
using TPSGame.ScriptableObjects;
using UnityEngine;

namespace TPSGame.Combats
{
    public class Health : MonoBehaviour,IHealth
    {
        [SerializeField] private HealthSO healthInfo;
        private int currentHealth;

        public bool IsDead => currentHealth <= 0;

        private void Awake()
        {
            currentHealth = healthInfo.MaxHealth;
        }

        public void TakeDamage(int damage)
        {
            if (IsDead) return;
            
            currentHealth -= damage;
        }
    }    
}


