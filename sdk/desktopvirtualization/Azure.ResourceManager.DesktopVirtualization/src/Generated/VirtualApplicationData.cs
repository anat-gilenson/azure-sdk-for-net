// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing the VirtualApplication data model. </summary>
    public partial class VirtualApplicationData : ResourceData
    {
        /// <summary> Initializes a new instance of VirtualApplicationData. </summary>
        /// <param name="commandLineSetting"> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </param>
        public VirtualApplicationData(CommandLineSetting commandLineSetting)
        {
            CommandLineSetting = commandLineSetting;
        }

        /// <summary> Initializes a new instance of VirtualApplicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="objectId"> ObjectId of Application. (internal use). </param>
        /// <param name="description"> Description of Application. </param>
        /// <param name="friendlyName"> Friendly name of Application. </param>
        /// <param name="filePath"> Specifies a path for the executable file for the application. </param>
        /// <param name="msixPackageFamilyName"> Specifies the package family name for MSIX applications. </param>
        /// <param name="msixPackageApplicationId"> Specifies the package application Id for MSIX applications. </param>
        /// <param name="applicationType"> Resource Type of Application. </param>
        /// <param name="commandLineSetting"> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </param>
        /// <param name="commandLineArguments"> Command Line Arguments for Application. </param>
        /// <param name="showInPortal"> Specifies whether to show the RemoteApp program in the RD Web Access server. </param>
        /// <param name="iconPath"> Path to icon. </param>
        /// <param name="iconIndex"> Index of the icon. </param>
        /// <param name="iconHash"> Hash of the icon. </param>
        /// <param name="iconContent"> the icon a 64 bit string as a byte array. </param>
        internal VirtualApplicationData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string objectId, string description, string friendlyName, string filePath, string msixPackageFamilyName, string msixPackageApplicationId, RemoteApplicationType? applicationType, CommandLineSetting commandLineSetting, string commandLineArguments, bool? showInPortal, string iconPath, int? iconIndex, string iconHash, byte[] iconContent) : base(id, name, type, systemData)
        {
            ObjectId = objectId;
            Description = description;
            FriendlyName = friendlyName;
            FilePath = filePath;
            MsixPackageFamilyName = msixPackageFamilyName;
            MsixPackageApplicationId = msixPackageApplicationId;
            ApplicationType = applicationType;
            CommandLineSetting = commandLineSetting;
            CommandLineArguments = commandLineArguments;
            ShowInPortal = showInPortal;
            IconPath = iconPath;
            IconIndex = iconIndex;
            IconHash = iconHash;
            IconContent = iconContent;
        }

        /// <summary> ObjectId of Application. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Description of Application. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Application. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Specifies a path for the executable file for the application. </summary>
        public string FilePath { get; set; }
        /// <summary> Specifies the package family name for MSIX applications. </summary>
        public string MsixPackageFamilyName { get; set; }
        /// <summary> Specifies the package application Id for MSIX applications. </summary>
        public string MsixPackageApplicationId { get; set; }
        /// <summary> Resource Type of Application. </summary>
        public RemoteApplicationType? ApplicationType { get; set; }
        /// <summary> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </summary>
        public CommandLineSetting CommandLineSetting { get; set; }
        /// <summary> Command Line Arguments for Application. </summary>
        public string CommandLineArguments { get; set; }
        /// <summary> Specifies whether to show the RemoteApp program in the RD Web Access server. </summary>
        public bool? ShowInPortal { get; set; }
        /// <summary> Path to icon. </summary>
        public string IconPath { get; set; }
        /// <summary> Index of the icon. </summary>
        public int? IconIndex { get; set; }
        /// <summary> Hash of the icon. </summary>
        public string IconHash { get; }
        /// <summary> the icon a 64 bit string as a byte array. </summary>
        public byte[] IconContent { get; }
    }
}
