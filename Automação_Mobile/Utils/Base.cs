using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação_SkySales.Utils
{
    public abstract class Base
    {

        protected IWebDriver driver
        {
            get
            {
                return HooksTest.driver;
            }
        }


        public void clicarElemento(By element)
        {
            driver.FindElement(element).Click();
        }

        public void preencherTexto(By element, string texto)
        {
            driver.FindElement(element).SendKeys(texto);
        }

        public void validarPreenchimento(string texto)
        {
            bool preencheuTexto = driver.PageSource.Contains(texto);
            Assert.IsTrue(preencheuTexto);
        }

        public void calendario()
        {
            DateTime dataViagem = DateTime.Now.AddDays(3);
            string strDataViagem = dataViagem.Day.ToString();

            DateTime dataViagemVolta = DateTime.Now.AddDays(5);
            string strDataViagemVolta = dataViagemVolta.Day.ToString();

            IWebElement dataIda = driver.FindElement(By.Id("dateIda"));
            dataIda.Click();

            IWebElement dateComponente = driver.FindElement(By.ClassName("ui-datepicker-calendar"));


            IList<IWebElement> colunas = dateComponente.FindElements(By.TagName("td"));

            foreach (IWebElement celula in colunas)
            {
                if (celula.Text.Equals(strDataViagem))
                {
                    celula.Click();
                    break;
                }
            }

            IWebElement dataVolta = driver.FindElement(By.Id("dateVolta"));
            dataVolta.Click();

            IWebElement dateComponenteVolta = driver.FindElement(By.ClassName("ui-datepicker-calendar"));


            IList<IWebElement> colunasVolta = dateComponenteVolta.FindElements(By.TagName("td"));

            foreach (IWebElement celula in colunasVolta)
            {
                if (celula.Text.Equals(strDataViagemVolta))
                {
                    celula.Click();
                    break;
                }
            }
        }
    }
}
