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
    Public Rue As String = ""
    Public Numero As Integer = 0
    Public Ville As String = ""

    Public Sub RecupererClient(email As String, motdepasse As String)
        Dim requete As String =
"SELECT c.CLI_ID, c.CLI_NOM, c.CLI_PRENOM, c.CLI_EMAIL, c.CLI_TEL,
        c.CLI_TAILLE, c.CLI_POIDS, c.CLI_DATE_NAISSANCE,
        a.ADR_RUE, a.ADR_NUM, a.ADR_VILLE
FROM HS_CLIENT c
JOIN HS_ADRESSE a ON a.ADR_ID = c.CLI_ADR_ID
WHERE c.CLI_EMAIL = :email
AND c.CLI_MOTS_DE_PASSE = :motdepasse"
        Dim parametres As New Dictionary(Of String, Object)
        parametres.Add("email", email)
        parametres.Add("motdepasse", motdepasse)
        Dim result = DatabaseHelper.ExecuteQuery(requete, parametres)
        If result.Count > 0 Then
            Connecter(result(0))
        Else
            MessageBox.Show("Aucun client trouvé avec cet email.")
        End If
    End Sub

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
        Rue = client("ADR_RUE").ToString()
        Numero = CInt(client("ADR_NUM"))
        Ville = client("ADR_VILLE").ToString()
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
        Rue = ""
        Numero = 0
        Ville = ""
    End Sub
End Module