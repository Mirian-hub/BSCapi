﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGrid.ViewModels.HelperModels
{
    public class DropDownModel
    {
        public ManuVModel FirstLevel { get; set; }
        public List<ManuVModel> SecondLevel { get; set; }
        public Dictionary<int, Dictionary<int, List<ManuVModel>>> ThirdLevel { get; set; }   
        //public bool HasChild { get; set; }
    }
}