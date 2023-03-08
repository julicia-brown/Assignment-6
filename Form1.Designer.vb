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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAvgSpeed = New System.Windows.Forms.Label()
        Me.txtAvgSpeed = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(545, 89)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(635, 65)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Internet Speed Test Survey"
        '
        'lstSpeeds
        '
        Me.lstSpeeds.Font = New System.Drawing.Font("Ebrima", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 59
        Me.lstSpeeds.Location = New System.Drawing.Point(1169, 206)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.Size = New System.Drawing.Size(123, 240)
        Me.lstSpeeds.TabIndex = 1
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSpeed.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(663, 222)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(403, 82)
        Me.btnSpeed.TabIndex = 2
        Me.btnSpeed.Text = "Enter Internet  Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1169, 741)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(176, 57)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAvgSpeed
        '
        Me.lblAvgSpeed.AutoSize = True
        Me.lblAvgSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgSpeed.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgSpeed.Location = New System.Drawing.Point(727, 660)
        Me.lblAvgSpeed.Name = "lblAvgSpeed"
        Me.lblAvgSpeed.Size = New System.Drawing.Size(414, 45)
        Me.lblAvgSpeed.TabIndex = 4
        Me.lblAvgSpeed.Text = "Average Internet Speed is:"
        Me.lblAvgSpeed.Visible = False
        '
        'txtAvgSpeed
        '
        Me.txtAvgSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvgSpeed.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgSpeed.Location = New System.Drawing.Point(1147, 657)
        Me.txtAvgSpeed.Name = "txtAvgSpeed"
        Me.txtAvgSpeed.Size = New System.Drawing.Size(172, 41)
        Me.txtAvgSpeed.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1385, 826)
        Me.Controls.Add(Me.txtAvgSpeed)
        Me.Controls.Add(Me.lblAvgSpeed)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents btnSpeed As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAvgSpeed As Label
    Friend WithEvents txtAvgSpeed As TextBox
End Class
