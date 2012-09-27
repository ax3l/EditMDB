Module Module1

    Sub Main()
        Console.WriteLine("--------------------------------------------" & vbCrLf & _
                          "This tool requires winetricks jet40 mdac28 " & vbCrLf & _
                          "(overwrite with --force) and a config file " & vbCrLf & _
                          "mdb_query.conf with line1: filename.mdb " & vbCrLf & _
                          "line2: sql update string" & vbCrLf & _
                          "--------------------------------------------")

        ' Read Config File
        Dim sConfigFile As String = "mdb_query.conf"

        Dim sFileReader As System.IO.StreamReader = System.IO.File.OpenText(sConfigFile)

        Dim sNextLine As String = sFileReader.ReadLine()

        Dim sMDBFile As String = sNextLine
        Dim sSQLQuery As String = ""
        Do Until sNextLine Is Nothing
            sNextLine = sFileReader.ReadLine()
            sSQLQuery &= sNextLine
        Loop

        Console.WriteLine("Open File: " & sMDBFile & vbCrLf & "and execute: " & sSQLQuery)

        ' Execute SQL String
        Dim dbConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sMDBFile & ";")
        dbConn.Open()

        Dim dbExe As New OleDb.OleDbCommand(sSQLQuery, dbConn)
        Dim iUpdates As Integer = dbExe.ExecuteNonQuery()

        Console.WriteLine("Affected rows: " & iUpdates)

        dbConn.Close()
    End Sub

End Module
