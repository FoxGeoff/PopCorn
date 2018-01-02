using Microsoft.AspNetCore.Mvc.ModelBinding;
using Popcorn.Data.Entities;
using Popcorn.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopCorn.Data.Entities
{
    public class ApiResponse
    {
        public bool Status { get; set; }
        public TRF Trf { get; set; }
        public ModelStateDictionary ModelState { get; set; }
    }
}
