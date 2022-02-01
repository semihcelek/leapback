using System;
using UnityEngine;

namespace SemihCelek.LeapBack.PlayerInput
{
    public class PlayerInputHandler : MonoBehaviour
    {
        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        public bool isJumping { get; set; }
        public bool isFiring { get; set; }
        public bool isInteracting { get; set; }

        private void Update()
        {
            IsMovingLeft = Input.GetKey(KeyCode.A);
            IsMovingRight = Input.GetKey(KeyCode.D);
            isJumping = Input.GetKey(KeyCode.Space);
            isFiring = Input.GetKey(KeyCode.K);
            isInteracting = Input.GetKey(KeyCode.J);
        }
    }
}