Imports System.Data
Imports System.Data.SqlClient
Module global_set
    Public con As New SqlConnection("Data Source = tcp:JESS-5780K20,8199; Initial Catalog = JVI_Money; Integrated Security = True")
    Public setradbtn As Integer
    Public userid As Integer
    Public usersaldo As Decimal
End Module
