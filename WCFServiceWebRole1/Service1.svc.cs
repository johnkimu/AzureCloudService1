using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private TempModel dbData = new TempModel();
        //private List<Temp> fakedb = new List<Temp>();

        //public Service1()
        //{
        //    SeedFakeDB();
        //}

        public List<Temp> GetTemp()
        {
            // return fakedb;
            return dbData.Temps.ToList();
        }

        public Temp FindTemp(string id)
        {
            int tempID = Int32.Parse(id);
            return dbData.Temps.FirstOrDefault(w => w.Id == tempID);
        }

        public void PostTemp(int temp)
        {
            Temp newTemp = new Temp();
            newTemp.Temparature = temp;
            newTemp.TimeStamp = DateTime.Now;
            dbData.Temps.Add(newTemp);
            dbData.SaveChanges();

        }

        //public void SeedFakeDB()
        //{
        //    Temp one = new Temp();
        //    Temp two = new Temp();
        //    Temp three = new Temp();

        //    one.Id = 1;
        //    two.Id = 2;
        //    three.Id = 3;

        //    one.Temparature = 11;
        //    two.Temparature = 22;
        //    three.Temparature = 33;

        //    one.TimeStamp = DateTime.Now;
        //    two.TimeStamp = DateTime.Now.AddDays(1);
        //    three.TimeStamp = DateTime.Now.AddDays(1.3);

        //    fakedb.Add(one);
        //    fakedb.Add(two);
        //    fakedb.Add(three);
        //}
    }
}
