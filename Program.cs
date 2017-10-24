using System;

namespace Question2
{
    class Falcon
    {
        private string _FalconName;
        private string _Species;
        private string _Sex;
        private int _Weight;
        private string _BandNumber;


        public string FalconName
        {
            set
            {
                _FalconName = value;
            }
        }

        public string Species
        {
            set
            {
                _Species = value;
            }
        }

        public string Sex
        {
            set
            {
                _Sex = value;
            }
        }

        public int Weight
        {
            set
            {
                _Weight = value;
            }
        }

        public string BandNumber
        {
            set
            {
                _BandNumber = value;
            }
        }


        public Falcon(string _FalconName, string _Species, string _Sex, int _Weight, string _BandNumber)
        {
            FalconName = _FalconName;
            Species = _Species;
            Sex = _Sex;
            Weight = _Weight;
            BandNumber = _BandNumber;
        }

        public string DisplayFalcon()
        {
            var falcon = "Falcon output:\n\n";
            falcon += $"The FalconName is: {_FalconName}\n";
            falcon += $"The Species is: {_Species}\n";
            falcon += $"The Sex is: {_Sex}\n";
            falcon += $"The Weight is: {_Weight}\n";
            falcon += $"The BandNumber is: {_BandNumber}\n";

            return falcon;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Falcon name :");
            var FalconName = Console.ReadLine();

            Console.WriteLine("Enter a Species of a Falcon :");
            var Species = Console.ReadLine();

            Console.WriteLine("Enter a Sex of Falcon :");
            var Sex = Console.ReadLine();

            Console.WriteLine("Enter a Weight of a Falcon :");
            var Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Band number of Falcon :");
            var BandNumber = Console.ReadLine();

            Console.WriteLine("FALCON DATA OUTPUT");

            Console.WriteLine("Falcon name  {0}.", FalconName);
            Console.WriteLine("Species : {0}.", Species);
            Console.WriteLine("Sex is : {0}.", Sex);
            Console.WriteLine("Weight : {0}.", Weight);
            Console.WriteLine("BandNumber {0}.", BandNumber);
        }
    }
}
