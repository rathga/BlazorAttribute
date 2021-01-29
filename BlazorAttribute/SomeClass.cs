using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAttribute
{
    [Some(SomeEnum.Something)] // <-- comment this to make blazor WASM debugging work
    public class SomeClass
    {
        
    }
}
