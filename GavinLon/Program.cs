// See https://aka.ms/new-console-template for more information
using GavinLon;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Ucze się githuba! ");
//List<Employee> employeeList = Data.GetEmployees();
//List<Department> departmentList = Data.GetDepartments();

//Part 7.4

////Concatenation Operator
////Concat

//List<int> integerList1 = new List<int> { 1, 2, 3, 4 };
//List<int> integerList2 = new List<int> { 5, 6, 7, 8, 9, 10 };

//IEnumerable<int> integerListConcat = integerList1.Concat(integerList2);

//foreach (var item in integerListConcat)
//{
//    Console.WriteLine(item);
//}

//List<Employee> employeeList2 = new List<Employee> { new Employee { Id = 5, FirstName = "Tony", LastName = "Stark" }, new Employee { Id = 6, FirstName = "Debbie", LastName = "Townsend" } };

//IEnumerable<Employee> results = employeeList.Concat(employeeList2);

//foreach (var item in results)
//{
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
//}



////Equality Operator
////SequenceEqual
//var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
//var integerList2 = new List<int> { 1, 2, 3, 4, 5, 6 };

//var employeeListCompare = Data.GetEmployees();
//bool boolSE = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());

//Console.WriteLine($"Result: {boolSE}");

//var boolSequenceEqual = integerList1.SequenceEqual(integerList2);
//Console.WriteLine(boolSequenceEqual);



////Aggregate Operators - Aggregate, Average, Count, Sum, Max
////Aggregate Operator

//decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0,(totalAnnualSalary, e) =>
//{
//    var bonus = (e.IsManager == true) ? 0.4m : 0.02m;

//    totalAnnualSalary = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totalAnnualSalary;

//        return totalAnnualSalary;
//});

//Console.WriteLine($"Total Annual Salary of all employess (including bonus): {totalAnnualSalary}");

//string data = employeeList.Aggregate<Employee,string, string>("Employee Annual Salaries (including bonus): ",
//    (s, e) => {
//        var bonus = (e.IsManager) ? 0.04m : 0.02m;

//        s += $"{e.FirstName} {e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)}, ";
//        return s;
//    }, s => s.Substring(0, s.Length - 2)
//);

//Console.WriteLine(data);

////Average
/////
//decimal average = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);
//Console.WriteLine($"Average Annual Salary (Technology Department): {average}");

////Count
///
//int countEmployees = employeeList.Count(e => e.DepartmentId == 3);

//Console.WriteLine($"Number of Employees (Technology Department): {countEmployees}");

//Sum

//decimal result = employeeList.Sum(e => e.AnnualSalary);
//Console.WriteLine($"Total Annual Salaries: {result}");

//Max

//var result = employeeList.Max(e => e.AnnualSalary);
//Console.WriteLine($"Highest Annual Salary: {result}");

////Generation Operators - DefaultIfEmpty, Empty, Range, Repeat
////DefaultIfEmpty

//List<int> intList = new List<int>();
//var newList = intList.DefaultIfEmpty();

//Console.WriteLine(newList.ElementAt(0));

//List<Employee> employees = new List<Employee>();
//var newList = employees.DefaultIfEmpty(new Employee { Id = 0});

//var result = newList.ElementAt(0);

//if (result.Id == 0)
//    Console.WriteLine($"The list is empty");

////Empty

//List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();

//emptyEmployeeList.Add(new Employee {Id = 7,FirstName="Dan", LastName="Brown" });

//foreach (var item in emptyEmployeeList)
//    Console.WriteLine($"{item.FirstName} {item.LastName}");

////Range
//var intCollection = Enumerable.Range(25, 20);
//foreach (var item in intCollection)
//   Console.WriteLine(item);

////Repeat
//var strCollection = Enumerable.Repeat<string>("Placeholder", 10);
//foreach (var item in strCollection)
//    Console.WriteLine(item);

////Set Operators - Distinct, Except, Intersect, Union
////Distinct

//List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
//var results = list.Distinct();
//foreach (var item in results)
//    Console.WriteLine(item);

////Except

//IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
//IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6};

//var results = collection1.Except(collection2);
//foreach (var item in results)
//    Console.WriteLine(item);

////Except

//IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
//IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6};

//var results = collection1.Except(collection2);
//foreach (var item in results)
//    Console.WriteLine(item);

List<Employee> employeeList2 = new List<Employee>();

