﻿'''<remarks/>
<System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
Partial Public Class clsXMLRestartScraper
    Private _selectedField As Boolean

    Private _sTypeField As Enums.ScrapeType

    Private _OptionsField As New Structures.ScrapeOptions

    Private _ScrapeListField As New System.Collections.Generic.List(Of String())

    '''<remarks/>
    Public Property Selected As Boolean
        Get
            Return Me._selectedField
        End Get
        Set(value As Boolean)
            Me._selectedField = value
        End Set
    End Property

    Public Property sType As Enums.ScrapeType
        Get
            Return Me._sTypeField
        End Get
        Set(value As Enums.ScrapeType)
            Me._sTypeField = value
        End Set
    End Property

    Public Property Options As Structures.ScrapeOptions
        Get
            Return Me._OptionsField
        End Get
        Set(value As Structures.ScrapeOptions)
            Me._OptionsField = value
        End Set
    End Property

    Public Property ScrapeList As System.Collections.Generic.List(Of String())
        Get
            Return Me._ScrapeListField
        End Get
        Set(value As System.Collections.Generic.List(Of String()))
            Me._ScrapeListField = value
        End Set
    End Property
End Class