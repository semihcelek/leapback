using SemihCelek.LeapBack.PlayerInput;
using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public class IdleState : CharacterState
    {
        private Rigidbody2D _characterRigidbody2D;
        private Transform _cachedTransform;
        private PlayerInputHandler _playerInputHandler;


        public IdleState(Character character) : base(character)
        {
        }

        public override void Start()
        {
            _characterRigidbody2D = Character.GetComponent<Rigidbody2D>();
            _cachedTransform = Character.transform;
            _playerInputHandler = Character.GetComponent<PlayerInputHandler>();
        }

        public override void HandleInput()
        {
            if (_playerInputHandler.IsMovingLeft == true || _playerInputHandler.IsMovingRight == true)
            {
                Character.SetMovementState(new RunningState(Character));
            }

            if (_playerInputHandler.isJumping == true)
            {
                Character.SetMovementState(new JumpState(Character));
            }
        }
    }
}