<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.remin_txt = New System.Windows.Forms.Label()
        Me.loadbtn = New MetroFramework.Controls.MetroButton()
        Me.loadproxy = New MetroFramework.Controls.MetroButton()
        Me.Button2 = New MetroFramework.Controls.MetroButton()
        Me.Button3 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(44, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Threads:"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OwnerDraw = True
        Me.ListView1.Size = New System.Drawing.Size(846, 348)
        Me.ListView1.Style = MetroFramework.MetroColorStyle.Green
        Me.ListView1.TabIndex = 12
        Me.ListView1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseSelectable = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Combo"
        Me.ColumnHeader1.Width = 226
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 177
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 136
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Country"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Subscription"
        Me.ColumnHeader5.Width = 258
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Proxy"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(12, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Good: 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Bad: 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(12, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Error: 0"
        '
        'remin_txt
        '
        Me.remin_txt.AutoSize = True
        Me.remin_txt.BackColor = System.Drawing.Color.Transparent
        Me.remin_txt.ForeColor = System.Drawing.Color.Blue
        Me.remin_txt.Location = New System.Drawing.Point(12, 440)
        Me.remin_txt.Name = "remin_txt"
        Me.remin_txt.Size = New System.Drawing.Size(73, 15)
        Me.remin_txt.TabIndex = 11
        Me.remin_txt.Text = "Remain: 0"
        '
        'loadbtn
        '
        Me.loadbtn.Location = New System.Drawing.Point(10, 147)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(138, 28)
        Me.loadbtn.Style = MetroFramework.MetroColorStyle.Green
        Me.loadbtn.TabIndex = 12
        Me.loadbtn.Text = "Load Combo"
        Me.loadbtn.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.loadbtn.UseSelectable = True
        '
        'loadproxy
        '
        Me.loadproxy.Location = New System.Drawing.Point(10, 189)
        Me.loadproxy.Name = "loadproxy"
        Me.loadproxy.Size = New System.Drawing.Size(138, 32)
        Me.loadproxy.TabIndex = 13
        Me.loadproxy.Text = "Load Proxy"
        Me.loadproxy.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.loadproxy.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Start"
        Me.Button2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button2.UseSelectable = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 32)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Exit"
        Me.Button3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Button3.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold
        Me.MetroTabControl1.Location = New System.Drawing.Point(150, 87)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(854, 386)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabControl1.TabIndex = 16
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.MetroTabPage1.Controls.Add(Me.ListView1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 7
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 34)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(846, 348)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "List"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 4
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.MetroTabPage2.Controls.Add(Me.PictureBox2)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 7
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 34)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(846, 348)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "About"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(846, 348)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(785, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "© !            Uchiha, Madara#8738"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.DimGray
        Me.NumericUpDown1.Location = New System.Drawing.Point(15, 312)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(129, 21)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(901, 63)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 19)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Show Free"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(35, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Proxy-Type:"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"HTTP(S)", "SOCKS4", "SOCKS5"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(10, 251)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(134, 29)
        Me.MetroComboBox1.TabIndex = 21
        Me.MetroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroComboBox1.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(12, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Free: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 550)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.loadproxy)
        Me.Controls.Add(Me.loadbtn)
        Me.Controls.Add(Me.remin_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Account Checker By Amir v0.3"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TransparencyKey = System.Drawing.SystemColors.ControlDark
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents remin_txt As System.Windows.Forms.Label
    Friend WithEvents ListView1 As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents loadbtn As MetroFramework.Controls.MetroButton
    Friend WithEvents loadproxy As MetroFramework.Controls.MetroButton
    Friend WithEvents Button2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Button3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
