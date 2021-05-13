namespace ConsoleApp1
{
    public class Employee
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public int Type { get; set; } // 1 : Permanent 2 : Contract
        public double Pay { get; set; }
        public double Bounus { get; set; }

        public double HouseAllowance { get; set; } // Only for permanent employee
        public double MedicalAllowance { get; set; } // Only for contract employee
    }
}
