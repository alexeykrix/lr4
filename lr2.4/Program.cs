class Program
{
    class ApplicationLicense
    {
        private string key = "";

        ApplicationLicense(string _key)
        {
            key = _key;
        }
        private void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
        }

        private void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }

        private void AllowPro()
        {
            Console.WriteLine("Платна версія");
        }

        public string CheckLicense()
        {
            if (key == "trial-Feg32Afigehy")
            {
                AllowTrial();
                return "Trial";
            }
            if (key == "Feg32Afigehy")
            {
                AllowPro();
                return "Pro";
            }

            AllowCommon();
            return "Common";
        }
    }
    
    static void Main(string[] args)
    {
        
    }
}