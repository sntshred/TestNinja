using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestNinja.Mocking;

namespace Unit.Twst.Mocking
{
    [TestFixture]
    public class VideoServiceTest
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _service;

        [SetUp]
        public void Setup()
        {
            //Mock look, this is defined in the mock name space and this is a generic class. So, we specify the generic argument 
            // in this case IFileReader.So we're telling the Moq library we want an object that implements, this IFileReader interface, okay? 
            _fileReader = new Mock<IFileReader>();
            //So this is the actual object that implements IFileReader.
            // Okay? Now when you use mocks

            _service = new VideoService(_fileReader.Object);
        }
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            
            var result = _service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
