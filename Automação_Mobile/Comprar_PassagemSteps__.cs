using System;
using TechTalk.SpecFlow;

namespace Automação_Mobile
{
    [Binding]
    public class Comprar_PassagemSteps
    {
        [Given(@"que esteja logado no app ""(.*)"" ""(.*)""")]
        public void DadoQueEstejaLogadoNoApp(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
