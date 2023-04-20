using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSGame.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Attack Info",menuName = "Attack Information/Create New",order = 51)]
    public class AttackSO : ScriptableObject
    {
                
        [SerializeField] private int damage = 10;
        [SerializeField] private float floatValue = 1f;
        [SerializeField] private LayerMask layerMask;
        [SerializeField] private float attackSpeed = 0.25f;

        public int Damage => damage;
        public float FloatValue => floatValue;
        public LayerMask LayerMask => layerMask;

        public float AttackSpeed => attackSpeed;
    }
}


