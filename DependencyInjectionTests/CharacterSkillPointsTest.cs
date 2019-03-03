using Dependency_Injection___Inversion_of_Control;
using NUnit.Framework;

namespace DependencyInjectionTests
{
    [TestFixture]
    public class CharacterSkillPointsTest
    {
        ICharacter character;
        ICharacterSkillPoints characterskillpoints;

        [SetUp]
        public void TestSetup()
        {
            characterskillpoints = new CharacterSkillPoints();

            CreateCharacter();
        }

        void CreateCharacter()
        {
            character = characterskillpoints.CreateCharacter(new Paladin());
        }

        [Test]
        public void check_skill_points_strength()
        {
            int StrengthSkillPoints = character.Strength;

            Assert.AreEqual(26, StrengthSkillPoints);
        }

        [Test]
        public void check_skill_points_stamina()
        {
            int StrengthSkillPoints = character.Stamina;

            Assert.AreEqual(22, StrengthSkillPoints);
        }
    }
}
