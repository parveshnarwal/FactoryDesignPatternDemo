using ConsoleApp1.Managers;

namespace ConsoleApp1.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;

        public BaseEmployeeFactory(Employee employee)
        {
            _emp = employee;
        }

        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = this.Create();
            _emp.Bounus = employeeManager.GetBonus();
            _emp.Pay = employeeManager.GetPay();
            return _emp;
        }

        public abstract IEmployeeManager Create();
    }
}
