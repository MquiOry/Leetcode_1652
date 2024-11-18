using System;

namespace Leetcode_1652
{
    class Solution
    {
        public int[] Decrypt(int[] code, int k)
        {
            int[] clone = new int[code.Length];

            if(k > 0)
            {
                for(int i = 0; i < code.Length; i++)
                {
                    if(i + k < code.Length)
                    {
                        for (int j = i + 1; j <= i + k; j++)
                            clone[i] += code[j];
                    }
                    else
                    {
                        if(i == code.Length - 1)
                        {
                            for(int j = 0; j < k; j++)
                                clone[i] += code[j];
                        }
                        else
                        {
                            for (int j = i + 1; j < code.Length; j++)
                                clone[i] += code[j];

                            for(int g = 0; g < (k - (code.Length - (i + 1))); g++)
                                clone[i] += code[g];
                        }
                    }
                    
                }
            }
            else if(k == 0)
            {
                for(int i = 0; i < code.Length; i++)
                    clone[i] = 0;
            }
            else
            {
                for(int i = 0; i < code.Length; i++)
                {
                    if(i == 0)
                    {
                        for (int j = code.Length - 1; j > (code.Length - 1) + k; j--)
                            clone[i] += code[j];
                    }
                    else if(i + k >= 0)
                    {
                        for(int j = i - 1; j >= i + k; j--)     
                            clone[i] += code[j];
                    }
                    else
                    {
                        for(int j = i - 1; j >= 0; j--)
                            clone[i] += code[j];

                        for(int g = code.Length - 1; g >= code.Length - (Math.Abs(k) - i); g--)
                            clone[i] += code[g];
                    }
                }
            }
            
            clone.CopyTo(code, 0);

            return code;
        }
    }
}
