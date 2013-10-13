<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGalleryThing
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.txtGalleryAbout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGalleryTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHtml = New System.Windows.Forms.Button()
        Me.txtPerPage = New System.Windows.Forms.TextBox()
        Me.txtColumns = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtImageAbout = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblImageTitle = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.dlgOpenXml = New System.Windows.Forms.OpenFileDialog()
        Me.dlgOpenImg = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 262)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAddImage)
        Me.TabPage1.Controls.Add(Me.txtGalleryAbout)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtGalleryTitle)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnHtml)
        Me.TabPage1.Controls.Add(Me.txtPerPage)
        Me.TabPage1.Controls.Add(Me.txtColumns)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(456, 236)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Gallery Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAddImage
        '
        Me.btnAddImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddImage.Location = New System.Drawing.Point(326, 211)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(130, 23)
        Me.btnAddImage.TabIndex = 8
        Me.btnAddImage.Text = "Add New Image"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'txtGalleryAbout
        '
        Me.txtGalleryAbout.Location = New System.Drawing.Point(11, 134)
        Me.txtGalleryAbout.Multiline = True
        Me.txtGalleryAbout.Name = "txtGalleryAbout"
        Me.txtGalleryAbout.Size = New System.Drawing.Size(445, 69)
        Me.txtGalleryAbout.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 7
        '
        'txtGalleryTitle
        '
        Me.txtGalleryTitle.Location = New System.Drawing.Point(11, 78)
        Me.txtGalleryTitle.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtGalleryTitle.Name = "txtGalleryTitle"
        Me.txtGalleryTitle.Size = New System.Drawing.Size(445, 22)
        Me.txtGalleryTitle.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 5
        '
        'btnHtml
        '
        Me.btnHtml.Location = New System.Drawing.Point(11, 209)
        Me.btnHtml.Name = "btnHtml"
        Me.btnHtml.Size = New System.Drawing.Size(154, 23)
        Me.btnHtml.TabIndex = 5
        Me.btnHtml.Text = "HTML!"
        Me.btnHtml.UseVisualStyleBackColor = True
        '
        'txtPerPage
        '
        Me.txtPerPage.Location = New System.Drawing.Point(97, 22)
        Me.txtPerPage.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtPerPage.Name = "txtPerPage"
        Me.txtPerPage.Size = New System.Drawing.Size(68, 22)
        Me.txtPerPage.TabIndex = 2
        '
        'txtColumns
        '
        Me.txtColumns.Location = New System.Drawing.Point(11, 22)
        Me.txtColumns.Margin = New System.Windows.Forms.Padding(3, 3, 15, 15)
        Me.txtColumns.Name = "txtColumns"
        Me.txtColumns.Size = New System.Drawing.Size(68, 22)
        Me.txtColumns.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtImageAbout)
        Me.TabPage2.Controls.Add(Me.btnUpdate)
        Me.TabPage2.Controls.Add(Me.btnNext)
        Me.TabPage2.Controls.Add(Me.btnPrev)
        Me.TabPage2.Controls.Add(Me.lblImageTitle)
        Me.TabPage2.Controls.Add(Me.picImage)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(456, 236)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Edit Images"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtImageAbout
        '
        Me.txtImageAbout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImageAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImageAbout.Location = New System.Drawing.Point(216, 29)
        Me.txtImageAbout.Multiline = True
        Me.txtImageAbout.Name = "txtImageAbout"
        Me.txtImageAbout.Size = New System.Drawing.Size(240, 174)
        Me.txtImageAbout.TabIndex = 11
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(293, 209)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(381, 209)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.Location = New System.Drawing.Point(212, 209)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 12
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblImageTitle
        '
        Me.lblImageTitle.AutoSize = True
        Me.lblImageTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImageTitle.Location = New System.Drawing.Point(212, 6)
        Me.lblImageTitle.Name = "lblImageTitle"
        Me.lblImageTitle.Size = New System.Drawing.Size(53, 20)
        Me.lblImageTitle.TabIndex = 1
        Me.lblImageTitle.Text = "Label"
        '
        'picImage
        '
        Me.picImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(8, 6)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(198, 226)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        '
        'dlgOpenXml
        '
        Me.dlgOpenXml.FileName = "OpenFileDialog1"
        Me.dlgOpenXml.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'dlgOpenImg
        '
        Me.dlgOpenImg.Filter = "All files (*.*)|*.*"
        '
        'frmGalleryThing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 262)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 300)
        Me.MinimumSize = New System.Drawing.Size(480, 300)
        Me.Name = "frmGalleryThing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GalleryThing"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dlgOpenXml As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents lblImageTitle As System.Windows.Forms.Label
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtImageAbout As System.Windows.Forms.TextBox
    Friend WithEvents dlgOpenImg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents txtGalleryAbout As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGalleryTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHtml As System.Windows.Forms.Button
    Friend WithEvents txtPerPage As System.Windows.Forms.TextBox
    Friend WithEvents txtColumns As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
