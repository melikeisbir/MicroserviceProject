﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceProject.DtoLayer.CatalogDtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
