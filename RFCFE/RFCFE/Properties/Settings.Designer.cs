﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RFCFE.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string SourceDir {
            get {
                return ((string)(this["SourceDir"]));
            }
            set {
                this["SourceDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\FILESERVER\\SharedDir")]
        public string DestDir {
            get {
                return ((string)(this["DestDir"]));
            }
            set {
                this["DestDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/mir /r:5 /w:10 /xo /v")]
        public string Switches {
            get {
                return ((string)(this["Switches"]));
            }
            set {
                this["Switches"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"$RECYCLE.BIN\" \"System Volume Information\" \"Recovery\"")]
        public string ExclDirs {
            get {
                return ((string)(this["ExclDirs"]));
            }
            set {
                this["ExclDirs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"desktop.ini\" \"Thumbs.db\" \"*.old\"")]
        public string ExclFiles {
            get {
                return ((string)(this["ExclFiles"]));
            }
            set {
                this["ExclFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogEnabled {
            get {
                return ((bool)(this["LogEnabled"]));
            }
            set {
                this["LogEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("robocopy.log")]
        public string LogFileLocation {
            get {
                return ((string)(this["LogFileLocation"]));
            }
            set {
                this["LogFileLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogTee {
            get {
                return ((bool)(this["LogTee"]));
            }
            set {
                this["LogTee"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LogOverwrite {
            get {
                return ((bool)(this["LogOverwrite"]));
            }
            set {
                this["LogOverwrite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LogAppend {
            get {
                return ((bool)(this["LogAppend"]));
            }
            set {
                this["LogAppend"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IndProcessState {
            get {
                return ((bool)(this["IndProcessState"]));
            }
            set {
                this["IndProcessState"] = value;
            }
        }
    }
}