employeeList2.Add(new Employee
{
    Id = 1,
    FirstName = "Bob",
    LastName = "Jones",
    AnnualSalary = 60000.3m,
    IsManager = true,
    DepartmentId = 2
}
);
employeeList2.Add(new Employee
{
    Id = 3,
    FirstName = "Douglas",
    LastName = "Roberts",
    AnnualSalary = 40000.2m,
    IsManager = false,
    DepartmentId = 1
}
);
employeeList2.Add(new Employee
{
    Id = 5,
    FirstName = "Craig",
    LastName = "Laurence",
    AnnualSalary = 20000.2m,
    IsManager = false,
    DepartmentId = 1
}
);
employeeList2.Add(new Employee
{
    Id = 6,
    FirstName = "Elizabeth",
    LastName = "Tate",
    AnnualSalary = 85000,
    IsManager = true,
    DepartmentId = 1
}
);

//var results = employeeList.Except(employeeList2, new EmployeeComparer());

//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

////Intersect


//var results = employeeList.Except(employeeList2, new EmployeeComparer());


//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");


////Union
//var results = employeeList.Union(employeeList2, new EmployeeComparer());

//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");


////Partitioning Operators - Skip, SkipWhile, Take, TakeWhile
////Skip

//var results = employeeList.Skip(2);
//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");



////SkipWhile

//employeeList.Add(new Employee { Id = 5, FirstName = "Sam", LastName = "Davis", AnnualSalary = 100000.0m });

//var results = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");


/////Take
//var results = employeeList.Take(2);
//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");


////TakeWhile

//employeeList.Add(new Employee { Id = 5, FirstName = "Sam", LastName = "Davis", AnnualSalary = 100000 });

//var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");


////Conversion Operators - ToList, ToDictionary, ToArray
////ToList

//List<Employee> results = (from emp in employeeList
//                         where emp.AnnualSalary > 50000
//                         select emp).ToList();

//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

////ToDictionary

//Dictionary<int, Employee> dictionary = (from emp in employeeList
//                                      where emp.AnnualSalary > 50000
//                                        select emp).ToDictionary<Employee, int>(e => e.Id);

//foreach (var key in dictionary.Keys)
//    Console.WriteLine($"Key: {key}, Value: {dictionary[key].FirstName} {dictionary[key].LastName}");

////ToArray
//Employee[] results = (from emp in employeeList
//                      where emp.AnnualSalary > 50000
//                      select emp).ToArray();

//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");


////Let Clause and Into Clause

////Let
//var results = from emp in employeeList
//             let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
//             let AnnualSalaryPlusBonus = (emp.IsManager) ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : emp.AnnualSalary + (emp.AnnualSalary * 0.02m)
//              where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 50000
//              select new
//              {
//                  Initials = Initials,
//                  FullName = emp.FirstName + " " + emp.LastName,
//                  AnnualSalaryPlusBonus = AnnualSalaryPlusBonus
//              };

//foreach (var item in results)
//    Console.WriteLine($"{item.Initials,-5} {item.FullName,-20} {item.AnnualSalaryPlusBonus,10}");


////Into
//var results = from emp in employeeList
//              where emp.AnnualSalary > 50000
//              select emp
//              into HighEarners
//              where HighEarners.IsManager == true
//              select HighEarners;

//foreach (var item in results)
//    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");


List<Employee> employeeList = Data.GetEmployees();
List<Department> departmentList = Data.GetDepartments(employeeList);

////Projection Operators - Select, SelectMany
////Select

//var results = departmentList.Select(d => d.Employees);

//foreach(var items in results)
//    foreach(var item in items)
//        Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");


////SelectMany

var results = departmentList.SelectMany(d => d.Employees); //.OrderBy(o => o.Id);

foreach (var item in results)
    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");

/// Part 7.3

//// Sorting Operations OrderBy, OrderByDescending, ThenBy, ThenByDescending
////Method Syntax
/////
//var results = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id,
//    (emp, dept) => new
//    {
//        Id = emp.Id,
//        FirstName = emp.FirstName,
//        LastName = emp.LastName,
//        AnnualSalary = emp.AnnualSalary,
//        DepartmentId = emp.DepartmentId,
//        DepartmentName = dept.LongName
//    }).OrderBy(o => o.DepartmentId).ThenByDescending(o => o.AnnualSalary);

//foreach (var item in results)
//    Console.WriteLine($"First Name: {item.FirstName,-10} Last Name: {item.LastName,-10} Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}");

////Query Syntax

