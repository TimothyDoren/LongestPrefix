﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPrefix
{

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}

}