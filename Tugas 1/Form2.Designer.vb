<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttugas = New System.Windows.Forms.TextBox()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbfakultas = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(510, 20)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(418, 38)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(271, 20)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(224, 38)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(3, 20)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(124, 38)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnclose)
        Me.Panel3.Controls.Add(Me.btndelete)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.btnnew)
        Me.Panel3.Location = New System.Drawing.Point(55, 452)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(939, 74)
        Me.Panel3.TabIndex = 14
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(134, 20)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(130, 38)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "GRADE"
        Me.dggrade.Name = "dggrade"
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        '
        'btnprocess
        '
        Me.btnprocess.Enabled = False
        Me.btnprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocess.Location = New System.Drawing.Point(467, 138)
        Me.btnprocess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(276, 42)
        Me.btnprocess.TabIndex = 5
        Me.btnprocess.UseVisualStyleBackColor = True
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "Nama"
        Me.dgnama.Name = "dgnama"
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvdata)
        Me.Panel2.Location = New System.Drawing.Point(55, 546)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(945, 191)
        Me.Panel2.TabIndex = 16
        '
        'dgvdata
        '
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(3, 15)
        Me.dgvdata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(936, 154)
        Me.dgvdata.TabIndex = 4
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.Location = New System.Drawing.Point(728, 360)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(121, 25)
        Me.lblgrade.TabIndex = 19
        Me.lblgrade.Text = "- GRADE -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(521, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "UAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "UTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tugas"
        '
        'txttugas
        '
        Me.txttugas.Location = New System.Drawing.Point(197, 355)
        Me.txttugas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttugas.Name = "txttugas"
        Me.txttugas.Size = New System.Drawing.Size(133, 26)
        Me.txttugas.TabIndex = 13
        '
        'txtuts
        '
        Me.txtuts.Location = New System.Drawing.Point(385, 355)
        Me.txtuts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(129, 26)
        Me.txtuts.TabIndex = 14
        '
        'txtuas
        '
        Me.txtuas.Location = New System.Drawing.Point(568, 355)
        Me.txtuas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(137, 26)
        Me.txtuas.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nilai"
        '
        'cbfakultas
        '
        Me.cbfakultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbfakultas.FormattingEnabled = True
        Me.cbfakultas.Location = New System.Drawing.Point(136, 205)
        Me.cbfakultas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbfakultas.Name = "cbfakultas"
        Me.cbfakultas.Size = New System.Drawing.Size(606, 40)
        Me.cbfakultas.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnprocess)
        Me.Panel1.Controls.Add(Me.lblgrade)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txttugas)
        Me.Panel1.Controls.Add(Me.txtuts)
        Me.Panel1.Controls.Add(Me.txtuas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbfakultas)
        Me.Panel1.Controls.Add(Me.cbjurusan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rbP)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.rbL)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtnama)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtnip)
        Me.Panel1.Location = New System.Drawing.Point(56, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 421)
        Me.Panel1.TabIndex = 15
        '
        'cbjurusan
        '
        Me.cbjurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Location = New System.Drawing.Point(136, 278)
        Me.cbjurusan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(606, 40)
        Me.cbjurusan.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbP.Location = New System.Drawing.Point(317, 144)
        Me.rbP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(147, 29)
        Me.rbP.TabIndex = 9
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbL.Location = New System.Drawing.Point(197, 144)
        Me.rbL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(124, 29)
        Me.rbL.TabIndex = 8
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fakultas"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(136, 75)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(606, 39)
        Me.txtnama.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'txtnip
        '
        Me.txtnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnip.Location = New System.Drawing.Point(136, 8)
        Me.txtnip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(606, 39)
        Me.txtnip.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 728)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnprocess As System.Windows.Forms.Button
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttugas As System.Windows.Forms.TextBox
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
End Class
