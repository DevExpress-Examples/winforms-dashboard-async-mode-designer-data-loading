Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace DashboardDesignerAsyncModeExample
	Public Class SalesData
		Public Property Id() As Integer
		Public Property SalesPerson() As String
		Public Property Quantity() As Integer
		Public Property OrderDate() As Date

		Public Shared Function CreateData() As List(Of SalesData)
			Dim data As New List(Of SalesData)()
			Dim rand As New Random()
			Dim salesPersons() As String = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio", "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" }

			For i As Integer = 0 To 999
				Dim record As New SalesData()
				record.Id = i
				record.SalesPerson = salesPersons(rand.Next(0, salesPersons.Length))
				record.Quantity = rand.Next(0, 100)
				record.OrderDate = (New Date(Date.Today.Year, 1, 1)).AddDays(rand.Next(1, 365))
				data.Add(record)
				Delay()
			Next i
			Return data
		End Function

		Private Shared Sub Delay()
			Dim arrayStr() As String = Enumerable.Range(0, 20*1000).Select((Function(i) i.ToString())).ToArray()
		End Sub
	End Class
End Namespace
