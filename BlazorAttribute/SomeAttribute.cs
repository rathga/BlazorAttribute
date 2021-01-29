using System;

namespace BlazorAttribute
{
    public class SomeAttribute : Attribute
    {
        public SomeAttribute(SomeEnum something)
        {
            Something = something;
        }

        public SomeEnum Something { get; }
    }
}
