using System;

namespace DI_Test.Models
{
    public class RenderTransient : IRenderTransient
    {
        public Guid GetGuidNow {get; private set;} = Guid.NewGuid();
    }
}