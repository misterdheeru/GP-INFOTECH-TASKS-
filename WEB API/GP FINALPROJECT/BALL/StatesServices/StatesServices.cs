using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALL.StatesServices
{
    public class StatesServices
    {
        public readonly DALL.States.StatesCrud _states;
        public StatesServices()
        {

            _states = new DALL.States.StatesCrud();

        }

        public List<DALL.States.States> GetAllCountryList()
        {
            var res = _states.GetAll().ToList();

            return res;
        }
    }
}
