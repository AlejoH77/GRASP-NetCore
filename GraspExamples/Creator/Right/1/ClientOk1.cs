using System;
using System.Collections.Generic;
namespace GraspExamples.Creator.Right._1
{
    public class ClientOk1
    {
        public List<OrderOk1> _orders = new List<OrderOk1>();

        public string Name { get; set; }
        public int Id { get; set; }

        public void AddOrder(int id, string description)
        {
            OrderOk1 order = new OrderOk1()
            {
                Id = Id,
                Description = description
            };

            _orders.Add(order);
        }
    }
}
