using CsvHelper;
using System.Globalization;

namespace AddressBookFileHandling
{
    public class Input
    {
        List<Person> personData = new List<Person>();
        Person person;
        public void InputData()
        {
            person = new Person();
            Console.Write("Enter First Name = ");
            person.first_Name = Console.ReadLine();
            Console.Write("Enter Last Name = ");
            person.last_Name = Console.ReadLine();
            Console.Write("Enter Address = ");
            person.address = Console.ReadLine();
            Console.Write("Enter State = ");
            person.state = Console.ReadLine();
            Console.Write("Enter City = ");
            person.city = Console.ReadLine();
            Console.Write("Enter Zip Code = ");
            person.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number = ");
            person.phone_Number = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Email = ");
            person.email = Console.ReadLine();

            personData.Add(person);

            using (StreamWriter writer = new StreamWriter(@"C:\source\repos\BridgeLabz\CSharp\AddressBookFileHandling\AddressBookFileHandling\Data.csv"))
            using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(personData);
            }
        }
    }
}