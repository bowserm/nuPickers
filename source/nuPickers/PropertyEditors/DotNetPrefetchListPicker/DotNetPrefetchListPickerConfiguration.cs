﻿namespace nuPickers.PropertyEditors.DotNetPrefetchListPicker
{
    using Umbraco.Core.PropertyEditors;
    using nuPickers.EmbeddedResource;

    internal class DotNetPrefetchListPickerConfiguration : ValueListConfiguration
    {

        [ConfigurationField("useLabel", "Include labels?", "boolean", Description = "")]
        public bool UseLabel { get; set; }

        [ConfigurationField("dataSource", "Data Source",
            EmbeddedResource.ROOT_URL + "DotNetDataSource/DotNetDataSourceConfig.html", HideLabel = true)]
        public object DataSource { get; set; }

        [ConfigurationField("customLabel", "Custom Label",
            EmbeddedResource.ROOT_URL + "CustomLabel/CustomLabelConfig.html", HideLabel = true)]
        public string CustomLabel { get; set; }

        [ConfigurationField("prefetchListPicker", "Prefetch List Picker",
            EmbeddedResource.ROOT_URL + "PrefetchListPicker/PrefetchListPickerConfig.html", HideLabel = true)]
        public object PrefetchListPicker { get; set; }

        [ConfigurationField("listPicker", "List Picker", EmbeddedResource.ROOT_URL + "ListPicker/ListPickerConfig.html",
            HideLabel = true)]
        public object ListPicker { get; set; }

        [ConfigurationField("saveFormat", "Save Format",
            EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfig.html")]
        public string SaveFormat { get; set; }
    }
}