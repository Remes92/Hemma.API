using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hemma.PersonInformationTest
{
    [TestClass]
    public class PersonInformationTest
    {
        [TestMethod]
        public void PersonTests()
        {
            var p = Hemma.PersonInformation.Business.Person.GetPerson.GetAllPersons();
            Assert.IsNull(p);

        }
    }
}
