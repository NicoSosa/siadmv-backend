﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiResources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MessagesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessagesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SiadMV.API.Resources.MessagesResources", typeof(MessagesResources).Assembly);
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
        ///   Looks up a localized string similar to The Address does not exist..
        /// </summary>
        public static string ErrorUserAddressNotExists {
            get {
                return ResourceManager.GetString("ErrorUserAddressNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The User Case dose not exist..
        /// </summary>
        public static string ErrorUserCaseNotExists {
            get {
                return ResourceManager.GetString("ErrorUserCaseNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user does not exist..
        /// </summary>
        public static string ErrorUserNotExists {
            get {
                return ResourceManager.GetString("ErrorUserNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Provider does not exist..
        /// </summary>
        public static string ErrorUserProviderNotExists {
            get {
                return ResourceManager.GetString("ErrorUserProviderNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Address was removed from the application successfully..
        /// </summary>
        public static string InformationRemoveAddressSuccess {
            get {
                return ResourceManager.GetString("InformationRemoveAddressSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Provider was removed from the user..
        /// </summary>
        public static string InformationRemoveUserProvider {
            get {
                return ResourceManager.GetString("InformationRemoveUserProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} with email &apos;{1}&apos; was removed from the application successfully..
        /// </summary>
        public static string InformationRemoveUserSuccess {
            get {
                return ResourceManager.GetString("InformationRemoveUserSuccess", resourceCulture);
            }
        }
    }
}
