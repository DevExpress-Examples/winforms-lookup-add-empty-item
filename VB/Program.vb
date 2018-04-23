Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections
Imports System.Data
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace LookUpListWithNullEntry
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			InitDal()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

		Private Shared Sub InitDal()
			Dim provider As New InMemoryDataStore(New DataSet(), AutoCreateOption.DatabaseAndSchema)
			XpoDefault.DataLayer = New SimpleDataLayer(provider)
		End Sub
	End Class
End Namespace