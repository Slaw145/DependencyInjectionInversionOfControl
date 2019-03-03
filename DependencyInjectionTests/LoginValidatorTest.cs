﻿using Dependency_Injection___Inversion_of_Control;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionTests
{
    [TestFixture]
    public class LoginValidatorTest
    {
         ILoginValidator loginvalidator;

        [SetUp]
        public void TestSetup()
        {
            loginvalidator = new LoginValidator();
        }

        [Test]
        public void test_if_login_is_valid()
        {
            bool ifloginvalid = loginvalidator.LoginValidate("asdasd123");

            Assert.IsTrue(ifloginvalid);
        }

        [Test]
        public void test_if_login_is_not_valid()
        {
            bool ifloginnotvalid = loginvalidator.LoginValidate("asdasd123@");

            Assert.IsFalse(ifloginnotvalid);
        }
    }
}
