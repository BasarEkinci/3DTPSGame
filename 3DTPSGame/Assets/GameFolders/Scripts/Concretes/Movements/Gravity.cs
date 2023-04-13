using UnityEngine;

namespace TPSGame.Movements
{
    public class Gravity : MonoBehaviour
    {
        [SerializeField] private float gravity = -9.81f;
        private CharacterController characterController;
        private Vector3 velocity;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            if (characterController.isGrounded) velocity.y = 0f;

            velocity.y += gravity * Time.deltaTime;

            characterController.Move(velocity * Time.deltaTime);
        }
    }
}
