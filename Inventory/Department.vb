Imports System.ComponentModel

Public Class Department

    Private dName As String
    Private dNumber As String
    Private dItems As New BindingList(Of Item)

    'Used to get and set name of department
    Public Property Name() As String
        Get
            Return dName
        End Get
        Set(ByVal value As String)
            dName = value
        End Set
    End Property

    'Used to get and set department number
    Public Property Number() As Integer
        Get
            Return dNumber
        End Get
        Set(ByVal value As Integer)
            dNumber = value
        End Set
    End Property

    'Used to store list of items associated with this class
    Public Property Items() As BindingList(Of Item)
        Get
            Return dItems
        End Get
        Set(ByVal value As BindingList(Of Item))
            dItems = value
        End Set
    End Property
End Class
