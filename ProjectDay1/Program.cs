using System.Text;

namespace ProjectDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            Console.Write("enter id : ");
            a.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter balance : ");
            a.Balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter Account Type : ");
            a.AccountType = Convert.ToString(Console.ReadLine());
            Console.WriteLine("calling get details \n");
            String s = a.GetDetails();
            Console.WriteLine(s);
            Console.WriteLine("calling withdraw \n");
            a.WithDraw(200);
            Console.WriteLine("calling get deatils \n");
            String s2 = a.GetDetails();
            Console.WriteLine(s2);     
        }
    }
}