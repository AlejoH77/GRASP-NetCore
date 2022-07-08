namespace GraspExamples.Creator.Right._2
{
    public class ClientOk2
    {
        OrderOk2 _order;

        public ClientOk2()
        {
            _order = new OrderOk2();
        }

        public void DeleteOrder()
        {
            _order.Delete();
        }

        public void RenameOrder(string newName)
        {
            _order.Update(newName);
        }
    }
}
