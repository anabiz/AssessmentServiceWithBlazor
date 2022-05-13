using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Option
    {
        public Guid Id { get; set; }
        public string Body { get; set; } = string.Empty;
        public bool IsAnswer { get; set; }
    }
}
