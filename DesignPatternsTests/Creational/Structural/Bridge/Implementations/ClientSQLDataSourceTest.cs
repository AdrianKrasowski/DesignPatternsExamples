using DesignPatternsExamples.Structural.Bridge.Implementation;
using DesignPatternsExamples.Structural.Bridge.Models;
using System.Linq;
using Xunit;

namespace DesignPatternsTests.Creational.Structural.Bridge.Implementations
{
    public class ClientSQLDataSourceTest
    {
        private ClientSQLDataSource _uut = new ClientSQLDataSource();
        
        [Fact]
        public void SQLDataSource_GetAllClientsShouldReturnExpectedData()
        {
            //Arrange
            int expectedNumberOfRecords = 2;
            Client expectedFirstClient = new Client
            {
                Id = 1,
                Name = "SQL",
                Surname = "SQL"
            };
            Client expectedSecondClient = new Client
            {
                Id = 2,
                Name = "SQL2",
                Surname = "SQL2"
            };

            //Act
            var result = _uut.GetAllClients().ToList();

            //Assert
            Assert.Equal(expectedNumberOfRecords, result.Count);
            Assert.Collection<Client>(result,
                firstElement =>
                {
                    Assert.Equal(expectedFirstClient.Id, firstElement.Id);
                    Assert.Equal(expectedFirstClient.Surname, firstElement.Surname);
                    Assert.Equal(expectedFirstClient.Name, firstElement.Name);
                },
                secondElement =>
                {
                    Assert.Equal(expectedSecondClient.Id, secondElement.Id);
                    Assert.Equal(expectedSecondClient.Name, secondElement.Name);
                    Assert.Equal(expectedSecondClient.Surname, secondElement.Surname);
                }
            );
        }

        [Fact]
        public void ClientSQLDataSource_GetClientById_ShouldReturnClientWithGivenId()
        {
            //Arrange
            int expectedId = 1;
            Client expectedClient = new Client
            {
                Id = expectedId,
                Name = "SQLMock",
                Surname = "SQLMock"
            };

            //Act
            var actualClient = _uut.GetClientBy(expectedId);

            //Assert
            Assert.Equal(expectedClient.Id, actualClient.Id);
            Assert.Equal(expectedClient.Name, actualClient.Name);
            Assert.Equal(expectedClient.Surname, actualClient.Surname);
        }

        [Fact]
        public void ClientSQLDataSource_GetClientByName_ShouldReturnRecordsWithRequestedName()
        {
            //Arrange
            int expectedRowsCount = 1;
            string expectedClientName = "Robert";
            Client expectedClient = new Client
            {
                Id = 3,
                Name = expectedClientName,
                Surname = "SQLMock"
            };

            //Act
            var actualResult = _uut.GetClientsBy(expectedClientName).ToList();

            //Assert
            Assert.Equal(expectedRowsCount, actualResult.Count);
            Assert.Collection<Client>(actualResult,
                actualClient =>
                {
                    Assert.Equal(expectedClient.Id, actualClient.Id);
                    Assert.Equal(expectedClient.Name, actualClient.Name);
                    Assert.Equal(expectedClient.Surname, actualClient.Surname);
                }
            );
        }
    }
}
