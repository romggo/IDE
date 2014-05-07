
Public Class romgotxt
    Dim current_route(0) As String
    Dim clipboard As String


    Private Sub NuevaPestañaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaPestañaToolStripMenuItem.Click
        ReDim Preserve current_route(current_route.Length)
        Dim new_txb As New RichTextBox
        tabs.TabPages.Add("new_tab" + CStr(tabs.TabPages.Count))
        tabs.SelectTab(tabs.TabPages.Count - 1)
        new_txb.Parent = tabs.SelectedTab
        new_txb.Multiline = True
        new_txb.Dock = DockStyle.Fill
        new_txb.BackColor = Color.LightGray
        new_txb.BorderStyle = BorderStyle.None
        new_txb.SelectionFont = New Font("arial", 10, FontStyle.Regular)
        new_txb.Select()
    End Sub

    Private Sub tabs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabs.DoubleClick
        Dim chN As New change_name
        If chN.ShowDialog = Windows.Forms.DialogResult.OK Then
            tabs.SelectedTab.Text = chN.new_name.Text + ".txt"
            My.Computer.FileSystem.RenameFile(current_route(tabs.SelectedIndex), chN.new_name.Text + ".txt")
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If current_route(tabs.SelectedIndex) = Nothing Then
            GuardarComoToolStripMenuItem_Click(sender, e)
        End If
        For Each c As RichTextBox In tabs.SelectedTab.Controls
            c.SaveFile(current_route(tabs.SelectedIndex), RichTextBoxStreamType.PlainText)
        Next
    End Sub

    Private Sub RenombrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenombrarToolStripMenuItem.Click
        Dim chN As New change_name
        If chN.ShowDialog = Windows.Forms.DialogResult.OK Then
            tabs.SelectedTab.Text = chN.new_name.Text + ".txt"
            My.Computer.FileSystem.RenameFile(current_route(tabs.SelectedIndex), chN.new_name.Text + ".txt")
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem1.Click
        Dim a As Integer
        If current_route.Length - 1 <> tabs.SelectedIndex Then
            For a = tabs.SelectedIndex To current_route.Length - 2
                current_route(a) = current_route(a + 1)
            Next a
            tabs.TabPages.Remove(tabs.SelectedTab)
        Else
            'current_route(a) = current_route(a + 1) 'corregir la asignacion de las rutas
            tabs.TabPages.Remove(tabs.SelectedTab)
        End If
        ReDim Preserve current_route(current_route.Length - 2)
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        If abrir_archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            current_route(tabs.SelectedIndex) = abrir_archivo.FileName
            current_fileName()
            Dim objReader As New System.IO.StreamReader(abrir_archivo.FileName)
            For Each c As RichTextBox In tabs.SelectedTab.Controls
                c.Text = objReader.ReadToEnd
            Next
            objReader.Close()
        End If

    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        guardar_archivo.AddExtension = True
        guardar_archivo.DefaultExt = "txt"
        guardar_archivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If guardar_archivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For Each c As RichTextBox In tabs.SelectedTab.Controls
                c.SaveFile(guardar_archivo.FileName, RichTextBoxStreamType.PlainText)
            Next
            current_route(tabs.SelectedIndex) = guardar_archivo.FileName
            current_fileName()
        End If

    End Sub

    Private Sub file_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles file_1.TextChanged
        For Each c As RichTextBox In tabs.SelectedTab.Controls
            num_lin.Text = c.Lines.Count
        Next
    End Sub

    Private Sub romgotxt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'num_lin.Text = CStr(file_1.Lines.Count + 1)
        file_1.Select()
    End Sub

    Sub current_fileName()
        Dim a As Integer = current_route(tabs.SelectedIndex).Length
        Do Until current_route(tabs.SelectedIndex)(a - 1) = "\"
            a -= 1
        Loop
        Dim nombre_archivo(current_route(tabs.SelectedIndex).Length - a) As Char
        For b = 0 To current_route(tabs.SelectedIndex).Length - a - 1
            nombre_archivo(b) = current_route(tabs.SelectedIndex)(a + b)
        Next b

        tabs.SelectedTab.Text = nombre_archivo
    End Sub

    Private Sub tabs_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tabs.Selected
        If tabs.TabCount > 0 Then
            For Each c As RichTextBox In tabs.SelectedTab.Controls
                c.Select()
            Next
        End If
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        clipboard = Nothing
        For Each c As RichTextBox In tabs.SelectedTab.Controls
            c.Copy()
        Next
    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        For Each c As RichTextBox In tabs.SelectedTab.Controls
            c.Paste()
        Next
    End Sub

    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        For Each c As RichTextBox In tabs.SelectedTab.Controls
            c.Cut()
        Next
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click

    End Sub
End Class