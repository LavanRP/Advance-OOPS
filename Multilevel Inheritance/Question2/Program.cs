using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails details1 = new DepartmentDetails("CSE","B.E");
        DepartmentDetails details2 = new DepartmentDetails("EEE","B.E");
        DepartmentDetails details3 = new DepartmentDetails("ECE","B.E");

        RackInfo rackInfo1 = new RackInfo(details1.DepartmentName,details1.Degree,1,1);
        RackInfo rackInfo2 = new RackInfo(details2.DepartmentName,details2.Degree,2,2);
        RackInfo rackInfo3 = new RackInfo(details3.DepartmentName,details3.Degree,3,3);

        BookInfo book1 = new BookInfo(rackInfo1.DepartmentName,rackInfo1.Degree,rackInfo1.RackNumber,rackInfo1.ColumnNumber,"Java","Aurthor1",1000);
        BookInfo book2 = new BookInfo(rackInfo2.DepartmentName,rackInfo2.Degree,rackInfo2.RackNumber,rackInfo2.ColumnNumber,"Power System","Aurthor2",1500);
        BookInfo book3 = new BookInfo(rackInfo3.DepartmentName,rackInfo3.Degree,rackInfo3.RackNumber,rackInfo3.ColumnNumber,"Electronic","Aurthor3",3000);

        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
    }
}