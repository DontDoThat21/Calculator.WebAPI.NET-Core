using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WebAPI.NET.Core.Interfaces
{
    public interface INumberStore
    {
        void StoreNumber(int number, string location, int position);
        void ClearNumbers(string location);
        (int? First, int? Second) GetNumbers(string location);
    }
}
