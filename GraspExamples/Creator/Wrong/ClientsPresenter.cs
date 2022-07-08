using System.Collections.Generic;
using System.Linq;

namespace GraspExamples.Creator.Wrong
{
    public class ClientsPresenter
    {
        List<Client> Clients = new List<Client>();

        public void AddOrder(int clientId, int id, string description)
        {
            Order order = new Order()
            {
                Id = id,
                Description = description
            };

            Client client = Clients.Where(x => x.Id == clientId).FirstOrDefault();
            if(client != null)
            {
                client._orders.Add(order);
            }

        }

        public void AddClient(int id, string name)
        {
            Client client = new Client()
            {
                Id = id,
                Name = name
            };

            Clients.Add(client);
        }

    }
}
