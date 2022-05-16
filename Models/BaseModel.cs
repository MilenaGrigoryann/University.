using System;

namespace UniversityConsoleApp1.Models
{
    public class BaseModel
    {
        public Guid ID { get => Guid.NewGuid(); }
    }
}
