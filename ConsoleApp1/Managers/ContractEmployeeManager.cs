namespace ConsoleApp1.Managers
{
    class ContractEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 50;
        }

        public double GetPay()
        {
            return 300;
        }

        public double GetMedicalAllowance()
        {
            return 10;
        }
    }
}
