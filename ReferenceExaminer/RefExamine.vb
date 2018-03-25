Public Class RefExamine
    Private _result As ReferenceInfo()
    Private Sub btn_BrowseFile_Click(sender As Object, e As EventArgs) Handles btn_BrowseFile.Click
        OpenFileDialog1.InitialDirectory = txt_Path.Text
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txt_Path.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_BrowseFolder_Click(sender As Object, e As EventArgs) Handles btn_BrowseFolder.Click
        FolderBrowserDialog1.SelectedPath = txt_Path.Text
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txt_Path.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        Dim result = ReferenceExaminer.ReferenceExaminerEngine.GetReferences(txt_Path.Text)

        lst_References.Items.Clear()

        _result = result
        If result IsNot Nothing Then
            lst_References.Items.AddRange(result)
        End If
    End Sub

    Private Sub lst_References_SelectedValueChanged(sender As Object, e As EventArgs) Handles lst_References.SelectedValueChanged
        Dim ref = CType(lst_References.SelectedItem, ReferenceInfo)

        lst_ReferencedBy.Items.Clear()

        If ref IsNot Nothing Then
            lst_ReferencedBy.Items.AddRange(ref.ReferencedBy.ToArray)
        End If
    End Sub

    Private Sub lst_ReferencedBy_DoubleClick(sender As Object, e As EventArgs) Handles lst_ReferencedBy.DoubleClick
        If _result IsNot Nothing Then
            Dim find = IO.Path.GetFileNameWithoutExtension(CStr(lst_ReferencedBy.SelectedItem))
            Dim idx = Array.FindIndex(_result, Function(a) String.Equals(a.AssemblyName, find, StringComparison.OrdinalIgnoreCase))
            Dim o = _result(idx)

            lst_References.SelectedItem = o
        End If
    End Sub
End Class
