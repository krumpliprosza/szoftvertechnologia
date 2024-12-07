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
        private string id;
        private string name = "";
        private string telNo = "";
        private string licenseNo = "";
        private string brandName = "";
        private string tyreName = "";
        private string tquantity = "";
        private string sName = "";
        private string squantity = "";
        private string endDate = "";
        private string totalPrice = "";
        #endregion
        #endregion
        #region protected:

        #endregion
        #region public:
        #region constructors:
        public Order() { }

        public Order(string id) {  this.id = id; }

        public Order(string id,string name,string telNo,string licenseno,string brandName,
            string tyreName,string tquantity,string sName, string squantity,string endDate, string totalPrice)
        {
            this.id = id;
            this.name = name;
            this.telNo = telNo;
            this.licenseNo = licenseno;
            this.brandName = brandName;
            this.tyreName= tyreName;
            this.tquantity = tquantity;
            this.sName= sName;
            this.squantity = squantity;
            this.endDate = endDate;
            this.totalPrice = totalPrice;
        }
        #endregion
        #region get/set functions

        public string getEnddate() { return endDate; }

        public void setEndDate(string endDate) {  this.endDate = endDate; }

        public string getTotalPrice() { return totalPrice; }

        public void setTotalPrice(string totalPrice) { this.totalPrice = totalPrice; }

        public string getSname() { return sName; }
        public void setSname(string sName) {  this.sName = sName; }

        public string getSquantity() {  return squantity; }
        public void setSquantity(string squantity) { this.squantity = squantity; }

        public string getBrandName() {  return brandName; }

        public void setBrandName(string brandName) {  this.brandName = brandName; }

        public string getTyreName() { return tyreName; }

        public void setTyreName(string tyreName) { this.tyreName = tyreName; }

        public string getTquantity() { return tquantity; }

        public void setTquantity(string tquantity) { this.tquantity= tquantity; }

        public string GetId()
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

        public string GetLicenseNo() { return licenseNo; }

        public void SetLicenseNo(string value)
        {
            licenseNo = value;
        }
        #endregion
        #region class specific functions

        #endregion
        #endregion
    }
}

