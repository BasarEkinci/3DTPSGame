using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSGame.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private bool canFire;
        [SerializeField] private float attackSpeed = 0.25f;
        [SerializeField] private float distance = 100f;
        [SerializeField] private Camera camera;
        [SerializeField] private LayerMask layerMask;
        private float currentTime = 0f;
        
        private void Update()
        {
            currentTime += Time.deltaTime;

            canFire = currentTime > attackSpeed;
        }

        public void Attack()
        {
            if (!canFire) return;

            Ray ray = camera.ViewportPointToRay(Vector3.one / 2f);

            if (Physics.Raycast(ray, out RaycastHit hit, distance,layerMask))
            {
                Debug.Log(hit.collider.gameObject.name);
            }
            
            currentTime = 0f;
        }
    }    
}


