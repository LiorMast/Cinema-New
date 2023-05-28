using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Cart
    {
        private Item[] items;
        private int currentIndex;

        public Cart()
        {
            items = new Item[10]; // Initial capacity of 10
            currentIndex = 0;
        }

        public void AddItem(Item item)
        {
            if (currentIndex == items.Length)
            {
                // Array is full, resize it
                Array.Resize(ref items, items.Length * 2);
            }

            items[currentIndex] = item;
            currentIndex++;
        }

        public void DeleteItem(Item item)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (items[i] == item)
                {
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }

                    items[currentIndex - 1] = null;
                    currentIndex--;
                    return;
                }
            }
            throw new Exception("Item not found in cart");
        }

        public Item[] GetItems()
        {
            return items;
        }

        public int GetItemCount()
        {
            return currentIndex;
        }

        public void ClearCart()
        {
            Array.Clear(items, 0, currentIndex);
            currentIndex = 0;
        }

        public Item GetItemByID(int id)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (items[i].GetID() == id)
                {
                    return items[i];
                }
            }

            return null;
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            try
            {
                for (int i = 0; i < currentIndex; i++)
                {
                    totalPrice += items[i].GetPrice();
                }
            }catch (Exception) {
            return 0;
            }

            return Math.Round(totalPrice,2);
        }
    }

}
