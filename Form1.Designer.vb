<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtfirstnumber = New TextBox()
        gavino = New Label()
        txtsecondnumber = New TextBox()
        anthony = New Label()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtfirstnumber
        ' 
        txtfirstnumber.Location = New Point(45, 88)
        txtfirstnumber.Name = "txtfirstnumber"
        txtfirstnumber.Size = New Size(118, 23)
        txtfirstnumber.TabIndex = 0
        ' 
        ' gavino
        ' 
        gavino.AutoSize = True
        gavino.Location = New Point(62, 52)
        gavino.Name = "gavino"
        gavino.Size = New Size(76, 15)
        gavino.TabIndex = 1
        gavino.Text = "First Number"
        ' 
        ' txtsecondnumber
        ' 
        txtsecondnumber.Location = New Point(45, 158)
        txtsecondnumber.Name = "txtsecondnumber"
        txtsecondnumber.Size = New Size(118, 23)
        txtsecondnumber.TabIndex = 2
        ' 
        ' anthony
        ' 
        anthony.AutoSize = True
        anthony.Location = New Point(62, 126)
        anthony.Name = "anthony"
        anthony.Size = New Size(89, 15)
        anthony.TabIndex = 3
        anthony.Text = "Second Nunber"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(74, 199)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 32)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 256)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(anthony)
        Controls.Add(txtsecondnumber)
        Controls.Add(gavino)
        Controls.Add(txtfirstnumber)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents gavino As Label
    Friend WithEvents Button2 As TextBox
    Friend WithEvents anthony As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents te As TextBox
    Friend WithEvents txtfirstnumber As TextBox
    Friend WithEvents txtsecondnumber As TextBox
    Friend WithEvents Label1 As Label
End Class
