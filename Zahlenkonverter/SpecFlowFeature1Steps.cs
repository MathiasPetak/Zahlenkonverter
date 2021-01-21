using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Zahlenkonverter
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private string number;
        private int result;
        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(string p0)
        {
            number = "affe";
        }
        
        [When(@"the conversion is hexadecimal")]
        public void WhenTheConversionIsHexadecimal()
        {
            result = System.Convert.ToInt32(number, 16);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
