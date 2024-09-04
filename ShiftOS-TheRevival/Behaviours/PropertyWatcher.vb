Imports System.ComponentModel

Module PropertyWatcher
    Public Class StringAdvisor
        Implements INotifyPropertyChanged

        Public String2 As String

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Property String1 As String
            Get
                Return String2
            End Get
            Set(value As String)
                If String2 <> value Then
                    String2 = value
                    OnPropertyChanged(String1)
                End If
            End Set
        End Property

        Protected Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Module
