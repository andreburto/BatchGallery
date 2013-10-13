<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatch
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtInputFolder = New System.Windows.Forms.TextBox
        Me.btnSelectInputFolder = New System.Windows.Forms.Button
        Me.btnSelectOutputFolder = New System.Windows.Forms.Button
        Me.txtOutputFolder = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.fbdInputFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.fbdOutputFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtThumb = New System.Windows.Forms.TextBox
        Me.txtSmall = New System.Windows.Forms.TextBox
        Me.btnThumbnailize = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.chkXml = New System.Windows.Forms.CheckBox
        Me.chkHtml = New System.Windows.Forms.CheckBox
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Folder:"
        '
        'txtInputFolder
        '
        Me.txtInputFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputFolder.Location = New System.Drawing.Point(12, 28)
        Me.txtInputFolder.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtInputFolder.Name = "txtInputFolder"
        Me.txtInputFolder.Size = New System.Drawing.Size(251, 22)
        Me.txtInputFolder.TabIndex = 1
        Me.txtInputFolder.TabStop = False
        '
        'btnSelectInputFolder
        '
        Me.btnSelectInputFolder.Location = New System.Drawing.Point(269, 28)
        Me.btnSelectInputFolder.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.btnSelectInputFolder.Name = "btnSelectInputFolder"
        Me.btnSelectInputFolder.Size = New System.Drawing.Size(71, 22)
        Me.btnSelectInputFolder.TabIndex = 1
        Me.btnSelectInputFolder.Text = "Select"
        Me.btnSelectInputFolder.UseVisualStyleBackColor = True
        '
        'btnSelectOutputFolder
        '
        Me.btnSelectOutputFolder.Location = New System.Drawing.Point(269, 84)
        Me.btnSelectOutputFolder.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.btnSelectOutputFolder.Name = "btnSelectOutputFolder"
        Me.btnSelectOutputFolder.Size = New System.Drawing.Size(71, 22)
        Me.btnSelectOutputFolder.TabIndex = 2
        Me.btnSelectOutputFolder.Text = "Select"
        Me.btnSelectOutputFolder.UseVisualStyleBackColor = True
        '
        'txtOutputFolder
        '
        Me.txtOutputFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputFolder.Location = New System.Drawing.Point(12, 84)
        Me.txtOutputFolder.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtOutputFolder.Name = "txtOutputFolder"
        Me.txtOutputFolder.Size = New System.Drawing.Size(251, 22)
        Me.txtOutputFolder.TabIndex = 4
        Me.txtOutputFolder.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Output Folder:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Thumb Size:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Small Size:"
        '
        'txtThumb
        '
        Me.txtThumb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThumb.Location = New System.Drawing.Point(111, 121)
        Me.txtThumb.Name = "txtThumb"
        Me.txtThumb.Size = New System.Drawing.Size(66, 22)
        Me.txtThumb.TabIndex = 3
        '
        'txtSmall
        '
        Me.txtSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSmall.Location = New System.Drawing.Point(274, 118)
        Me.txtSmall.Name = "txtSmall"
        Me.txtSmall.Size = New System.Drawing.Size(66, 22)
        Me.txtSmall.TabIndex = 4
        '
        'btnThumbnailize
        '
        Me.btnThumbnailize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThumbnailize.Location = New System.Drawing.Point(12, 185)
        Me.btnThumbnailize.Name = "btnThumbnailize"
        Me.btnThumbnailize.Size = New System.Drawing.Size(328, 29)
        Me.btnThumbnailize.TabIndex = 7
        Me.btnThumbnailize.Text = "Create Thumbnail Gallery"
        Me.btnThumbnailize.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 224)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(352, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statLabel
        '
        Me.statLabel.Name = "statLabel"
        Me.statLabel.Size = New System.Drawing.Size(38, 17)
        Me.statLabel.Text = "Ready"
        Me.statLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkXml
        '
        Me.chkXml.AutoSize = True
        Me.chkXml.Checked = True
        Me.chkXml.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkXml.Location = New System.Drawing.Point(15, 155)
        Me.chkXml.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.chkXml.Name = "chkXml"
        Me.chkXml.Size = New System.Drawing.Size(127, 17)
        Me.chkXml.TabIndex = 5
        Me.chkXml.Text = "Create XML Index file"
        Me.chkXml.UseVisualStyleBackColor = True
        '
        'chkHtml
        '
        Me.chkHtml.AutoSize = True
        Me.chkHtml.Checked = True
        Me.chkHtml.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHtml.Location = New System.Drawing.Point(205, 155)
        Me.chkHtml.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.chkHtml.Name = "chkHtml"
        Me.chkHtml.Size = New System.Drawing.Size(135, 17)
        Me.chkHtml.TabIndex = 6
        Me.chkHtml.Text = "Create HTML Index file"
        Me.chkHtml.UseVisualStyleBackColor = True
        '
        'frmBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 246)
        Me.Controls.Add(Me.chkHtml)
        Me.Controls.Add(Me.chkXml)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnThumbnailize)
        Me.Controls.Add(Me.txtSmall)
        Me.Controls.Add(Me.txtThumb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSelectOutputFolder)
        Me.Controls.Add(Me.txtOutputFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSelectInputFolder)
        Me.Controls.Add(Me.txtInputFolder)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 280)
        Me.MinimumSize = New System.Drawing.Size(360, 280)
        Me.Name = "frmBatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BatchSize2"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInputFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectInputFolder As System.Windows.Forms.Button
    Friend WithEvents btnSelectOutputFolder As System.Windows.Forms.Button
    Friend WithEvents txtOutputFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fbdInputFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents fbdOutputFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtThumb As System.Windows.Forms.TextBox
    Friend WithEvents txtSmall As System.Windows.Forms.TextBox
    Friend WithEvents btnThumbnailize As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkXml As System.Windows.Forms.CheckBox
    Friend WithEvents chkHtml As System.Windows.Forms.CheckBox

End Class
