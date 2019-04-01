Imports System.ComponentModel

Public Class btnAddDept

    'Bindng list used as instance of departments existing in form1
    Private gdepartments As New BindingList(Of Department)

    Public Property Departments() As BindingList(Of Department)
        Get
            Return gdepartments
        End Get
        Set(ByVal value As BindingList(Of Department))
            gdepartments = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Variable to hold new Department
        'Boolean used to decide to create new deparmtent or not
        Dim newDept As New Department
        Dim deptExists As Boolean = False

        'Making sure user does not enter just spaces
        If Not txtDeptName.Text.Trim = "" Then

            'Try block used to catch invalid conversions
            Try

                'Checking department names to see if the deparment exists
                For index = 0 To gdepartments.Count - 1

                    'deptExists will set to true if the name or dept number already exists
                    If txtDeptName.Text = gdepartments(index).Name Or CInt(txtDeptNumber.Text) = gdepartments(index).Number Then

                        deptExists = True

                    End If

                Next

                'If it is a new deprartment, it will be created
                If deptExists = False Then

                    'Setting new department values
                    newDept.Name = txtDeptName.Text
                    newDept.Number = CInt(txtDeptNumber.Text)
                    gdepartments.Add(newDept)

                    'Creating connection to form 1
                    Dim form1 As Form1 = Application.OpenForms().OfType(Of Form1).Single()
                    'Adding new Department name to cbx
                    form1.cbxDepartment.Items.Add(newDept.Name)
                    form1.cbxDepartment.SelectedIndex = 0

                    'Closing form
                    Me.Close()

                Else
                    'Message shows if the deptartment exists
                    MessageBox.Show("Department already exists.")

                End If



            Catch ex As Exception

            End Try


        Else

            MessageBox.Show("Please enter a valid name.")

        End If

    End Sub


End Class