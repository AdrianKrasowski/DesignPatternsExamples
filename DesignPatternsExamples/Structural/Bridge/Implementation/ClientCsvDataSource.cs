using DesignPatternsExamples.Structural.Bridge.Implementation.Abstract;
using DesignPatternsExamples.Structural.Bridge.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Structural.Bridge.Implementation
{
    public class ClientCsvDataSource : IClientDataSource
    {
        public IEnumerable<Client> GetAllClients()
        {
            return new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "CSV",
                    Surname = "CSV"
                },
                new Client
                {
                    Id = 2,
                    Name = "CSV2",
                    Surname = "CSV2"
                }
            };
        }

        public Client GetClientBy(int id)
        {
            return new Client
            {
                Id = id,
                Name = "CSVMock",
                Surname = "CSVMock"
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
                    Surname = "CSVMock"
                }
            };
        }

        public async Task UpdateClient(Client client)
        {
            await Task.Run(() =>
                {
                    Console.WriteLine("Asynchronously change client data in CSV");
                }
            );
        }
    }
}
