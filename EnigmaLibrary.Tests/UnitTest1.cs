using NUnit.Framework;
using EnigmaLibrary;
using Autofac;

namespace Tests
{
    public class Tests
    {      
        [Test]
        public void Test1()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IDecodingProcessor>();
                var result = app.Decode("barbara");
                Assert.That(result, Is.EqualTo("ADXCOTC"));
            }                       
        }
    }
}