using ConsoleApp1.Managers;

namespace ConsoleApp1.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager permanentEmployeeManager = new PermanentEmployeeManager();
            _emp.HouseAllowance = permanentEmployeeManager.GetHouseAllowance();
            return permanentEmployeeManager;
        }
    }
}
