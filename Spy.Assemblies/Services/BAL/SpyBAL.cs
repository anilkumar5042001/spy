using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spy.Assemblies.Services.BAL
{
  public class SpyBAL
    {
        public bool CheckIsSpy(string strMsg,string strCode)
        {
            bool IsSpy = false;
            try
            {
                List<int> msg = GetArrayInt(strMsg);
                List<int> code = GetArrayInt(strCode);
                List<int> resultPositions = GetCodesPositions(msg, code);
                bool isNegativePositionExist = CheckNegativeNumberExist(resultPositions);
                if (isNegativePositionExist)
                {
                    IsSpy = false;
                }
                else
                {
                    IsSpy = IsSequence(resultPositions);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsSpy;
        }

        private List<int> GetArrayInt(string numbs)
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
        private bool IsSequence(List<int> array)
        {
            bool IsSeq = true;
            try
            {
                int temp = 0;

                for (int i = 0; i < array.Count; i++)
                {
                    if (temp > array[i])
                    {
                        IsSeq = false;
                        break;
                    }
                    temp = array[i];

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsSeq;
        }
        private bool CheckNegativeNumberExist(List<int> array)
        {
            bool isNegative = false;
            try
            {
                //Check is -ve value exists

                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] < 0)
                    {
                        isNegative = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isNegative;
        }
        //eg: [1,2,0,3,0,5,6,7] [007]
        private List<int> GetCodesPositions(List<int> msg, List<int> code)
        {

            List<int> resultPositions = new List<int>();
            try
            {
                foreach (int c in code)
                {
                    int pos = getPosition(msg, c, resultPositions);
                    resultPositions.Add(pos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultPositions;
        }
        private int getPosition(List<int> msg, int singleCode, List<int> resultPositions)
        {
            int pos = -1;
            try
            {
                for (int i = 0; i < msg.Count; i++)
                {
                    int exist = resultPositions.Where(x => x == i).Count();
                    if (exist == 0)
                    {
                        if (singleCode == msg[i])
                        {
                            pos = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pos;
        }
    }
}
