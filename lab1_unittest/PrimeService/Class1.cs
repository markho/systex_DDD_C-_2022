using System;
namespace Prime.Service;
public class PrimeService
{
    public bool IsPrime(int candidate) {
        if (candidate==1) {
            return false;
        }
        if (candidate==2) {
            return true;
        }
        throw new NotImplementedException("not yet implement");
    }

}
