using System;
using System.Collections.Generic;

namespace Exam
{
    public delegate void DelegBook(string message);

    internal class BookEvent
    {
        public event DelegBook BookCheck;

        public void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

        public void RaiseEvent(string mes)
        {
            DelegBook bookDelegate = BookCheck;
            if (bookDelegate != null)
            {
                bookDelegate(mes);
            }
        }
    }
}

