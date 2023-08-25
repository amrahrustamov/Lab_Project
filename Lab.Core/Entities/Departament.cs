namespace Lab.Core.Entities;

public class Departament : BaseClass<int>
{
    public string DepartamentName { get; set; }
    public List<Employee> Employees { get; set; }
}
