﻿namespace nuPickers.Shared.JsonDataSource
{
    using Newtonsoft.Json.Linq;
    using nuPickers.Shared.Editor;
    using System.Collections.Generic;
    using System.Web.Http;
    using Umbraco.Web.Editors;
    using Umbraco.Web.Mvc;

    [PluginController("nuPickers")]
    public class JsonDataSourceApiController : UmbracoAuthorizedJsonController
    {
        [HttpPost]
        public IEnumerable<EditorDataItem> GetEditorDataItems([FromUri] int currentId, [FromUri] int parentId, [FromUri] string propertyAlias, [FromBody] dynamic data)
        {
            return Editor.GetEditorDataItems(
                            currentId,
                            parentId,
                            propertyAlias,
                            ((JObject)data.config.dataSource).ToObject<JsonDataSource>(),
                            (string)data.config.customLabel,
                            (string)data.typeahead);
        }
    }
}