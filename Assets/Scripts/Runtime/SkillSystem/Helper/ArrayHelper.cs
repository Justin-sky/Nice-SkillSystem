using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

public static class ArrayHelper 
{

    public static T Find<T>(T[] array, Func<T, bool> condition)
    {
        for(int i=0; i< array.Length; i++)
        {
            if (condition(array[i]))
            {
                return array[i];
            }
        }

        return default(T);
    }

    public static T[] FindAll<T>(T[] array, Func<T, bool> condition)
    {
        List<T> list = new List<T>();
        for (int i = 0; i < array.Length; i++)
        {
            if (condition(array[i]))
            {
                list.Add(array[i]);
            }
        }

        return list.ToArray(); ;
    }

    public static T GetMax<T, Q>(this T[] array,Func<T, Q> condition) where Q:IComparable
    {
        T max = array[0];
        for(int i=0; i < array.Length; i++)
        {
            if(condition(max).
                CompareTo(
                    condition(array[i])
                ) < 0)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static T GetMin<T, Q>(this T[] array, Func<T, Q> condition) where Q : IComparable
    {
        T min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (condition(min).
                CompareTo(
                    condition(array[i])
                ) > 0)
            {
                min = array[i];
            }
        }
        return min;
    }

    //升序
    public static T[] OrderBy<T, Q>(this T[] array, Func<T, Q> condition) where Q:IComparable
    {
        for(int i=0; i<array.Length-1; i++)
        {
            for(int j=0; j<array.Length - 1 -i; j++)
            {
                if (condition(array[j]).CompareTo(condition(array[j + 1])) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
    //降序
    public static T[] OrderDescding<T, Q>(this T[] array, Func<T, Q> condition) where Q : IComparable
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (condition(array[j]).CompareTo(condition(array[j + 1])) < 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }


    public static Q[] Select<T,Q>(this T[] array, Func<T,Q> condition)
    {
        Q[] result = new Q[array.Length];
        for(int i=0; i<array.Length; i++)
        {
            result[i] = condition(array[i]);
        }
        return result;
    }

}
