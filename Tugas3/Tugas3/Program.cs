using System;

namespace Tugas3
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi1 = new Taxi();
            Taxi taxi2 = new Taxi();
            Taxi taxi3 = new Taxi();

            taxi1.driver ="rifki";
            taxi1.onduty = "no";
            taxi1.number = "4";

            taxi2.driver = "bondan";
            taxi2.onduty = "no";
            taxi2.number = "2";

            taxi3.driver = "yanto";
            taxi3.onduty = "y/n";
            taxi3.number = "6";

            taxi1.taxiinfo();
            taxi1.pickuppassenger();


            taxi2.taxiinfo();
            taxi2.dropofpassenger();

            taxi3.taxiinfo();
            taxi3.pickuppassenger();
            taxi3.dropofpassenger();


            Console.ReadKey();
        }
    }
}
