Public Class Form1

    Dim Spliten As Boolean = True

#Region "Play Titles"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'RichTextBox1.Text = (Environment.CurrentDirectory + "\Alls Well that Ends Well.txt")
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\All's Well that Ends Well.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\As You Like It.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\The Comedy Of Errors.txt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Cymbeline.txt")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Love's Labour's Lost.txt")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Measure for Measure.txt")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Merry Wives of Windsor.txt")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Merchant of Venice.txt")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Midsummer Night's Dream.txt")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Much Ado About Nothing.txt")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Pericles.txt")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Taming of the Shrew.txt")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\The Tempest.txt")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Troiles and Cressida.txt")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Twelfth Night.txt")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Two Gentlemen of Verona.txt")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Winter's Tale.txt")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry IV, part 1.txt")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry IV, part 2.txt")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry V.txt")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry VI, part 1.txt")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry VI, part 2.txt")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry VI, part 3.txt")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Henry VIII.txt")
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\King John.txt")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Richard II.txt")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Richard III.txt")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Antony and Cleopatra.txt")
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\The Tragedy of Coriolanus.txt")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Hamlet.txt")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\The Death of Julius Caesar.txt")
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\King Lear.txt")
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Macbeth.txt")
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Othello.txt")
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Romeo an Juliet.txt")
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Timon of Athens.txt")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Titus Andronicus.txt")
    End Sub
#End Region

    Private Sub RibbonButton2_Click(sender As Object, e As EventArgs) Handles RibbonButton2.Click
        AxWebBrowser1.GoBack()
    End Sub

    Private Sub RibbonButton3_Click(sender As Object, e As EventArgs) Handles RibbonButton3.Click
        AxWebBrowser1.GoForward()
    End Sub

    Private Sub RibbonButton5_Click(sender As Object, e As EventArgs) Handles RibbonButton5.Click
        If Spliten = True Then
            SplitContainer1.Panel1.Enabled = False
            Spliten = False
        Else
            SplitContainer1.Panel1.Enabled = True
            Spliten = True
        End If
    End Sub

    Private Sub AxWebBrowser1_NavigateComplete2(sender As Object, e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event) Handles AxWebBrowser1.NavigateComplete2
        ToolStripStatusLabel1.Text = AxWebBrowser1.LocationName + " Loaded"
    End Sub

    Private Sub RibbonButton6_Click(sender As Object, e As EventArgs) Handles RibbonButton6.Click
        AxWebBrowser1.Refresh()
    End Sub

    Private Sub RibbonButton4_Click(sender As Object, e As EventArgs) Handles RibbonButton4.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Welcome to the new William Shakespeare Library.htm")
    End Sub

    Private Sub AxWebBrowser1_NavigateError(sender As Object, e As AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent) Handles AxWebBrowser1.NavigateError
        ToolStripStatusLabel1.Text = "Oops... We've encountered an error"
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Error.htm")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\Welcome to the new William Shakespeare Library.htm")
    End Sub

    Private Sub RibbonButton7_Click(sender As Object, e As EventArgs) Handles RibbonButton7.Click
        AboutBox1.Visible = True
    End Sub

    Private Sub RibbonButton8_Click(sender As Object, e As EventArgs) Handles RibbonButton8.Click
        Feedback.Visible = True
    End Sub

    Private Sub RibbonButton9_Click(sender As Object, e As EventArgs) Handles RibbonButton9.Click
        AxWebBrowser1.Navigate(Environment.CurrentDirectory + "\License.txt")

    End Sub

    Private Sub RibbonButton10_Click(sender As Object, e As EventArgs) Handles RibbonButton10.Click
        GitHubUpdater.Visible = True
    End Sub
End Class
