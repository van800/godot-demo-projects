#region

using System;
using System.Collections.Generic;

#endregion

namespace Test;

public static class ListExtension
{
    public static void Sort<T>(this IList<T> list, Comparison<T> comparison)
    {
        List<T> tempList = new(list);

        tempList.Sort(comparison);

        for (int i = 0; i < list.Count; i++)
        {
            list[i] = tempList[i];
        }
    }
}