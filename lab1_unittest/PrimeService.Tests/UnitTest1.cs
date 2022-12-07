namespace Prime.Service.Tests;


public class Tests
{
    [OneTimeSetUp]
    public void init() {
        //Console.WriteLine("一次性的起動");
        TestContext.Progress.WriteLine("一次性的起動");
    }
    [OneTimeTearDown]
    public void finalize() {
        //Console.WriteLine("一次性的清除");
        TestContext.Progress.WriteLine("最後的清理");
    }
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("準備環境");
    }
    [TearDown]
    public void StoreData()
    {
        Console.WriteLine("清理環境, 儲存資料");
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("this is test1");
        Assert.Pass();
    }
    [Test]
    [Ignore("因為還沒寫好")]
    public void Test2()
    {
        Console.WriteLine("this is test2");
        Assert.Fail("這是意料中應該失敗的");
    }
}