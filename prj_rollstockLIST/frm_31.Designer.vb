<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_31
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnCompleteRoll = New System.Windows.Forms.Button()
        Me.lblToWeight = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblWEIGHT = New System.Windows.Forms.Label()
        Me.lblGSM = New System.Windows.Forms.Label()
        Me.lblBF = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtWEIGHT = New System.Windows.Forms.TextBox()
        Me.txtGSM = New System.Windows.Forms.TextBox()
        Me.txtBF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(498, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 45)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SIZE :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "SELECTED ROLL"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(158, 38)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "0"
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.AutoSize = True
        Me.lblTotalWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotalWeight.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWeight.Location = New System.Drawing.Point(106, 380)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(25, 30)
        Me.lblTotalWeight.TabIndex = 13
        Me.lblTotalWeight.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.lblTotalWeight)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.btnCompleteRoll)
        Me.GroupBox2.Controls.Add(Me.lblToWeight)
        Me.GroupBox2.Location = New System.Drawing.Point(606, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 425)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(61, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(499, 235)
        Me.DataGridView1.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(61, 63)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(499, 35)
        Me.txtSearch.TabIndex = 8
        '
        'btnCompleteRoll
        '
        Me.btnCompleteRoll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCompleteRoll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompleteRoll.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteRoll.Location = New System.Drawing.Point(428, 368)
        Me.btnCompleteRoll.Name = "btnCompleteRoll"
        Me.btnCompleteRoll.Size = New System.Drawing.Size(132, 38)
        Me.btnCompleteRoll.TabIndex = 10
        Me.btnCompleteRoll.Text = "COMPLETE "
        Me.btnCompleteRoll.UseVisualStyleBackColor = False
        '
        'lblToWeight
        '
        Me.lblToWeight.AutoSize = True
        Me.lblToWeight.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToWeight.Location = New System.Drawing.Point(56, 350)
        Me.lblToWeight.Name = "lblToWeight"
        Me.lblToWeight.Size = New System.Drawing.Size(143, 30)
        Me.lblToWeight.TabIndex = 11
        Me.lblToWeight.Text = "Total Weight "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(609, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 45)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "31"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblWEIGHT)
        Me.GroupBox1.Controls.Add(Me.lblGSM)
        Me.GroupBox1.Controls.Add(Me.lblBF)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.txtWEIGHT)
        Me.GroupBox1.Controls.Add(Me.txtGSM)
        Me.GroupBox1.Controls.Add(Me.txtBF)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 425)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'lblWEIGHT
        '
        Me.lblWEIGHT.AutoSize = True
        Me.lblWEIGHT.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWEIGHT.ForeColor = System.Drawing.Color.Black
        Me.lblWEIGHT.Location = New System.Drawing.Point(57, 194)
        Me.lblWEIGHT.Name = "lblWEIGHT"
        Me.lblWEIGHT.Size = New System.Drawing.Size(103, 30)
        Me.lblWEIGHT.TabIndex = 1
        Me.lblWEIGHT.Text = "WEIGHT :"
        '
        'lblGSM
        '
        Me.lblGSM.AutoSize = True
        Me.lblGSM.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGSM.ForeColor = System.Drawing.Color.Black
        Me.lblGSM.Location = New System.Drawing.Point(91, 153)
        Me.lblGSM.Name = "lblGSM"
        Me.lblGSM.Size = New System.Drawing.Size(69, 30)
        Me.lblGSM.TabIndex = 1
        Me.lblGSM.Text = "GSM :"
        '
        'lblBF
        '
        Me.lblBF.AutoSize = True
        Me.lblBF.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBF.ForeColor = System.Drawing.Color.Black
        Me.lblBF.Location = New System.Drawing.Point(112, 110)
        Me.lblBF.Name = "lblBF"
        Me.lblBF.Size = New System.Drawing.Size(48, 30)
        Me.lblBF.TabIndex = 1
        Me.lblBF.Text = "BF :"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInsert.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(283, 235)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(107, 43)
        Me.btnInsert.TabIndex = 7
        Me.btnInsert.Text = "SAVE"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'txtWEIGHT
        '
        Me.txtWEIGHT.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWEIGHT.Location = New System.Drawing.Point(166, 194)
        Me.txtWEIGHT.Name = "txtWEIGHT"
        Me.txtWEIGHT.Size = New System.Drawing.Size(224, 35)
        Me.txtWEIGHT.TabIndex = 6
        '
        'txtGSM
        '
        Me.txtGSM.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSM.Location = New System.Drawing.Point(166, 153)
        Me.txtGSM.Name = "txtGSM"
        Me.txtGSM.Size = New System.Drawing.Size(224, 35)
        Me.txtGSM.TabIndex = 5
        '
        'txtBF
        '
        Me.txtBF.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBF.Location = New System.Drawing.Point(166, 112)
        Me.txtBF.Name = "txtBF"
        Me.txtBF.Size = New System.Drawing.Size(224, 35)
        Me.txtBF.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(360, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 45)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SHREE RAM ROLL PURCHASE STOCK LIST"
        '
        'frm_31
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_31"
        Me.Text = "SHREE RAM ROLL PURCHASE  STOCK LIST "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblTotalWeight As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnCompleteRoll As Button
    Friend WithEvents lblToWeight As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblWEIGHT As Label
    Friend WithEvents lblGSM As Label
    Friend WithEvents lblBF As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtWEIGHT As TextBox
    Friend WithEvents txtGSM As TextBox
    Friend WithEvents txtBF As TextBox
    Friend WithEvents Label1 As Label
End Class
