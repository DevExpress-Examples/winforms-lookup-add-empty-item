Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace LookUpListWithNullEntry

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call InitDal()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub

        Private Sub InitDal()
            Dim provider As InMemoryDataStore = New InMemoryDataStore(New DataSet(), AutoCreateOption.DatabaseAndSchema)
            XpoDefault.DataLayer = New SimpleDataLayer(provider)
        End Sub
    End Module
End Namespace
