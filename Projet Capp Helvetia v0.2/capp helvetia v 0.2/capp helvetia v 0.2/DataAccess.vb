Module DataAccess
    Public Function GetClient() As List(Of Dictionary(Of String, Object))
        Dim n = 1
        Dim requete = "select * from HS_CLIENT where cli_id = :n"



        Return DatabaseHelper.ExecuteQuery(requete)
    End Function




End Module
