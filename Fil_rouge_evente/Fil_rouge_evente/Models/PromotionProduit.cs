﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fil_rouge_evente.Models
{
    public class PromotionProduit
    {
        public int Remise { get; set; }
        public int ProduitId { get; set; }
        public string ProduitNom { get; set; }
        public decimal Prix { get; set; }

    }
}