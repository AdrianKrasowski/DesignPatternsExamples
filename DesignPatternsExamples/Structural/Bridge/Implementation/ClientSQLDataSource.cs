using DesignPatternsExamples.Structural.Bridge.Implementation.Abstract;
using DesignPatternsExamples.Structural.Bridge.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Structural.Bridge.Implementation
{
    public class ClientSQLDataSource : IClientDataSource
    {
        public IEnumerable<Client> GetAllClients()
        {
            return new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "SQL",
                    Surname = "SQL"
                },
                new Client
                {
                    Id = 2,
                    Name = "SQL2",
                    Surname = "SQL2"
                }
            };
        }

        public Client GetClientBy(int id)
        {
            return new Client
            {
                Id = id,
                Name = "SQLMock",
                Surname = "SQLMock"
            };
        }

        public IEnumerable<Client> GetClientsBy(string name)
        {
            return new List<Client>
            {
                new Client
                {
                    Id = 3,
                    Name = name,
                    Surname = "SQLMock"
                }
            };
        }

        public async Task UpdateClient(Client client)
        {
            await Task.Run(() => 
                { 
                    Console.WriteLine("Asynchronously change client"); 
                }
            ); 
        }
    }
}
