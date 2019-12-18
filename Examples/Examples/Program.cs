using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        //soru1
        public static int maxDifference(List<int> nums)
        {
            int maxSayi = nums[0];
            int index = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (maxSayi < nums[i])
                {
                    maxSayi = nums[i];
                    index = i;
                }


            }

            //index numarası 0 olan sayının maksimum sayı olup olmadığı kontrol edilir.
            if (index == 0)
            {
                nums.Remove(maxSayi);
                maxSayi = nums.Max();
                index = nums.IndexOf(maxSayi);
            }

            int minSayi = nums[0];
            for (int i = 1; i < index; i++)
            {
                if (nums[i] < minSayi)
                {
                    minSayi = nums[i];
                }
            }
            int fark = maxSayi - minSayi;
            if (fark == 0) return -1;
            return fark;
        }
        //soru2
        public static string firstRepeatedWord(string s)
        {
            string word = "";
            string[] dizi = s.Split(',', ':', ';', '-', '.', ' ');
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        word = dizi[i];
                        return word;
                    }
                }
            }
            return word;
        }
        static void Main(string[] args)
        {
            //soru1
            int numsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> nums = new List<int>();

            for (int i = 0; i < numsCount; i++)
            {
                int numsItem = Convert.ToInt32(Console.ReadLine().Trim());
                nums.Add(numsItem);
            }

            int result = maxDifference(nums);
            Console.WriteLine(result);
            Console.ReadKey();
            //soru2
            //string result = firstRepeatedWord("örnek cümle örnek");
            //Console.Write(result);
            //Console.ReadKey();
        }
    }
}
