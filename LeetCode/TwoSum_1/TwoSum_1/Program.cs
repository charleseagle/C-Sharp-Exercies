using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            Solution FindIndex = new Solution();
            Solution.TwoSum(nums, target);
            
            Console.WriteLine(Solution.TwoSum(nums, target));
            //Console.WriteLine(index2);
            Console.ReadLine();



        }
    }
    public class Solution
    {
        
        public int[] TwoSum(int[] nums, int target)
        {
            //var hashtable = new Dictionary<int, int>();
            int [] Index = new int[] { 0, 0};
            
            for (int index1 = 0; index1 < nums.Length - 1; index1++)
            {
                for (int index2 = index1 + 1; index2 < nums.Length; index2++)
                {
                    if (nums[index1] + nums[index2] == target)
                    {
                        //hashtable.Add(nums[index1], index1 + 1);
                        //hashtable.Add(nums[index2], index2 + 2);
                        Index[0] = (index1 + 1);
                        Index[1] = (index2 + 2);

                       
                    }

                }
            }
            return Index;
        }
    }
}
