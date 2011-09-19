﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib.Web.Mvc.JQuery.JqGrid.Constants
{
    /// <summary>
    /// Contains default values for jqGrid options
    /// </summary>
    public static class JqGridOptionsDefaults
    {
        /// <summary>
        /// The name of an array that contains the actual data.
        /// </summary>
        public const string ResponseRecords = "rows";

        /// <summary>
        /// The name for page index parametr.
        /// </summary>
        public const string ResponsePageIndex = "page";

        /// <summary>
        /// The name of a field that contains total pages count.
        /// </summary>
        public const string ResponseTotalPagesCount = "total";

        /// <summary>
        /// The name of a field that contains total records count.
        /// </summary>
        public const string ResponseTotalRecordsCount = "records";

        /// <summary>
        /// The name of an array that contains custom data.
        /// </summary>
        public const string ResponseUserData = "userdata";

        /// <summary>
        /// The name of a field that contains record identifier.
        /// </summary>
        public const string ResponseRecordId = "id";

        /// <summary>
        /// The name of an array that contains record values.
        /// </summary>
        public const string ResponseRecordValues = "cell";

        /// <summary>
        /// The name for page index parametr.
        /// </summary>
        public const string RequestPageIndex = "page";

        /// <summary>
        /// The name for records count parametr.
        /// </summary>
        public const string RequestRecordsCount = "rows";

        /// <summary>
        /// The name for sorting name parametr.
        /// </summary>
        public const string RequestSortingName = "sidx";

        /// <summary>
        /// The name for sorting order parametr.
        /// </summary>
        public const string RequestSortingOrder = "sord";

        /// <summary>
        /// The name for searching parametr.
        /// </summary>
        public const string RequestSearching = "_search";

        /// <summary>
        /// The name for id parametr.
        /// </summary>
        public const string RequestId = "id";

        /// <summary>
        /// The name for operator parametr.
        /// </summary>
        public const string RequestOperator = "oper";

        /// <summary>
        /// The name for edit operator parametr.
        /// </summary>
        public const string RequestEditOperator = "edit";

        /// <summary>
        /// The name for add operator parametr.
        /// </summary>
        public const string RequestAddOperator = "add";

        /// <summary>
        /// The name for delete operator parametr.
        /// </summary>
        public const string RequestDeleteOperator = "del";

        /// <summary>
        /// The name for subgrid id parametr.
        /// </summary>
        public const string RequestSubgridId = "id";

        /// <summary>
        /// The name for total rows parametr.
        /// </summary>
        public const string RequestTotalRows = "totalrows";

        /// <summary>
        /// The icon (form UI theme images) that will be used if the group is collapsed.
        /// </summary>
        public const string GroupingPlusIcon = "ui-icon-circlesmall-plus";

        /// <summary>
        /// The icon (form UI theme images) that will be used if the group is expanded.
        /// </summary>
        public const string GroupingMinusIcon = "ui-icon-circlesmall-minus";
    }
}
