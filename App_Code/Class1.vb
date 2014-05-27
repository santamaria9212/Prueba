Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Class1
    Public cnn As New SqlConnection
    Public command As New SqlCommand
    Public adaptersql As New SqlDataAdapter
    Public ds As DataSet
    Public reader As SqlDataReader

    Public Sub AbrirConexion()
        cnn = New SqlConnection
        Try
            cnn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Administrador\Documents\GitHub\Prueba\App_Data\Database.mdf;Integrated Security=True;User Instance=True"
            'cnn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Administrador\Desktop\AccesoADatos\AccesoADatos\ESP.mdf;Integrated Security=True;User Instance=True"
            'cnn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ESP.mdf;Integrated Security=True;User Instance=True"
            cnn.Open()
        Catch ex As Exception

        End Try


    End Sub
End Class
