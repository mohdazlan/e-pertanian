Public Class loginFrm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If String.IsNullOrEmpty(txtUsername.Text) Then
            MessageBox.Show("Please enter a user name", "No entry")
        Else
            If txtUsername.Text = "admin" & txtPassword.Text = "admin" Then
                mainFrm.Show()
            ElseIf txtUsername.Text = "admin" & txtPassword.Text = "admin" Then


            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub loginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
