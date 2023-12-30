using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void ConnectionString_SqlServer_Should_be_a_Connectionstring_To_AzureSqlDatabase()
        {
            // Arrange
            var expected = "";

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Act
            var result = configuration.GetConnectionString("SqlServer");

            // Assert
            Assert.Equal(expected, result);
        }


    }
}
