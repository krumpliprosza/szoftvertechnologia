using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_oef27r_tqfaiu_wtl2bi.Classes
{
    public class Tyre
    {
        #region private:
        #region data members
        private int id;
        private string name = "";
        private string brand = "";
        private string season = "";
        private int profileWidth;
        private int profileRatio;
        private int diameter;
        private int loadIndex;
        private string speedIndex = "";
        private int price;
        private int quantity;
        private string location = "";
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
        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string value)
        {
            brand = value;
        }
        public string GetSeason()
        {
            return season;
        }
        public void SetSeason(string value)
        {
            season = value;
        }
        public int GetProfileWidth()
        {
            return profileWidth;
        }
        public void SetProfileWidth(int value)
        {
            profileWidth = value;
        }
        public int GetProfileRatio()
        {
            return profileRatio;
        }
        public void SetProfileRatio(int value)
        {
            profileRatio = value;
        }
        public int GetDiameter()
        {
            return diameter;
        }
        public void SetDiameter(int value)
        {
            diameter = value;
        }
        public int GetLoadIndex()
        {
            return loadIndex;
        }
        public void SetLoadIndex(int value)
        {
            loadIndex = value;
        }
        public string GetSpeedIndex()
        {
            return speedIndex;
        }
        public void SetSpeedIndex(string value)
        {
            speedIndex = value;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int value)
        {
            price = value;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int value)
        {
            quantity = value;
        }
        public string GetLocation()
        {
            return location;
        }
        public void SetLocation(string value)
        {
            location = value;
        }
        #endregion
        #region class specific functions

        #endregion
        #endregion
    }
}
