using System;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float together = 0;
            int times = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                together += nums[i];
                times++;
            }
            return (together / times);
        }
    }
}
