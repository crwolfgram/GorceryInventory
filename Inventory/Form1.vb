Option Explicit On
Option Strict On
Imports System.ComponentModel

Public Class Form1
    'Selected item and department used to reference the item dispalyed and selected in lbx
    Dim selectedItem As Item
    Dim selectedDept As Department
    'Binding list used to store departments of objects, and display them in the lbx
    Dim departments As New BindingList(Of Department)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Populating departments array
        Dim grocery As New Department
        Dim produce As New Department
        Dim meat As New Department
        Dim frozen As New Department
        Dim bakery As New Department

        grocery.Name = "Grocery"
        grocery.Number = 1

        departments.Add(grocery)

        produce.Name = "Produce"
        produce.Number = 2

        departments.Add(produce)

        meat.Name = "Meat"
        meat.Number = 3

        departments.Add(meat)

        frozen.Name = "Frozen"
        frozen.Number = 4

        departments.Add(frozen)


        bakery.Name = "Bakery"
        bakery.Number = 5

        departments.Add(bakery)

        selectedDept = departments(0)

        'Populating lbx
        lbxDepartments.DataSource = departments
        lbxDepartments.DisplayMember = "Name"

        lbxItems.DataSource = selectedDept.Items
        lbxItems.DisplayMember = "Name"

        'Populating cbx
        cbxDepartment.Items.Add("Grocery")
        cbxDepartment.Items.Add("Produce")
        cbxDepartment.Items.Add("Meat")
        cbxDepartment.Items.Add("Frozen")
        cbxDepartment.Items.Add("Bakery")
        cbxDepartment.SelectedIndex = 0

    End Sub


    'Sub displays selected item
    Private Sub DispalyItems()

        'Checking if there is a selected item
        If Not selectedItem Is Nothing Then
            'Variable to hold dept total
            Dim deptTotal As Double

            'Setting lables to selected item info
            lblName.Text = selectedItem.Name
            lblQuantity.Text = selectedItem.Quantity.ToString
            lblPrice.Text = "$" + selectedItem.Price.ToString
            lblItemTotal.Text = "$" + selectedItem.Total.ToString
            lblDept.Text = selectedItem.deptName

            'Adding all the totals togoether for dept total
            For index = 0 To selectedDept.Items.Count - 1

                deptTotal += selectedDept.Items(index).Total

            Next

            lblDeptTotal.Text = "$" + deptTotal.ToString

        Else
            'Values for lables when no item selected
            lblName.Text = "N/A"
            lblQuantity.Text = "N/A"
            lblPrice.Text = "N/A"
            lblItemTotal.Text = "N/A"
            lblDept.Text = "N/A"
            lblDeptTotal.Text = "N/A"

        End If

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        'Try block to catch inputs that cannot be convereted
        Try

            If Not cbxDepartment.SelectedItem Is Nothing Then


                'Making sure name is not just spaces
                If Not txtName.Text.Trim = "" Or String.IsNullOrEmpty(cbxDepartment.SelectedItem.ToString) Then

                    'Checking which department is selected
                    'Works b/c the index for the cbx and lbxDept are the same
                    For index = 0 To departments.Count - 1

                        If cbxDepartment.SelectedIndex = index Then

                            'Assigning the correct index to the selected dept
                            selectedDept = departments(index)

                            'Boolean used to determine if the item exists, will be changed in the for loop if item exists
                            Dim newItem As Boolean = True

                            'For loop to determine in the item exits
                            For indexExists = 0 To selectedDept.Items.Count - 1

                                'If the item name matches one from items from the list, new Item changed to false
                                If txtName.Text.Trim = selectedDept.Items(indexExists).Name Then

                                    newItem = False
                                    selectedItem = selectedDept.Items(indexExists)
                                    MessageBox.Show("Item already exists in this department, the item  quantity and price have been updated.")

                                End If
                            Next

                            'Item created if the item is new, updated if it is false
                            If newItem Then

                                CreateItem(selectedDept)

                            Else

                                UpdateItem(selectedItem)

                            End If

                        End If

                    Next

                Else

                    MessageBox.Show("Please enter a valid name.")

                End If

            Else

                MessageBox.Show("Please add a department.")

            End If

        Catch ex As Exception

            MessageBox.Show("Please enter numbers only for Price and Quantity" + ex.Message)

        End Try

    End Sub

    Private Sub lbxDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDepartments.SelectedIndexChanged

        'Changing selected department to the one selected in the lbx
        selectedDept = CType(lbxDepartments.SelectedItem, Department)

        'Updating datasource and display for the lbxItems
        If Not lbxDepartments.SelectedItem Is Nothing Then

            lbxItems.DataSource = selectedDept.Items
            If Not selectedDept.Items.Count = 0 Then
                lbxItems.SelectedItem = selectedDept.Items(0)
                selectedItem = CType(lbxItems.SelectedItem, Item)
                DispalyItems()
            Else
                lbxItems.SelectedItem = Nothing
                selectedItem = Nothing
                DispalyItems()
            End If

            DispalyItems()

        End If

    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click

        'Deleteing item (if one is selected)
        If Not selectedDept Is Nothing Then

            selectedDept.Items.Remove(selectedItem)

            'Changing selected item to the one selected in the lbx
            selectedItem = CType(lbxItems.SelectedItem, Item)
            DispalyItems()

        Else

            MessageBox.Show("Please select an Item to delete first.")

        End If
    End Sub

    Private Sub lbxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxItems.SelectedIndexChanged

        'Changing selected item if the lbxItems changed
        selectedItem = CType(lbxItems.SelectedItem, Item)
        DispalyItems()

    End Sub

    Private Sub CreateItem(department As Department)

        'Sub called to create new item
        Dim newItem As New Item()

        'user inputs assigned to values in object
        newItem.Name = txtName.Text.ToString
        newItem.Price = CDbl(txtPrice.Text)
        newItem.Quantity = CInt(txtQuantity.Text)
        newItem.deptName = cbxDepartment.SelectedItem.ToString

        'Changing lbxDepartment to the selected department
        lbxDepartments.SelectedItem = department
        'Changing the items datasource to the correct department
        lbxItems.DataSource = department.Items

        'Adding new item to selected department
        department.Items.Add(newItem)

        selectedItem = newItem
        lbxItems.SelectedItem = newItem
        DispalyItems()

        'Clearing text boxes
        txtName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()


    End Sub

    Private Sub UpdateItem(item As Item)

        'Updating existing item
        selectedItem.Quantity += CInt(txtQuantity.Text)
        selectedItem.Price = CDbl(txtPrice.Text)
        DispalyItems()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Updates selected item
        If Not selectedItem Is Nothing Then

            UpdateItem(selectedItem)

        End If

    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click

        'Opens form2 to add department
        'Connects department list to form2's list
        Dim deptForm As New btnAddDept()

        deptForm.Departments = departments
        deptForm.Show()

    End Sub

    Private Sub btnDeptDelete_Click(sender As Object, e As EventArgs) Handles btnDeptDelete.Click
        'Removed selected department
        If Not selectedDept Is Nothing Then

            'Removing selected department from cbx
            For index = 0 To departments.Count - 1

                If departments(index).Name = selectedDept.Name Then

                    cbxDepartment.Items.RemoveAt(index)

                End If

            Next

            departments.Remove(selectedDept)

            'Making the selectedDept the one selected in the lbx
            selectedDept = CType(lbxDepartments.SelectedItem, Department)

            'Making the selected item the first in the lbxItems (if applicable)
            If Not selectedDept Is Nothing Then

                lbxItems.DataSource = selectedDept.Items
                If selectedDept.Items.Count = 0 Then

                    selectedItem = Nothing

                Else

                    selectedItem = selectedDept.Items(0)

                End If
                DispalyItems()
                cbxDepartment.SelectedIndex = 0

            End If

        End If
    End Sub
End Class
