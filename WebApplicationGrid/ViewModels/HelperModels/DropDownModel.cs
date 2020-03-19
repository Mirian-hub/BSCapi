using System;
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
        public List<GroupingModel> LeftGroupModelList { get; set; }
        public List<ListViewModel> ListView { get; set; }
        public string PageTitle { get; set; }
        public List<string> TypeSource { get; set; }
        public List<string> StatusSource { get; set; }
        public List<PageSearhcModel> PageSearchSource { get; set; }
        public List<PageSortModel> PaegSortSource { get; set; }
    }
    public class GroupingModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
    public class ListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public string Key { get; set; }
        public int Code { get; set; }
        public int GroupId { get; set; }
    }

    public class PageSearhcModel
    {
        public string SearchName { get; set; }
        public string SearchFormat { get; set; }        
    }
    public class PageSortModel
    {
        public string SortName { get; set; }
        public string SortFormat { get; set; }
    }
} 
