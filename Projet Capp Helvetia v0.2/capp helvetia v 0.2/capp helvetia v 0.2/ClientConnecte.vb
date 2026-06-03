Module ClientConnecte

    Public Id As Integer = 0
    Public Nom As String = ""
    Public Prenom As String = ""
    Public Email As String = ""
    Public Telephone As String = ""
    Public Taille As Integer = 0
    Public Poids As Integer = 0
    Public DateNaissance As Date

    Public EstConnecte As Boolean = False

    Public Sub Connecter(client As Dictionary(Of String, Object))

        Id = CInt(client("CLI_ID"))
        Nom = client("CLI_NOM").ToString()
        Prenom = client("CLI_PRENOM").ToString()
        Email = client("CLI_EMAIL").ToString()
        Telephone = client("CLI_TEL").ToString()
        Taille = CInt(client("CLI_TAILLE"))
        Poids = CInt(client("CLI_POIDS"))
        DateNaissance = CDate(client("CLI_DATE_NAISSANCE"))

        EstConnecte = True

    End Sub

    Public Sub Deconnecter()

        Id = 0
        Nom = ""
        Prenom = ""
        Email = ""
        Telephone = ""
        Taille = 0
        Poids = 0
        DateNaissance = Date.MinValue

        EstConnecte = False

    End Sub


End Module
