using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection___Inversion_of_Control
{
    public class GameServer
    {
        ILoginValidator loginvalidator;
        IPasswordValidator passwordvalidator;
        ICharacterSkillPoints characterskillpoints;
        ICharacterRace characterrace;

        public GameServer(ILoginValidator loginvalidator, IPasswordValidator passwordvalidator, ICharacterSkillPoints characterskillpoints, ICharacterRace characterrace)
        {
            this.loginvalidator = loginvalidator;
            this.passwordvalidator = passwordvalidator;
            this.characterskillpoints = characterskillpoints;
            this.characterrace = characterrace;
        }

        public bool RegisterUser(string login, string password)
        {
            bool ifloginvalidate = loginvalidator.LoginValidate(login);
            bool ifpasswordvalidate = passwordvalidator.PasswordValidate(password);

            if (ifloginvalidate == true && ifpasswordvalidate == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ICharacter CreateCharacter(ICharacter character)
        {
            return characterskillpoints.CreateCharacter(character);
        }

        public ICharacterRace CreateCharacterRace(ICharacterRace characterrace)
        {
            return characterrace.CreateCharacterRace(characterrace);
        }

        public bool StartGame(ICharacter character, bool ifUserIsSigned)
        {
            if(character!=null && ifUserIsSigned==true)
            {
                return true;
                //Start the game
            }
            else
            {
                return false;
                //Throw exception
            }
        }
    }
}
