<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RefExamine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_Path = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_BrowseFolder = New System.Windows.Forms.Button()
        Me.btn_BrowseFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lst_References = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_ReferencedBy = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Path
        '
        Me.txt_Path.Location = New System.Drawing.Point(69, 22)
        Me.txt_Path.Name = "txt_Path"
        Me.txt_Path.Size = New System.Drawing.Size(288, 20)
        Me.txt_Path.TabIndex = 0
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select a folder to scan all assemblies in that folder"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Path/File"
        '
        'btn_BrowseFolder
        '
        Me.btn_BrowseFolder.Location = New System.Drawing.Point(436, 22)
        Me.btn_BrowseFolder.Name = "btn_BrowseFolder"
        Me.btn_BrowseFolder.Size = New System.Drawing.Size(85, 23)
        Me.btn_BrowseFolder.TabIndex = 2
        Me.btn_BrowseFolder.Text = "Browse Folder"
        Me.btn_BrowseFolder.UseVisualStyleBackColor = True
        '
        'btn_BrowseFile
        '
        Me.btn_BrowseFile.Location = New System.Drawing.Point(363, 22)
        Me.btn_BrowseFile.Name = "btn_BrowseFile"
        Me.btn_BrowseFile.Size = New System.Drawing.Size(69, 23)
        Me.btn_BrowseFile.TabIndex = 3
        Me.btn_BrowseFile.Text = "Browse File"
        Me.btn_BrowseFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Assembly File|*.dll;*.exe"
        Me.OpenFileDialog1.Title = "Select a file to examine"
        '
        'lst_References
        '
        Me.lst_References.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_References.DisplayMember = "AssemblyName"
        Me.lst_References.FormattingEnabled = True
        Me.lst_References.IntegralHeight = False
        Me.lst_References.Location = New System.Drawing.Point(5, 18)
        Me.lst_References.Name = "lst_References"
        Me.lst_References.Size = New System.Drawing.Size(253, 407)
        Me.lst_References.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "All References"
        '
        'lst_ReferencedBy
        '
        Me.lst_ReferencedBy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_ReferencedBy.FormattingEnabled = True
        Me.lst_ReferencedBy.IntegralHeight = False
        Me.lst_ReferencedBy.Location = New System.Drawing.Point(2, 18)
        Me.lst_ReferencedBy.Name = "lst_ReferencedBy"
        Me.lst_ReferencedBy.Size = New System.Drawing.Size(257, 407)
        Me.lst_ReferencedBy.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Referenced By"
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Location = New System.Drawing.Point(211, 48)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_Refresh.TabIndex = 6
        Me.btn_Refresh.Text = "Refresh"
        Me.btn_Refresh.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-2, 77)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 436)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lst_References)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 430)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lst_ReferencedBy)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(270, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 430)
        Me.Panel2.TabIndex = 1
        '
        'RefExamine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 513)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btn_Refresh)
        Me.Controls.Add(Me.btn_BrowseFile)
        Me.Controls.Add(Me.btn_BrowseFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Path)
        Me.Name = "RefExamine"
        Me.Text = "Reference Examiner"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Path As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_BrowseFolder As Button
    Friend WithEvents btn_BrowseFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lst_References As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lst_ReferencedBy As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Refresh As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
