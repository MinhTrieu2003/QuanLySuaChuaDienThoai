namespace QLDVSC.Properties
{
    [global::System.Runtime.CompilerServices.CompilerGenerated()]
    [global::System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
    internal class Settings : global::System.Configuration.ApplicationSettingsBase
    {
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSetting()]
        [global::System.Diagnostics.DebuggerNonUserCode()]
        [global::System.Configuration.DefaultSettingValue("")]
        public string RememberUsername
        {
            get { return ((string)(this["RememberUsername"])); }
            set { this["RememberUsername"] = value; }
        }

        [global::System.Configuration.UserScopedSetting()]
        [global::System.Diagnostics.DebuggerNonUserCode()]
        [global::System.Configuration.DefaultSettingValue("")]
        public string RememberPassword
        {
            get { return ((string)(this["RememberPassword"])); }
            set { this["RememberPassword"] = value; }
        }

        [global::System.Configuration.UserScopedSetting()]
        [global::System.Diagnostics.DebuggerNonUserCode()]
        [global::System.Configuration.DefaultSettingValue("false")]
        public bool IsRememberMeChecked
        {
            get { return ((bool)(this["IsRememberMeChecked"])); }
            set { this["IsRememberMeChecked"] = value; }
        }

    }
}