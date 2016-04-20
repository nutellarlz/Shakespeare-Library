Imports System.IO

Public Class GitHubUpdater
    Private client As Object
    Dim latestTag

    Private Sub GitHubUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Octokit.

        Dim releases = client.Release.GetAll("nutellarlz", "Shakespeare-Library")
        Dim latest = releases(0)
        Console.WriteLine("The latest release is tagged at {0} and is named {1}", latest.TagName, latest.Name)
        latestTag = releases(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As String = Path.GetTempPath()
        Dim curFile As String = result + "\update.exe"

        If File.Exists(curFile) Then
            My.Computer.FileSystem.DeleteFile(result + "\update.exe")
        End If

        My.Computer.Network.DownloadFile(
    "https://github.com/nutellarlz/Shakespeare-Library/releases/download/" + "/update.exe",
    result + "\update.exe")
    End Sub
End Class