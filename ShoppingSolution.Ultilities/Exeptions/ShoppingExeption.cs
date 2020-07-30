using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.Ultilities.Exeptions
{
    public class ShoppingExeption : Exception
    {
        public ShoppingExeption()
        {
        }

        public ShoppingExeption(string message)
            : base(message)
        {
        }

        public ShoppingExeption(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
