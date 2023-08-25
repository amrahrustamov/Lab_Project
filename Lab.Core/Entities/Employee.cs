namespace Lab.Core.Entities;

public class Employee:BaseClass<int>
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Father { get; set; }
    public string EmployeeNumber { get; set; }
    public string Pin { get; set; }
    public string Email { get; set; }
    public string ImgPath { get; set; }
    public int DepartamentId { get; set; }
    public Departament Departament { get; set; }


}
