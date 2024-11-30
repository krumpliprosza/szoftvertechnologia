using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oef27r_tqfaiu_wtl2bi.Classes
{
    internal class Order
    {
        #region private:
        #region data members
        private int id;
        private string name = "";
        private string telNo = "";
        #endregion
        #endregion
        #region protected:

        #endregion
        #region public:
        #region get/set functions
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetTelNo()
        {
            return telNo;
        }
        public void SetTelNo(string value)
        {
            telNo = value;
        }
        #endregion
        #region class specific functions

        #endregion
        #endregion
    }
}

