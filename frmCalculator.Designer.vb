<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFirstNum = New System.Windows.Forms.Label()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.lblSecondNum = New System.Windows.Forms.Label()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.cboDecimals = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstNum
        '
        Me.lblFirstNum.AutoSize = True
        Me.lblFirstNum.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFirstNum.Location = New System.Drawing.Point(162, 80)
        Me.lblFirstNum.Name = "lblFirstNum"
        Me.lblFirstNum.Size = New System.Drawing.Size(102, 64)
        Me.lblFirstNum.TabIndex = 0
        Me.lblFirstNum.Text = "First" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirstNum.Location = New System.Drawing.Point(162, 161)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(125, 39)
        Me.txtFirstNum.TabIndex = 1
        Me.txtFirstNum.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtFirstNum, "Enter positive or negative integer or real number or 0")
        '
        'lblSecondNum
        '
        Me.lblSecondNum.AutoSize = True
        Me.lblSecondNum.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSecondNum.Location = New System.Drawing.Point(485, 80)
        Me.lblSecondNum.Name = "lblSecondNum"
        Me.lblSecondNum.Size = New System.Drawing.Size(102, 64)
        Me.lblSecondNum.TabIndex = 0
        Me.lblSecondNum.Text = "Second" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSecondNum.Location = New System.Drawing.Point(485, 161)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(125, 39)
        Me.txtSecondNum.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtSecondNum, "Enter positive or negative integer or real number or 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(unless performing divisi" &
        "on)")
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(332, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 67)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Tag = "The sum of"
        Me.btnAdd.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add the two numbers specified" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtract.Location = New System.Drawing.Point(332, 103)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(91, 67)
        Me.btnSubtract.TabIndex = 3
        Me.btnSubtract.Tag = "The difference of"
        Me.btnSubtract.Text = "-"
        Me.ToolTip1.SetToolTip(Me.btnSubtract, "Subtract the two numbers specified" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.Location = New System.Drawing.Point(332, 186)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(91, 67)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Tag = "The product of"
        Me.btnMultiply.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnMultiply, "Multiply the two numbers specified" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(332, 271)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(91, 67)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Tag = "The quotient of"
        Me.btnDivide.Text = "÷"
        Me.ToolTip1.SetToolTip(Me.btnDivide, "Divide the two numbers specified")
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'cboDecimals
        '
        Me.cboDecimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecimals.FormattingEnabled = True
        Me.cboDecimals.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cboDecimals.Location = New System.Drawing.Point(633, 54)
        Me.cboDecimals.Name = "cboDecimals"
        Me.cboDecimals.Size = New System.Drawing.Size(98, 28)
        Me.cboDecimals.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cboDecimals, "Specify the number of decimals in the calculated result")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(644, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear numbers entered and results")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtResult.Location = New System.Drawing.Point(63, 377)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(675, 39)
        Me.txtResult.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(622, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Precision"
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDecimals)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.lblSecondNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.lblFirstNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstNum As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblSecondNum As Label
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents cboDecimals As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
End Class
