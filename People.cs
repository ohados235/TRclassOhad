using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRclassOhados
{
    //
    internal class People
    {
        private string id;
        private string telephone;
        private string adress;
        private string name;

        public People() { }
        public People(string id,string telphone,string adress,string name)
        {
          this.id = id;
          this.telephone = telphone;
          this.adress = adress;
          this.name = name;
        }


        //get 

        public string getId() { return id; }
        public string getTelephone() {  return telephone; }
        public string getAdress() {  return adress; }
        public string getName() { return name; }
        //set

        public void SetID(string id) { this.id = id;}
        public void SetTelephone(string telephone) { this.telephone = telephone;}
        public void SetAdress(string adress) { this.adress  =adress;}
        public void SetName(string name) { this.name = name;}


        //פעולות שונות

       
        //הדפסה כללית
        public override string ToString()
        {
            return this.id + " ," + this.telephone + " ," + this.adress + ", " + this.name;
        }

        //הדפסת כתובת
        public string PrintNameAdress()
        {
           
            return this.adress + " ," + this.name;
        }




    }
}
