Option Strict On

Imports System.ComponentModel
Imports System.Globalization

<Designer(GetType(HResizeOnly))>
Public Class MonthPicker
	Private _MinYear As Integer
	Private Months As List(Of MonthItem)

	Public Sub New()
		InitializeComponent()

		Dim T = Date.Today
		Months = Enumerable.Range(1, 12).Select(Function(i) New MonthItem(CUShort(i), DateTimeFormatInfo.CurrentInfo.GetMonthName(i))).ToList()
		CB_Month.DataSource = Months
		CB_Month.DisplayMember = "Name"
		CB_Month.ValueMember = "Index"
		CB_Month.SelectedValue = CUShort(T.Month)

		_MinYear = 2010
		FillYear()
	End Sub

#Region "Properties"

#Region "Designer"

	''' <summary>
	''' Минимальный год
	''' </summary>
	<Browsable(True), Category("MonthPicker"), DefaultValue(2010)>
	Public Property MinYear As Integer
		Get
			Return _MinYear
		End Get
		Set(value As Integer)
			_MinYear = value
			FillYear()
		End Set
	End Property

#End Region

	''' <summary>
	''' Первый день месяца
	''' </summary>
	<Browsable(True), Category("MonthPicker")>
	Public ReadOnly Property FirstDate As Date
		Get
			Return New Date(Year, Month, 1)
		End Get
	End Property

	''' <summary>
	''' Последний день месяца
	''' </summary>
	<Browsable(True), Category("MonthPicker")>
	Public ReadOnly Property LastDate As Date
		Get
			Return New Date(Year, Month, Date.DaysInMonth(Year, Month))
		End Get
	End Property

	''' <summary>
	''' Выбранный месяц
	''' </summary>
	<Browsable(False)>
	Public ReadOnly Property Month As UShort
		Get
			Return CUShort(CB_Month.SelectedValue)
		End Get
	End Property

	''' <summary>
	''' Выбранный год
	''' </summary>
	<Browsable(False)>
	Public ReadOnly Property Year As Integer
		Get
			Return CInt(CB_Year.SelectedItem)
		End Get
	End Property

#End Region

	Protected Sub OnDateChanged()
		RaiseEvent DateChanged(Me, EventArgs.Empty)
	End Sub

	Private Sub CB_Month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Month.SelectedIndexChanged
		OnDateChanged()
	End Sub

	Private Sub CB_Year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Year.SelectedIndexChanged
		OnDateChanged()
	End Sub

	Private Sub FillYear()
		Dim Y = Date.Today.Year
		CB_Year.DataSource = Enumerable.Range(MinYear, Y - MinYear + 1).ToList()
		If MinYear <= Y Then CB_Year.Text = Y.ToString
	End Sub

	Private Structure MonthItem

		Public Sub New(I As UShort, N As String)
			Index = I
			Name = N
		End Sub

		Public Property Index As UShort
		Public Property Name As String
	End Structure

	Public Event DateChanged(sender As Object, e As EventArgs)

End Class