Imports JANL
Imports JANL.Forms
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json

Namespace My
    ' Для MyApplication имеются следующие события:
    ' Startup: возникает при запуске приложения перед созданием начальной формы.
    ' Shutdown: возникает после закрытия всех форм приложения.  Это событие не создается, если происходит аварийное завершение работы приложения.
    ' UnhandledException: возникает, если в приложении обнаруживается необработанное исключение.
    ' StartupNextInstance: возникает при запуске приложения, допускающего одновременное выполнение только одного экземпляра, если это приложение уже активно.
    ' NetworkAvailabilityChanged: возникает при изменении состояния подключения — при подключении или отключении.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            'Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR")
            Config.Current = JsonConvert.DeserializeObject(Of Config)(IO.File.ReadAllText("Config.json"))
            'JANL.My.MySettings.Default.Font
            Defaults.Connection = "Data Source=PARTSERVER2014;Initial Catalog=wpeople_SPR;Integrated Security=True"
            '
            ExceptionBox.DefaultText = "Произошла непредвиденная ошибка. Отправьте ошибку по почте, либо скопируйте и отправьте другим доступным способом"
            ExceptionBox.MailInfo = New ExceptionBox.EMail() With {
                .[To] = Config.Current.ExceptionMail,
                .Subject = "Ошибка TestWAT",
                .Text = $"Примечание:{vbNewLine}<Место для примечания>"
            }
            ExceptionBox.WittyComments = {
                "Ух... Это сделал я?",
                "Упсс",
                "Прости, Дейв.",
                "Почему оно ломается? :(",
                "Но оно работает на моём компьютере.",
                "Я просто незнаю что пошло не так.",
                "Простите :(",
                "Я подвёл тебя. Прости :(",
                "Задача провалена успешно"}
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            Dim EB = New ExceptionBox(e.Exception)
            EB.ShowDialog()
        End Sub

    End Class

End Namespace