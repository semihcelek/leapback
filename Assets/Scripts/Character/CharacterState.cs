using SemihCelek.LeapBack.PlayerInput;
using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public abstract class CharacterState
    {
        protected Character Character;

        protected CharacterState(Character character)
        {
            Character = character;
        }

        public virtual void Start()
        {
        }

        public virtual void HandleInput()
        {
        }

        public virtual void HandleTrigger(Collider collider)
        {
        }
    }
}