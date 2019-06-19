using Spy.Assemblies.Services.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spy
{
    class Program
    {
        static void Main(string[] args)
        {
            SpyBAL objSpyBAL = new SpyBAL();
            System.Console.WriteLine("Please enter a msg using comma separated.");
            string strMsg = Console.ReadLine().ToString();
            System.Console.WriteLine("Please enter a code using comma separated.");
            
            string strCode = Console.ReadLine().ToString();
            Console.ReadLine();
            bool isSpy= objSpyBAL.CheckIsSpy(strMsg, strCode);
            Console.WriteLine(isSpy);
            Console.ReadLine();
        }
        
    }
}
