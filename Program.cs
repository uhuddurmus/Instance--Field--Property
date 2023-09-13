namespace class_instance_field_property;
class Program
{
    static void Main(string[] args)
    {

        //Access Modifiers
        // * Public
        // * Private
        // * Internal
        // * Protected



        Employee employeeOne = new Employee();
        employeeOne.Name = "Mustafa Uhud";
        employeeOne.LastName = "Durmus";
        employeeOne.No = 111111;
        employeeOne.Department = "Galaktik Lord";

        employeeOne.GetEmployeeInfo();

        Console.WriteLine("---------------------------");

        Employee employeeTwo = new Employee();
        employeeTwo.Name = "Haydar";
        employeeTwo.LastName = "Haydaroğlu";
        employeeTwo.No = 222222;
        employeeTwo.Department = "Galaktik Lord Yardımcısı";

        employeeTwo.GetEmployeeInfo();

    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int No;
        public string Department;

        public void GetEmployeeInfo()
        {
            Console.WriteLine("Name of the employee: {0}", Name);
            Console.WriteLine("Last Name of the employee: {0}", LastName);
            Console.WriteLine("Id of the employee: {0}", No);
            Console.WriteLine("Department of the employee: {0}", Department);
        }
    }
}