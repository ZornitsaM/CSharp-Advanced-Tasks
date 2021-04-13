﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
         where T : IComparable
    {
        public Box()
        {
            this.Values = new List<T>();
        }

        public List<T> Values { get; set; }
        public int GreaterValueThan(T targetItem)
        {
            int counter = 0;
            foreach (var item in this.Values)
            {
                if (item.CompareTo(targetItem) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void Swap(int a, int b)
        {
            bool isInRange = a >= 0 && a < this.Values.Count && b >= 0 && b < this.Values.Count;

            if (!isInRange)
            {
                throw new InvalidOperationException();
            }
            T tempValue = this.Values[a];
            this.Values[a] = this.Values[b];
            this.Values[b] = tempValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
