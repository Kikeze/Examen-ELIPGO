﻿using Examen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Data.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Total_In_Shelf { get; set; }
        public int Total_In_Vault { get; set; }

        public int Store_Id { get; set; }
        public string Store_Name { get; set; }

    }
}
