using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Product
    {
        internal string Name { get; set; }
        internal double Price { get; set; }
        internal DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .Append($"{String.Join(string.Empty, Name.Select(x => Name.IndexOf(x) == 0 ? char.ToUpper(x) : char.ToLower(x)))};")
                .Append($"{String.Format("{0:C}", Price)};")
                .Append($"{ExpirationDate.ToString("yyyy-MM-dd")}")
                .ToString();
        }
    }
}
