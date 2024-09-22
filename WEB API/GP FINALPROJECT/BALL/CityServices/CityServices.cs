using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.CityServices
{
    public class CityServices
    {
        public readonly DALL.City.CityCrud _city;
        public CityServices()
        {

            _city = new DALL.City.CityCrud();

        }

        public List<DALL.City.City> GetAllCountryList()
        {
            var res = _city.GetAll().ToList();

            return res;
        }

    }
}
