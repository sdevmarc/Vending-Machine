<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.pbMilk = New System.Windows.Forms.PictureBox()
        Me.pbDel = New System.Windows.Forms.PictureBox()
        Me.pbGat = New System.Windows.Forms.PictureBox()
        Me.pbGum = New System.Windows.Forms.PictureBox()
        Me.pbPringles = New System.Windows.Forms.PictureBox()
        Me.pbSoda = New System.Windows.Forms.PictureBox()
        CType(Me.pbMilk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPringles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSoda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 39)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "R E C E I P T"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(57, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 26)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "THANK YOU FOR THE PURCHASE!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(86, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 23)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "CHANGE"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(242, 257)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(20, 23)
        Me.lblChange.TabIndex = 42
        Me.lblChange.Text = "0"
        '
        'pbMilk
        '
        Me.pbMilk.Image = CType(resources.GetObject("pbMilk.Image"), System.Drawing.Image)
        Me.pbMilk.Location = New System.Drawing.Point(128, 71)
        Me.pbMilk.Name = "pbMilk"
        Me.pbMilk.Size = New System.Drawing.Size(159, 144)
        Me.pbMilk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMilk.TabIndex = 43
        Me.pbMilk.TabStop = False
        Me.pbMilk.Visible = False
        '
        'pbDel
        '
        Me.pbDel.Image = CType(resources.GetObject("pbDel.Image"), System.Drawing.Image)
        Me.pbDel.Location = New System.Drawing.Point(130, 71)
        Me.pbDel.Name = "pbDel"
        Me.pbDel.Size = New System.Drawing.Size(159, 144)
        Me.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDel.TabIndex = 44
        Me.pbDel.TabStop = False
        Me.pbDel.Visible = False
        '
        'pbGat
        '
        Me.pbGat.Image = CType(resources.GetObject("pbGat.Image"), System.Drawing.Image)
        Me.pbGat.Location = New System.Drawing.Point(130, 71)
        Me.pbGat.Name = "pbGat"
        Me.pbGat.Size = New System.Drawing.Size(159, 144)
        Me.pbGat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGat.TabIndex = 45
        Me.pbGat.TabStop = False
        Me.pbGat.Visible = False
        '
        'pbGum
        '
        Me.pbGum.Image = CType(resources.GetObject("pbGum.Image"), System.Drawing.Image)
        Me.pbGum.Location = New System.Drawing.Point(128, 71)
        Me.pbGum.Name = "pbGum"
        Me.pbGum.Size = New System.Drawing.Size(159, 144)
        Me.pbGum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGum.TabIndex = 46
        Me.pbGum.TabStop = False
        Me.pbGum.Visible = False
        '
        'pbPringles
        '
        Me.pbPringles.Image = CType(resources.GetObject("pbPringles.Image"), System.Drawing.Image)
        Me.pbPringles.Location = New System.Drawing.Point(128, 71)
        Me.pbPringles.Name = "pbPringles"
        Me.pbPringles.Size = New System.Drawing.Size(159, 144)
        Me.pbPringles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPringles.TabIndex = 47
        Me.pbPringles.TabStop = False
        Me.pbPringles.Visible = False
        '
        'pbSoda
        '
        Me.pbSoda.Image = CType(resources.GetObject("pbSoda.Image"), System.Drawing.Image)
        Me.pbSoda.Location = New System.Drawing.Point(128, 71)
        Me.pbSoda.Name = "pbSoda"
        Me.pbSoda.Size = New System.Drawing.Size(159, 144)
        Me.pbSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSoda.TabIndex = 48
        Me.pbSoda.TabStop = False
        Me.pbSoda.Visible = False
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 365)
        Me.Controls.Add(Me.pbSoda)
        Me.Controls.Add(Me.pbPringles)
        Me.Controls.Add(Me.pbGum)
        Me.Controls.Add(Me.pbGat)
        Me.Controls.Add(Me.pbDel)
        Me.Controls.Add(Me.pbMilk)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Receipt"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        CType(Me.pbMilk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPringles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSoda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents pbMilk As PictureBox
    Friend WithEvents pbDel As PictureBox
    Friend WithEvents pbGat As PictureBox
    Friend WithEvents pbGum As PictureBox
    Friend WithEvents pbPringles As PictureBox
    Friend WithEvents pbSoda As PictureBox
End Class
