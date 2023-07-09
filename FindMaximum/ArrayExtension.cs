﻿using System;

namespace FindMaximumTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value recursively.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int FindMaximum(int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            return FindMaxValueRecursive(array, 0, array.Length - 1);
        }

        private static int FindMaxValueRecursive(int[]? array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (start == end)
            {
                return array[start];
            }

            int mid = (start + end) / 2;
            int leftMax = FindMaxValueRecursive(array, start, mid);
            int rightMax = FindMaxValueRecursive(array, mid + 1, end);
            return Math.Max(leftMax, rightMax);
        }
    }
}
