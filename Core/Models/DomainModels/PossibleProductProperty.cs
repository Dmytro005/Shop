﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.DomainModels
{
    public class PossibleProductProperty : BaseEntity
    {
        public string SubCategory { get; set; }
        public string PropertyName { get; set; }
        public string Values { get; set; }
    }
}
