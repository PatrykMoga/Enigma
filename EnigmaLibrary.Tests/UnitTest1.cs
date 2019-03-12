using Autofac;
using EnigmaLibrary;
using EnigmaLibrary.Decoding;
using NUnit.Framework;

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
                var result = app.Decode("AAAAAAAAAAAAAAAAAAAAA");
                Assert.That(result, Is.EqualTo("BDZGOWCXLTKSBTMCDLPBM"));
            }                       
        }

        [Test]
        public void Test2()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IDecodingProcessor>();
                var result = app.Decode("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                Assert.That(result, Is.EqualTo("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHE"));
            }
        }

        [Test]
        public void Test3()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IDecodingProcessor>();
                var result = app.Decode("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                Assert.That(result, Is.EqualTo("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHN"));
            }
        }

        [Test]
        public void Test4()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IDecodingProcessor>();
                var result = app.Decode("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                Assert.That(result, Is.EqualTo("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKOVHCBUBTZSZSOOSTGOTFSODBBZZLXLCYZXIFGWFDZEEQIBMGFJBW"));
            }
        }

        [Test]
        public void Test5()
        {
            var container = Container.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IDecodingProcessor>();
                var result = app.Decode("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                Assert.That(result, Is.EqualTo("BDZGOWCXLTKSBTMCDLPBMUQOFXYHCXTGYJFLINHNXSHIUNTHEORXPQPKOVHCBUBTZSZSOOSTGOTFSODBBZZLXLCYZXIFGWFDZEEQIBMGFJBWZFCKPFMGBXQCIVIBBRNCOCJUVYDKMVJPFMDRMTGLWFOZLXGJEYYQPVPBWNCKVKLZTCBDLDCTSNRCOOVPTGBVBBISGJSOYHDENCTNUUKCUGHREVWBDJCTQXXOGLEBZMDBRZOSXDTZSZBGDCFPRBZYQGSNCCHGYEWOHVJBYZGKDGYNNEUJIWCTYCYTUUMBOYVUNNQUKKSOBSCORSUOSCNVROQLHEUDSUKYMIGIBSXPIHNTUVGGHIFQTGZXLGYQCNVNSRCLVPYOSVRBKCEXRNLGDYWEBFXIVKKTUGKPVMZOTUOGMHHZDREKJHLEFKKPOXLWBWVBYUKDTQUHDQTREVRQJMQWNDOVWLJHCCXCFXRPPXMSJEZCJ"));
            }
        }
    }
}