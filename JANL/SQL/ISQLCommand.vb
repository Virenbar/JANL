Imports System.Data.SqlClient

Namespace SQL

	Public Interface ISQLCommand

		Sub Execute()

		Sub Execute(tr As SqlTransaction)

		Sub Execute(conn As SqlConnection)

	End Interface

End Namespace