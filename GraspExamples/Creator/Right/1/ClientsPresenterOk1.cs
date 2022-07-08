using System.Collections.Generic;
using System.Linq;

namespace GraspExamples.Creator.Right._1
{
    public class ClientsPresenterOk1
    {
        List<ClientOk1> Clients = new List<ClientOk1>();

        public void AddOrder(int clientId, int id, string description)
        {
            ClientOk1 client = Clients.Where(x => x.Id == clientId).FirstOrDefault();
            if (client != null)
            {
                client.AddOrder(id, description);
            }
        }

        public void AddClient(int id, string name)
        {
            ClientOk1 client = new ClientOk1()
            {
                Id = id,
                Name = name
            };

            Clients.Add(client);
        }
    }
}
