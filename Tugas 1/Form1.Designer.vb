<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProces = New System.Windows.Forms.Button()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cbFakultas = New System.Windows.Forms.ComboBox()
        Me.cbJurusan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FAKULTAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "JURUSAN"
        '
        'btnProces
        '
        Me.btnProces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProces.Location = New System.Drawing.Point(183, 344)
        Me.btnProces.Name = "btnProces"
        Me.btnProces.Size = New System.Drawing.Size(144, 41)
        Me.btnProces.TabIndex = 4
        Me.btnProces.Text = "Process"
        Me.btnProces.UseVisualStyleBackColor = True
        '
        'txtNip
        '
        Me.txtNip.Location = New System.Drawing.Point(283, 47)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(279, 26)
        Me.txtNip.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(283, 127)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(279, 26)
        Me.txtNama.TabIndex = 6
        '
        'cbFakultas
        '
        Me.cbFakultas.FormattingEnabled = True
        Me.cbFakultas.Location = New System.Drawing.Point(283, 205)
        Me.cbFakultas.Name = "cbFakultas"
        Me.cbFakultas.Size = New System.Drawing.Size(279, 28)
        Me.cbFakultas.TabIndex = 7
        '
        'cbJurusan
        '
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Location = New System.Drawing.Point(283, 280)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(279, 28)
        Me.cbJurusan.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 397)
        Me.Controls.Add(Me.cbJurusan)
        Me.Controls.Add(Me.cbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNip)
        Me.Controls.Add(Me.btnProces)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnProces As System.Windows.Forms.Button
    Friend WithEvents txtNip As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cbJurusan As System.Windows.Forms.ComboBox

End Class
