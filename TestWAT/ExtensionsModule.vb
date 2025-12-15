Imports System.Runtime.CompilerServices

Module ExtensionsModule

    <Extension()>
    Public Sub BindSettings(form As Form)
        form.DataBindings.Add(New Binding("Font", My.Settings, "Font", True, DataSourceUpdateMode.OnPropertyChanged))
        form.DataBindings.Add(New Binding("ForeColor", My.Settings, "ForeColor", True, DataSourceUpdateMode.OnPropertyChanged))
        form.DataBindings.Add(New Binding("BackColor", My.Settings, "BackColor", True, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

End Module