using gp_DALL.Models;
using gp_DALL.Repository;
using System.Collections.Generic;
using System.Linq;


namespace gp_BALL.ServicesRepository
{
    public class CountrysServicesRepository
    {

        CountriesRepository objdall = new CountriesRepository();
        public List<Countrys> AllCountries()
        {
            return objdall.GetAllCountrys().ToList();
        }

        public int insertCountryRecord(Countrys obj)
        {
            int i = objdall.InsertRecord(obj);

            return i;
        }

        public int updatedCountryRecord(int ID, Countrys obj)
        {
            int i = objdall.UpdateCountrys(ID, obj);

            return i;
        }
        public int DeleteCountryRecord(int ID)
        {
            int i = objdall.DeleteCountrys(ID);

            return i;
        }
        public List<Countrys> SingleCountrys(int ID)
        {
            return objdall.GetSingleCountry(ID).ToList();

        }
    }
}
