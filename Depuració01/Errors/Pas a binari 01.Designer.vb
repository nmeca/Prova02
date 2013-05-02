<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumDec = New System.Windows.Forms.TextBox()
        Me.NumBin = New System.Windows.Forms.TextBox()
        Me.PasABinari = New System.Windows.Forms.Button()
        Me.PasADecimal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Decimal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Binari"
        '
        'NumDec
        '
        Me.NumDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDec.Location = New System.Drawing.Point(43, 62)
        Me.NumDec.Name = "NumDec"
        Me.NumDec.Size = New System.Drawing.Size(118, 26)
        Me.NumDec.TabIndex = 2
        '
        'NumBin
        '
        Me.NumBin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumBin.Location = New System.Drawing.Point(346, 62)
        Me.NumBin.Name = "NumBin"
        Me.NumBin.Size = New System.Drawing.Size(225, 26)
        Me.NumBin.TabIndex = 3
        '
        'PasABinari
        '
        Me.PasABinari.Location = New System.Drawing.Point(194, 48)
        Me.PasABinari.Name = "PasABinari"
        Me.PasABinari.Size = New System.Drawing.Size(126, 23)
        Me.PasABinari.TabIndex = 4
        Me.PasABinari.Text = "=====>"
        Me.PasABinari.UseVisualStyleBackColor = True
        '
        'PasADecimal
        '
        Me.PasADecimal.Location = New System.Drawing.Point(194, 77)
        Me.PasADecimal.Name = "PasADecimal"
        Me.PasADecimal.Size = New System.Drawing.Size(126, 23)
        Me.PasADecimal.TabIndex = 5
        Me.PasADecimal.Text = "<===="
        Me.PasADecimal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 207)
        Me.Controls.Add(Me.PasADecimal)
        Me.Controls.Add(Me.PasABinari)
        Me.Controls.Add(Me.NumBin)
        Me.Controls.Add(Me.NumDec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pas a binari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumDec As System.Windows.Forms.TextBox
    Friend WithEvents NumBin As System.Windows.Forms.TextBox
    Friend WithEvents PasABinari As System.Windows.Forms.Button
    Friend WithEvents PasADecimal As System.Windows.Forms.Button

End Class
