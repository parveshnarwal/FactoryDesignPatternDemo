namespace ConsoleApp1.Managers
{
    class PermanentEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 100;
        }

        public double GetPay()
        {
            return 500;
        }

        public double GetHouseAllowance()
        {
            return 70;
        }
    }
}
