using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection___Inversion_of_Control
{
    public interface ICharacterRace
    {
        ICharacterRace CreateCharacterRace(ICharacterRace characterrace);
    }
}
