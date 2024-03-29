﻿Option Strict On
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

    'Function that return string of details of each item displayed
    Public Overridable Function Display() As String
        Return "Item Name & Type of Material: " & ItemName & " Made of " & Material & Environment.NewLine
    End Function

    ' This function to warn user about harm of item if it cannot be Disposed in other way
    Public Overridable Function Warning() As String 'This form of function should be in nonReclable class
        Select Case IsBiodigradable
            Case True
                If (IsReusable = True) Then
                    Return Display() & " / NB!!! Should be Reused/Donated to Avoid Dumbing"
                Else
                    Return Display() & " / It is less harmful to environment"
                End If
            Case False
                If (IsReusable = True) Then
                    Return Display() & " / NB!!! Should be Reused/Donated to Avoid Dumbing"
                Else
                    Return Display() & " / NB!!! It is very Harmful to the Environment Dumbing Should be limited"
                End If
            Case Else
                Return Nothing
        End Select
    End Function
End Class
