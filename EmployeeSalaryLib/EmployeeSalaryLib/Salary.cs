namespace EmployeeSalaryLib
{
    public class Salary
    {
        public double Total { get; set; }
        public double Basic { get; set; }
        public double MedicalPercent { get; set; }
        public double ConveyancePercent { get; set; }
        public double IncrementPercent { get; set; }
        public int NoOfIncrement { get; set; }

        public Salary(double basic, double medicalPercent, double conveyancePercent, int incrementPercent):this()
        {
            Basic = basic;
            MedicalPercent = medicalPercent;
            ConveyancePercent = conveyancePercent;
            IncrementPercent = incrementPercent;
        }

        public Salary()
        {
        }

        public double GetTotal()
        {
           Total = Basic + GetMedicalPercent() + GetConveyancePercent()+GetIncrimentPercent();
            return Total;
        }

        public double GetMedicalPercent()
        {
            return (Basic*MedicalPercent/100);
        }

        public double GetConveyancePercent()
        {
            return (Basic*ConveyancePercent/100);
        }

        public double GetIncrimentPercent()
        {
            NoOfIncrement++;
            return (IncrementPercent*Basic/100);
        }
    }
}