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
        BtnGenerate = New Button()
        NumericUpDown1 = New NumericUpDown()
        CheckBoxUpperCase = New CheckBox()
        CheckBoxLowerCase = New CheckBox()
        CheckBoxNumbers = New CheckBox()
        CheckBoxSpecialChars = New CheckBox()
        TextBoxPassword = New TextBox()
        BtnCopy = New Button()
        Label1 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnGenerate
        ' 
        BtnGenerate.Location = New Point(142, 130)
        BtnGenerate.Name = "BtnGenerate"
        BtnGenerate.Size = New Size(177, 51)
        BtnGenerate.TabIndex = 0
        BtnGenerate.Text = "Сгенерировать пароль"
        BtnGenerate.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(425, 158)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 1
        ' 
        ' CheckBoxUpperCase
        ' 
        CheckBoxUpperCase.AutoSize = True
        CheckBoxUpperCase.Location = New Point(109, 58)
        CheckBoxUpperCase.Name = "CheckBoxUpperCase"
        CheckBoxUpperCase.Size = New Size(122, 19)
        CheckBoxUpperCase.TabIndex = 2
        CheckBoxUpperCase.Text = "Заглавные буквы"
        CheckBoxUpperCase.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxLowerCase
        ' 
        CheckBoxLowerCase.AutoSize = True
        CheckBoxLowerCase.Location = New Point(255, 58)
        CheckBoxLowerCase.Name = "CheckBoxLowerCase"
        CheckBoxLowerCase.Size = New Size(119, 19)
        CheckBoxLowerCase.TabIndex = 2
        CheckBoxLowerCase.Text = "Строчные буквы"
        CheckBoxLowerCase.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxNumbers
        ' 
        CheckBoxNumbers.AutoSize = True
        CheckBoxNumbers.Location = New Point(407, 58)
        CheckBoxNumbers.Name = "CheckBoxNumbers"
        CheckBoxNumbers.Size = New Size(67, 19)
        CheckBoxNumbers.TabIndex = 2
        CheckBoxNumbers.Text = "Цифры"
        CheckBoxNumbers.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxSpecialChars
        ' 
        CheckBoxSpecialChars.AutoSize = True
        CheckBoxSpecialChars.Location = New Point(506, 58)
        CheckBoxSpecialChars.Name = "CheckBoxSpecialChars"
        CheckBoxSpecialChars.Size = New Size(111, 19)
        CheckBoxSpecialChars.TabIndex = 2
        CheckBoxSpecialChars.Text = "Спец. символы"
        CheckBoxSpecialChars.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(142, 244)
        TextBoxPassword.Multiline = True
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(475, 50)
        TextBoxPassword.TabIndex = 3
        ' 
        ' BtnCopy
        ' 
        BtnCopy.Location = New Point(324, 319)
        BtnCopy.Name = "BtnCopy"
        BtnCopy.Size = New Size(97, 53)
        BtnCopy.TabIndex = 4
        BtnCopy.Text = "Копировать"
        BtnCopy.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(425, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 15)
        Label1.TabIndex = 5
        Label1.Text = "Укажите длину пароля:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtnCopy)
        Controls.Add(TextBoxPassword)
        Controls.Add(CheckBoxSpecialChars)
        Controls.Add(CheckBoxNumbers)
        Controls.Add(CheckBoxLowerCase)
        Controls.Add(CheckBoxUpperCase)
        Controls.Add(NumericUpDown1)
        Controls.Add(BtnGenerate)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnGenerate As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBoxUpperCase As CheckBox
    Friend WithEvents CheckBoxLowerCase As CheckBox
    Friend WithEvents CheckBoxNumbers As CheckBox
    Friend WithEvents CheckBoxSpecialChars As CheckBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents BtnCopy As Button
    Friend WithEvents Label1 As Label

End Class
