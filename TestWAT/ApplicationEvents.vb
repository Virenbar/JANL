Imports Microsoft.VisualBasic.ApplicationServices
Imports OfficeOpenXml
Imports Newtonsoft.Json
Imports JANL

Namespace My
	' Для MyApplication имеются следующие события:
	' Startup: возникает при запуске приложения перед созданием начальной формы.
	' Shutdown: возникает после закрытия всех форм приложения.  Это событие не создается, если происходит аварийное завершение работы приложения.
	' UnhandledException: возникает, если в приложении обнаруживается необработанное исключение.
	' StartupNextInstance: возникает при запуске приложения, допускающего одновременное выполнение только одного экземпляра, если это приложение уже активно.
	' NetworkAvailabilityChanged: возникает при изменении состояния подключения — при подключении или отключении.
	Partial Friend Class MyApplication

		Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
			Config.Current = JsonConvert.DeserializeObject(Of Config)(IO.File.ReadAllText("Config.json"))
			ExceptionBox.MailTo = Config.Current.ExceptionMail
			ExceptionBox.MailSubject = "Ошибка TestWAT"
			'ExcelPackage.LicenseContext = LicenseContext.NonCommercial
			'Await Helpers.Bankrupt.Init()
		End Sub

		Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
			e.ExitApplication = False
			Dim EB = New ExceptionBox(e.Exception)
			EB.ShowDialog()
		End Sub

	End Class

End Namespace