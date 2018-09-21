using System;

namespace DI_Test.Models
{
    public class RenderSingleton : IRenderSingleton
    {        
        public Guid GetGuidNow {get; private set; } = Guid.NewGuid();
    }
}