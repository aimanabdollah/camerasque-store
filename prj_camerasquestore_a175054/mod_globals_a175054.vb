Module mod_globals_a175054
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_CAMERASQUESTORE_A175054.accdb;Persist Security Info=False;"

    Public myconnection2 As New OleDb.OleDbConnection(myconnection)
    'search product
    Public product_id As String = ""

    'date today
    Public today As Date = Date.Now()



    Public Function run_select(mysql As String) As DataTable

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        Return mytable

    End Function


    Public Sub run_sql_command(mysql As String)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below:  " & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try


    End Sub

End Module
