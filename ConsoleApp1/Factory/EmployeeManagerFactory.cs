using ConsoleApp1.Managers;

namespace ConsoleApp1.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeType)
        {
            if (employeeType == 1)
                return new PermanentEmployeeManager();
            else 
                return new ContractEmployeeManager();

        }
    }
}
