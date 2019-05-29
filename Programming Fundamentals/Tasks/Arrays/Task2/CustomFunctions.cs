using System;
using System.Linq;

namespace CustomFunctions
{
    public class ArrayRelated
    {
        /// <summary>
        /// Returns an array of certain type, the way Array.Reverse() should've been.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[] Reverse(int[] array, int index, int size)
        {
            Array.Reverse(array, index, size);
            return (int[])array;
        }
        public static string[] Reverse(string[] array, int index, int size)
        {
            Array.Reverse(array, index, size);
            return (string[])array;
        }
        public static double[] Reverse(double[] array, int index, int size)
        {
            Array.Reverse(array, index, size);
            return (double[])array;
        }
    }
}
