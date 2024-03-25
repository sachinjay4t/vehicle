using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_project
{
    internal class bike
    {
        public string id { get; set; }
        public  string model  { get; set; }
        public  int year  { get; set; }


        public void starting()
        {
            Console.WriteLine("engination is started");
        }
        public void run()
        {
            Console.WriteLine("Bike is Now forwarding");
        }
    }
}