//var results = from emp in employeeList
//              join dept in departmentList
//              on emp.DepartmentId equals dept.Id
//              orderby emp.DepartmentId, emp.AnnualSalary descending
//              select new
//              {
//                  Id = emp.Id,
//                  FirstName = emp.FirstName,
//                  LastName = emp.LastName,
//                  AnnualSalary = emp.AnnualSalary,
//                  DepartmentId = emp.DepartmentId,
//                  DepartmentName = dept.LongName
//              };

//foreach (var item in results)
//  Console.WriteLine($"First Name: {item.FirstName,-10} Last Name: {item.LastName,-10} Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}");


////Grouping Operators
////GroupBy
///

//var groupResult = from emp in employeeList
//                  orderby emp.DepartmentId
//                  group emp by emp.DepartmentId;

//foreach (var empGroup in groupResult)
//{
//    Console.WriteLine($"Department Id: {empGroup.Key}");

//    foreach (Employee emp in empGroup)
//    {
//        Console.WriteLine($"\tEmployee Fullname: {emp.FirstName} {emp.LastName}");
//    }

//}

////ToLookup Operator
//var groupResult = employeeList.OrderBy(o => o.DepartmentId).ToLookup(e => e.DepartmentId);

////var groupResult = employeeList.ToLookup(e => e.DepartmentId);

//foreach (var empGroup in groupResult)
//{
//    Console.WriteLine($"Department Id: {empGroup.Key}");

//    foreach (Employee emp in empGroup)
//    {
//        Console.WriteLine($"\tEmployee Fullname: {emp.FirstName} {emp.LastName}");
//    }

//}


////All, Any, Contains Quantifier Operators
////All and Any Operators

//var annualSalaryCompare = 20000;

////bool isTrueAll = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);
////if (isTrueAll)
////{
////    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
////}
////else
////{
////    Console.WriteLine($"Not all employee annual salaries are above {annualSalaryCompare}");
////}


//bool isTrueAny = employeeList.Any(e => e.AnnualSalary > annualSalaryCompare);
//if (isTrueAny)
//{
//    Console.WriteLine($"At least one employee has an annual salary above {annualSalaryCompare}");
//}
//else
//{
//    Console.WriteLine($"No employees have an annual salary above {annualSalaryCompare}");
//}

////Contains Operator

//var searchEmployee = new Employee
//{
//    Id = 3,
//    FirstName = "Douglas",
//    LastName = "Roberts",
//    AnnualSalary = 40000.2m,
//    IsManager = false,
//    DepartmentId = 1
//};

//bool containsEmployee = employeeList.Contains(searchEmployee, new EmployeeComparer());

//if (containsEmployee)
//{
//    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
//}
//else
//{
//    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");
//}



////OfType filter Operator
ArrayList mixedCollection = Data.GetHeterogeneousDataCollection();

//var stringResult = from s in mixedCollection.OfType<string>()
//                   select s;


//var intResult = from i in mixedCollection.OfType<int>()
//                   select i;

//foreach (var item in intResult)
//{
//    Console.WriteLine(item);
//}

//var employeeResults = from e in mixedCollection.OfType<Employee>()
//                      select e;

//foreach (var emp in employeeResults)
//{
//    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
//}

//var departmentResults = from d in mixedCollection.OfType<Department>()
//                        select d;

//foreach (var dept in departmentResults)
//{

//    Console.WriteLine($"{dept.Id,-5} {dept.LongName,-30} {dept.ShortName,-10}");
//}

////ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single and SingleOrDefault Element Operators
////ElementAt, ElementAtOrDefault Operators
/////
//var emp = employeeList.ElementAtOrDefault(1);

//if (emp != null)
//{
//    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
//}
//else
//{
//    Console.WriteLine("This employee record does not exist within the collection");
//}

////First, FirstOrDefault, Last, LastOrDefault Operators

//List<int> integerList = new List<int> { 3, 13, 23,24, 17, 27, 87 };

////int result = integerList.First(i => i % 2 == 0);

//int result = integerList.FirstOrDefault(i => i % 2 == 0);


//if (result != 0)
//{
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("There are no even numbers in the collection");
//}

////Single, SingleOrDefault Operators

//var emp = employeeList.SingleOrDefault(e => e.Id == 100);


//if (emp != null)
//{
//    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
//}
//else
//{
//    Console.WriteLine("This employee does not exist within the collection");
//}
//Console.ReadKey();

class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
    {
        if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
        {
            return true;
        }
        return false;
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        return obj.Id.GetHashCode();
    }
}
