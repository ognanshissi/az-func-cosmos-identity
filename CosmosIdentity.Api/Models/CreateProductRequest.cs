using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosIdentity.Api.Models
{
    public class CreateProductRequest
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int Rate { get; set; }
    }
}
