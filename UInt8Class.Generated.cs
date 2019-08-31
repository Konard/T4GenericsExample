using System;

namespace T4GenericsExample
{
    public class UInt8Class : IGeneric<Byte>
    {
        public Byte ReturnResult() => 1 + 3;
    }
}