using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public abstract class CharacterStateMachine : MonoBehaviour
    {
        protected CharacterState MovementState;
        protected CharacterState EquipmentState;

        public void SetMovementState(CharacterState state)
        {
            MovementState = state;
            MovementState.Start();
        }
        
        public void SetEquipmentState(CharacterState state)
        {
            EquipmentState = state;
            EquipmentState.Start();
        }
    }
}