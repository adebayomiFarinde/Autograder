using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Data
{
    public static List<int> AllList()
    {
        return new List<int>
        {
            23, 45, 67, 85, 12, 67, 98, 23, 45, 12, 65
        };
    }

    public double TIME = TimeSpan.FromMinutes(0.0000000000000000001).TotalMilliseconds;
}
