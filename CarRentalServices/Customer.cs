namespace CarRentalServices
{
    public class Customer : Account
    {
        public Customer(string na, string pa)
        {
            username = na;
            password = pa;
            loginPairs.Add(username, password);
            accountList.Add(username, this);
        }
    }
}