﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MajdQadhi.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ( ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 4)) || ((x >= 6) && (x <= 9) && (y >= 5) && (y <= 10)) || ((x >= 2) && (x <= 5) && (y >= 7) && (y <= 7)) || ((x >= 3) && (x <= 6) && (y >= 11) && (y <= 11)) || ((x >= 7) && (x <= 7) && (y >= 11) && (y <= 12)) || ((x >= 9) && (x <= 9) && (y >= 3) && (y <= 4)) || ((x >= 11) && (x <= 12) && (y >= 5) && (y <= 7)) || ((x >= 10) && (x <= 13) && (y >= 8) && (y <= 8)) || ((x >= 10) && (x <= 12) && (y >= 9) && (y <= 10)) || ((x >= 11) && (x <= 12) && (y >= 11) && (y <= 11))  )
            {
                res = true;
            }
            else 
            {
                res = false;
            }
            return res;
        }
    }
}
//bool res;

//if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 13))
//{
//    res = true;
//}
//else
//{
//    res = false;
//}
//return res;
