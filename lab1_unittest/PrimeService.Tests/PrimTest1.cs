namespace Prime.Service.Tests;

[TestFixture]
public class PrimeTest1
{

    private PrimeService primeService = null!;
    [OneTimeSetUp]
    public void prepare() {
        primeService = new PrimeService();
    }
    [Test]
    public void test1()
    {
        
        bool result = primeService.IsPrime(1);
        Assert.IsFalse(result, "1 should not be a prime");
    }
    [Test]
    public void test2()
    {
        bool result = primeService.IsPrime(2);
        Assert.IsTrue(result, "2 should be a prime");
    }
}