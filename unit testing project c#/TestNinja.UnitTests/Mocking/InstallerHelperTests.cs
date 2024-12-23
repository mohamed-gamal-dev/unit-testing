using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    internal class InstallerHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallerHelper _installerHelper;
        [SetUp]
        public void Setup()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_fileDownloader.Object);
        }
        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFlase()
        {
            // you should not pass parameters lik ("","") to download file function it will not work
            /*
             you can write this code
            (
            _fileDownloader.Setup(w=>w.DownloadFile("http://example.com/customr/installer", null)).Throws<WebException>();
            ) 
            or another code below
             */

            // Arrange
            _fileDownloader.Setup(w=>w.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

            // Act
            var result = _installerHelper.DownloadInstaller("customer", "installer");

            // Assert
            Assert.That(result,Is.False);
        }

        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnTrue()
        {
            var result = _installerHelper.DownloadInstaller("customer", "installer");
            Assert.That(result, Is.True);

        }
    }
}
