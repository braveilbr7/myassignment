﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

    }
    public void useroutput()
    {

        Console.WriteLine($"number of uppercase letters is : {Ucount}");
        Console.WriteLine($"number of lowercase letters is : {Lcount}");

        Console.Write($" No.vowels : {vcount}");
        Console.Write($" No . of consonants : {ccount}");
        Console.Write($" no. other alphabets : {others}");
        Console.Write($" no of sentences : {scount}");

        input = input.Replace(input[0].ToString(), string.Empty);
    }
}
