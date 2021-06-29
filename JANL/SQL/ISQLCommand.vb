Imports System.Data.SqlClient

Namespace SQL

	Public Interface ISQLCommand
		ReadOnly Property Command As SqlCommand

	End Interface

End Namespace