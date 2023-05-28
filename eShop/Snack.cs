using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Snack : Item
    {
        public enum SnackType
        {
            Popcorn,
            Chips,
            Nachos
        }

        public enum SnackSize
        {
            Small,
            Medium,
            Large
        }

        private SnackType type;
        private SnackSize size;

        public Snack(SnackType type, SnackSize size, double price)
            : base(price)
        {
            SetSnackSize(size);
            SetSnackType(type);
        }

        public SnackType GetSnackType()
        {
            return type;
        }

        public void SetSnackType(SnackType newType)
        {
            if (Enum.IsDefined(typeof(SnackType), newType))
            {
                type = newType;
            }
            else
            {
                throw new Exception("Invalid snack type.");
            }
        }

        public SnackSize GetSnackSize()
        {
            return size;
        }

        public void SetSnackSize(SnackSize newSize)
        {
            if (Enum.IsDefined(typeof(SnackSize), newSize))
            {
                size = newSize;
            }
            else
            {
                throw new Exception("Invalid snack size.");
            }
        }
        //add a ToString method to print out the snack type and size and the price
        public override string ToString()
        {
            return $"{type} {size} {base.price}";
        }
        

    }

}
