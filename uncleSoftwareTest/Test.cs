using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace uncleSoftwareTest
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver = new FirefoxDriver();       
        
       
        [Test]
        public void kurumsalKayitOlma()
        {
            //Anasayfaya gidiyoruz
            driver.Navigate().GoToUrl("http://unclesoftware.com/");

            //kayıt ol butonuna tıklıyoruz
            driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / ul / li[1] / a")).Click();
            System.Threading.Thread.Sleep(1000);

            //ad soyad giriyoruz
            driver.FindElement(By.Name("name")).SendKeys("TestAd TestSoyad");
            System.Threading.Thread.Sleep(1000);
            //mail adresi giriyoruz
            driver.FindElement(By.Name("mail")).SendKeys("testMail@hotmail.com");
            System.Threading.Thread.Sleep(1000);
            //şifre giriyoruz
            driver.FindElement(By.Name("password")).SendKeys("123456");
            System.Threading.Thread.Sleep(1000);
            //kurumsal hesap radio butonunu tıklıyoruz
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/div[4]/label[2]")).Click();
            System.Threading.Thread.Sleep(3000);
            //hesap oluştur butonuna tıklıyoruz
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000);


            /*
             1.kullanıcı adı
             2.kullanıcı telefon
             3.şirket adı
             4.şirket telefonu
             5.kuruluş tarihi
             6.şirket hakkında
             7.şirket mail
             8.şirket web sayfası
             */
            driver.FindElement(By.Name("nick")).SendKeys("testuser");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("phoneUser")).SendKeys("2321234567");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("companyName")).SendKeys("testCompanyName");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("phoneCompany")).SendKeys("2329876543");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("companyDate")).SendKeys("2018-12-04");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("companyAbout")).SendKeys("Test amaçlı oluşturulmuştur");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("companyMail")).SendKeys("test@testcompany.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("companyWeb")).SendKeys("testcompany.com");
            System.Threading.Thread.Sleep(1000);


            //
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/a")).Click();
            Assert.Pass("kurumsal kayıt olma başarılı");
        }
        [Test]
        public void sifreHatirlatma()
        {
            //Anasayfaya gidiyoruz
            driver.Navigate().GoToUrl("http://unclesoftware.com/");
            System.Threading.Thread.Sleep(2000);
            //giriş butonuna tıklıyoruz
            driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / ul / li[2] / a")).Click();
            System.Threading.Thread.Sleep(2000);
            //şifremi unuttum tıklıyoruz
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/div[3]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            //mail adresini gönderiyoruz           
            driver.FindElement(By.Name("email")).SendKeys("testMail@hotmail.com");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[2]/form/div[3]/a")).Click();
            Assert.Pass("kurumsal kayıt olma başarılı");

        }

        [Test]
        public void FirmaAdiDuzeltme()
        {
            //Anasayfaya gidiyoruz
            driver.Navigate().GoToUrl("http://unclesoftware.com/");
            System.Threading.Thread.Sleep(2000);
            //Giriş butonuna tıklıyoruz
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            //Kullanıcı adı ve şifreyi giriyoruz
            driver.FindElement(By.Name("emailorname")).SendKeys("testMail@hotmail.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("123456");
            System.Threading.Thread.Sleep(1000);
            //Giriş yapma butonuna tıklanıyor
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            //Kullanıcı menüsü açılıyor
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[6]/a")).Click();
            System.Threading.Thread.Sleep(1000);
            // Kullanıcı adı altından ayarla seçeneği tıklanıyor
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[6]/ul/li[6]/a")).Click();
            System.Threading.Thread.Sleep(6000);
            //Firma bilgiler sekmesi tıklanıyor
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/ul/li[3]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            //Firma formunda kullanıcı adının sonuna Changed ekleniyor
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/div[2]/table/tbody/tr[1]/td[2]/div/input")).SendKeys("Changed");
            System.Threading.Thread.Sleep(2000);
            //Değişiklikleri kaydet butonuna tıklanıyor
            driver.FindElement(By.Name("company_form")).Click(); // burada kullanıcı adı veya eposta ile giriş için bilgiler gönderiliyor textboxa
            System.Threading.Thread.Sleep(2000);
            Assert.Pass("Firma İsim değişikliği başarılı");
        }





    }
}
