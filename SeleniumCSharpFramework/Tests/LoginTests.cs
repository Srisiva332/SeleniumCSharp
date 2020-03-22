using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using SeleniumCSharpFramework.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpFramework.Tests
{
    [TestFixture("Environments/qa.json")]
    public class LoginTests
    {
        readonly EnvironmentData environmentData;
        readonly string configfile;

        public LoginTests(string configfile)
        {
            this.configfile = configfile;
            var config = this.InitConfiguration();
            environmentData = config.GetSection("EnvironmentData").Get<EnvironmentData>();
        }


        [Test]
        public void SampleTest()
        {
            Console.WriteLine(environmentData.LoginUrl);
        }

        internal IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(configfile)
                .Build();
            return config;
        }

    }
}
