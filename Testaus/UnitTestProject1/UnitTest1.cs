using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testaus.Utilities;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PäivämääräTestit()
        {
            //kelvollinen päivämäärä
            String syöte = "7.6.2018";
            DateTime tulos = DateParsing.ParseFinnishDate(syöte);
            DateTime odotettu = new DateTime(2018, 6, 7);
            Assert.AreEqual(odotettu, tulos);
        
       
            //karkauspäivämäärä
            syöte = "29.2.2016";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = new DateTime(2016, 2, 29);
            Assert.AreEqual(odotettu, tulos);

            //virheellien syöte
            syöte = "";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);


            //virheellien syöte 2
            syöte = null;
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);

            //virheellien pvm
            syöte = "7/6/2018";
            tulos = DateParsing.ParseFinnishDate(syöte);
            odotettu = DateTime.MinValue;
            Assert.AreEqual(odotettu, tulos);
        }

        [TestMethod]
        public void ViikkonumeroTestit()
        {
            DateTime pvm = new DateTime(2018, 6, 7);
            int tulos = DateParsing.GetWeekNumber(pvm);
            int odotettu = 23;
            Assert.AreEqual(odotettu, tulos);
        }

    }
}
