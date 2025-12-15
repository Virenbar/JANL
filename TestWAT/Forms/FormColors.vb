Imports System.Reflection
Imports JANL.Controls
Imports JANL.Drawing

Public Class FormColors

    Private Sub AddPanels()

        'Dim dark = GetColors(Of AstroColor.Dark)()
        'Dim light = GetColors(Of AstroColor.Light)()
        'Dim lightB = GetColors(Of AstroColor.LightBorder)()

        'For Each Color In dark
        '    Dim P = New Panel() With {
        '        .BackColor = Color.Value,
        '        .Size = New Size(150, 50)
        '    }
        '    FLP_Dark.Controls.Add(P)
        'Next

        'For Each Color In light
        '    Dim P = New Panel() With {
        '        .BackColor = Color.Value,
        '        .Dock = DockStyle.Fill
        '    }
        '    Dim Border = New Panel() With {
        '        .BackColor = lightB(Color.Key),
        '        .Padding = New Padding(2),
        '        .Size = New Size(150, 50)
        '    }
        '    Border.Controls.Add(P)
        '    FLP_Light.Controls.Add(Border)
        'Next

        FLP_Dark.Controls.Clear()
        FLP_Light.Controls.Clear()
        For Each S As AstroStatus In [Enum].GetValues(GetType(AstroStatus))
            Dim dark = New AstroStatusPanel(S) With {.Size = New Size(150, 50), .DarkMode = True}
            FLP_Dark.Controls.Add(dark)
            Dim light = New AstroStatusPanel(S) With {.Size = New Size(150, 50), .Padding = New Padding(3)}
            FLP_Light.Controls.Add(light)
        Next
    End Sub

    Private Function GetColors(Of T)() As Dictionary(Of String, Color)
        Dim R = GetType(T).
            GetProperties(BindingFlags.Static Or BindingFlags.Public).
            Where(Function(P) P.PropertyType.Name = GetType(Color).Name).
            ToDictionary(Function(P) P.Name, Function(P) DirectCast(P.GetValue(Nothing), Color))
        Return R
    End Function

    Private Sub FormColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindSettings()
        AddPanels()
    End Sub

End Class