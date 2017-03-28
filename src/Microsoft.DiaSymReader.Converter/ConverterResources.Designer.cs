﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DiaSymReader.Tools {
    using System;
    using System.Reflection;
    
    
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
    internal class ConverterResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConverterResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DiaSymReader.Converter.ConverterResources", typeof(ConverterResources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Invalid PDB format: {0}.
        /// </summary>
        internal static string InvalidPdbFormat {
            get {
                return ResourceManager.GetString("InvalidPdbFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid user entry point in the source PDB.
        /// </summary>
        internal static string InvalidUserEntryPointInSourcePdb {
            get {
                return ResourceManager.GetString("InvalidUserEntryPointInSourcePdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metadata not available.
        /// </summary>
        internal static string MetadataNotAvailable {
            get {
                return ResourceManager.GetString("MetadataNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified PE was built with Portable PDB.
        /// </summary>
        internal static string SpecifiedPEBuiltWithPortablePdb {
            get {
                return ResourceManager.GetString("SpecifiedPEBuiltWithPortablePdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified PE file doesn&apos;t have any PDB associated with it.
        /// </summary>
        internal static string SpecifiedPEFileHasNoAssociatedPdb {
            get {
                return ResourceManager.GetString("SpecifiedPEFileHasNoAssociatedPdb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream must be readable.
        /// </summary>
        internal static string StreamMustBeReadable {
            get {
                return ResourceManager.GetString("StreamMustBeReadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream must be seakable.
        /// </summary>
        internal static string StreamMustBeSeakable {
            get {
                return ResourceManager.GetString("StreamMustBeSeakable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream must be writable.
        /// </summary>
        internal static string StreamMustBeWritable {
            get {
                return ResourceManager.GetString("StreamMustBeWritable", resourceCulture);
            }
        }
    }
}
