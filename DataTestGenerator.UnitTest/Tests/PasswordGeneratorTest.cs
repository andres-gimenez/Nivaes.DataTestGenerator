﻿namespace Nivaes.DataTestGenerator.UnitTest
{
    using FluentAssertions;
    using global::Xunit;
    using global::Xunit.Abstractions;
    using System.Collections.Generic;

    public class PasswordGeneratorTest
    {
        private readonly ITestOutputHelper mOutput;

        public PasswordGeneratorTest(ITestOutputHelper output)
        {
            mOutput = output;
        }

        [Fact]
        public void PasswordGeneratorString01()
        {
            var password = PasswordGenerator.Instance.CreatePassword();
            mOutput.WriteLine(password);
            password.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void PasswordGeneratorString02()
        {
            List<string> passwords = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                var password = PasswordGenerator.Instance.CreatePassword();

                password.Should().NotBeNullOrEmpty();
                passwords.Should().NotContain(password);

                passwords.Add(password);
                mOutput.WriteLine(password);
            }
        }
    }
}
