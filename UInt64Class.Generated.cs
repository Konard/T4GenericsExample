
using System;

namespace T4GenericsExample
{
    public class UInt64Class : IGeneric<UInt64>
    {
        public UInt64 ReturnResult() => 1 + 3;
    }
}