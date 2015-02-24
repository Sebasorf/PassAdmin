using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Security.Cryptography;

namespace BR
{
    public class Accounts
    {
        //Methods must be Static for GUI calling


        public static string GetUserData()
        {
            //Must encrypt data before sending to MySQL database
            //Key created ramdonmly Ffvsb91UtJQDFcnUm630nF4ndcvHt1i3HEaTazzDqss=	
            /*
             * La idea es que yo acá encripte los datos, los mande al server encriptados,
             * si se puede el server los decripte por ahi hardcodeando los keys
             * y los guarde en texto plano, cuando yo los consulte los encripte y los mande
             * sino de ultima los encripto aca, guardo encriptado y los desencripto y los desencripto aca.

        }

        public static string GetPassData()
        {
            //Must encrypt data before sending to MySQL database
        }

        public static ArrayList GetAccountsData()
        {
            //Must encrypt data before sending to MySQL database
        }

        public static void SetUserData()
        {

        }

        public static void SetUserData()
        {

        }

        public static void SetAccountsData()
        {

        }

        public static void ModUserData()
        {

        }

        public static void ModPassData()
        {

        }

        public static void ModAccountData()
        {

        }
    }
}
