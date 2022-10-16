/*Collections

3. Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products*/


using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    class Products
    {
        int Productid;
        string ProductName;
        int Price;
    }

    public static void Main()
    {
        SortedList slist = new SortedList();
        slist.Add("5000", "Realme");
        slist.Add("5500", "Poco");
        slist.Add("20000", "Iphone");
        slist.Add("6500", "Vivo");
        slist.Add("7000", "Samsung");
        slist.Add("7500", "Mi");
        slist.Add("10000", "Oppo");
        slist.Add("8000", "Motorola");
        slist.Add("6000", "Infinix");
        slist.Add("7400", "Narzo");

        foreach (DictionaryEntry d in slist)
        {
            Console.Write(d.Key + " " + d.Value);
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
