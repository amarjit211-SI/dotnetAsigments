namespace CsharpAssigment3Prb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.employeeName = "Amarjit";
            manager.employeeId = 32;
            manager.employeeSalary = 27000;
            manager.CalculateBonus();

            Console.WriteLine("\n");

            Developer developer = new Developer();
            developer.employeeName = "Ranjeet";
            developer.employeeId = 33;
            developer.employeeSalary = 28000;
            developer.CalculateBonus();

            Console.WriteLine("\n");

            SalesPerson salesPerson = new SalesPerson();
            salesPerson.employeeName = "Tanish";
            salesPerson.employeeId = 50;
            salesPerson.employeeSalary = 125000;
            salesPerson.CalculateBonus();

        }
    }
}