using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_oef27r_tqfaiu_wtl2bi.Classes
{
    public class Worker
    {
        #region private:
        #region data members
        private string username = "";
        private string password = "";
        private int role;
        private string value1;
        private string value2;
        private int v;

        public Worker() { }
        public Worker(string username, string password, int role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        #endregion
        #endregion
        #region protected:

        #endregion
        #region public:
        #region get/set functions
        public string GetUserame() {
            return username;
        }
        public void SetUsername(string value) {
            username = value;
        }
        public string GetPassword() {
            return password;
        }
        public void SetPassword(string value) {
            password = value;
        }
        public int GetRole()
        {
            return role;
        }
        public void SetRole(int value)
        {
            role = value;
        }
        #endregion
        #region class specific functions

        #endregion
        #endregion
    }
}
