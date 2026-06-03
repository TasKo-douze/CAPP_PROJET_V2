Module DataAccess
    Public Function GetClient() As List(Of Dictionary(Of String, Object))
        ' a modifier avec la session pour récupérer l'id du client connecté

        Dim requete = "select * from HS_CLIENT where cli_id = 1"



        Return DatabaseHelper.ExecuteQuery(requete)
    End Function

    Public Sub InsertPassager(nom As String, prenom As String, dateNaissance As Date, taille As Integer, poids As Integer)

        Dim requete As String = "INSERT INTO HS_PASSAGERS(PASS_ID,PASS_TAILLE,PASS_POIDS, PASS_DATE_NAISSANCE,PASS_NOM,PASS_PRENOM)
                                VALUES(SEQ_PASS_ID.NEXTVAL,:taille,:poids,:dateNaissance,:nom,:prenom)"

        Dim parametres As New Dictionary(Of String, Object)

        parametres.Add("taille", taille)
        parametres.Add("poids", poids)
        parametres.Add("dateNaissance", dateNaissance)
        parametres.Add("nom", nom)
        parametres.Add("prenom", prenom)

        DatabaseHelper.ExecuteNonQuery(requete, parametres)

    End Sub

    Public Sub InsertReservation(villeDepart As String, villeArrivee As String, dateReservation As Date, nbPassagers As Integer, prixTotal As Double)

        Dim requete As String = "INSERT INTO HS_RESERVATION(RES_ID, VIL_ID_DE, VIL_ID_POUR, CLI_RES_ID, RES_DATE_RESERVATION,RES_DUREEESTIME, RES_ACCOMPTE, RES_STATUT, RES_NOMBRE_PASSAGERS_ESTIME)
                                 VALUES(SEQ_RES_ID.NEXTVAL,
        (SELECT VIL_ID FROM HS_VILLE WHERE VIL_NOM = :villeDepart),
        (SELECT VIL_ID FROM HS_VILLE WHERE VIL_NOM = :villeArrivee),
         1,
        :dateReservation,
         0,
        :acompte,
        'Payée',
        :nbPassagers)"


        Dim parametres As New Dictionary(Of String, Object)

        parametres.Add("villeDepart", villeDepart)
        parametres.Add("villeArrivee", villeArrivee)
        parametres.Add("dateReservation", dateReservation)
        parametres.Add("acompte", prixTotal)
        parametres.Add("nbPassagers", nbPassagers)

        DatabaseHelper.ExecuteNonQuery(requete, parametres)

    End Sub

    Public Function InscriptionClient(nom As String, prenom As String, telephone As String, email As String, motdepasse As String, dateNaissance As Date, taille As Integer, poids As Integer, rue As String, ville As String, numero As Integer) As Boolean

        'trim sert a valider la donnée du client meme si il y a un esapce après
        nom = nom.Trim()
        prenom = prenom.Trim()
        telephone = telephone.Trim()
        email = email.Trim()
        motdepasse = motdepasse.Trim()
        rue = rue.Trim()
        ville = ville.Trim()



        Dim requeteAdresse As String =
        "INSERT INTO HS_ADRESSE (ADR_ID,ADR_RUE, ADR_VILLE, ADR_NUM, ADR_PAYS)
        VALUES (SEQ_ADRE_ID.NEXTVAL,:rue, :ville , :numero ,'Suisse')"


        Dim parametresAdresse As New Dictionary(Of String, Object)

        parametresAdresse.Add("rue", rue)
        parametresAdresse.Add("ville", ville)
        parametresAdresse.Add("numero", numero)

        DatabaseHelper.ExecuteNonQuery(requeteAdresse, parametresAdresse)




        Dim requeteClient As String =
        "INSERT INTO HS_CLIENT (CLI_ID, CLI_ADR_ID, CLI_DATEINSCRIPTION, CLI_DATE_NAISSANCE, CLI_ACTIVE, CLI_NOM, CLI_PRENOM, CLI_TEL, CLI_EMAIL, CLI_MOTS_DE_PASSE, CLI_TAILLE, CLI_POIDS)
        VALUES (SEQ_CLI_ID.NEXTVAL, SEQ_ADRE_ID.CURRVAL, SYSDATE, TO_DATE('" & dateNaissance.ToString("dd.MM.yyyy") & "','DD.MM.YYYY'), '1', :nom, :prenom, :telephone, :email, :motdepasse, :taille, :poids)"

        Dim parametresClient As New Dictionary(Of String, Object)


        parametresClient.Add("nom", nom)
        parametresClient.Add("prenom", prenom)
        parametresClient.Add("telephone", telephone)
        parametresClient.Add("email", email)
        parametresClient.Add("motdepasse", motdepasse)
        parametresClient.Add("taille", taille)
        parametresClient.Add("poids", poids)

        DatabaseHelper.ExecuteNonQuery(requeteClient, parametresClient)

        Return True

    End Function


    Public Function Connexion(email As String, motdepasse As String) As Boolean

        Dim requete As String = "
        SELECT * FROM HS_CLIENT
        WHERE CLI_EMAIL = '" & email & "'
        AND CLI_MOTS_DE_PASSE = '" & motdepasse & "'"


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

    Public Function GetClientByEmail(email As String) As List(Of Dictionary(Of String, Object))

        ' récupère les informations du client avec son email
        Dim requete As String = "
    SELECT 
        c.CLI_NOM,
        c.CLI_PRENOM,
        c.CLI_DATE_NAISSANCE,
        c.CLI_TAILLE,
        c.CLI_POIDS,
        c.CLI_TEL,
        c.CLI_EMAIL,
        a.ADR_RUE,
        a.ADR_NUM,
        a.ADR_VILLE,
        a.ADR_PAYS
    FROM HS_CLIENT c
    JOIN HS_ADRESSE a ON a.ADR_ID = c.CLI_ADR_ID
    WHERE c.CLI_EMAIL = '" & email & "'
    "

        Return DatabaseHelper.ExecuteQuery(requete)

    End Function

    'samir'
    Public Function VerifierEmail(email As String) As Boolean
        Dim requete As String = "SELECT * FROM HS_CLIENT WHERE CLI_EMAIL = '" & email & "'"
        Dim result = DatabaseHelper.ExecuteQuery(requete)
        Return result.Count > 0
    End Function

    Public Sub UpdateCoordonnees(email As String, nouveauTel As String, nouveauEmail As String, rue As String, numero As String, ville As String)
        Dim requeteClient As String = "UPDATE HS_CLIENT SET CLI_TEL = '" & nouveauTel & "', CLI_EMAIL = '" & nouveauEmail & "' WHERE CLI_EMAIL = '" & email & "'"
        DatabaseHelper.ExecuteNonQuery(requeteClient)

        Dim requeteAdresse As String = "UPDATE HS_ADRESSE SET ADR_RUE = '" & rue & "', ADR_NUM = " & numero & ", ADR_VILLE = '" & ville & "' WHERE ADR_ID = (SELECT CLI_ADR_ID FROM HS_CLIENT WHERE CLI_EMAIL = '" & nouveauEmail & "')"
        DatabaseHelper.ExecuteNonQuery(requeteAdresse)
    End Sub

End Module
