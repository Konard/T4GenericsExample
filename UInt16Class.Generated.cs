using System;

namespace T4GenericsExample
{
    public class UInt16Class : IGeneric<UInt16>
    {
        public UInt16 ReturnResult() => 1 + 3;
    }
}