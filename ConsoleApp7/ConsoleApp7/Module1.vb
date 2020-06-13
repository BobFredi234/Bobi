Module Module1

    Sub Main()
        Dim nameID As String
        Dim passwordID As String
        Dim choix As Integer

        CenterText("AUTHENTIFICATION")
        Console.WriteLine()
        CenterText("***********************************************************")
        Console.WriteLine()
        Console.WriteLine()
        Do

            CenterText("Entrer Votre nom:  ")
            nameID = Console.ReadLine()
            CenterText("Entrer Votre mot de passe:  ")
            passwordID = Console.ReadLine()

            If Not nameID = "Vanessa" And Not passwordID = "jeVeuxPasGouterSa" Then
                CenterText("Verifier votre nom et mot de Passe")
                Console.WriteLine()
            End If

        Loop Until nameID = "Vanessa" And passwordID = "jeVeuxPasGouterSa"

        CenterText("MENU DE NOTRE APPLICATION")
        Console.WriteLine()
        CenterText("***********************************************************")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("                 1.   Effectuer une opération d'achat")
        Console.WriteLine("                 2.   Voir Les Etats")
        Console.WriteLine("                 3.   A propos")
        Console.WriteLine()
        Do

            Console.Write("               Faites votre choix Ici:  ")
            choix = Console.ReadLine()
        Loop Until choix >= 1 And choix <= 3

        Dim prix_Totalpd As Double = 0.0
        Dim Mont_A_PAYER As Double = 0.0

        If choix = 1 Then
            Dim nbProd As Integer
            CenterText("Entrer le nombre de produit : ")
            nbProd = Console.ReadLine()
            Dim prixProd(nbProd) As Double

            For t As Integer = 0 To nbProd - 1
                CenterText("Entrer Le prix du produit n° " & (t + 1) & "   ")
                prixProd(t) = Console.ReadLine()
                prix_Totalpd += prixProd(t)
                Mont_A_PAYER += prixProd(t) - (prixProd(t) * 0.02)
            Next
            CenterText("Le prix Total Hors Taxe est:  " & prix_Totalpd)

            If Mont_A_PAYER >= 250000 And Mont_A_PAYER < 500000 Then
                Mont_A_PAYER -= Mont_A_PAYER * 0.1
            ElseIf Mont_A_PAYER > 500000 Then
                Mont_A_PAYER -= Mont_A_PAYER * 0.15
            End If
            Console.WriteLine()
        End If

        Console.WriteLine()
        Console.WriteLine()

        CenterText("FACTURE N° 1127648")
        Console.WriteLine()
        CenterText("***********************************************************")
        Console.WriteLine()
        Console.WriteLine()
        CenterText("Nom CLIENT : MONSIEUR TANTANPION")
        Console.WriteLine()
        CenterText("PRIX TOTAL HORS REMISE : " & prix_Totalpd)
        Console.WriteLine()
        CenterText("LE MONTANT A PAYER EST : " & Mont_A_PAYER)


        Console.ReadKey()
    End Sub

    Sub CenterText(Text As String)
        Dim msg, x2
        msg = Text
        x2 = 120 / 2 - Len(msg) / 2
        Console.Write(Space(x2) & msg)
    End Sub

End Module
