using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.CountryServices
{
    public class CountryServices
    {
        public readonly DALL.Country.CountrysCrud _country;
        public CountryServices()
        {

            _country = new DALL.Country.CountrysCrud();

        }

        public List<DALL.Country.Country> GetAllCountryList()
        {
            var res = _country.GetAll().ToList();

            return res;
        }
    }
}
