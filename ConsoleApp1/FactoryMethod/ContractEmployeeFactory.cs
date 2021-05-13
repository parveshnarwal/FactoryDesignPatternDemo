using ConsoleApp1.Managers;

namespace ConsoleApp1.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {

        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager contractEmployeeManager = new ContractEmployeeManager();
            _emp.MedicalAllowance = contractEmployeeManager.GetMedicalAllowance();
            return contractEmployeeManager;
        }
    }
}
