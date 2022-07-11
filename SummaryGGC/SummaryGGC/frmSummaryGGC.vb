#Region "About"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Sample code for Summary GridGroupingControl of Syncfusion Community.
' / Microsoft Visual Basic .NET (2010) & MS Access 2010.
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

'// Syncfusion
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Drawing
Imports Syncfusion.GroupingGridExcelConverter
Imports Syncfusion.GridExcelConverter

' / Summaries in Windows Forms GridGrouping control
' / https://help.syncfusion.com/windowsforms/gridgrouping/summaries

Public Class frmSummaryGGC

    ' / Summary single column.
    Private Sub btnSingleColumn_Click(sender As System.Object, e As System.EventArgs) Handles btnSingleColumn.Click
        'Me.gridGroupingControl1.ResetTableDescriptor()
        Me.gridGroupingControl1.DataSource = Nothing
        Me.gridGroupingControl1.DataSource = SampleData()
        Call InitGridGroup()
        Call SummarySingleColumn()
    End Sub

    ' / Summary multi column.
    Private Sub btnMultiColumn_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiColumn.Click
        'Me.gridGroupingControl1.ResetTableDescriptor()
        Me.gridGroupingControl1.DataSource = Nothing
        Me.gridGroupingControl1.DataSource = SampleData()
        Call InitGridGroup()
        Call SummaryMultiColumn()
    End Sub

    ' / Summary multi row.
    Private Sub btnMultiRow_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiRow.Click
        Me.gridGroupingControl1.DataSource = Nothing
        Me.gridGroupingControl1.DataSource = SampleData()
        Call InitGridGroup()
        Call SummaryMultiRow()
    End Sub

    ' / Summary multi column - row.
    Private Sub btnMultiColRow_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiColRow.Click
        Me.gridGroupingControl1.DataSource = Nothing
        Me.gridGroupingControl1.DataSource = SampleData()
        Call InitGridGroup()
        Call SummaryMultiColumnRow()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Summary single column.
    Sub SummarySingleColumn()
        '/ Declares an ExpressionFieldDescriptor.
        Dim expression1 As New ExpressionFieldDescriptor()
        expression1.Name = "TotalPrice"
        expression1.Expression = "[Quantity] * [UnitPrice]"
        '/ Adds the Expression column to the grid.
        Me.gridGroupingControl1.TableDescriptor.ExpressionFields.Add(expression1)
        With Me.gridGroupingControl1.TableDescriptor.Columns("TotalPrice")
            .Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
            .Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        End With
        '/
        '/ Create summary column descriptor 1
        Dim scd1 As New GridSummaryColumnDescriptor("TotalPrice", SummaryType.DoubleAggregate, "TotalPrice", "Sum = {Sum:#,##.00}")
        Dim srd1 As New GridSummaryRowDescriptor()
        '/ Adding the summary columns into the summary row descriptor
        srd1.SummaryColumns.Add(scd1)
        gridGroupingControl1.TableDescriptor.SummaryRows.Add(srd1)
        '/
        srd1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        srd1.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        srd1.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
        '/ Changing the Appearance of the Summary Cells through the TableDescriptor
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.BackColor = Color.LightYellow
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.TextColor = Color.Black
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Summary multi columns.
    Sub SummaryMultiColumn()
        '/ Declares an ExpressionFieldDescriptor.
        Dim expression1 As New ExpressionFieldDescriptor()
        expression1.Name = "TotalPrice"
        expression1.Expression = "[Quantity] * [UnitPrice]"
        '/ Adds the Expression column to the grid.
        Me.gridGroupingControl1.TableDescriptor.ExpressionFields.Add(expression1)
        With Me.gridGroupingControl1.TableDescriptor.Columns("TotalPrice")
            .Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
            .Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        End With
        '/ Create summary column descriptor 1
        Dim scd1 As New GridSummaryColumnDescriptor("TotalPrice", SummaryType.DoubleAggregate, "TotalPrice", "Sum = {Sum:#,##.00}")
        scd1.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(192, 255, 162))
        '/ Create summary column descriptor 2
        Dim scd2 As New GridSummaryColumnDescriptor("Quantity", SummaryType.Int32Aggregate, "Quantity", "Sum = {Sum:0} Items.")
        scd2.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.LavenderBlush)
        '/
        Dim summaryRowDescriptor As New GridSummaryRowDescriptor()
        '/ Adding the summary columns into the summary row descriptor
        summaryRowDescriptor.SummaryColumns.AddRange(New GridSummaryColumnDescriptor() {scd1, scd2})
        summaryRowDescriptor.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(255, 231, 162))
        Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(summaryRowDescriptor)
        '
        scd1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd1.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd1.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
        '/
        scd2.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd2.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd2.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Summary multi rows.
    Sub SummaryMultiRow()
        '/ Declares an ExpressionFieldDescriptor.
        Dim expression1 As New ExpressionFieldDescriptor()
        expression1.Name = "TotalPrice"
        expression1.Expression = "[Quantity] * [UnitPrice]"
        '/ Adds the Expression column to the grid.
        Me.gridGroupingControl1.TableDescriptor.ExpressionFields.Add(expression1)
        With Me.gridGroupingControl1.TableDescriptor.Columns("TotalPrice")
            .Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
            .Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        End With

        '/ Create summary column descriptor 1
        Dim scd1 As New GridSummaryColumnDescriptor("TotalPrice", SummaryType.DoubleAggregate, "TotalPrice", "Sum = {Sum:#,##.00}")
        scd1.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.Lavender)
        '/ Create summary column descriptor 2
        Dim scd2 As New GridSummaryColumnDescriptor("TotalPrice", SummaryType.DoubleAggregate, "TotalPrice", "Average = {Average:#,##.00}")
        scd2.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.LightGoldenrodYellow)
        '
        '/ Adding the summary columns into the summary row descriptor
        Dim srd1 As New GridSummaryRowDescriptor()
        srd1.SummaryColumns.Add(scd1)
        Dim srd2 As New GridSummaryRowDescriptor()
        '/ Adding the summary columns into the summary row descriptor
        srd2.SummaryColumns.Add(scd2)
        '/
        srd1.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(255, 232, 162))
        srd2.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(255, 232, 162))
        Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(srd1)
        Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(srd2)
        '
        scd1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd1.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd1.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
        '/
        scd2.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd2.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd2.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Summary multi columns - rows.
    Sub SummaryMultiColumnRow()
        '/ Declares an ExpressionFieldDescriptor.
        Dim expression1 As New ExpressionFieldDescriptor()
        expression1.Name = "TotalPrice"
        expression1.Expression = "[Quantity] * [UnitPrice]"
        '/ Adds the Expression column to the grid.
        Me.gridGroupingControl1.TableDescriptor.ExpressionFields.Add(expression1)
        With Me.gridGroupingControl1.TableDescriptor.Columns("TotalPrice")
            .Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
            .Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        End With

        '/ Create summary column descriptor 1
        Dim scd1 As New GridSummaryColumnDescriptor("Quantity", SummaryType.Int32Aggregate, "Quantity", "Sum = {Sum:} Items.")
        scd1.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(192, 255, 162))
        '/ Create summary column descriptor 2
        Dim scd2 As New GridSummaryColumnDescriptor("TotalPrice", SummaryType.DoubleAggregate, "TotalPrice", "Sum = {Sum:#,##.00}")
        scd2.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.LavenderBlush)
        '/
        Dim summaryRowDescriptor As New GridSummaryRowDescriptor()
        '/ Adding the summary columns into the summary row descriptor
        summaryRowDescriptor.SummaryColumns.AddRange(New GridSummaryColumnDescriptor() {scd1, scd2})
        summaryRowDescriptor.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(255, 231, 162))
        Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(summaryRowDescriptor)
        '/ Average in Column 3 and Summary Row 2.
        Dim scd3 As New GridSummaryColumnDescriptor("TotalPrice", SummaryType.DoubleAggregate, "TotalPrice", "Average = {Average:#,##.00}")
        scd3.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.MintCream)
        Dim srd As New GridSummaryRowDescriptor()
        '/ Adding the summary columns into the summary row descriptor
        srd.SummaryColumns.Add(scd3)
        Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(srd)
        srd.Appearance.AnySummaryCell.Interior = New BrushInfo(Color.FromArgb(255, 232, 162))
        '//
        scd1.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd1.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd1.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
        '/
        scd2.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd2.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd2.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
        '/
        scd3.Appearance.AnyCell.HorizontalAlignment = GridHorizontalAlignment.Right
        scd3.Appearance.AnyCell.VerticalAlignment = GridVerticalAlignment.Middle
        scd3.Appearance.AnyCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
    End Sub

    ' / --------------------------------------------------------------------------------
    Function SampleData() As DataTable
        Dim DT As New DataTable
        With DT
            .Columns.Add("PK", GetType(Integer))
            .Columns.Add("ProductID", GetType(String))
            .Columns.Add("ProductName", GetType(String))
            .Columns.Add("Quantity", GetType(Integer))
            .Columns.Add("UnitPrice", GetType(Double))
            .Columns.Add("TotalPrice", GetType(Double))
        End With
        With DT
            .Rows.Add({"1", "PRO0001", "Product 1", "10", "1500.25", "0.00"})
            .Rows.Add({"2", "PRO0002", "Product 2", "20", "500.75", "0.00"})
            .Rows.Add({"3", "PRO0003", "Product 3", "15", "1500.20", "0.00"})
            .Rows.Add({"4", "PRO0004", "Product 4", "15", "7500.10", "0.00"})
            .Rows.Add({"5", "PRO0005", "Product 5", "10", "1000.00", "0.00"})
        End With
        Return DT
    End Function

    ' / --------------------------------------------------------------------------------
    ' / Initilized GridGroupingControl
    Private Sub InitGridGroup()
        '// Initialize Columns GridGroup
        With Me.gridGroupingControl1.TableDescriptor
            '// Hidden Primary Key Column
            .VisibleColumns.Remove("PK")
            '/ Using Column Name
            .Columns("ProductID").HeaderText = "Product ID"
            .Columns("ProductName").HeaderText = "Product Name"
            With .Columns("Quantity")
                .HeaderText = "Quantity"
                .Appearance.AnyRecordFieldCell.CellValueType = GetType(Int32)
                .Appearance.AnyRecordFieldCell.Format = "N0"
            End With
            '// Format UnitPrice
            With .Columns("UnitPrice")
                .HeaderText = "Unit Price"
                .Appearance.AnyRecordFieldCell.CellValueType = GetType(Double)
                .Appearance.AnyRecordFieldCell.Format = "N2"
            End With
            '// Format TotalPrice
            With .Columns("TotalPrice")
                .HeaderText = "Quantity x UnitPrice"
                .Appearance.AnyRecordFieldCell.CellValueType = GetType(Double)
                .Appearance.AnyRecordFieldCell.Format = "N2"
            End With
        End With
        For i As Byte = 1 To 5
            With Me.gridGroupingControl1.TableDescriptor
                .Columns(i).Appearance.AnyRecordFieldCell.VerticalAlignment = GridVerticalAlignment.Middle
                .Columns(i).AllowGroupByColumn = False
                '/ Set Header font.
                .Columns(i).Appearance.AnyHeaderCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Bold))
                ' // Set Font Columns any cell.
                .Columns(i).Appearance.AnyRecordFieldCell.Font = New Syncfusion.Windows.Forms.Grid.GridFontInfo(New Font("Tahoma", 11.0F, FontStyle.Regular))
            End With
        Next
        '// Initialize normal GridGroupingControl
        With Me.gridGroupingControl1
            ' Allows GroupDropArea to be visible
            .ShowGroupDropArea = False  ' Disable
            '// Hidden Top Level of Grouping
            .TopLevelGroupOptions.ShowCaption = False
            '// Metro Styles
            .GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            ' Disables editing in GridGroupingControl
            .ActivateCurrentCellBehavior = GridCellActivateAction.None
            ' Disables editing in GridGroupingControl
            .TableDescriptor.AllowNew = False
            '// Autofit Columns
            .AllowProportionalColumnSizing = True

            '// Row Height
            .Table.DefaultRecordRowHeight = 25
            .Table.DefaultCaptionRowHeight = 25
            .Table.DefaultColumnHeaderRowHeight = 30    '// Columns Header Row Height

            '// Selection
            .TableOptions.ListBoxSelectionMode = SelectionMode.One
            'Selection Back color
            .TableOptions.SelectionBackColor = Color.Firebrick
            '//
            .Appearance.ColumnHeaderCell.TextColor = Color.DarkBlue

            'Applies back color as LightCyan for alternative records in the Grid.
            .Appearance.AlternateRecordFieldCell.BackColor = Color.LightCyan

            'Disable record preview row 
            .TableOptions.ShowRecordPreviewRow = False
            'Will enable the Group Header for the top most group.
            .TopLevelGroupOptions.ShowGroupHeader = False ' True
            'Will enable the Group Footer for the group.
            .TopLevelGroupOptions.ShowGroupFooter = False 'True
            '//
            .TableOptions.GroupHeaderSectionHeight = 30
            .TableOptions.GroupFooterSectionHeight = 30
        End With
        '/ Summary Row Height.
        Me.gridGroupingControl1.Table.DefaultSummaryRowHeight = 38

    End Sub

    ' / --------------------------------------------------------------------------------
    '// Full Select Row
    Private Sub gridGroupingControl1_TableControlCurrentCellActivating(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCurrentCellActivatingEventArgs) Handles gridGroupingControl1.TableControlCurrentCellActivating
        '// Get Column Index 0 is the Primary Key. (Hidden column)
        e.Inner.ColIndex = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSummaryGGC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / Simple convert from GridGroupingControl to Excel.
    Private Sub btnExportToExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportToExcel.Click
        If Me.gridGroupingControl1.Table.Records.Count = 0 Then Return
        '/ Creating the converter control for Exporting the grid
        Dim converter As New GroupingGridExcelConverterControl()
        '/ Export the contents of the Grid to Excel
        converter.GroupingGridToExcel(Me.gridGroupingControl1, MyPath(Application.StartupPath) & "GGCtoXLS.xls", ConverterOptions.RowHeaders Or ConverterOptions.ColumnHeaders)
        'MessageBox.Show("Export to Excel complete.")
        Process.Start(MyPath(Application.StartupPath) & "GGCtoXLS.xls")
    End Sub

    Function MyPath(ByVal AppPath As String) As String
        '/ Return Value
        MyPath = AppPath.ToLower.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\").Replace("\bin\x86\release", "\")
        '// If not found folder then put the \ (BackSlash ASCII Code = 92) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

End Class
