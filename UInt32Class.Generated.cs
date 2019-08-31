using System;

namespace T4GenericsExample
{
    public class UInt32Class : IGeneric<UInt32>
    {
        public UInt32 ReturnResult() => 1 + 3;
    }
}