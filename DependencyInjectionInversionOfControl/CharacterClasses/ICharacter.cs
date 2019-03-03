using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection___Inversion_of_Control
{
    public interface ICharacter
    {
        int Strength { get; set; }
        int Stamina { get; set; }

        int AdditionalStrength { get; set; }
        int AdditionalStamina { get; set; }
    }
}
