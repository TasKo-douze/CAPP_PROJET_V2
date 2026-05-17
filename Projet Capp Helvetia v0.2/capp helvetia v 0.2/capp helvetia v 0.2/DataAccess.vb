Module DataAccess
    Public Function GetClient() As List(Of Dictionary(Of String, Object))
        ' a modifier avec la session pour récupérer l'id du client connecté

        Dim requete = "select * from HS_CLIENT where cli_id = 1"



        Return DatabaseHelper.ExecuteQuery(requete)
    End Function

    Public Sub InsertPassager(
    nom As String,
    prenom As String,
    dateNaissance As Date,
    taille As Integer,
    poids As Integer,
    bagage As Integer
)

        Dim requete As String =
    "INSERT INTO HS_PASSAGERS
    (PASS_ID, PASS_TAILLE, PASS_POIDS, PASS_POIDSBAGAGE,
    PASS_DATE_NAISSANCE, PASS_NOM, PASS_PRENOM)

    VALUES
    (SEQ_PASS_ID.NEXTVAL, :taille, :poids, :bagage,
    :dateNaissance, :nom, :prenom)"

        Dim parametres As New Dictionary(Of String, Object)

        parametres.Add("taille", taille)
        parametres.Add("poids", poids)
        parametres.Add("bagage", bagage)
        parametres.Add("dateNaissance", dateNaissance)
        parametres.Add("nom", nom)
        parametres.Add("prenom", prenom)

        DatabaseHelper.ExecuteNonQuery(requete, parametres)

    End Sub
    Public Function InscriptionClient(nom As String,
                                      prenom As String,
                                      telephone As String,
                                      email As String,
                                      motdepasse As String,
                                      dateNaissance As Date,
                                      taille As Integer,
                                      poids As Integer,
                                      rue As String,
                                      ville As String,
                                      numero As Integer) As Boolean

        nom = nom.Trim()
        prenom = prenom.Trim()
        telephone = telephone.Trim()
        email = email.Trim()
        motdepasse = motdepasse.Trim()
        rue = rue.Trim()
        ville = ville.Trim()

        ' Vérification téléphone avec la contrainte de formatage
        If Not telephone Like "+41.##.###.##.##" Then
            MessageBox.Show("Format téléphone invalide")
            Return False
        End If

        ' Vérification email
        If Not email.Contains("@") Or Not email.Contains(".") Then
            MessageBox.Show("Format email invalide")
            Return False
        End If

        ' 1. INSERT ADRESSE
        Dim requeteAdresse As String = "
        INSERT INTO HS_ADRESSE (
            ADR_ID,
            ADR_RUE,
            ADR_VILLE,
            ADR_NUM,
            ADR_PAYS
        )
        VALUES (
            SEQ_ADRE_ID.NEXTVAL,
            '" & rue & "',
            '" & ville & "',
            " & numero & ",
            'Suisse'
        )
    "

        DatabaseHelper.ExecuteQuery(requeteAdresse)

        ' 2. INSERT CLIENT
        Dim requeteClient As String = "
        INSERT INTO HS_CLIENT (
            CLI_ID,
            CLI_ADR_ID,
            CLI_DATEINSCRIPTION,
            CLI_DATE_NAISSANCE,
            CLI_ACTIVE,
            CLI_NOM,
            CLI_PRENOM,
            CLI_TEL,
            CLI_EMAIL,
            CLI_MOTS_DE_PASSE,
            CLI_TAILLE,
            CLI_POIDS
        )
        VALUES (
            SEQ_CLI_ID.NEXTVAL,
            SEQ_ADRE_ID.CURRVAL,
            SYSDATE,
            DATE '" & dateNaissance.ToString("yyyy-MM-dd") & "',
            '1',
            '" & nom & "',
            '" & prenom & "',
            '" & telephone & "',
            '" & email & "',
            '" & motdepasse & "',
            " & taille & ",
            " & poids & "
        )
    "

        DatabaseHelper.ExecuteQuery(requeteClient)

        Return True

    End Function










    Public Function Connexion(email As String, motdepasse As String) As Boolean

        'sert à enlever les espaces inutiles avant et après le texte.'
        email = email.Trim()
        motdepasse = motdepasse.Trim()


        Dim requete As String = "
        SELECT *FROM HS_CLIENT
        WHERE CLI_EMAIL = '" & email & "'
        AND CLI_MOTS_DE_PASSE = '" & motdepasse & "'
    "

        Dim result = DatabaseHelper.ExecuteQuery(requete)

        Return result.Count > 0

    End Function


    Public Function GetHistoriqueVols() As List(Of Dictionary(Of String, Object))
        ' a modifier avec la session pour récupérer l'id du client connecté
        Dim requete As String = "
        SELECT
            tra.TRAJ_ID,
            vd.VIL_NOM AS VILLE_DEPART,
            va.VIL_NOM AS VILLE_ARRIVEE,
            tra.TRAJ_DATE_EFFECTIF,
            tra.TRAJ_DUREEESTIME,
            tra.TRAJ_FACTURE_MONTANT
        FROM HS_TRAJET tra
        JOIN HS_RESERVATION res ON res.RES_ID = tra.RES_TRAJET_ID
        JOIN HS_VILLE dep ON dep.VIL_ID = tra.VIL_ID_DEPART
        JOIN HS_VILLE arr ON arr.VIL_ID = tra.VIL_ID_ARRIVER
        
        WHERE res.CLI_RES_ID = 1
        ORDER BY tra.TRAJ_DATE_EFFECTIF DESC
    "

        Return DatabaseHelper.ExecuteQuery(requete)

    End Function


    Public Function GetVilles() As List(Of Dictionary(Of String, Object))
        Dim selectQuery = "SELECT VIL_NOM FROM HS_VILLE ORDER BY VIL_NOM"
        Return DatabaseHelper.ExecuteQuery(selectQuery)
    End Function

End Module
