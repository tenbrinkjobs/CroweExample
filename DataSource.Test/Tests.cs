using NUnit.Framework;
using Autofac;
using DataSource;
using Contract;

namespace DataSource.Test
{
    public class Tests
    {
        private TestLogger _logger;
        [SetUp]
        public void Setup()
        {
            _logger = new TestLogger();
        }

        [Test]
        public void TestData()
        {
            var source = new DisplayStringDataSource(_logger);
            Assert.AreEqual(source.GetDisplayString(), "Hello World");
        }
    }
}