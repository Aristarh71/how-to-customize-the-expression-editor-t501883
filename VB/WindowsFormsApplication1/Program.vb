﻿Imports DevExpress.Skins
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            SkinManager.EnableFormSkins()
            Application.Run(New Form1())
        End Sub

    End Class
End Namespace
