﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Model.CustomEntities
{
    public class ProductCategoriesTree
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public int ParentId { get; set; }

    }
}
