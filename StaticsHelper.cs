using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StaticsHelper
    {
        public static float GetAvarageGrade(Students[] students)
        {  
            float avarage = default;
            int sum = default;
            foreach (var item in students)
            {   
                sum += item.Grade;
                avarage = sum/students.Length;
                
            }
            return avarage;

        }

        
    }
}
