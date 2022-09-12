namespace Library.Tests;
using NUnit.Framework;
using TestDateFormat;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatOK()
    {
        string testDate = "10/11/1997";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), "1997-11-10");
    }

    [Test]
    public void FormatNotOK()
    {
        string testDate = "1997/11/10";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), " - - ");
    }

    [Test]
    public void DateEnBlanco()
    {
        string testDate = "";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), " - - ");
    }
}