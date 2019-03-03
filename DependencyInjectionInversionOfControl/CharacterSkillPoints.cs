using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection___Inversion_of_Control
{
    public interface ICharacterSkillPoints
    {
        ICharacter CreateCharacter(ICharacter character);
        ICharacter GiveOutSkillPoints(ICharacter character);
    }

    public class CharacterSkillPoints: ICharacterSkillPoints
    {
        public ICharacter CreateCharacter(ICharacter character)
        {
            return GiveOutSkillPoints(character);
        }

        public ICharacter GiveOutSkillPoints(ICharacter character)
        {
            character.Strength += character.AdditionalStrength;
            character.Stamina += character.AdditionalStamina;

            return character;
        }
    }
}
