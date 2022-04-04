
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Diagnostics;

public class UnitTests
{
    private TestContext testContextInstance;
    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    ///
    [SetUp]
    public void Setup()
    {

    }

    public TestContext TestContext
    {
        get
        {
            return testContextInstance;
        }
        set
        {
            testContextInstance = value;
        }
    }

    [Test]
    public void TestTiming()
    {
        var watch = Stopwatch.StartNew();

        int count = AutograderService.GetAllCountInArray();

        watch.Stop();

        long time = watch.ElapsedMilliseconds;
        var timeMillisecs = new Data().TIME;

        Assert.LessOrEqual(timeMillisecs, time);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Equals(TestStatus.Failed))
        {
            // Your test failed, handle it
        }
        else
        {
            // Your test success, handle it
        }
    }

    [Test]
    public void TestingIfValid()
    {
        int count = AutograderService.GetAllCountInArray();

        Assert.AreEqual(count, 11);
    }
}