using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spy.Assemblies.Services
{
   public class CommonMethods
    {
        public List<int> GetArrayInt(string numbs)
        {
            List<int> arrayInt = new List<int>();
            try
            {
                string[] strSplit = numbs.Split(',');
                foreach (string str in strSplit)
                {
                    arrayInt.Add(Convert.ToInt32(str));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return arrayInt;
        }
    }
}
