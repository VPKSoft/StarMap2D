﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarMap2D.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60.1102605")]
        public double Latitude {
            get {
                return ((double)(this["Latitude"]));
            }
            set {
                this["Latitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22.8782576")]
        public double Longitude {
            get {
                return ((double)(this["Longitude"]));
            }
            set {
                this["Longitude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-US")]
        public string UiLanguage {
            get {
                return ((string)(this["UiLanguage"]));
            }
            set {
                this["UiLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("N/A")]
        public string DefaultLocationName {
            get {
                return ((string)(this["DefaultLocationName"]));
            }
            set {
                this["DefaultLocationName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DeepSkyBlue")]
        public global::System.Drawing.Color ConstellationLineColor {
            get {
                return ((global::System.Drawing.Color)(this["ConstellationLineColor"]));
            }
            set {
                this["ConstellationLineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("13, 23, 125")]
        public global::System.Drawing.Color ConstellationBorderLineColor {
            get {
                return ((global::System.Drawing.Color)(this["ConstellationBorderLineColor"]));
            }
            set {
                this["ConstellationBorderLineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color MapCircleColor {
            get {
                return ((global::System.Drawing.Color)(this["MapCircleColor"]));
            }
            set {
                this["MapCircleColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("39, 39, 39")]
        public global::System.Drawing.Color MapSurroundingsColor {
            get {
                return ((global::System.Drawing.Color)(this["MapSurroundingsColor"]));
            }
            set {
                this["MapSurroundingsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#" +
            "ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#ffffff;#" +
            "ffffff")]
        public string StarMagnitudeColors {
            get {
                return ((string)(this["StarMagnitudeColors"]));
            }
            set {
                this["StarMagnitudeColors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10;10;10;10;10;10;9;8;7;6;5;4;3;3;3;3;3;3;3;3;2")]
        public string StarMagnitudeSizes {
            get {
                return ((string)(this["StarMagnitudeSizes"]));
            }
            set {
                this["StarMagnitudeSizes"] = value;
            }
        }
    }
}
