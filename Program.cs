using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksis4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Прокси-сервер ===");
            Proxy.Start();
        }
    }
}