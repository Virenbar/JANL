Imports JANL.Beep

Module Beep

    Private ReadOnly StillAlive As Song
    Private ReadOnly Mary As Song
    Private Current As Song

    Sub New()
        Dim Score = {
            "R0H,G6E,F#6E,E6E,E6E,F#6H,R0H,R0Q,R0E,A5E,G6E,F#6E,E6E,E6E,F#6Q.,D6Q,E6E",
            "A5H,R5E,R0Q.,A5E,E6Q,F#6E,G6Q.,E6E,C#6Q,D6Q.,E6Q,A5E,A5Q,F#6Q.,R0H",
            "R0H,G6E,F#6E,E6E,E6E,F#6H,R0H,R0Q,R0E,A5E,G6E,F#6E,E6E,E6Q,F#6E,D6Q.,E6E",
            "A5H,R5E,R0Q.,E6Q,F#6E,G6Q.,E6E,C#6Q.,D6E,E6Q,A5E,D6E,E6E",
            "F6E,E6E,D6E,C6E,R0Q,A5E,Bb5E,C6Q,F6Q,E6E,D6E,D6E,C6E,D6E,C6E,C6Q,C6Q,A5E,Bb5E",
            "C6Q,F6Q,G6E,F6E,E6E,D6E,D6E,E6E,F6Q,F6Q,G6E,A6E,Bb6E,Bb6E,A6Q,G6Q,F6E,G6E",
            "A6E,A6E,G6Q,F6Q,D6E,C6E,D6E,F6E,F6E,E6Q,E6E,F#6E,F#6Q.",
            "A6E,A6E,G6Q,F6Q,D6E,C6E,D6E,F6E,F6E,E6Q,E6E,F#6E,F#6H",
            "G6E,A6E,A6Q,R0Q,R0E,G6E,F#6E,F#6Q",
            "G6E,A6E,A6Q,R0Q,R0E,G6E,F#6E,F#6Q"}
        StillAlive = Song.Parse(Score, 120)
        ' Declare the first few notes of the song, "Mary Had A Little Lamb".
        Mary = Song.Parse("BQ,AQ,G3Q,AQ,BQ,BQ,BH,AQ,AQ,AH,BQ,DQ,DH")
    End Sub

    Public Sub Play(Song As Song)
        If Current?.Playing Then
            Current.Stop()
            Exit Sub
        End If
        Current = Song
        Task.Run(Sub() Song.Play())
    End Sub

    Public Sub PlayMary()
        Play(Mary)
    End Sub

    Public Sub PlayStillAlive()
        Play(StillAlive)
    End Sub

End Module