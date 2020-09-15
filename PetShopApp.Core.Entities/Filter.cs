﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public class Filter
    {
        public string OrderDirection { get; set; }
        public string OrderProperty { get; set; }
        public string SearchText { get; set; }
        public string SearchField { get; set; }
        public int ItemsPrPage { get; set; }
        public int CurrentPage { get; set; }
    }
}
