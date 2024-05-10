using DesignPatternsExamples.Structural.Bridge.Implementation;
using DesignPatternsExamples.Structural.Bridge.Models;
using System.Linq;
using Xunit;

namespace DesignPatternsTests.Creational.Structural.Bridge.Implementations
{
    public class ClientCSVDataSourceTest
    {
        //Arrange
        private ClientCsvDataSource _uut = new ClientCsvDataSource();

        [Fact]
        public void ClientCSVDataSource_GetClientById_ShouldReturnClientWithProvidedID()
        {
            //Arrange
            int expectedId = 1;
            Client expectedClient = new Client
            {
                Id = expectedId,
                Name = "CSVMock",
                Surname = "CSVMock"
            };

            //Act
            var actualClient = _uut.GetClientBy(expectedId);

            //Assert
            Assert.NotNull(actualClient);
            Assert.Equal(expectedId, actualClient.Id);
            Assert.Equal(expectedClient.Name, actualClient.Name);
            Assert.Equal(expectedClient.Surname, actualClient.Surname);
        }

        [Fact]
        public void ClientCSVDataSource_GetClientByName_ShouldReturnClientWithProvidedName()
        {
            //Arrange
            string expectedName = "Robert";
            int expectedClientsCount = 1;
            Client expectedClient = new Client
            {
                Id = 3,
                Name = expectedName,
                Surname = "CSVMock"
            };

            //Act
            var actualUsersList = _uut.GetClientsBy(expectedName).ToList();

            //Assert
            Assert.NotNull(actualUsersList);
            Assert.Equal(expectedClientsCount, actualUsersList.Count);
            Assert.Collection<Client>(actualUsersList,
                actualUser =>
                {
                    Assert.Equal(expectedName, actualUser.Name);
                    Assert.Equal(expectedClient.Id, actualUser.Id);
                    Assert.Equal(expectedClient.Surname, actualUser.Surname);
                }
            );
        }

        [Fact]
        public void SQLDataSource_GetAllClientsShouldReturnExpectedData()
        {
            //Arrange
            int expectedNumberOfRecords = 2;
            Client expectedFirstClient = new Client
            {
                Id = 1,
                Name = "CSV",
                Surname = "CSV"
            };
            Client expectedSecondClient = new Client
            {
                Id = 2,
                Name = "CSV2",
                Surname = "CSV2"
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
    }
}
