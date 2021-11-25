using Employees_Managing_App;


//Developer developerOne = new Developer("bob", "erx", 28);
//Developer developerTwo = new Developer("yell", "ron", 35);
//Developer developerThree = new Developer("ronen", "agil", 19);
//Developer developerFour = new Developer("sivan", "sultan", 40);
//Developer developerFive = new Developer("yael", "tilda", 24);


//Team dev1 = new Team();
//dev1.developerOne.firstName = "bob";
//dev1.developerOne.lastName = "erx";
//dev1.developerOne.age = 78;


//Team[] teamOfDevelopers = new Team[5];

//for (int i = 0; i < teamOfDevelopers.Length; i++)
//{
//    Console.WriteLine("Enter Developer info");
//    teamOfDevelopers[i].[i].firstName = Console.ReadLine();
//    teamOfDevelopers[i].[i].lastName = Console.ReadLine();
//    teamOfDevelopers[i].[i].age = int.Parse(Console.ReadLine());
//}


Developer[] teamOfDevelopers = new Developer[5];

//for (int i = 0; i < teamOfDevelopers.Length; i++)
//{
//    for (int j = 0; j < 1; j++)
//    {
//        Console.WriteLine("Enter Developer info");
//        teamOfDevelopers[i].firstName = Console.ReadLine();
//        teamOfDevelopers[i].lastName = Console.ReadLine();
//        teamOfDevelopers[i].age = int.Parse(Console.ReadLine());
//    }
//}

for (int i = 0; i < teamOfDevelopers.GetLength(0); i++)
{
    for (int j = 0; j < teamOfDevelopers.GetLength(1); j++)
    {
        Console.WriteLine("Enter Developer info");
        teamOfDevelopers[j].firstName = Console.ReadLine();
        teamOfDevelopers[j].lastName = Console.ReadLine();
        teamOfDevelopers[j].age = int.Parse(Console.ReadLine());
    }
}

foreach (Developer developer in teamOfDevelopers)
{
    Console.WriteLine($"{developer.firstName } {developer.lastName} {developer.age}");
}



User[] arrayOfUsers = new User[] {
    new User("bob",1998,"bob@gmail.com"),
    new User("sid",1997,"sid@gmail.com"),
    new User("root",1845,"root@gmail.com"),
    new User("xor",1450,"xor@gmail.com")
};

Array.Sort(arrayOfUsers);

foreach (User user in arrayOfUsers)
{
    user.UserInfo(); 
}

Manager managerOne = new Manager();
managerOne.Department = "development";
managerOne.Salary = 21000;
managerOne.Employee = 54;


Employee[] arrayOfEmployees = new Employee[] {
    new Employee("silver",1950,"silver@gmail.com","security",9000),
    new Employee("squid",1940,"squid@gmail.com","counselor",10000),
    new Employee("root",1997,"root@gmail.com","CEO",20000),
    new Employee("bob",1994,"bob@gmail.com","developer",12000)
};


Console.WriteLine("Before Sort");

foreach (Employee employee in arrayOfEmployees)
{
    employee.EmployeeInfo();
}
Array.Sort(arrayOfEmployees);

Console.WriteLine("After Sort");


foreach (Employee employee in arrayOfEmployees)
{
    employee.EmployeeInfo();
}


Employee employee1 = new Employee("bob",1998,"bob@gmail.com", "CTO",400000);
employee1.EmployeeInfo();
