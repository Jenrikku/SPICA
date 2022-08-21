﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPICA.Rendering.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SPICA.Rendering.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to //SPICA auto-generated code
        /////This code was translated from a MAESTRO Vertex Shader
        /////This file was also hand modified to improve compatibility
        ///#version 330 core
        ///
        ///uniform vec4 WrldMtx[3];
        ///uniform vec4 NormMtx[3];
        ///uniform vec4 PosOffs;
        ///uniform vec4 IrScale[2];
        ///uniform vec4 TexcMap;
        ///uniform vec4 TexMtx0[3];
        ///uniform vec4 TexMtx1[3];
        ///uniform vec4 TexMtx2[2];
        ///uniform vec4 TexTran;
        ///uniform vec4 MatAmbi;
        ///uniform vec4 MatDiff;
        ///uniform vec4 HslGCol;
        ///uniform vec4 HslSCol;
        ///uniform vec4 HslSDir;
        ///unif [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultVertexShader {
            get {
                return ResourceManager.GetString("DefaultVertexShader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #version 150
        ///#extension GL_ARB_gpu_shader5 : require
        ///
        ///uniform sampler2D LUTs[6];
        ///
        ///uniform sampler2D Textures[3];
        ///
        ///uniform sampler2D LightDistanceLUT[3];
        ///
        ///uniform sampler2D LightAngleLUT[3];
        ///
        ///uniform samplerCube TextureCube;
        ///
        ///uniform sampler2D UVTestPattern;
        ///
        ///struct Light_t {
        ///	vec3 Position;
        ///	vec3 Direction;
        ///	vec4 Ambient;
        ///	vec4 Diffuse;
        ///	vec4 Specular0;
        ///	vec4 Specular1;
        ///	float AttScale;
        ///	float AttBias;
        ///	float AngleLUTScale;
        ///	int AngleLUTInput;
        ///	int SpotAttEnb;
        ///	int DistAttEnb;
        ///	i [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FragmentShaderBase {
            get {
                return ResourceManager.GetString("FragmentShaderBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] UVPattern {
            get {
                object obj = ResourceManager.GetObject("UVPattern", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
