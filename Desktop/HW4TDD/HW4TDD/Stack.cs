﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4TDD
{
    public class Stack<T>
    {
        #region Members
        private T[] stackArray;
        private int maximumLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        #endregion

        public void Push(T value)
        {
            if (Size == maximumLength)
            {
                throw new ExceededSizeException();
            }
            else
            {
                stackArray[Size++] = value;
            }
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }
            else
            {
                return stackArray[--Size];
            }
        }

        public T Peek()
        {
            if(Size==0)
            {
                throw new ExpenditureProhibitedException();
            }
            else
            {
                return stackArray[Size - 1];
            }
        }
    }
}
