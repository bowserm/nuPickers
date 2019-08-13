﻿using ClientDependency.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace nuPickers.DataEditors.JsonDropDownPicker
{
    // EDITOR UI
    [DataEditor(DataEditorConstants.JsonDropDownPickerAlias, "nuPickers: Json DropDown Picker", EmbeddedResource.EmbeddedResource.ROOT_URL + "DropDownPicker/DropDownPickerEditor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "DropDownPicker/DropDownPickerEditorController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]

    // RESOURCES (all are referenced as EditorResource consumes the others)
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "Editor/EditorResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "DataSource/DataSourceResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatResource.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]

    // CONFIG
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.EmbeddedResource.ROOT_URL + "PropertyEditor/PropertyEditorConfig.css" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "JsonDataSource/JsonDataSourceConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "RelationMapping/RelationMappingConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.EmbeddedResource.ROOT_URL + "SaveFormat/SaveFormatConfigController.js" + EmbeddedResource.EmbeddedResource.FILE_EXTENSION)]
    public class JsonDropDownPickerDataEditor : DataEditor
    {
        protected override IConfigurationEditor CreateConfigurationEditor() => new JsonDropDownPickerConfigurationEditor();

        public JsonDropDownPickerDataEditor(ILogger logger) : base(logger)
        {
        }
    }
}