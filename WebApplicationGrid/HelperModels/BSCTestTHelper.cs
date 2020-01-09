using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationGrid.HelperModels
{
    public class BSCTestTHelper
    {
        public List<int> OperationType { get; set; }
        public List<string> OperationName { get; set; }
        public Nullable<long> OpAmt { get; set; }
        public string OpDescriptin { get; set; }
        public string AddedColumn { get; set; }
        public Nullable<int> AddedColumn2 { get; set; }
        public string AddedColumn3 { get; set; }
        public string AddedColumn4 { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OperationId { get; set; }
        public List<int> ID { get; set; }
    }
}