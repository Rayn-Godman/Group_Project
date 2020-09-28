Option Strict On
Option Infer Off
Option Explicit On

Public Class Items
    'Declare instance variables
    Private _ItemName As String
    Private _MaterialType As String
    Private _SerialNum As Integer
    Private _IsReusable As Boolean
    Private _IsBiodigradable As Boolean

    'Constructor that accepts two parameters 
    Public Sub New(name As String, material As String)
        _ItemName = name
        _MaterialType = material
        _IsReusable = IsReusable
        _IsBiodigradable = IsBiodigradable

    End Sub

    'Declare all property methods for each of the instance variables
    Public Property ItemName As String
        Get
            Return _ItemName
        End Get
        Set(value As String)
            _ItemName = value
        End Set
    End Property

    Public Property Material As String
        Get
            Return _MaterialType
        End Get
        Set(value As String)
            _MaterialType = value
        End Set
    End Property

    Public ReadOnly Property SerialNum As Integer
        Get
            Return _SerialNum
        End Get
    End Property

    Public Property IsReusable As Boolean
        Get
            Return _IsReusable
        End Get
        Set(value As Boolean)
            _IsReusable = value
        End Set
    End Property

    Public Property IsBiodigradable As Boolean
        Get
            Return _IsBiodigradable
        End Get
        Set(value As Boolean)
            _IsBiodigradable = value
        End Set
    End Property

    'Function to validate any property methods
    Protected Function ValidInt(num As Integer) As Integer
        If num < 0 Then
            Return 0
        Else
            Return num
        End If
    End Function

    'Overridable function that will calculate average of recycable and waste items
    Public Overridable Function CalcAve(numItems As Integer) As Double
        Throw New Exception
    End Function

    'Function that will return string based on each average of recycable and non recycable items 
    Public Overridable Function CalcRating() As String
        Throw New Exception
    End Function

    'Function that will do same as previous function excpet will use MyClass to that function
    Public Overridable Function Rating() As String
        Throw New Exception
    End Function

    'Function that return string of details of each item displayed
    Public Overridable Function Display() As String
        Return "Item Name: " & ItemName & Environment.NewLine & "Type of Material:  " & Material & Environment.NewLine & "Rating: " & Rating()
    End Function


End Class
