﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18052
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duality.Resources {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DefaultRes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DefaultRes() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duality.Resources.DefaultRes", typeof(DefaultRes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Beep {
            get {
                object obj = ResourceManager.GetObject("Beep", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Checkerboard {
            get {
                object obj = ResourceManager.GetObject("Checkerboard", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] DroneLoop {
            get {
                object obj = ResourceManager.GetObject("DroneLoop", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap DualityIcon {
            get {
                object obj = ResourceManager.GetObject("DualityIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap DualityIconB {
            get {
                object obj = ResourceManager.GetObject("DualityIconB", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap DualityLogoBig {
            get {
                object obj = ResourceManager.GetObject("DualityLogoBig", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap DualityLogoMedium {
            get {
                object obj = ResourceManager.GetObject("DualityLogoMedium", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap DualityLogoSmall {
            get {
                object obj = ResourceManager.GetObject("DualityLogoSmall", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] LogoJingle {
            get {
                object obj = ResourceManager.GetObject("LogoJingle", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die uniform sampler2D mainTex;
        ///
        ///void main()
        ///{
        ///	gl_FragColor = gl_Color * texture2D(mainTex, gl_TexCoord[0].st);
        ///} ähnelt.
        /// </summary>
        internal static string MinimalFrag {
            get {
                return ResourceManager.GetString("MinimalFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die void main()
        ///{
        ///	gl_Position = ftransform();
        ///	gl_TexCoord[0] = gl_MultiTexCoord0;
        ///	gl_FrontColor = gl_Color;
        ///} ähnelt.
        /// </summary>
        internal static string MinimalVert {
            get {
                return ResourceManager.GetString("MinimalVert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die uniform sampler2D mainTex;
        ///
        ///void main()
        ///{
        ///	gl_FragColor = vec4(gl_Color.rgb, step(0.5, texture2D(mainTex, gl_TexCoord[0].st).a));
        ///} ähnelt.
        /// </summary>
        internal static string PickingFrag {
            get {
                return ResourceManager.GetString("PickingFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die uniform sampler2D mainTex;
        ///
        ///const float Gamma = 2.2;
        ///
        ///void main()
        ///{
        ///	// Retrieve base color
        ///	vec4 texClr = texture2D(mainTex, gl_TexCoord[0].st);
        ///	
        ///	// Do some anti-aliazing
        ///	float w = clamp(64.0 * (abs(dFdx(gl_TexCoord[0].s)) + abs(dFdy(gl_TexCoord[0].t))), 0.0, 0.5);
        ///	float a = smoothstep(0.5 - w, 0.5 + w, texClr.a);
        ///
        ///	// Perform Gamma Correction to achieve a linear attenuation
        ///	texClr.a = pow(a, 1.0 / Gamma);
        ///
        ///	// Compose result color
        ///	gl_FragColor = texClr * gl_Color; 
        ///} ähnelt.
        /// </summary>
        internal static string SharpMaskFrag {
            get {
                return ResourceManager.GetString("SharpMaskFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die uniform sampler2D mainTex;
        ///varying float animBlendVar;
        ///
        ///void main()
        ///{
        ///	// Retrieve frames
        ///	vec4 texClrOld = texture2D(mainTex, gl_TexCoord[0].st);
        ///	vec4 texClrNew = texture2D(mainTex, gl_TexCoord[0].pq);
        ///
        ///	// This code prevents nasty artifacts when blending between differently masked frames
        ///	float accOldNew = (texClrOld.w - texClrNew.w) / (texClrOld.w + texClrNew.w);
        ///	accOldNew *= mix(min(min(animBlendVar, 1.0 - animBlendVar) * 4.0, 1.0), 1.0, abs(accOldNew));
        ///	texClrNew.xyz = mix(texClrNew.xyz, [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string SmoothAnimFrag {
            get {
                return ResourceManager.GetString("SmoothAnimFrag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die attribute float animBlend;
        ///varying float animBlendVar;
        ///
        ///void main()
        ///{
        ///	gl_Position = ftransform();
        ///	gl_TexCoord[0] = gl_MultiTexCoord0;
        ///	gl_FrontColor = gl_Color;
        ///	animBlendVar = animBlend;
        ///} ähnelt.
        /// </summary>
        internal static string SmoothAnimVert {
            get {
                return ResourceManager.GetString("SmoothAnimVert", resourceCulture);
            }
        }
    }
}
