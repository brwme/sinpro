Public Class MyDatagridView
    Inherits DataGridView

    <System.Security.Permissions.UIPermission(System.Security.Permissions.SecurityAction.LinkDemand, Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)> Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        ' Extract the key code from the key value. 
        Dim key As Keys = keyData And Keys.KeyCode
        If key = Keys.Enter Then
            If Not Me.CurrentRow.Cells.Item(6).Value Is System.DBNull.Value Then
                If Not Me.CurrentRow.Cells.Item(3).Value Is System.DBNull.Value Then
                    If Not Me.CurrentRow.Cells.Item(0).EditedFormattedValue = "" And (Me.CurrentRow.Cells.Item(3).Value = "Multiples" Or Me.CurrentRow.Cells.Item(6).Value = "Multiples") Then
                        Me.CurrentRow.Selected = True
                        Return Me.EndEdit()
                    End If
                End If
            End If
        ElseIf key = Keys.ControlKey Then
            Frm_Principal.Frm_Pedidos_Clientes.recibevalor()
            Return Me.EndEdit()
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    <System.Security.Permissions.SecurityPermission( _
        System.Security.Permissions.SecurityAction.LinkDemand, Flags:= _
        System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> _
    Protected Overrides Function ProcessDataGridViewKey(ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean
        ' Handle the ENTER key as if it were a RIGHT ARROW key. 
        If e.KeyCode = Keys.Enter Then
            If Not Me.CurrentRow.Cells.Item(0).EditedFormattedValue = "" Then
                Me.CurrentRow.Selected = True
                Return Me.EndEdit()
            End If
        End If
        Return MyBase.ProcessDataGridViewKey(e)
    End Function
End Class
