﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWordPress.PageObjects {
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
    internal class loginObject {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal loginObject() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestWordPress.PageObjects.loginObject", typeof(loginObject).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //*[@id=&apos;login_error&apos;].
        /// </summary>
        internal static string ErrorLogin {
            get {
                return ResourceManager.GetString("ErrorLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //*[@id=&apos;wp-submit&apos;].
        /// </summary>
        internal static string loginSubmitButton {
            get {
                return ResourceManager.GetString("loginSubmitButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //*[@id=&apos;user_pass&apos;].
        /// </summary>
        internal static string passwordTextbox {
            get {
                return ResourceManager.GetString("passwordTextbox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //*[@id=&apos;user_login&apos;].
        /// </summary>
        internal static string userNameTextbox {
            get {
                return ResourceManager.GetString("userNameTextbox", resourceCulture);
            }
        }
    }
}
