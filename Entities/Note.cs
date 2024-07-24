using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Note : IEntity
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public string Stext { get; set; }
        public Boolean Status { get; set; }
        public string Header { get; set; }


    }
}
