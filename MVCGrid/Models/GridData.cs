﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCGrid.Models
{
    public class GridData
    {
        public GridData()
        {
            Rows = new List<GridRow>();
        }

        public int? TotalRecords { get; set; }
        public List<GridRow> Rows { get; set; }
    }
}
