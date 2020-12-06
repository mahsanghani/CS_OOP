using System;

// Possibilities of T
// where T : IComparable
// where T : Book (class name)
// where T : struct (value type)
// where T : class (reference type)
// where T : new()  (object that has default constructor)

namespace practice.advanced.generics
{
    public class DiscountBook<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
