Imports System.Speech.Synthesis

Public Class TTSPlayer
    Private CurrentPrompt As Prompt
    Private Synth As SpeechSynthesizer

    Public Sub New()
        InitializeComponent()

        Synth = New SpeechSynthesizer() With {
            .Rate = 2
        }
        AddHandler Synth.SpeakProgress, AddressOf Synth_SpeakProgress
        AddHandler Synth.StateChanged, AddressOf Synth_StateChanged
        AddHandler Synth.SpeakCompleted, AddressOf Synth_SpeakCompleted
        RefreshUI()
    End Sub

    Public ReadOnly Property Queue As Queue(Of Prompt) = New Queue(Of Prompt)

    Private Sub B_Pause_Click(sender As Object, e As EventArgs) Handles B_Pause.Click
        If Synth.State = SynthesizerState.Speaking Then
            Synth.Pause()
        End If
        RefreshUI()
    End Sub

    Private Sub B_Play_Click(sender As Object, e As EventArgs) Handles B_Play.Click
        Select Case Synth.State
            Case SynthesizerState.Ready
                Play()
            Case SynthesizerState.Speaking
                Synth.Pause()
            Case SynthesizerState.Paused
                Synth.Resume()
        End Select
    End Sub

    Private Sub B_Stop_Click(sender As Object, e As EventArgs) Handles B_Stop.Click
        Synth.SpeakAsyncCancel(CurrentPrompt)
        RefreshUI()
    End Sub

    Private Sub Play()
        If Queue.Count > 0 Then
            CurrentPrompt = Queue.Dequeue()
            Synth.SpeakAsync(CurrentPrompt)
        End If
        RefreshUI()
    End Sub

    Private Sub RefreshUI()
        B_Play.Enabled = Synth.State = SynthesizerState.Ready Or Synth.State = SynthesizerState.Paused
        B_Pause.Enabled = Synth.State = SynthesizerState.Speaking
        B_Stop.Enabled = Synth.State = SynthesizerState.Speaking Or Synth.State = SynthesizerState.Paused
    End Sub

    Private Sub Synth_SpeakCompleted(sender As Object, e As SpeakCompletedEventArgs)
        'L_Progress.Text = $"{e.Text.Length / e.CharacterPosition:P}"
        RefreshUI()
    End Sub

    Private Sub Synth_SpeakProgress(sender As Object, e As SpeakProgressEventArgs)
        L_Progress.Text = $"{e.Prompt.ToString().Length / e.CharacterPosition:P}"
    End Sub

    Private Sub Synth_StateChanged(sender As Object, e As StateChangedEventArgs)
        RefreshUI()
    End Sub

    Private Sub TB_Rate_Scroll(sender As Object, e As EventArgs) Handles TB_Rate.Scroll
        Synth.Rate = TB_Rate.Value
        If Synth.State = SynthesizerState.Speaking Then
            Synth.Pause()
            Synth.Resume()
        End If
        RefreshUI()
    End Sub

End Class