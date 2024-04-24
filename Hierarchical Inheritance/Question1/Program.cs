using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        TeacherInfo teacher1 = new TeacherInfo("Kumar","Ram",new DateTime(1950,04,12),"12345",Gender.Male,"kumar@gmail.com","CSE","Java","B,sc",8,new DateTime(2002,05,07));
        TeacherInfo teacher2 = new TeacherInfo("RamKumar","ramesh",new DateTime(1959,04,11),"987654",Gender.Male,"ram@gmail.com","CSE","C#","B,sc",5,new DateTime(2007,07,06));
        teacher1.ShowDetails();
        teacher2.ShowDetails();
        Console.WriteLine();

        StudentInfo student1 = new StudentInfo("lavan","Ramesh",new DateTime(2002,05,12),"123456",Gender.Male,"lavan@mail.com","B.E","CSE",7);
        StudentInfo student2 = new StudentInfo("kishore","Karthi",new DateTime(2001,09,11),"6543",Gender.Male,"Kishor@mail.com","B.E","CSE",7);
        student1.ShowDetails();
        student2.ShowDetails();
        Console.WriteLine();
        
        PrincipalInfo principal1 = new PrincipalInfo("Jhon","Peter",new DateTime(1950,09,09),"98765",Gender.Male,"jhon@gmail.com","M,sc",10,new DateTime(1998,05,12));
        PrincipalInfo principal2 = new PrincipalInfo("Miller","Jhon",new DateTime(1955,05,19),"765678",Gender.Male,"miller@gmail.com","M,sc",11,new DateTime(1997,07,02));
        principal1.ShowDetails();
        principal2.ShowDetails();
    }
}