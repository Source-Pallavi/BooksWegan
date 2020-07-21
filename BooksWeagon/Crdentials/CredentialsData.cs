using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWeagon.NewFolder1
{
   public class CredentialsData
    {
        public string email = "";
        public string password = "";
        public string Gemail = "";
        public string Gpassword = "";
        public string json = "";

        public CredentialsData()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\rebel\source\repos\BooksWeagon\BooksWeagon\Crdentials\data.json"))
            {
                json = r.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(json);
            Console.WriteLine("Array:" + array["email"]);
            email = array["email"];
            password = array["password"];
            Gemail = array["Gemail"];
            Gpassword = array["Gpassword"];
        }
    }
}

