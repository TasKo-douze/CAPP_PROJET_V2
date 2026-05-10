Module DataAccess
    Public Function GetClient() As List(Of Dictionary(Of String, Object))
        ' a modifier avec la session pour récupérer l'id du client connecté

        Dim requete = "select * from HS_CLIENT where cli_id = 1"



        Return DatabaseHelper.ExecuteQuery(requete)
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


End Module
