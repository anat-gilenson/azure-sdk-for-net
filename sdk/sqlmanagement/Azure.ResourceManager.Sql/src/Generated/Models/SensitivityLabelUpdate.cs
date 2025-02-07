// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A sensitivity label update operation. </summary>
    public partial class SensitivityLabelUpdate : ResourceData
    {
        /// <summary> Initializes a new instance of SensitivityLabelUpdate. </summary>
        public SensitivityLabelUpdate()
        {
        }

        /// <summary> Initializes a new instance of SensitivityLabelUpdate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="op"></param>
        /// <param name="schema"> Schema name of the column to update. </param>
        /// <param name="table"> Table name of the column to update. </param>
        /// <param name="column"> Column name to update. </param>
        /// <param name="sensitivityLabel"> The sensitivity label information to apply on a column. </param>
        internal SensitivityLabelUpdate(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, SensitivityLabelUpdateKind? op, string schema, string table, string column, SensitivityLabelData sensitivityLabel) : base(id, name, type, systemData)
        {
            Op = op;
            Schema = schema;
            Table = table;
            Column = column;
            SensitivityLabel = sensitivityLabel;
        }

        /// <summary> Gets or sets the op. </summary>
        public SensitivityLabelUpdateKind? Op { get; set; }
        /// <summary> Schema name of the column to update. </summary>
        public string Schema { get; set; }
        /// <summary> Table name of the column to update. </summary>
        public string Table { get; set; }
        /// <summary> Column name to update. </summary>
        public string Column { get; set; }
        /// <summary> The sensitivity label information to apply on a column. </summary>
        public SensitivityLabelData SensitivityLabel { get; set; }
    }
}
