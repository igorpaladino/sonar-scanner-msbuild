﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarQube.TeamBuild.PreProcessor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarQube.TeamBuild.PreProcessor.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSBuild SonarQube Runner Pre-processor.
        /// </summary>
        public static string AssemblyDescription {
            get {
                return ResourceManager.GetString("AssemblyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /install:[true|false] - install standard MSBuild targets required for analysis (default true).
        /// </summary>
        public static string CmdLine_ArgDescription_InstallTargets {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_InstallTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /key:[SonarQube project key].
        /// </summary>
        public static string CmdLine_ArgDescription_ProjectKey {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /name:[SonarQube project name].
        /// </summary>
        public static string CmdLine_ArgDescription_ProjectName {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /version:[SonarQube project version].
        /// </summary>
        public static string CmdLine_ArgDescription_ProjectVersion {
            get {
                return ResourceManager.GetString("CmdLine_ArgDescription_ProjectVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving the config file to {0}.
        /// </summary>
        public static string DIAG_SavingConfigFile {
            get {
                return ResourceManager.GetString("DIAG_SavingConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SonarQube URL must be supplied. The URL can be specified in a settings file or on the command line (e.g. using /d:sonar.host.url=http://myserver:9000)..
        /// </summary>
        public static string ERROR_Args_UrlRequired {
            get {
                return ResourceManager.GetString("ERROR_Args_UrlRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarQube pre-processing cannot be performed - required settings are missing.
        /// </summary>
        public static string ERROR_CannotPerformProcessing {
            get {
                return ResourceManager.GetString("ERROR_CannotPerformProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value for /install: {0}. Valid values are &quot;true&quot; or &quot;false&quot;..
        /// </summary>
        public static string ERROR_CmdLine_InvalidInstallTargetsValue {
            get {
                return ResourceManager.GetString("ERROR_CmdLine_InvalidInstallTargetsValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following CheckId should not appear multiple times: {0}.
        /// </summary>
        public static string ERROR_DuplicateCheckId {
            get {
                return ResourceManager.GetString("ERROR_DuplicateCheckId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting at least three command line arguments:
        ///- SonarQube project key
        ///- SonarQube project name
        ///- SonarQube project version
        ///The full path to a settings file can also be supplied. If it is not supplied, the exe will attempt to locate a default settings file in the same directory as the MSBuild.SonarQube.Runner..
        /// </summary>
        public static string ERROR_InvalidCommandLineArgs {
            get {
                return ResourceManager.GetString("ERROR_InvalidCommandLineArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid project key. Allowed characters are alphanumeric, &apos;-&apos;, &apos;_&apos;, &apos;.&apos; and &apos;:&apos;, with at least one non-digit..
        /// </summary>
        public static string ERROR_InvalidProjectKeyArg {
            get {
                return ResourceManager.GetString("ERROR_InvalidProjectKeyArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing analysis setting: {0}.
        /// </summary>
        public static string ERROR_MissingSetting {
            get {
                return ResourceManager.GetString("ERROR_MissingSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while trying to connect to the SonarQube server. Please check that the web server is accessible. Url {0}.
        /// </summary>
        public static string ERROR_WebException {
            get {
                return ResourceManager.GetString("ERROR_WebException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating config and output folders....
        /// </summary>
        public static string MSG_CreatingFolders {
            get {
                return ResourceManager.GetString("MSG_CreatingFolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching analysis configuration settings....
        /// </summary>
        public static string MSG_FetchingAnalysisConfiguration {
            get {
                return ResourceManager.GetString("MSG_FetchingAnalysisConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching properties for project &apos;{0}&apos; from {1}....
        /// </summary>
        public static string MSG_FetchingProjectProperties {
            get {
                return ResourceManager.GetString("MSG_FetchingProjectProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating the FxCop ruleset: {0}.
        /// </summary>
        public static string MSG_GeneratingRuleset {
            get {
                return ResourceManager.GetString("MSG_GeneratingRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating rulesets....
        /// </summary>
        public static string MSG_GeneratingRulesets {
            get {
                return ResourceManager.GetString("MSG_GeneratingRulesets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed {0} to {1}.
        /// </summary>
        public static string MSG_InstallTargets_Copy {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_Copy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} was overwritten at {1}.
        /// </summary>
        public static string MSG_InstallTargets_Overwrite {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_Overwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is up to date at {1}.
        /// </summary>
        public static string MSG_InstallTargets_UpToDate {
            get {
                return ResourceManager.GetString("MSG_InstallTargets_UpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping installing the ImportsBefore targets file.
        /// </summary>
        public static string MSG_NotCopyingTargets {
            get {
                return ResourceManager.GetString("MSG_NotCopyingTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating build integration targets....
        /// </summary>
        public static string MSG_UpdatingMSBuildTargets {
            get {
                return ResourceManager.GetString("MSG_UpdatingMSBuildTargets", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C# plugin is not installed so the SonarLint ruleset cannot be retrieved.
        /// </summary>
        public static string SLAP_CSharpPluginNotInstalled {
            get {
                return ResourceManager.GetString("SLAP_CSharpPluginNotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching the SonarLint ruleset from the server....
        /// </summary>
        public static string SLAP_FetchingSonarLintRuleset {
            get {
                return ResourceManager.GetString("SLAP_FetchingSonarLintRuleset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SonarQube server did returned an invalid ruleset for SonarLint.
        /// </summary>
        public static string SLAP_InvalidRulesetReturned {
            get {
                return ResourceManager.GetString("SLAP_InvalidRulesetReturned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not obtain a C# profile for project &apos;{0}&apos;.
        /// </summary>
        public static string SLAP_NoProfileForProject {
            get {
                return ResourceManager.GetString("SLAP_NoProfileForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found SonarLint profile export for project &apos;{0}&apos;.
        /// </summary>
        public static string SLAP_ProfileExportFound {
            get {
                return ResourceManager.GetString("SLAP_ProfileExportFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find SonarLint profile export for project &apos;{0}&apos;.
        /// </summary>
        public static string SLAP_ProfileExportNotFound {
            get {
                return ResourceManager.GetString("SLAP_ProfileExportNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SonarLint ruleset downloaded: {0}.
        /// </summary>
        public static string SLAP_SonarLintRulesetCreated {
            get {
                return ResourceManager.GetString("SLAP_SonarLintRulesetCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This version of the MSBuild SonarQube Runner automatically deploys {0}, however a copy has been found in {1}. Please remove it if it is not intentional..
        /// </summary>
        public static string WARN_ExistingGlobalTargets {
            get {
                return ResourceManager.GetString("WARN_ExistingGlobalTargets", resourceCulture);
            }
        }
    }
}
