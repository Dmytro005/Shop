﻿using Core.Models.DomainModels.Category;
using Core.Models.DomainModels.Category.SubCategory.SubSecondCategory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.DomainModels.Category.SubCategoty
{
    public class SchoolFolder : BaseEntity
    {
        public string SubCategoryName { get; } = "SchoolFolder";

        public Stationery Stationery { get; set; }
        public string StationeryId { get; set; }

        public ForCopybooks ForCopybooks { get; set; }
        public ForWorks ForWorks { get; set; }
    }
}
