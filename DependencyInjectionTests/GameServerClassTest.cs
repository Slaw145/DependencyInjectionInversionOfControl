using Dependency_Injection___Inversion_of_Control;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionTests
{
    class GameServerClassTest
    {
        ICharacterSkillPoints characterskillpoints;
        GameServer gameserver;

        Mock<ICharacterRace> characterRaceMock;
        Mock<ICharacter> characterMock;
        ICharacter character;

        [SetUp]
        public void TestSetup()
        {
            characterRaceMock = new Mock<ICharacterRace>();
            characterMock = new Mock<ICharacter>();

            character = characterMock.Object;

            ILoginValidator loginvalidator = new LoginValidator();
            IPasswordValidator passwordvalidator = new PasswordValidator();
            characterskillpoints = new CharacterSkillPoints();

            gameserver = new GameServer(loginvalidator, passwordvalidator, characterskillpoints, characterRaceMock.Object);
        }

        [Test]
        public void test_race_attributes()
        {
            characterRaceMock.Setup(x => x.CreateCharacterRace(It.IsAny<ICharacterRace>())).Returns(() => characterRaceMock.Object);

            Assert.IsInstanceOf(typeof(Mock), characterRaceMock);
        }

        //ICharacter CreateCharacter()
        //{
        //    return characterskillpoints.CreateCharacter(new Mage());
        //}

        [Test]
        public void start_the_game_test_correctly()
        {
            //ICharacter character = CreateCharacter();

            bool ifvalidate = gameserver.RegisterUser("assd12", "adasd123@");

            bool ifGameIsStarted = gameserver.StartGame(character, ifvalidate);

            Assert.IsTrue(ifGameIsStarted);
        }

        [Test]
        public void start_the_game_test_not_correctly_with_bad_login_and_password()
        {
            //ICharacter character = CreateCharacter();

            bool ifvalidate = gameserver.RegisterUser("assd", "adasd12");

            bool ifGameIsStarted = gameserver.StartGame(character, ifvalidate);

            Assert.IsFalse(ifGameIsStarted);
        }

        [Test]
        public void start_the_game_test_not_correctly_without_created_character()
        {
            bool ifvalidate = gameserver.RegisterUser("assd12", "adasd123@");

            bool ifGameIsStarted = gameserver.StartGame(null, ifvalidate);

            Assert.IsFalse(ifGameIsStarted);
        }
    }
}
