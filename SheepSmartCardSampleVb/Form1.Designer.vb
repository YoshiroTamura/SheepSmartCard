<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtErrMsg = New System.Windows.Forms.TextBox()
        Me.btnReadUID = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSCardIDm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtErrMsg
        '
        Me.txtErrMsg.BackColor = System.Drawing.Color.Ivory
        Me.txtErrMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtErrMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtErrMsg.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtErrMsg.ForeColor = System.Drawing.Color.Red
        Me.txtErrMsg.Location = New System.Drawing.Point(199, 182)
        Me.txtErrMsg.Margin = New System.Windows.Forms.Padding(4)
        Me.txtErrMsg.Multiline = True
        Me.txtErrMsg.Name = "txtErrMsg"
        Me.txtErrMsg.ReadOnly = True
        Me.txtErrMsg.Size = New System.Drawing.Size(467, 100)
        Me.txtErrMsg.TabIndex = 14
        '
        'btnReadUID
        '
        Me.btnReadUID.Font = New System.Drawing.Font("MS UI Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnReadUID.ForeColor = System.Drawing.Color.Black
        Me.btnReadUID.Location = New System.Drawing.Point(507, 117)
        Me.btnReadUID.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReadUID.Name = "btnReadUID"
        Me.btnReadUID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnReadUID.Size = New System.Drawing.Size(100, 44)
        Me.btnReadUID.TabIndex = 13
        Me.btnReadUID.Text = "Scan"
        Me.btnReadUID.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(84, 125)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(102, 28)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Card ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(34, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(454, 40)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SheepSmartCard Sample"
        '
        'txtSCardIDm
        '
        Me.txtSCardIDm.Font = New System.Drawing.Font("MS UI Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtSCardIDm.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtSCardIDm.Location = New System.Drawing.Point(199, 122)
        Me.txtSCardIDm.Name = "txtSCardIDm"
        Me.txtSCardIDm.Size = New System.Drawing.Size(280, 34)
        Me.txtSCardIDm.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(732, 333)
        Me.Controls.Add(Me.txtErrMsg)
        Me.Controls.Add(Me.btnReadUID)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSCardIDm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtErrMsg As TextBox
    Friend WithEvents btnReadUID As Button
    Private WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents txtSCardIDm As TextBox
End Class
