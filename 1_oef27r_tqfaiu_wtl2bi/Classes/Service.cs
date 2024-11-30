using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oef27r_tqfaiu_wtl2bi.Classes
{
    public class Service
    {
        #region private:
        #region data members
        private string name = "";
        private int price;
        #endregion
        #endregion
        #region protected:

        #endregion
        #region public:
        #region get/set functions
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int value)
        {
            price = value;
        }
        #endregion
        #region class specific functions

        #endregion
        #endregion
    }
}
