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
    Public Function InscriptionClient(dateNaissance As Date, nom As String, prenom As String, telephone As String, email As String, motdepasse As String, dateNaissance As Date, taille As Integer, poids As Integer, rue As String, ville As String, numero As Integer) As Boolean

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
        "INSERT INTO HS_CLIENT (CLI_ADR_ID, CLI_DATEINSCRIPTION, CLI_DATE_NAISSANCE, CLI_ACTIVE, CLI_NOM, CLI_PRENOM, CLI_TEL, CLI_EMAIL, CLI_MOTS_DE_PASSE, CLI_TAILLE, CLI_POIDS)
        VALUES (SEQ_ADRE_ID.CURRVAL, SYDATA, :dateNaissance, '1', :nom, :prenom, :telephone, :email, :motdepasse, :taille, :poids)"

        Dim parametresClient As New Dictionary(Of String, Object)

        parametresClient.Add("dateNaissance", dateNaissance)
        parametresClient.Add("nom", nom)
        parametresClient.Add("prenom", prenom)
        parametresClient.Add("telephone", telephone)
        parametresClient.Add("email", email)
        parametresClient.Add("motdepasse", motdepasse)
        parametresClient.Add("taille", taille)
        parametresClient.Add("poids", poids)

        DatabaseHelper.ExecuteQuery(requeteClient, parametresClient)

        Return True

    End Function





    Public Function Connexion(email As String, motdepasse As String) As Boolean

        Dim requete As String = "
        SELECT * FROM HS_CLIENT
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

    'SAMIR'
    Public Function GetVilles() As List(Of Dictionary(Of String, Object))
        Dim selectQuery = "SELECT VIL_NOM FROM HS_VILLE ORDER BY VIL_NOM"
        Return DatabaseHelper.ExecuteQuery(selectQuery)
    End Function

    Public Function GetClientByEmail(email As String) As List(Of Dictionary(Of String, Object))
        ' Récupère les infos d'un client à partir de son email
        Dim requete As String = "
        SELECT  CLI_NOM, CLI_PRENOM, CLI_DATE_NAISSANCE, CLI_TAILLE, CLI_POIDS, CLI_TEL, CLI_EMAIL, ADR_RUE, ADR_NUM, ADR_VILLE, ADR_PAYS
        FROM HS_CLIENT
        JOIN HS_ADRESSE ON ADR_ID = CLI_ADR_ID
        WHERE CLI_EMAIL = @email"

        Dim params As New Dictionary(Of String, Object) From {
        {"@email", email}
    }

        Return DatabaseHelper.ExecuteQuery(requete, params)
    End Function


End Module
