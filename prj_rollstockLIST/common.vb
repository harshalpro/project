Imports System.Data.SqlClient
Module common
    Public cnn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tha N Star\Documents\Visual Studio 2015\Projects\prj_rollstockLIST\prj_rollstockLIST\stockLIst.mdf;Integrated Security=True")
    Public Function openConnection() As Integer
        Try
            cnn.Open()
            Return 1
        Catch ex As Exception
            MessageBox.Show("Could Not connect to the database")
            Return 0
        End Try
    End Function
    Public Function closeConnection() As Integer
        Try
            cnn.Close()
            Return 1
        Catch ex As Exception
            MessageBox.Show("Could Not connect to the database")
            Return 0
        End Try
    End Function
End Module
