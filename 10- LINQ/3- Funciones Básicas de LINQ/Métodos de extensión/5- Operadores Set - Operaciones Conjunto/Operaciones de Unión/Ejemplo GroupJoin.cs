var departments = new List<Department>
{
    new Department { Id = 1, Name = "HR" },
    new Department { Id = 2, Name = "Finance" },
    new Department { Id = 3, Name = "Marketing" }
};

var employees = new List<Employee>
{
    new Employee { Id = 1, Name = "John", DepartmentId = 1 },
    new Employee { Id = 2, Name = "Jane", DepartmentId = 2 },
    new Employee { Id = 3, Name = "Bob", DepartmentId = 1 },
    new Employee { Id = 4, Name = "Alice", DepartmentId = 3 },
    new Employee { Id = 5, Name = "Mike", DepartmentId = 2 }
};

var result = departments.GroupJoin(
    employees,
    department => department.Id,
    employee => employee.DepartmentId,
    (department, group) => new
    {
        DepartmentName = department.Name,
        Employees = group
    }
);

foreach (var department in result)
{
    Console.WriteLine($"Department: {department.DepartmentName}");
    foreach (var employee in department.Employees)
    {
        Console.WriteLine($"- Employee: {employee.Name}");
    }
}

#region  Explicacion Ejemplo

/*En este ejemplo, unimos las colecciones departments y employees en base al campo Id de departments y el campo DepartmentId de employees. Utilizamos una función de selección de resultados para crear un objeto anónimo con el nombre del departamento y los empleados que pertenecen a ese departamento en forma de grupo.*/

#endregion
