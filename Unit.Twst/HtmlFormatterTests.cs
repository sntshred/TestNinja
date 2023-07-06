﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Unit.Twst
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement() 
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            // more general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

        }
    }
}
