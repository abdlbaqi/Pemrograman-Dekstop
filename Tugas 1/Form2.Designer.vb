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
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.cbfakultas = New System.Windows.Forms.ComboBox()
        Me.rbP = New System.Windows.Forms.RadioButton()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.btnprocess = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbjurusan
        '
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Items.AddRange(New Object() {"Matematika", "Kimia", "Biologi", "Fisika", "Ilmu Komputer"})
        Me.cbjurusan.Location = New System.Drawing.Point(296, 307)
        Me.cbjurusan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(136, 28)
        Me.cbjurusan.TabIndex = 23
        '
        'cbfakultas
        '
        Me.cbfakultas.FormattingEnabled = True
        Me.cbfakultas.Items.AddRange(New Object() {"FMIPA", "FKIP", "FEB"})
        Me.cbfakultas.Location = New System.Drawing.Point(296, 235)
        Me.cbfakultas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbfakultas.Name = "cbfakultas"
        Me.cbfakultas.Size = New System.Drawing.Size(136, 28)
        Me.cbfakultas.TabIndex = 22
        '
        'rbP
        '
        Me.rbP.AutoSize = True
        Me.rbP.Location = New System.Drawing.Point(399, 171)
        Me.rbP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbP.Name = "rbP"
        Me.rbP.Size = New System.Drawing.Size(116, 24)
        Me.rbP.TabIndex = 21
        Me.rbP.TabStop = True
        Me.rbP.Text = "Perempuan"
        Me.rbP.UseVisualStyleBackColor = True
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(296, 171)
        Me.rbL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(97, 24)
        Me.rbL.TabIndex = 20
        Me.rbL.TabStop = True
        Me.rbL.Text = "Laki-Laki"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(296, 105)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(298, 26)
        Me.txtnama.TabIndex = 19
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(296, 37)
        Me.txtnip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(191, 26)
        Me.txtnip.TabIndex = 18
        '
        'btnprocess
        '
        Me.btnprocess.Location = New System.Drawing.Point(180, 355)
        Me.btnprocess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnprocess.Name = "btnprocess"
        Me.btnprocess.Size = New System.Drawing.Size(84, 29)
        Me.btnprocess.TabIndex = 17
        Me.btnprocess.Text = "Process"
        Me.btnprocess.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fakultas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NIP"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 421)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.cbfakultas)
        Me.Controls.Add(Me.rbP)
        Me.Controls.Add(Me.rbL)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.btnprocess)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbfakultas As System.Windows.Forms.ComboBox
    Friend WithEvents rbP As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents btnprocess As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
