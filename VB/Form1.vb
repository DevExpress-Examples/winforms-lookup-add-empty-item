Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors

Namespace LookUpListWithNullEntry

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            FillData()
            repositoryItemLookUpEdit1.DataSource = New DataSourceWithEmptyItem(xpc2)
        End Sub

        Private Sub FillData()
            If xpc2.Count = 0 Then
                Dim lookup As Lookup = New Lookup()
                lookup.Description = "Description 1"
                lookup.Save()
                xpc2.Add(lookup)
            End If
        End Sub

        Private Sub repositoryItemLookUpEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete Then
                Dim editor As LookUpEdit = CType(sender, LookUpEdit)
                editor.CancelPopup()
                editor.EditValue = Nothing
            End If
        End Sub
    End Class

    Public Class Main
        Inherits XPObject

        Public Name As String

        Public Description As Lookup
    End Class

    Public Class Lookup
        Inherits XPObject

        Public Description As String
    End Class
End Namespace
