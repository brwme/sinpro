﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5420
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Tesis_Nueva.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property Add_16x161() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Add_16x161", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property check_16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("check_16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;
        '''	&lt;body&gt;
        '''		&lt;table&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				Estimado Usuario:
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				Esta es un mensaje automático generado por los sistemas internos de &lt;b&gt; &apos;&lt;%NombreEmpresaCorto%&gt;&apos; &lt;/b&gt; para notificarle que fue devuelto un cheque
        '''				correspondiente al pago de una o varias de sus facturas pendientes. Detalles a continuación:
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&lt;b&gt; N&amp;uacute;mero de ch [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ChequeDevuelto() As String
            Get
                Return ResourceManager.GetString("ChequeDevuelto", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property delete() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("delete", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Logo() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Logo", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        Friend ReadOnly Property Logo_AGSA() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Logo_AGSA", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Logo_Reportes() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Logo_Reportes", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property logo1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logo1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;
        '''	&lt;body&gt;
        '''		&lt;table&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				El usuario &apos;&lt;%Destino%&gt;&apos; ha &lt;b&gt; finalizado &lt;/b&gt; un msj a trav&amp;eacute;s de nuestra plataforma, el titulo del mensaje es:
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&lt;%TituloMensaje%&gt;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&lt;%NombreEmpresa%&gt;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&lt;%RIFEmpresa%&gt;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;/table&gt;
        '''	&lt;/body&gt;
        '''&lt;/html&gt;.
        '''</summary>
        Friend ReadOnly Property MensajeFinalizado() As String
            Get
                Return ResourceManager.GetString("MensajeFinalizado", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;
        '''	&lt;body&gt;
        '''		&lt;table&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''			El usuario &apos;&lt;%Remitente%&gt;&apos; le ha enviado un msj a trav&amp;eacute;s de nuestra plataforma, el mensaje enviado es:
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''			&lt;%CuerpoMensaje%&gt;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''			&lt;%NombreEmpresa%&gt;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''			&lt;%RIFEmpresa%&gt;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;/table&gt;
        '''	&lt;/body&gt;
        '''&lt;/html&gt;.
        '''</summary>
        Friend ReadOnly Property NuevoMensaje() As String
            Get
                Return ResourceManager.GetString("NuevoMensaje", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;
        '''	&lt;body&gt;
        '''		&lt;table&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				Estimado Usuario:
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				Esta es un mensaje automático generado por los sistemas internos de &lt;b&gt; &apos;&lt;%NombreEmpresaCorto%&gt;&apos; &lt;/b&gt; para notificarle que fue creado un nuevo
        '''				pedido en nuestros sistemas. Detalles a continuación:
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&amp;nbsp;
        '''			&lt;/td&gt;
        '''		&lt;/tr&gt;
        '''		&lt;tr&gt;
        '''			&lt;td&gt;
        '''				&lt;b&gt; N&amp;uacute;mero de pedido: &lt;/b&gt; &lt;%NumeroPedido%&gt;
        '''			&lt;/td&gt;
        '''		&lt; [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property NuevoPedido() As String
            Get
                Return ResourceManager.GetString("NuevoPedido", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property Up() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Up", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Update16x16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Update16x16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property ZMensaje() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("ZMensaje", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
