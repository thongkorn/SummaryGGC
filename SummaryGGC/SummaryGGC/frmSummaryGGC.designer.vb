<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummaryGGC
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
        Me.components = New System.ComponentModel.Container()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.btnExit = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnSingleColumn = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnMultiColumn = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnMultiRow = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnMultiColRow = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.btnExportToExcel = New Syncfusion.Windows.Forms.ButtonAdv()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 44)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridGroupingControl1.Size = New System.Drawing.Size(935, 557)
        Me.gridGroupingControl1.TabIndex = 6
        Me.gridGroupingControl1.Text = "GridGroupingControl1"
        Me.gridGroupingControl1.UseRightToLeftCompatibleTextBox = True
        Me.gridGroupingControl1.VersionInfo = "15.2400.0.43"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnExit.BeforeTouchSize = New System.Drawing.Size(86, 33)
        Me.btnExit.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnExit.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.KeepFocusRectangle = False
        Me.btnExit.Location = New System.Drawing.Point(845, 5)
        Me.btnExit.MetroColor = System.Drawing.Color.Red
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnExit.Size = New System.Drawing.Size(86, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.ThemeName = "Metro"
        Me.btnExit.UseVisualStyle = True
        '
        'btnSingleColumn
        '
        Me.btnSingleColumn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnSingleColumn.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSingleColumn.BeforeTouchSize = New System.Drawing.Size(128, 33)
        Me.btnSingleColumn.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnSingleColumn.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnSingleColumn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSingleColumn.ForeColor = System.Drawing.Color.White
        Me.btnSingleColumn.KeepFocusRectangle = False
        Me.btnSingleColumn.Location = New System.Drawing.Point(2, 5)
        Me.btnSingleColumn.Name = "btnSingleColumn"
        Me.btnSingleColumn.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnSingleColumn.Size = New System.Drawing.Size(128, 33)
        Me.btnSingleColumn.TabIndex = 0
        Me.btnSingleColumn.Text = "Single Column-Row"
        Me.btnSingleColumn.ThemeName = "Metro"
        Me.btnSingleColumn.UseVisualStyle = True
        '
        'btnMultiColumn
        '
        Me.btnMultiColumn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnMultiColumn.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMultiColumn.BeforeTouchSize = New System.Drawing.Size(128, 33)
        Me.btnMultiColumn.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnMultiColumn.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnMultiColumn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiColumn.ForeColor = System.Drawing.Color.White
        Me.btnMultiColumn.KeepFocusRectangle = False
        Me.btnMultiColumn.Location = New System.Drawing.Point(136, 5)
        Me.btnMultiColumn.MetroColor = System.Drawing.Color.DodgerBlue
        Me.btnMultiColumn.Name = "btnMultiColumn"
        Me.btnMultiColumn.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnMultiColumn.Size = New System.Drawing.Size(128, 33)
        Me.btnMultiColumn.TabIndex = 1
        Me.btnMultiColumn.Text = "Multi Column"
        Me.btnMultiColumn.ThemeName = "Metro"
        Me.btnMultiColumn.UseVisualStyle = True
        '
        'btnMultiRow
        '
        Me.btnMultiRow.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnMultiRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMultiRow.BeforeTouchSize = New System.Drawing.Size(128, 33)
        Me.btnMultiRow.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnMultiRow.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnMultiRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiRow.ForeColor = System.Drawing.Color.White
        Me.btnMultiRow.KeepFocusRectangle = False
        Me.btnMultiRow.Location = New System.Drawing.Point(270, 5)
        Me.btnMultiRow.MetroColor = System.Drawing.Color.DarkKhaki
        Me.btnMultiRow.Name = "btnMultiRow"
        Me.btnMultiRow.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnMultiRow.Size = New System.Drawing.Size(128, 33)
        Me.btnMultiRow.TabIndex = 2
        Me.btnMultiRow.Text = "Multi Row"
        Me.btnMultiRow.ThemeName = "Metro"
        Me.btnMultiRow.UseVisualStyle = True
        '
        'btnMultiColRow
        '
        Me.btnMultiColRow.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnMultiColRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMultiColRow.BeforeTouchSize = New System.Drawing.Size(128, 33)
        Me.btnMultiColRow.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnMultiColRow.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnMultiColRow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiColRow.ForeColor = System.Drawing.Color.White
        Me.btnMultiColRow.KeepFocusRectangle = False
        Me.btnMultiColRow.Location = New System.Drawing.Point(404, 5)
        Me.btnMultiColRow.MetroColor = System.Drawing.Color.Goldenrod
        Me.btnMultiColRow.Name = "btnMultiColRow"
        Me.btnMultiColRow.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnMultiColRow.Size = New System.Drawing.Size(128, 33)
        Me.btnMultiColRow.TabIndex = 3
        Me.btnMultiColRow.Text = "Multi Column-Row"
        Me.btnMultiColRow.ThemeName = "Metro"
        Me.btnMultiColRow.UseVisualStyle = True
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportToExcel.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.btnExportToExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnExportToExcel.BeforeTouchSize = New System.Drawing.Size(128, 33)
        Me.btnExportToExcel.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
        Me.btnExportToExcel.ComboEditBackColor = System.Drawing.Color.Silver
        Me.btnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportToExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportToExcel.KeepFocusRectangle = False
        Me.btnExportToExcel.Location = New System.Drawing.Point(711, 5)
        Me.btnExportToExcel.MetroColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
        Me.btnExportToExcel.Size = New System.Drawing.Size(128, 33)
        Me.btnExportToExcel.TabIndex = 4
        Me.btnExportToExcel.Text = "Export to Excel"
        Me.btnExportToExcel.ThemeName = "Metro"
        Me.btnExportToExcel.UseVisualStyle = True
        '
        'frmSummaryGGC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 602)
        Me.Controls.Add(Me.btnExportToExcel)
        Me.Controls.Add(Me.btnMultiColRow)
        Me.Controls.Add(Me.btnMultiRow)
        Me.Controls.Add(Me.btnMultiColumn)
        Me.Controls.Add(Me.btnSingleColumn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "frmSummaryGGC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary GridGroupingControl Syncfusion - Code bY: Thongkorn Tubtimkrob"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private WithEvents btnExit As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnSingleColumn As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnMultiColumn As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnMultiRow As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnMultiColRow As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents btnExportToExcel As Syncfusion.Windows.Forms.ButtonAdv

End Class
