using SemihCelek.LeapBack.PlayerInput;
using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public class RunningState : CharacterState
    {
        private Rigidbody2D _characterRigidbody2D;
        private PlayerInputHandler _playerInputHandler;

        private float _characterSpeed = 12f;
        private Transform _cachedTransform;

        public RunningState(Character character) : base(character)
        {
        }

        public override void Start()
        {
            _characterRigidbody2D = Character.GetComponent<Rigidbody2D>();
            _playerInputHandler = Character.GetComponent<PlayerInputHandler>();

            _cachedTransform = Character.transform;
        }

        public override void HandleInput()
        {
            if (_playerInputHandler.IsMovingLeft == false || _playerInputHandler.IsMovingRight == false ||
                _playerInputHandler.isJumping == false)
            {
                Character.SetMovementState(new IdleState(Character));
            }

            if (_playerInputHandler.IsMovingLeft)
            {
                _characterRigidbody2D.AddForce(Vector2.left * _characterSpeed);
            }

            if (_playerInputHandler.IsMovingRight)
            {
                _characterRigidbody2D.AddForce(Vector2.right * _characterSpeed);
            }
            
            if (_playerInputHandler.isJumping == true)
            {
                Character.SetMovementState(new JumpState(Character));
            }
        }
    }
}