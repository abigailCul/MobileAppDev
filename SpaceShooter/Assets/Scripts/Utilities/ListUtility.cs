using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities
{
    public class ListUtility
    {
        // method that shuffles a list into a stack
        // CreateShuffleStack
        public static Stack<T> CreateShuffledStack<T>(IList<T> values) where T : Object
        {
            var stack = new Stack<T>();
            var list = new List<T>(values);
            while(list.Count > 0)
            {
                var randomIndex = Random.Range(0, list.Count - 1);
                var randomItem = list[randomIndex];
                list.RemoveAt(randomIndex);
                stack.Push(randomItem);
            }
            return stack;
        }
    }
}