using DesignPatternsExamples.Structural.Bridge.Implementation.Abstract;
using DesignPatternsExamples.Structural.Bridge.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Structural.Bridge.Abstraction
{
    public class ClientSerivce
    {
        protected IClientDataSource _implementation { get; set; }

        public ClientSerivce(IClientDataSource implementation)
        {
            _implementation = implementation;
        }

        public List<Client> GetClientsBy(string name)
        {
            return _implementation.GetClientsBy(name).ToList();
        }

        public async Task UpdateClient(Client client)
        {
            await _implementation.UpdateClient(client);
        }

        public Client GetLatestClientData(Client client)
        {
            return _implementation.GetClientBy(client.Id);
        }
    }
}
