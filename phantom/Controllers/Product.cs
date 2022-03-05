using phantom.Models;
using System;

namespace phantom.Controllers
{
    internal class Product
    {
        public static implicit operator Product(Project v)
        {
            throw new NotImplementedException();
        }
    }
}