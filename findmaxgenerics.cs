﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testmaximumproblem
{
    public class findmaxgenerics<T> where T : IComparable
    {
        public static T MaximumNum<T>(T FirstValue, T SecondValue, T ThirdValue) where T : IComparable
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
               FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
               FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
            { return FirstValue; }

            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
              SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
               SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
            { return SecondValue; }

            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
              ThirdValue.CompareTo(FirstValue) >= 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
              ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
            { return ThirdValue; }


            return FirstValue;
        }
    }
}
