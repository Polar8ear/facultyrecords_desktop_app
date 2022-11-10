<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a187806
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
        Me.lbl_menutitle = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_menutitle.Location = New System.Drawing.Point(303, 16)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(208, 46)
        Me.lbl_menutitle.TabIndex = 1
        Me.lbl_menutitle.Text = "Main Menu"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(351, 396)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(113, 30)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit Program"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(634, 403)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(90, 17)
        Me.lbl_date.TabIndex = 3
        Me.lbl_date.Text = "Today's date"
        '
        'frm_mainmenu_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.Name = "frm_mainmenu_a187806"
        Me.Text = "frm_mainmenu_a187806"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menutitle As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_date As Label
End Class
