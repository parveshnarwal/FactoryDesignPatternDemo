namespace ConsoleApp1.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            if (employee.Type == 1)
                return new PermanentEmployeeFactory(employee);
            else
                return new ContractEmployeeFactory(employee);
        }
    }
}
