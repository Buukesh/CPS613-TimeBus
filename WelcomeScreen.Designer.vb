<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Highlight
        Label1.Font = New Font("Segoe UI", 30F)
        Label1.Location = New Point(140, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(462, 54)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to the TimeBus"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.Location = New Point(193, 249)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 51)
        Button1.TabIndex = 1
        Button1.Text = "Pilot"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15F)
        Button2.Location = New Point(317, 249)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 51)
        Button2.TabIndex = 2
        Button2.Text = "Visitor"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 15F)
        Button3.Location = New Point(441, 249)
        Button3.Name = "Button3"
        Button3.Size = New Size(110, 51)
        Button3.TabIndex = 3
        Button3.Text = "Guide"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Highlight
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(340, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 25)
        Label2.TabIndex = 4
        Label2.Text = "I am a..."
        ' 
        ' WelcomeScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.TimeBus
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(743, 438)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "WelcomeScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TimeBus"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label

End Class
