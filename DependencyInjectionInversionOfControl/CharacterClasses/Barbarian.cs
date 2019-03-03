using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection___Inversion_of_Control
{
    public class Barbarian : ICharacter
    {
        private int _strength = 18;
        public int Strength { get => _strength; set => _strength = value; }

        private int _stamina = 17;
        public int Stamina { get => _stamina; set => _stamina = value; }

        private int _additionalStrength=15;
        public int AdditionalStrength { get => _additionalStrength; set => _additionalStrength=value; }

        private int _additionalStamina=9;
        public int AdditionalStamina { get => _additionalStamina; set => AdditionalStrength=value; }
    }
}
