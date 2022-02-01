using SemihCelek.LeapBack.Utilities;
using UnityEngine;

namespace SemihCelek.LeapBack.Character
{
    public class EmptyEquipmentState : CharacterState
    {
        public EmptyEquipmentState(Character character) : base(character)
        {
        }

        public override void Start()
        {
        }

        public override void HandleInput()
        {
        }

        public override void HandleTrigger(Collider collider)
        {
            var hasGun = collider.TryGetComponent(out GunController gunController);

            if (hasGun)
            {
                Character.SetEquipmentState(new GunEquipmentState(Character));
            }
        }
    }

    public class GunEquipmentState : CharacterState
    {
        public GunEquipmentState(Character character) : base(character)
        {
        }
    }
}