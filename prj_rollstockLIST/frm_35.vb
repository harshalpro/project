Imports System.Data.SqlClient
Public Class frm_35
    Private Sub frm_35_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        fillGrid("select * from tab_35")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim BF, GSM, WEIGHT As String
        BF = txtBF.Text
        GSM = txtGSM.Text
        WEIGHT = txtWEIGHT.Text

        Dim cmd As New SqlCommand("insert into tab_35 (BF,GSM,WEIGHT) values(@B,@G,@W)", cnn)
        With cmd.Parameters
            .AddWithValue("@B", BF)
            .AddWithValue("@G", GSM)
            .AddWithValue("@W", WEIGHT)
        End With
        If openConnection() Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Your Data has been Inserted Successfully")
            ClearForm()

            closeConnection()
        End If
    End Sub
    Public Sub ClearForm()
        txtBF.Clear()
        txtGSM.Clear()
        txtWEIGHT.Clear()
    End Sub
    Public Sub fillGrid(ByVal query As String)
        Dim ada As New SqlDataAdapter(query, cnn)
        Dim tab As New DataTable
        ada.Fill(tab)
        DataGridView1.DataSource = tab

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim id As Integer
        id = DataGridView1.CurrentRow.Cells(0).Value
        lblID.Text = id

        '1 get data into adapater
        Dim ada As New SqlDataAdapter("select * from tab_35 where id=" & id.ToString, cnn)
        '2 declare a table to store the data from adapater
        Dim tab As New DataTable
        '3 fill data of adapater into table
        ada.Fill(tab)



        txtBF.Text = tab.Rows(0).Item(1).ToString
        txtGSM.Text = tab.Rows(0).Item(2).ToString
        txtWEIGHT.Text = tab.Rows(0).Item(2).ToString
    End Sub

    Private Sub btnCompleteRoll_Click(sender As Object, e As EventArgs) Handles btnCompleteRoll.Click
        Dim cmd As New SqlCommand
        cmd.CommandText = "delete from tab_35 where id=@i"
        cmd.Connection = cnn
        Try
            With cmd.Parameters

                .AddWithValue("@i", lblID.Text)

            End With
            openConnection()
            cmd.ExecuteNonQuery()
            closeConnection()
            MessageBox.Show("Data Deleted Successfully")
            fillGrid("select * from tab_35 where WEIGHT like '%" & txtSearch.Text & "%'")

        Catch ex As Exception
            MessageBox.Show("Something Went Wrong : " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        fillGrid("select * from tab_35 where WEIGHT like '%" & txtSearch.Text & "%'")
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub lblTotalWeight_Click(sender As Object, e As EventArgs) Handles lblTotalWeight.Click
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(3).Value

        Next
        lblTotalWeight.Text = sum.ToString
    End Sub
End Class