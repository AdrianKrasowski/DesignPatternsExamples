using DesignPatternsExamples.Structural.Bridge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Structural.Bridge.Implementation.Abstract
{
    public interface IClientDataSource
    {
        Client GetClientBy(int id);
        IEnumerable<Client> GetAllClients();
        IEnumerable<Client> GetClientsBy(string name);
        Task UpdateClient(Client client);
    }
}
