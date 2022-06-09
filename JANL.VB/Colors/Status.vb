Imports System.Drawing

Namespace Colors

    ''' <summary>
    ''' Status colors palette
    ''' </summary>
    ''' <remarks>
    ''' https://www.astrouxds.com/patterns/status-system/
    ''' </remarks>
    Friend Structure Status
        Public Shared ReadOnly Property Critical As Color = Color.FromArgb(255, 56, 56)
        Public Shared ReadOnly Property Serious As Color = Color.FromArgb(255, 179, 2)
        Public Shared ReadOnly Property Caution As Color = Color.FromArgb(252, 232, 58)
        Public Shared ReadOnly Property Normal As Color = Color.FromArgb(86, 240, 0)
        Public Shared ReadOnly Property Standby As Color = Color.FromArgb(45, 204, 255)
        Public Shared ReadOnly Property Off As Color = Color.FromArgb(158, 167, 173)

    End Structure

End Namespace