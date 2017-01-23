<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSGODirector
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelSettings = New System.Windows.Forms.Panel()
        Me.btnStreamURL = New System.Windows.Forms.Button()
        Me.rbStream = New System.Windows.Forms.RadioButton()
        Me.rbDirector = New System.Windows.Forms.RadioButton()
        Me.rbGame = New System.Windows.Forms.RadioButton()
        Me.SettingsExpander = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.PanelSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(932, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PanelSettings
        '
        Me.PanelSettings.BackColor = System.Drawing.SystemColors.WindowText
        Me.PanelSettings.Controls.Add(Me.btnStreamURL)
        Me.PanelSettings.Controls.Add(Me.rbStream)
        Me.PanelSettings.Controls.Add(Me.rbDirector)
        Me.PanelSettings.Controls.Add(Me.rbGame)
        Me.PanelSettings.Controls.Add(Me.SettingsExpander)
        Me.PanelSettings.Location = New System.Drawing.Point(0, 0)
        Me.PanelSettings.Name = "PanelSettings"
        Me.PanelSettings.Size = New System.Drawing.Size(241, 50)
        Me.PanelSettings.TabIndex = 4
        '
        'btnStreamURL
        '
        Me.btnStreamURL.Location = New System.Drawing.Point(4, 5)
        Me.btnStreamURL.Name = "btnStreamURL"
        Me.btnStreamURL.Size = New System.Drawing.Size(215, 23)
        Me.btnStreamURL.TabIndex = 9
        Me.btnStreamURL.Text = "Stream URL"
        Me.btnStreamURL.UseVisualStyleBackColor = True
        '
        'rbStream
        '
        Me.rbStream.AutoSize = True
        Me.rbStream.Checked = True
        Me.rbStream.ForeColor = System.Drawing.Color.White
        Me.rbStream.Location = New System.Drawing.Point(78, 31)
        Me.rbStream.Name = "rbStream"
        Me.rbStream.Size = New System.Drawing.Size(80, 17)
        Me.rbStream.TabIndex = 8
        Me.rbStream.TabStop = True
        Me.rbStream.Text = "Stream only"
        Me.rbStream.UseVisualStyleBackColor = True
        '
        'rbDirector
        '
        Me.rbDirector.AutoSize = True
        Me.rbDirector.ForeColor = System.Drawing.Color.White
        Me.rbDirector.Location = New System.Drawing.Point(159, 31)
        Me.rbDirector.Name = "rbDirector"
        Me.rbDirector.Size = New System.Drawing.Size(62, 17)
        Me.rbDirector.TabIndex = 7
        Me.rbDirector.TabStop = True
        Me.rbDirector.Text = "Director"
        Me.rbDirector.UseVisualStyleBackColor = True
        '
        'rbGame
        '
        Me.rbGame.AutoSize = True
        Me.rbGame.ForeColor = System.Drawing.Color.White
        Me.rbGame.Location = New System.Drawing.Point(3, 31)
        Me.rbGame.Name = "rbGame"
        Me.rbGame.Size = New System.Drawing.Size(75, 17)
        Me.rbGame.TabIndex = 6
        Me.rbGame.TabStop = True
        Me.rbGame.Text = "Game only"
        Me.rbGame.UseVisualStyleBackColor = True
        '
        'SettingsExpander
        '
        Me.SettingsExpander.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsExpander.ForeColor = System.Drawing.Color.White
        Me.SettingsExpander.Location = New System.Drawing.Point(225, -2)
        Me.SettingsExpander.Name = "SettingsExpander"
        Me.SettingsExpander.Size = New System.Drawing.Size(16, 50)
        Me.SettingsExpander.TabIndex = 5
        Me.SettingsExpander.Text = ">"
        Me.SettingsExpander.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(958, 478)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.UseHttpActivityObserver = False
        '
        'CSGODirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(958, 478)
        Me.Controls.Add(Me.PanelSettings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CSGODirector"
        Me.Text = "CSGODirector"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        Me.PanelSettings.ResumeLayout(False)
        Me.PanelSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents PanelSettings As Panel
    Friend WithEvents SettingsExpander As Label
    Friend WithEvents rbGame As RadioButton
    Friend WithEvents rbStream As RadioButton
    Friend WithEvents rbDirector As RadioButton
    Friend WithEvents btnStreamURL As Button
    Friend WithEvents WebBrowser1 As Gecko.GeckoWebBrowser
End Class
