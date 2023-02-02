using static EnumStatic.RegisMonth;
namespace EnumStatic
{
    internal class Program
    {
        static void Main()
        {
            User user1 = new User("Ruslan","M",RegistrationMonth.June,"SUPPPER");
            User user2 = new User("Seymur", "G.",RegistrationMonth.Arpil, "WASSSUP");
            User user3 = new User("Ruslan", "M.",RegistrationMonth.September, "THROWWW");
            User user4 = new User("Metleb", "H.", RegistrationMonth.June, "KICKCCC");
            User user5 = new User("Shamil", "H.", RegistrationMonth.June, "WHATEVE");
            user1.GetDetails();
            user2.GetDetails();
            user3.GetDetails();
            user4.GetDetails();
            user5.GetDetails();

        }
    }
}