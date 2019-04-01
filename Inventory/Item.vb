Public Class Item

    Private iName As String
    Private iPrice As Double
    Private iQuantity As Integer
    Private iTotal As Double
    Private iDeptName As String

    'Used to get and set name of product
    Public Property Name() As String
        Get
            Return iName
        End Get
        Set(ByVal value As String)
            iName = value
        End Set
    End Property

    'Used to get and set price of product
    Public Property Price() As Double
        Get
            Return iPrice
        End Get
        Set(ByVal value As Double)
            iPrice = value
        End Set
    End Property

    'Used to get and set quantity of product
    Public Property Quantity() As Integer
        Get
            Return iQuantity
        End Get
        Set(ByVal value As Integer)
            iQuantity = value
        End Set
    End Property

    'Used to get and set total of product (quantity x price)
    Public Property Total() As Double
        Get
            iTotal = iPrice * iQuantity
            Return iTotal
        End Get
        Set(ByVal value As Double)
            iTotal = value
        End Set
    End Property

    'Used to get and set the department name of product
    Public Property deptName() As String
        Get
            Return iDeptName
        End Get
        Set(ByVal value As String)
            iDeptName = value
        End Set
    End Property

End Class
