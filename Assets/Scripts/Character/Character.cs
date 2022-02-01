using System;
using SemihCelek.LeapBack.PlayerInput;
using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public class Character : CharacterStateMachine
    {
        private void Start()
        {
            SetMovementState(new IdleState(this));
            SetEquipmentState(new EmptyEquipmentState(this));
        }

        private void Update()
        {
            MovementState.HandleInput();
            EquipmentState.HandleInput();
        }

        private void OnTriggerEnter(Collider other)
        {
            EquipmentState.HandleTrigger(other);
        }


    }
}