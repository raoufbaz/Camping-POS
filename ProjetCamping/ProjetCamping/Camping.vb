Public Class Camping



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'VARIABLES
        'var sejour
        Dim dateDebut, dateFin As DateTime
        dateDebut = datPickDebut.Value
        dateFin = datPickFin.Value
        Dim jours As Integer = DateDiff(DateInterval.Day, dateDebut, dateFin)
        Dim premjanvier As Date = #01/01/2018 12:00 PM#
        Dim premavril As Date = #04/01/2018 12:00 PM#
        Dim premjuin As Date = #06/01/2018 12:00 PM#
        Dim premnovembre As Date = #11/01/2018 12:00 PM#
        Dim premsept As Date = #09/01/2018 12:00 PM#
        Dim premdecembre As Date = #12/31/2018 12:00 PM#
        Dim total1 As Decimal
        Dim total As Decimal
        Dim nbrpersonne As Integer = NumericUpDown1.Value
        Dim nom As String = TextBox1.Text
        'var equitation
        Dim nbrpersonneEQ As Integer = equitation.NumericUpDown1.Value
        Dim totalEQ As Decimal
        Dim parcours As Integer = equitation.Numericparcours.Value
        'var canot
        Dim nbrpersonnecanot = canot.Numericcanot.Value
        Dim totalcanot As Decimal
        'var escalade
        Dim nbrpersonneESC As Integer = escalade.NumericpersonneESC.Value
        Dim nbrheureESC As Integer = escalade.NumericheureESC.Value
        Dim totalESC As Decimal


        'CALCUL TOTAL
        total = fraisSejour(total1, nbrpersonne, jours, premavril, premjuin, premsept, premnovembre, premjanvier, premdecembre) + FraisEquitation(totalEQ, parcours, nbrpersonneEQ) + FraisCanot(totalcanot, nbrpersonnecanot) + FraisEscalade(totalESC, nbrpersonneESC, nbrheureESC)
        total = total + CalculTaxe(total)
        lblTarifAPayer.Text = "le total de " + nom + " est de:" + " " + Format(total, "C")
        Button5.Visible = True
    End Sub

    'FONCTIONS 
    'fonction frais de sejour
    Public Function fraisSejour(total1 As Decimal, nbrpersonne As Integer, jours As Integer, premavril As Date, premjuin As Date, premsept As Date, premnovembre As Date, premjanvier As Date, premdecembre As Date) As Decimal
        Dim resultat As Decimal
        If (datPickDebut.Value >= premavril And datPickDebut.Value < premjuin) Then
            total1 = jours * 18.9

        ElseIf (datPickDebut.Value >= premjanvier And datPickDebut.Value < premavril) Then
            MessageBox.Show("le Camping ouvre le premier avril !")

        ElseIf (datPickDebut.Value >= premjuin And datPickDebut.Value < premsept) Then
            total1 = jours * 23.25


        ElseIf (datPickDebut.Value >= premsept And datPickDebut.Value < premnovembre) Then
            total1 = jours * 20.25

        ElseIf (datPickDebut.Value >= premnovembre And datPickDebut.Value < premdecembre) Then
            MessageBox.Show("le Camping ferme le premier novembre !")
        End If

        resultat = nbrpersonne * total1
        Return resultat
    End Function

    'fonction frais equitation
    Public Function FraisEquitation(totalEQ As Decimal, parcours As Integer, nbrpersonneEQ As Integer) As Decimal
        If (equitation.RadioButton2.Checked) Then
            If (parcours = 1) Then
                totalEQ = nbrpersonneEQ * 15.25
            ElseIf (parcours = 2) Then
                totalEQ = nbrpersonneEQ * 22.75
            Else
                totalEQ = nbrpersonneEQ * 25.25
            End If
        ElseIf (equitation.RadioButton1.Checked) Then
            If (parcours = 1) Then
                totalEQ = nbrpersonneEQ * 18.25

            ElseIf parcours = 2 Then
                totalEQ = nbrpersonneEQ * 25.0
            Else
                totalEQ = nbrpersonneEQ * 27.75
            End If

        End If
        Return totalEQ
    End Function

    'fonction frais canot
    Public Function FraisCanot(totalcanot As Decimal, nbrpersonnecanot As Integer) As Decimal
        If (canot.radioFDScanot.Checked) Then
            totalcanot = nbrpersonnecanot * 29.55
        ElseIf (canot.radioScanot.Checked) Then
            totalcanot = nbrpersonnecanot * 22.35
        End If
        Return totalcanot
    End Function

    'fonction escalade
    Public Function FraisEscalade(totalESC As Decimal, nbrpersonneEQ As Integer, nbrheureESC As Integer) As Decimal
        totalESC = (nbrpersonneEQ * nbrheureESC) * 10
        Return totalESC
    End Function

    'fonction calcul tax
    Function CalculTaxe(total As Decimal) As Decimal

        Return (total * 0.15)
    End Function



    'OUVERTURE DES FORMULAIRES
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        equitation.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        canot.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        escalade.Show()

    End Sub
    'reset button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Refresh()
        equitation.Refresh()
        escalade.Refresh()
        canot.Refresh()
        TextBox1.Text = ""
        lblTarifAPayer.Text = ""
        NumericUpDown1.Value = 0
        equitation.NumericUpDown1.Value = 0
        equitation.RadioButton1.Checked = False
        equitation.RadioButton2.Checked = False
        canot.radioFDScanot.Checked = False
        canot.radioScanot.Checked = False
        canot.Numericcanot.Value = 0
        escalade.NumericheureESC.Value = 0
        escalade.NumericpersonneESC.Value = 0
        Button5.Visible = False
    End Sub
End Class
