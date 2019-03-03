using System;

namespace Dependency_Injection___Inversion_of_Control
{
    class WebServer
    {
        static GameServer gameServer;

        static void Main(string[] args)
        {
            var loginvalidator = new LoginValidator();
            var passwordvalidator = new PasswordValidator();
            var characterskillpoints = new CharacterSkillPoints();
            gameServer = new GameServer(loginvalidator, passwordvalidator, characterskillpoints, new ICharacterRace());

            bool ifUserIsLoginIn = LogIn();

            ICharacter createdCharacter = CreateCharacter();

            StartGame(createdCharacter, ifUserIsLoginIn);

            Console.ReadKey();
        }

        static bool LogIn()
        {
            bool ifvalidate = gameServer.RegisterUser("assd12", "adasd123@");

            if (ifvalidate)
            {
                Console.WriteLine("Register user");
            }
            else
            {
                Console.WriteLine("Login or password are incorrect!");
            }

            return ifvalidate;
        }

        static ICharacter CreateCharacter()
        {
            ICharacter character = gameServer.CreateCharacter(new Barbarian());

            Console.WriteLine("Skill points after give out.");

            Console.WriteLine(character.Strength);
            Console.WriteLine(character.Stamina);

            return character;
        }

        static void StartGame(ICharacter character, bool ifvalidate)
        {
            bool ifGameIsStarted = gameServer.StartGame(character, ifvalidate);

            if (ifGameIsStarted)
            {
                Console.WriteLine("Start the game");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
