Imports System.Threading

Module Beep

	Public Sub PlayMary()
		' Declare the first few notes of the song, "Mary Had A Little Lamb".
		Dim Mary As Note() = {
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.G, 3, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.B, Duration.HALF),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.HALF),
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.D, Duration.QUARTER),
			New Note(NoteMIDI.D, Duration.HALF)}
		'Task.Run(Sub() Play(Mary))
		Dim Tree As Note() = {
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.G, 3, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.B, Duration.HALF),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.QUARTER),
			New Note(NoteMIDI.A, Duration.HALF),
			New Note(NoteMIDI.B, Duration.QUARTER),
			New Note(NoteMIDI.D, Duration.QUARTER),
			New Note(NoteMIDI.D, Duration.HALF)}
		Task.Run(Sub() Play(Tree))
		'Play(Mary)
	End Sub

	' Play the notes in a song.
	Private Sub Play(tune() As Note)
		Dim n As Note
		For Each n In tune
			If n.NoteFrequency = 0 Then
				Thread.Sleep(n.NoteDuration)
			Else
				Console.Beep(n.NoteFrequency, n.NoteDuration)
			End If
		Next n
	End Sub

	Public Class Song
		Private song As List(Of Note)

		Public Sub New()

		End Sub

		Public Sub Play()
			For Each n In song
				If n.NoteFrequency = 0 Then
					Thread.Sleep(n.NoteDuration)
				Else
					Console.Beep(n.NoteFrequency, n.NoteDuration)
				End If
			Next n
		End Sub

	End Class

	Private Enum Note4
		REST = 0
		C = 262
		Csharp = 277
		D = 294
		Dsharp = 311
		E = 330
		F = 349
		Fsharp = 370
		G = 392
		Gsharp = 415
		A = 440
		Asharp = 466
		B = 494
	End Enum

	Private Enum NoteMIDI
		REST = 0
		C = 60
		Csharp = 61
		D = 62
		Dsharp = 63
		E = 64
		F = 65
		Fsharp = 66
		G = 67
		Gsharp = 68
		A = 69
		Asharp = 70
		B = 71
	End Enum

	Private Enum Duration
		WHOLE = 1600
		HALF = WHOLE \ 2
		QUARTER = HALF \ 2
		EIGHTH = QUARTER \ 2
		SIXTEENTH = EIGHTH \ 2
	End Enum 'Duration

	Private Structure Note
		Const A440 = 440

		Public Sub New(frequency As Note4, oct As Integer, time As Duration)
			NoteOctave = oct : NoteDuration = time
			NoteFrequency = CInt((frequency \ 8) * (2 ^ NoteOctave))
		End Sub

		Public Sub New(frequency As Note4, time As Duration)
			NoteOctave = 4 : NoteDuration = time
			NoteFrequency = frequency
		End Sub

		Public Sub New(note As NoteMIDI, time As Duration)
			Me.New(note, 4, time)
		End Sub

		Public Sub New(note As NoteMIDI, oct As Integer, time As Duration)
			NoteOctave = oct : NoteDuration = time
			If note = Beep.NoteMIDI.REST Then
				NoteMIDI = 0 : NoteFrequency = 0
			Else
				NoteMIDI = note - 12 * (4 - oct)
				NoteFrequency = CInt(A440 * 2 ^ ((NoteMIDI - 69) / 12))
			End If
		End Sub

		Public Sub New(time As Duration)
			NoteOctave = 0 : NoteDuration = time
			NoteMIDI = 0 : NoteFrequency = 0
		End Sub

		Public ReadOnly Property NoteMIDI As Integer
		Public ReadOnly Property NoteFrequency As Integer
		Public ReadOnly Property NoteOctave As Integer
		Public ReadOnly Property NoteDuration As Duration
	End Structure

End Module