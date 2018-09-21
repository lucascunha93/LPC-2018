using System;

namespace DI_Test.Models
{
    public class RenderScoped : IRenderScope
    {
        public Guid GetGuidNow {get; private set;} = Guid.NewGuid();
    }
}