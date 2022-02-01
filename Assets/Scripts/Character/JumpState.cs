using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public class JumpState : CharacterState
    {
        private Rigidbody2D _characterRigidbody2D;
        private float _jumpForce = 5;
        private Transform _cachedTransform;
        private LayerMask _groundLayer;
        private Vector2 _characterLocalScale;

        public JumpState(Character character) : base(character)
        {
        }

        public override void Start()
        {
            _characterRigidbody2D = Character.GetComponent<Rigidbody2D>();
            _cachedTransform = Character.transform;
            _groundLayer = LayerMask.GetMask("Ground");
            _characterLocalScale = _cachedTransform.localScale;

            _characterRigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }

        public override void HandleInput()
        {
            var hit = Physics2D.Raycast(_cachedTransform.position, -Vector2.up, _characterLocalScale.y / 2 + 0.1f,
                _groundLayer);

            if (hit.collider != null)
            {
                Character.SetMovementState(new RunningState(Character));
            }
        }
    }
}