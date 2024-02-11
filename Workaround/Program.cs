using Business.Concrete;
using Entities.Concrete;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {

        Person person1 = new Person();
        person1.FirstName = "Nuri";
        person1.LastName = "Demir";
        person1.DateOfBirthYear = 1998;
        person1.NationalIdentity = 123;


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();

    }

}