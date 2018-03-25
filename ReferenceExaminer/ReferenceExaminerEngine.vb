Public Module ReferenceExaminerEngine
    Public Function GetReferences(paths() As String) As List(Of ReferenceInfo)
        Dim result As Dictionary(Of String, ReferenceInfo) = Nothing

        For Each path In paths
            Dim res = GetReferencesInternal(path)
            If result Is Nothing Then
                result = res
            Else
                For Each de In res
                    Dim temp As ReferenceInfo
                    If result.TryGetValue(de.Key, temp) Then
                        temp.ReferencedBy.AddRange(de.Key)
                        temp.ReferencedBy = temp.ReferencedBy.Distinct
                    Else
                        result.Add(de.Key, de.Value)
                    End If
                Next
            End If
        Next

        Return result.Values.ToList
    End Function
    Public Function GetReferences(path As String) As ReferenceInfo()
        Return GetReferencesInternal(path).Values.OrderBy(Function(v) v.AssemblyName).ToArray
    End Function
    Private Function GetReferencesInternal(path As String) As Dictionary(Of String, ReferenceInfo)
        Dim files As IEnumerable(Of String) = Nothing
        If IO.File.Exists(path) Then
            files = New String() {path}
        ElseIf IO.Directory.Exists(path) Then
            files = IO.Directory.EnumerateFiles(path, "*.dll")
            files = files.Concat(IO.Directory.EnumerateFiles(path, "*.exe"))
        End If


        Dim result As New Dictionary(Of String, ReferenceInfo)
        If files IsNot Nothing Then
            For Each file In files
                For Each a In GetReferencesFromFile(file)
                    Dim refInfo As ReferenceInfo = Nothing
                    If Not result.TryGetValue(a, refInfo) Then
                        refInfo = New ReferenceInfo
                        refInfo.AssemblyName = a
                        result.Add(a, refInfo)
                    End If
                    refInfo.ReferencedBy.Add(IO.Path.GetFileName(file))
                Next
            Next
        End If

        For Each de In result
            de.Value.ReferencedBy.Sort()
        Next
        Return result
    End Function
    Public Function GetReferencesFromFile(file As String) As String()

        Dim asy = Reflection.Assembly.ReflectionOnlyLoadFrom(file)
        Dim asyNames = (From a In asy.GetReferencedAssemblies Select a.Name).ToArray

        Return asyNames
    End Function
End Module

Public Class ReferenceInfo
    Property AssemblyName As String
    Property ReferencedBy As New List(Of String)
End Class


