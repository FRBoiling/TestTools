using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilityLibrary
{
    public static class RAND
    {
        static Random rand = new Random((int)DateTime.Now.Ticks);

        static public int Range(int min, int max)
        {
            rand = new Random(GetRandomSeed());
            return rand.Next(min, max + 1);
        }
        static public bool Happened(float value)
        {
            rand = new Random(GetRandomSeed());
            int result = rand.Next(0, 10000);
            value *= 100;
            if (result < value)
            {
                return true;
            }
            return false;
        }
        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        static public float RangeFloat(float min, float max)
        {
            rand = new Random(GetRandomSeed());
            return (float)(rand.NextDouble() * (max - min)) + min;
        }

        // 返回随机索引
        static public int RollBall(List<int> rateList)
        {
            int index = 0;
            int totalRange = 0;
            List<int> rangeList = new List<int>();
            for (int i = 0; i < rateList.Count; i++)
            {
                totalRange += rateList[i];
                rangeList.Add(totalRange);
            }
            int rate = Range(1, totalRange);
            for (int i = 0; i < rangeList.Count; i++)
            {
                if (i == 0 && rate <= rangeList[i])
                {
                    index = 0;
                    break;
                }
                else if (i > 0 && i < rangeList.Count - 1)
                {
                    if (rate > rangeList[i - 1] && rate <= rangeList[i])
                    {
                        index = i;
                        break;
                    }
                }
                else
                {
                    // 最后一个
                    index = i;
                }
            }
            return index;
        }
    }

    public static class NewRAND
    {
        public static int Next(int min, int max)
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            int randomNum = BitConverter.ToUInt16(bytes, 0);
            Random random = new Random(randomNum);
            return random.Next(min, max + 1);
        }
    }
}
