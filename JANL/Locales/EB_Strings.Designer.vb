﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Этот класс создан автоматически классом StronglyTypedResourceBuilder
    'с помощью такого средства, как ResGen или Visual Studio.
    'Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    'с параметром /str или перестройте свой проект VS.
    '''<summary>
    '''  Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class EB_Strings
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("JANL.EB_Strings", GetType(EB_Strings).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Перезаписывает свойство CurrentUICulture текущего потока для всех
        '''  обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Continue.
        '''</summary>
        Friend Shared ReadOnly Property EB_Continue() As String
            Get
                Return ResourceManager.GetString("EB_Continue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Copy.
        '''</summary>
        Friend Shared ReadOnly Property EB_Copy() As String
            Get
                Return ResourceManager.GetString("EB_Copy", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Error description.
        '''</summary>
        Friend Shared ReadOnly Property EB_ErrDesc() As String
            Get
                Return ResourceManager.GetString("EB_ErrDesc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Exit.
        '''</summary>
        Friend Shared ReadOnly Property EB_Exit() As String
            Get
                Return ResourceManager.GetString("EB_Exit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Send by mail.
        '''</summary>
        Friend Shared ReadOnly Property EB_Mail() As String
            Get
                Return ResourceManager.GetString("EB_Mail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Message.
        '''</summary>
        Friend Shared ReadOnly Property EB_Message() As String
            Get
                Return ResourceManager.GetString("EB_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Method.
        '''</summary>
        Friend Shared ReadOnly Property EB_Method() As String
            Get
                Return ResourceManager.GetString("EB_Method", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Ищет локализованную строку, похожую на Type.
        '''</summary>
        Friend Shared ReadOnly Property EB_Type() As String
            Get
                Return ResourceManager.GetString("EB_Type", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
