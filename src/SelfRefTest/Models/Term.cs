using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfRefTest.Models
{
    public class Term
    {
        public int Id { get; set; }
        public int CategoryId{ get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Term Parent { get; set; }
        public ICollection<Term> Children { get; set; }
    }
}