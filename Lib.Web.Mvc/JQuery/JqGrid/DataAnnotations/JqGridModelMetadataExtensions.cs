﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations
{
    internal static class JqGridModelMetadataExtensions
    {
        #region Fields
        private const string _alignmentKey = "JqGridColumnModel.Alignment";
        private const string _classesKey = "JqGridColumnModel.Classes";
        private const string _fixedKey = "JqGridColumnModel.Fixed";
        private const string _resizableKey = "JqGridColumnModel.Resizable";
        private const string _widthKey = "JqGridColumnModel.Width";
        private const string _editableKey = "JqGridColumnModel.Editable";
        private const string _editOptionsKey = "JqGridColumnModel.EditOptions";
        private const string _editRulesKey = "JqGridColumnModel.EditRules";
        private const string _formOptionsKey = "JqGridColumnModel.FormOptions";
        private const string _editTypeKey = "JqGridColumnModel.EditType";
        private const string _formatterKey = "JqGridColumnModel.Formatter";
        private const string _formatterOptionsKey = "JqGridColumnModel.FormatterOptions";
        private const string _unFormatterKey = "JqGridColumnModel.UnFormatter";
        private const string _labelOptionsKey = "JqGridColumnModel.LabelOptions";
        private const string _searchableKey = "JqGridColumnModel.Searchable";
        private const string _searchOptionsKey = "JqGridColumnModel.SearchOptions";
        private const string _searchRulesKey = "JqGridColumnModel.SearchRules";
        private const string _searchTypeKey = "JqGridColumnModel.SearchType";
        private const string _sortableKey = "JqGridColumnModel.Sortable";
        private const string _indexKey = "JqGridColumnModel.Index";
        private const string _initialSortingOrderKey = "JqGridColumnModel.InitialSortingOrder";
        private const string _summaryTypeKey = "JqGridColumnModel.SummaryType";
        private const string _summaryTemplateKey = "JqGridColumnModel.SummaryTemplate";
        private const string _summaryFunctionKey = "JqGridColumnModel.SummaryFunction";
        #endregion

        #region Methods
        internal static void SetColumnAlignment(this ModelMetadata metadata, JqGridAlignments alignment)
        {
            metadata.AdditionalValues.Add(_alignmentKey, alignment);
        }

        internal static JqGridAlignments GetColumnAlignment(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_alignmentKey))
                return (JqGridAlignments)metadata.AdditionalValues[_alignmentKey];
            else
                return JqGridAlignments.Left;
        }

        internal static void SetColumnClasses(this ModelMetadata metadata, string classes)
        {
            metadata.AdditionalValues.Add(_classesKey, classes);
        }

        internal static string GetColumnClasses(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_classesKey))
                return (string)metadata.AdditionalValues[_classesKey];
            else
                return String.Empty;
        }

        internal static void SetColumnFixed(this ModelMetadata metadata, bool @fixed)
        {
            metadata.AdditionalValues.Add(_fixedKey, @fixed);
        }

        internal static bool GetColumnFixed(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_fixedKey))
                return (bool)metadata.AdditionalValues[_fixedKey];
            else
                return false;
        }

        internal static void SetColumnResizable(this ModelMetadata metadata, bool resizable)
        {
            metadata.AdditionalValues.Add(_resizableKey, resizable);
        }

        internal static bool GetColumnResizable(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_resizableKey))
                return (bool)metadata.AdditionalValues[_resizableKey];
            else
                return true;
        }

        internal static void SetColumnWidth(this ModelMetadata metadata, int width)
        {
            metadata.AdditionalValues.Add(_widthKey, width);
        }

        internal static int GetColumnWidth(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_widthKey))
                return (int)metadata.AdditionalValues[_widthKey];
            else
                return 150;
        }

        internal static void SetColumnLabelOptions(this ModelMetadata metadata, JqGridColumnLabelOptions labelOptions)
        {
            metadata.AdditionalValues.Add(_labelOptionsKey, labelOptions);
        }

        internal static void SetColumnEditable(this ModelMetadata metadata, bool editable)
        {
            metadata.AdditionalValues.Add(_editableKey, editable);
        }

        internal static bool GetColumnEditable(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_editableKey))
                return (bool)metadata.AdditionalValues[_editableKey];
            else
                return false;
        }

        internal static void SetColumnEditOptions(this ModelMetadata metadata, JqGridColumnEditOptions editOptions)
        {
            metadata.AdditionalValues.Add(_editOptionsKey, editOptions);
        }

        internal static JqGridColumnEditOptions GetColumnEditOptions(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_editOptionsKey))
                return (JqGridColumnEditOptions)metadata.AdditionalValues[_editOptionsKey];
            else
                return null;
        }

        internal static void SetColumnEditRules(this ModelMetadata metadata, JqGridColumnRules editRules)
        {
            metadata.AdditionalValues.Add(_editRulesKey, editRules);
        }

        internal static JqGridColumnRules GetColumnEditRules(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_editRulesKey))
                return (JqGridColumnRules)metadata.AdditionalValues[_editRulesKey];
            else
                return null;
        }

        internal static void SetColumnEditType(this ModelMetadata metadata, JqGridColumnEditTypes editType)
        {
            metadata.AdditionalValues.Add(_editTypeKey, editType);
        }

        internal static JqGridColumnEditTypes GetColumnEditType(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_editTypeKey))
                return (JqGridColumnEditTypes)metadata.AdditionalValues[_editTypeKey];
            else
                return JqGridColumnEditTypes.Text;
        }

        internal static void SetColumnFormOptions(this ModelMetadata metadata, JqGridColumnFormOptions formOptions)
        {
            metadata.AdditionalValues.Add(_formOptionsKey, formOptions);
        }

        internal static JqGridColumnFormOptions GetColumnFormOptions(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_formOptionsKey))
                return (JqGridColumnFormOptions)metadata.AdditionalValues[_formOptionsKey];
            else
                return null;
        }

        internal static void SetColumnFormatter(this ModelMetadata metadata, string formatter)
        {
            metadata.AdditionalValues.Add(_formatterKey, formatter);
        }

        internal static string GetColumnFormatter(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_formatterKey))
                return (string)metadata.AdditionalValues[_formatterKey];
            else
                return String.Empty;
        }

        internal static void SetColumnFormatterOptions(this ModelMetadata metadata, JqGridColumnFormatterOptions formatterOptions)
        {
            metadata.AdditionalValues.Add(_formatterOptionsKey, formatterOptions);
        }

        internal static JqGridColumnFormatterOptions GetColumnFormatterOptions(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_formatterOptionsKey))
                return (JqGridColumnFormatterOptions)metadata.AdditionalValues[_formatterOptionsKey];
            else
                return null;
        }

        internal static void SetColumnUnFormatter(this ModelMetadata metadata, string unFormatter)
        {
            metadata.AdditionalValues.Add(_unFormatterKey, unFormatter);
        }

        internal static string GetColumnUnFormatter(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_unFormatterKey))
                return (string)metadata.AdditionalValues[_unFormatterKey];
            else
                return String.Empty;
        }

        internal static JqGridColumnLabelOptions GetColumnLabelOptions(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_labelOptionsKey))
                return (JqGridColumnLabelOptions)metadata.AdditionalValues[_labelOptionsKey];
            else
                return null;
        }

        internal static void SetColumnSearchable(this ModelMetadata metadata, bool searchable)
        {
            metadata.AdditionalValues.Add(_searchableKey, searchable);
        }

        internal static bool GetColumnSearchable(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchableKey))
                return (bool)metadata.AdditionalValues[_searchableKey];
            else
                return true;
        }

        internal static void SetColumnSearchOptions(this ModelMetadata metadata, JqGridColumnSearchOptions searchOptions)
        {
            metadata.AdditionalValues.Add(_searchOptionsKey, searchOptions);
        }

        internal static JqGridColumnSearchOptions GetColumnSearchOptions(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchOptionsKey))
                return (JqGridColumnSearchOptions)metadata.AdditionalValues[_searchOptionsKey];
            else
                return null;
        }

        internal static void SetColumnSearchRules(this ModelMetadata metadata, JqGridColumnRules searchRules)
        {
            metadata.AdditionalValues.Add(_searchRulesKey, searchRules);
        }

        internal static JqGridColumnRules GetColumnSearchRules(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchRulesKey))
                return (JqGridColumnRules)metadata.AdditionalValues[_searchRulesKey];
            else
                return null;
        }

        internal static void SetColumnSearchType(this ModelMetadata metadata, JqGridColumnSearchTypes searchType)
        {
            metadata.AdditionalValues.Add(_searchTypeKey, searchType);
        }

        internal static JqGridColumnSearchTypes GetColumnSearchType(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_searchTypeKey))
                return (JqGridColumnSearchTypes)metadata.AdditionalValues[_searchTypeKey];
            else
                return JqGridColumnSearchTypes.Text;
        }

        internal static void SetColumnSortable(this ModelMetadata metadata, bool sortable)
        {
            metadata.AdditionalValues.Add(_sortableKey, sortable);
        }

        internal static bool GetColumnSortable(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_sortableKey))
                return (bool)metadata.AdditionalValues[_sortableKey];
            else
                return true;
        }

        internal static void SetColumnIndex(this ModelMetadata metadata, string index)
        {
            metadata.AdditionalValues.Add(_indexKey, index);
        }

        internal static string GetColumnIndex(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_indexKey))
                return (string)metadata.AdditionalValues[_indexKey];
            else
                return String.Empty;
        }

        internal static void SetColumnInitialSortingOrder(this ModelMetadata metadata, JqGridSortingOrders initialSortingOrder)
        {
            metadata.AdditionalValues.Add(_initialSortingOrderKey, initialSortingOrder);
        }

        internal static JqGridSortingOrders GetColumnInitialSortingOrder(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_initialSortingOrderKey))
                return (JqGridSortingOrders)metadata.AdditionalValues[_initialSortingOrderKey];
            else
                return JqGridSortingOrders.Asc;
        }

        internal static void SetColumnSummaryType(this ModelMetadata metadata, JqGridColumnSummaryTypes type)
        {
            metadata.AdditionalValues.Add(_summaryTypeKey, type);
        }

        internal static JqGridColumnSummaryTypes? GetColumnSummaryType(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_summaryTypeKey))
                return (JqGridColumnSummaryTypes)metadata.AdditionalValues[_summaryTypeKey];
            else
                return null;
        }

        internal static void SetColumnSummaryTemplate(this ModelMetadata metadata, string template)
        {
            metadata.AdditionalValues.Add(_summaryTemplateKey, template);
        }

        internal static string GetColumnSummaryTemplate(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_summaryTemplateKey))
                return (string)metadata.AdditionalValues[_summaryTemplateKey];
            else
                return null;
        }

        internal static void SetColumnSummaryFunction(this ModelMetadata metadata, string function)
        {
            metadata.AdditionalValues.Add(_summaryFunctionKey, function);
        }

        internal static string GetColumnSummaryFunction(this ModelMetadata metadata)
        {
            if (metadata.AdditionalValues.ContainsKey(_summaryFunctionKey))
                return (string)metadata.AdditionalValues[_summaryFunctionKey];
            else
                return null;
        }
        #endregion
    }
}
