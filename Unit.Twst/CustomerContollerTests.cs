using Newtonsoft.Json.Bson;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Unit.Twst
{
    [TestFixture]
    public class CustomerContollerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            //Notfound
            Assert.That(result, Is.TypeOf<NotFound>());

            // Notfound or one if its derivatives
            Assert.That(result,Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var contorller = new CustomerController();

            var result = contorller.GetCustomer(3);

            Assert.That(result, Is.TypeOf<Ok>());
        }

    }
}
