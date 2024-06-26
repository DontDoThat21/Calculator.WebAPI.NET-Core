using Calculator.WebAPI.NET.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WebAPI.NET.Infrastructure.Services
{
    public class NumberStore : INumberStore
    {
        private readonly Dictionary<string, (int? First, int? Second)> _store = new Dictionary<string, (int? First, int? Second)>();

        public void StoreNumber(int number, string location, int position)
        {
            if (!_store.ContainsKey(location))
            {
                _store[location] = (null, null);
            }

            var currentNumbers = _store[location];
            if (position == 1)
            {
                _store[location] = (number, currentNumbers.Second);
            }
            else if (position == 2)
            {
                _store[location] = (currentNumbers.First, number);
            }
        }

        public void ClearNumbers(string location)
        {
            if (_store.ContainsKey(location))
            {
                _store[location] = (null, null);
            }
        }

        public (int? First, int? Second) GetNumbers(string location)
        {
            return _store.ContainsKey(location) ? _store[location] : (null, null);
        }
    }
}
