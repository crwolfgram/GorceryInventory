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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lbxDepartments = New System.Windows.Forms.ListBox()
        Me.lbxItems = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblDeptTotal = New System.Windows.Forms.Label()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblItemTotal = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDept = New System.Windows.Forms.Button()
        Me.btnDeptDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add to the Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 170)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Item Price:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(133, 68)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 22)
        Me.txtName.TabIndex = 4
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(133, 132)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(132, 22)
        Me.txtQuantity.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(133, 191)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 22)
        Me.txtPrice.TabIndex = 6
        '
        'cbxDepartment
        '
        Me.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.Location = New System.Drawing.Point(133, 250)
        Me.cbxDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(132, 24)
        Me.cbxDepartment.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Department:"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(37, 292)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(161, 57)
        Me.btnAddItem.TabIndex = 9
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'lbxDepartments
        '
        Me.lbxDepartments.FormattingEnabled = True
        Me.lbxDepartments.ItemHeight = 16
        Me.lbxDepartments.Location = New System.Drawing.Point(385, 68)
        Me.lbxDepartments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbxDepartments.Name = "lbxDepartments"
        Me.lbxDepartments.Size = New System.Drawing.Size(208, 148)
        Me.lbxDepartments.TabIndex = 10
        '
        'lbxItems
        '
        Me.lbxItems.FormattingEnabled = True
        Me.lbxItems.ItemHeight = 16
        Me.lbxItems.Location = New System.Drawing.Point(604, 68)
        Me.lbxItems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbxItems.Name = "lbxItems"
        Me.lbxItems.Size = New System.Drawing.Size(208, 212)
        Me.lbxItems.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(381, 48)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Departments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(600, 48)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Items"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(820, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Item Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(820, 130)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Item Quantity:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(820, 161)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Item Price:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(820, 226)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Department:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label.Location = New System.Drawing.Point(820, 260)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(144, 20)
        Me.Label.TabIndex = 18
        Me.Label.Text = "Department Total:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblName.Location = New System.Drawing.Point(923, 98)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(15, 20)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "*"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPrice.Location = New System.Drawing.Point(916, 161)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(15, 20)
        Me.lblPrice.TabIndex = 20
        Me.lblPrice.Text = "*"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQuantity.Location = New System.Drawing.Point(941, 130)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(15, 20)
        Me.lblQuantity.TabIndex = 21
        Me.lblQuantity.Text = "*"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDept.Location = New System.Drawing.Point(931, 226)
        Me.lblDept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(15, 20)
        Me.lblDept.TabIndex = 22
        Me.lblDept.Text = "*"
        '
        'lblDeptTotal
        '
        Me.lblDeptTotal.AutoSize = True
        Me.lblDeptTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDeptTotal.Location = New System.Drawing.Point(981, 260)
        Me.lblDeptTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeptTotal.Name = "lblDeptTotal"
        Me.lblDeptTotal.Size = New System.Drawing.Size(15, 20)
        Me.lblDeptTotal.TabIndex = 23
        Me.lblDeptTotal.Text = "*"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(604, 292)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(208, 57)
        Me.btnDeleteItem.TabIndex = 24
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(820, 193)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 20)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Item Total:"
        '
        'lblItemTotal
        '
        Me.lblItemTotal.AutoSize = True
        Me.lblItemTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblItemTotal.Location = New System.Drawing.Point(916, 193)
        Me.lblItemTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemTotal.Name = "lblItemTotal"
        Me.lblItemTotal.Size = New System.Drawing.Size(15, 20)
        Me.lblItemTotal.TabIndex = 26
        Me.lblItemTotal.Text = "*"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(205, 292)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(161, 57)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update Selection"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDept
        '
        Me.btnDept.Location = New System.Drawing.Point(388, 229)
        Me.btnDept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDept.Name = "btnDept"
        Me.btnDept.Size = New System.Drawing.Size(208, 57)
        Me.btnDept.TabIndex = 28
        Me.btnDept.Text = "Add Department"
        Me.btnDept.UseVisualStyleBackColor = True
        '
        'btnDeptDelete
        '
        Me.btnDeptDelete.Location = New System.Drawing.Point(388, 293)
        Me.btnDeptDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeptDelete.Name = "btnDeptDelete"
        Me.btnDeptDelete.Size = New System.Drawing.Size(208, 57)
        Me.btnDeptDelete.TabIndex = 29
        Me.btnDeptDelete.Text = "Delete Department"
        Me.btnDeptDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeptDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 391)
        Me.Controls.Add(Me.btnDeptDelete)
        Me.Controls.Add(Me.btnDept)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblItemTotal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.lblDeptTotal)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbxItems)
        Me.Controls.Add(Me.lbxDepartments)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxDepartment)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Grocery Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbxDepartment As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lbxDepartments As ListBox
    Friend WithEvents lbxItems As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents lblDeptTotal As Label
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents lblItemTotal As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDept As Button
    Friend WithEvents btnDeptDelete As Button
End Class
