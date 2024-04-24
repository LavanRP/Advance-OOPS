using System;
using Question1;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        Personalnfo personalnfo1 = new Personalnfo("Lavan",Gender.Male,new DateTime(2002,05,12),"123456",Maritaldetails.single);
        Personalnfo personalnfo2 = new Personalnfo("Kumar",Gender.Male,new DateTime(2002,07,02),"765423",Maritaldetails.single);

        RegisterPerson register1 = new RegisterPerson(personalnfo1.Name,personalnfo1.Gender,personalnfo1.DOB,personalnfo1.Phone,personalnfo1.Maritaldetails,"Ramesh","Rani","Madurai",2,DateTime.Now);
        RegisterPerson register2 = new RegisterPerson(personalnfo2.Name,personalnfo2.Gender,personalnfo2.DOB,personalnfo2.Phone,personalnfo2.Maritaldetails,"Suresh","Priya","Chennai",4,DateTime.Now);

        personalnfo1.ShowInfo();
        register1.ShowInfo();
        Console.WriteLine();
        personalnfo2.ShowInfo();
        register2.ShowInfo();
    }
}