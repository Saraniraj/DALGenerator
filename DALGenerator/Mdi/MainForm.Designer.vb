<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMyStatements = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloseLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsToolMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrFilterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.stStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.DownloadUpdateProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.DownloadUpdateLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditTrans = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrefixSuffixadd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDalGenerate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayees = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpendingOverview = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMonthlyIncome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBudgets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMostUsed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnclearSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditStartingBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdvancedFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportTrans = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBalanceAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoanCalculator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckforUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckbookHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenuStrip.SuspendLayout()
        Me.stStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuMenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuTools, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuMenuStrip.Size = New System.Drawing.Size(984, 24)
        Me.mnuMenuStrip.TabIndex = 6
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuMyStatements, Me.mnuCloseLedger, Me.ToolStripSeparator1, Me.mnuSaveAs, Me.ToolStripSeparator2, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(42, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(228, 22)
        Me.mnuOpen.Text = "My Checkbook &Ledgers..."
        '
        'mnuMyStatements
        '
        Me.mnuMyStatements.Name = "mnuMyStatements"
        Me.mnuMyStatements.Size = New System.Drawing.Size(228, 22)
        Me.mnuMyStatements.Text = "My S&tatements..."
        '
        'mnuCloseLedger
        '
        Me.mnuCloseLedger.Name = "mnuCloseLedger"
        Me.mnuCloseLedger.Size = New System.Drawing.Size(228, 22)
        Me.mnuCloseLedger.Text = "&Close Ledger"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(225, 6)
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditTrans, Me.mnuPrefixSuffixadd, Me.mnuDalGenerate, Me.mnuEditPayment, Me.mnuCategories, Me.mnuViewReceipt, Me.mnuPayees, Me.mnuEditType, Me.mnuEditDeposit, Me.mnuSpendingOverview, Me.mnuMonthlyIncome, Me.mnuBudgets, Me.mnuMostUsed, Me.mnuClearSelected, Me.mnuUnclearSelected, Me.ToolStripSeparator3, Me.mnuEditStartingBalance})
        Me.mnuEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(46, 20)
        Me.mnuEdit.Text = "&DAL"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(267, 6)
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSum, Me.mnuFilter, Me.mnuAdvancedFilter, Me.mnuOptions, Me.mnuImportTrans, Me.mnuExportTransactions, Me.mnuBalanceAccount, Me.tsToolMenuSeparator1, Me.mnuLoanCalculator, Me.mnuCalc, Me.ToolStripSeparator8, Me.mnuCheckforUpdate})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(55, 20)
        Me.mnuTools.Text = "&Tools"
        '
        'tsToolMenuSeparator1
        '
        Me.tsToolMenuSeparator1.Name = "tsToolMenuSeparator1"
        Me.tsToolMenuSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(201, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCheckbookHelp, Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(49, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'tmrFilterTimer
        '
        Me.tmrFilterTimer.Interval = 1
        '
        'stStatusStrip
        '
        Me.stStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadUpdateProgressBar, Me.DownloadUpdateLabel, Me.stLabel})
        Me.stStatusStrip.Location = New System.Drawing.Point(0, 689)
        Me.stStatusStrip.Name = "stStatusStrip"
        Me.stStatusStrip.Size = New System.Drawing.Size(984, 22)
        Me.stStatusStrip.TabIndex = 22
        Me.stStatusStrip.Text = "StatusStrip1"
        '
        'DownloadUpdateProgressBar
        '
        Me.DownloadUpdateProgressBar.Margin = New System.Windows.Forms.Padding(12, 3, 1, 3)
        Me.DownloadUpdateProgressBar.Name = "DownloadUpdateProgressBar"
        Me.DownloadUpdateProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'DownloadUpdateLabel
        '
        Me.DownloadUpdateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DownloadUpdateLabel.Name = "DownloadUpdateLabel"
        Me.DownloadUpdateLabel.Size = New System.Drawing.Size(150, 17)
        Me.DownloadUpdateLabel.Text = "Downloading latest version"
        '
        'stLabel
        '
        Me.stLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.stLabel.Name = "stLabel"
        Me.stLabel.Size = New System.Drawing.Size(91, 17)
        Me.stLabel.Text = "Transaction Info"
        '
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(228, 22)
        Me.mnuNew.Text = "&DAL Generate"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Image = CType(resources.GetObject("mnuSaveAs.Image"), System.Drawing.Image)
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(228, 22)
        Me.mnuSaveAs.Text = "&Save As..."
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(228, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuEditTrans
        '
        Me.mnuEditTrans.Image = CType(resources.GetObject("mnuEditTrans.Image"), System.Drawing.Image)
        Me.mnuEditTrans.Name = "mnuEditTrans"
        Me.mnuEditTrans.Size = New System.Drawing.Size(270, 22)
        Me.mnuEditTrans.Text = "&Fill Grid Title"
        '
        'mnuPrefixSuffixadd
        '
        Me.mnuPrefixSuffixadd.Image = CType(resources.GetObject("mnuPrefixSuffixadd.Image"), System.Drawing.Image)
        Me.mnuPrefixSuffixadd.Name = "mnuPrefixSuffixadd"
        Me.mnuPrefixSuffixadd.Size = New System.Drawing.Size(270, 22)
        Me.mnuPrefixSuffixadd.Text = "&Prefix Suffix Add"
        '
        'mnuDalGenerate
        '
        Me.mnuDalGenerate.Image = CType(resources.GetObject("mnuDalGenerate.Image"), System.Drawing.Image)
        Me.mnuDalGenerate.Name = "mnuDalGenerate"
        Me.mnuDalGenerate.Size = New System.Drawing.Size(270, 22)
        Me.mnuDalGenerate.Text = "&DAL Generator"
        '
        'mnuEditPayment
        '
        Me.mnuEditPayment.Image = CType(resources.GetObject("mnuEditPayment.Image"), System.Drawing.Image)
        Me.mnuEditPayment.Name = "mnuEditPayment"
        Me.mnuEditPayment.Size = New System.Drawing.Size(270, 22)
        Me.mnuEditPayment.Text = "Pre Suffix_for Loop"
        '
        'mnuCategories
        '
        Me.mnuCategories.Image = CType(resources.GetObject("mnuCategories.Image"), System.Drawing.Image)
        Me.mnuCategories.Name = "mnuCategories"
        Me.mnuCategories.Size = New System.Drawing.Size(270, 22)
        Me.mnuCategories.Text = "&Categories..."
        '
        'mnuViewReceipt
        '
        Me.mnuViewReceipt.Image = CType(resources.GetObject("mnuViewReceipt.Image"), System.Drawing.Image)
        Me.mnuViewReceipt.Name = "mnuViewReceipt"
        Me.mnuViewReceipt.Size = New System.Drawing.Size(270, 22)
        Me.mnuViewReceipt.Text = "View &Receipt"
        '
        'mnuPayees
        '
        Me.mnuPayees.Image = CType(resources.GetObject("mnuPayees.Image"), System.Drawing.Image)
        Me.mnuPayees.Name = "mnuPayees"
        Me.mnuPayees.Size = New System.Drawing.Size(270, 22)
        Me.mnuPayees.Text = "&Payees..."
        '
        'mnuEditType
        '
        Me.mnuEditType.Image = CType(resources.GetObject("mnuEditType.Image"), System.Drawing.Image)
        Me.mnuEditType.Name = "mnuEditType"
        Me.mnuEditType.Size = New System.Drawing.Size(270, 22)
        Me.mnuEditType.Text = "&Type..."
        '
        'mnuEditDeposit
        '
        Me.mnuEditDeposit.Image = CType(resources.GetObject("mnuEditDeposit.Image"), System.Drawing.Image)
        Me.mnuEditDeposit.Name = "mnuEditDeposit"
        Me.mnuEditDeposit.Size = New System.Drawing.Size(270, 22)
        Me.mnuEditDeposit.Text = "&Deposit..."
        '
        'mnuSpendingOverview
        '
        Me.mnuSpendingOverview.Image = CType(resources.GetObject("mnuSpendingOverview.Image"), System.Drawing.Image)
        Me.mnuSpendingOverview.Name = "mnuSpendingOverview"
        Me.mnuSpendingOverview.Size = New System.Drawing.Size(270, 22)
        Me.mnuSpendingOverview.Text = "Spending &Overview..."
        '
        'mnuMonthlyIncome
        '
        Me.mnuMonthlyIncome.Image = CType(resources.GetObject("mnuMonthlyIncome.Image"), System.Drawing.Image)
        Me.mnuMonthlyIncome.Name = "mnuMonthlyIncome"
        Me.mnuMonthlyIncome.Size = New System.Drawing.Size(270, 22)
        Me.mnuMonthlyIncome.Text = "Monthly &Income..."
        '
        'mnuBudgets
        '
        Me.mnuBudgets.Image = CType(resources.GetObject("mnuBudgets.Image"), System.Drawing.Image)
        Me.mnuBudgets.Name = "mnuBudgets"
        Me.mnuBudgets.Size = New System.Drawing.Size(270, 22)
        Me.mnuBudgets.Text = "&Budgets..."
        '
        'mnuMostUsed
        '
        Me.mnuMostUsed.Image = CType(resources.GetObject("mnuMostUsed.Image"), System.Drawing.Image)
        Me.mnuMostUsed.Name = "mnuMostUsed"
        Me.mnuMostUsed.Size = New System.Drawing.Size(270, 22)
        Me.mnuMostUsed.Text = "&Most Used Categories/Payees..."
        '
        'mnuClearSelected
        '
        Me.mnuClearSelected.Image = CType(resources.GetObject("mnuClearSelected.Image"), System.Drawing.Image)
        Me.mnuClearSelected.Name = "mnuClearSelected"
        Me.mnuClearSelected.Size = New System.Drawing.Size(270, 22)
        Me.mnuClearSelected.Text = "&Clear"
        '
        'mnuUnclearSelected
        '
        Me.mnuUnclearSelected.Image = CType(resources.GetObject("mnuUnclearSelected.Image"), System.Drawing.Image)
        Me.mnuUnclearSelected.Name = "mnuUnclearSelected"
        Me.mnuUnclearSelected.Size = New System.Drawing.Size(270, 22)
        Me.mnuUnclearSelected.Text = "&Unclear"
        '
        'mnuEditStartingBalance
        '
        Me.mnuEditStartingBalance.Image = CType(resources.GetObject("mnuEditStartingBalance.Image"), System.Drawing.Image)
        Me.mnuEditStartingBalance.Name = "mnuEditStartingBalance"
        Me.mnuEditStartingBalance.Size = New System.Drawing.Size(270, 22)
        Me.mnuEditStartingBalance.Text = "Edit &Starting Balance..."
        '
        'mnuSum
        '
        Me.mnuSum.Image = CType(resources.GetObject("mnuSum.Image"), System.Drawing.Image)
        Me.mnuSum.Name = "mnuSum"
        Me.mnuSum.Size = New System.Drawing.Size(204, 22)
        Me.mnuSum.Text = "&Sum Selected"
        '
        'mnuFilter
        '
        Me.mnuFilter.Image = CType(resources.GetObject("mnuFilter.Image"), System.Drawing.Image)
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(204, 22)
        Me.mnuFilter.Text = "&Quick Filter"
        '
        'mnuAdvancedFilter
        '
        Me.mnuAdvancedFilter.Image = CType(resources.GetObject("mnuAdvancedFilter.Image"), System.Drawing.Image)
        Me.mnuAdvancedFilter.Name = "mnuAdvancedFilter"
        Me.mnuAdvancedFilter.Size = New System.Drawing.Size(204, 22)
        Me.mnuAdvancedFilter.Text = "&Advanced Filter..."
        '
        'mnuOptions
        '
        Me.mnuOptions.Image = CType(resources.GetObject("mnuOptions.Image"), System.Drawing.Image)
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(204, 22)
        Me.mnuOptions.Text = "&Options..."
        '
        'mnuImportTrans
        '
        Me.mnuImportTrans.Image = CType(resources.GetObject("mnuImportTrans.Image"), System.Drawing.Image)
        Me.mnuImportTrans.Name = "mnuImportTrans"
        Me.mnuImportTrans.Size = New System.Drawing.Size(204, 22)
        Me.mnuImportTrans.Text = "&Import Transactions..."
        '
        'mnuExportTransactions
        '
        Me.mnuExportTransactions.Image = CType(resources.GetObject("mnuExportTransactions.Image"), System.Drawing.Image)
        Me.mnuExportTransactions.Name = "mnuExportTransactions"
        Me.mnuExportTransactions.Size = New System.Drawing.Size(204, 22)
        Me.mnuExportTransactions.Text = "&Export Transactions..."
        '
        'mnuBalanceAccount
        '
        Me.mnuBalanceAccount.Image = CType(resources.GetObject("mnuBalanceAccount.Image"), System.Drawing.Image)
        Me.mnuBalanceAccount.Name = "mnuBalanceAccount"
        Me.mnuBalanceAccount.Size = New System.Drawing.Size(204, 22)
        Me.mnuBalanceAccount.Text = "&Balance Account"
        '
        'mnuLoanCalculator
        '
        Me.mnuLoanCalculator.Image = CType(resources.GetObject("mnuLoanCalculator.Image"), System.Drawing.Image)
        Me.mnuLoanCalculator.Name = "mnuLoanCalculator"
        Me.mnuLoanCalculator.Size = New System.Drawing.Size(204, 22)
        Me.mnuLoanCalculator.Text = "&Loan Calculator..."
        '
        'mnuCalc
        '
        Me.mnuCalc.Image = CType(resources.GetObject("mnuCalc.Image"), System.Drawing.Image)
        Me.mnuCalc.Name = "mnuCalc"
        Me.mnuCalc.Size = New System.Drawing.Size(204, 22)
        Me.mnuCalc.Text = "&Windows Calculator"
        '
        'mnuCheckforUpdate
        '
        Me.mnuCheckforUpdate.Image = CType(resources.GetObject("mnuCheckforUpdate.Image"), System.Drawing.Image)
        Me.mnuCheckforUpdate.Name = "mnuCheckforUpdate"
        Me.mnuCheckforUpdate.Size = New System.Drawing.Size(204, 22)
        Me.mnuCheckforUpdate.Text = "&Check for Update"
        '
        'mnuCheckbookHelp
        '
        Me.mnuCheckbookHelp.Image = CType(resources.GetObject("mnuCheckbookHelp.Image"), System.Drawing.Image)
        Me.mnuCheckbookHelp.Name = "mnuCheckbookHelp"
        Me.mnuCheckbookHelp.Size = New System.Drawing.Size(183, 22)
        Me.mnuCheckbookHelp.Text = "Checkbook &Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Image = CType(resources.GetObject("mnuAbout.Image"), System.Drawing.Image)
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(183, 22)
        Me.mnuAbout.Text = "&About Checkbook"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.stStatusStrip)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1000, 667)
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dal Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.stStatusStrip.ResumeLayout(False)
        Me.stStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuMyStatements As ToolStripMenuItem
    Friend WithEvents mnuCloseLedger As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuPrefixSuffixadd As ToolStripMenuItem
    Friend WithEvents mnuDalGenerate As ToolStripMenuItem
    Friend WithEvents mnuEditTrans As ToolStripMenuItem
    Friend WithEvents mnuClearSelected As ToolStripMenuItem
    Friend WithEvents mnuUnclearSelected As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuEditStartingBalance As ToolStripMenuItem
    Friend WithEvents mnuTools As ToolStripMenuItem
    Friend WithEvents mnuSum As ToolStripMenuItem
    Friend WithEvents mnuFilter As ToolStripMenuItem
    Friend WithEvents mnuAdvancedFilter As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuImportTrans As ToolStripMenuItem
    Friend WithEvents mnuExportTransactions As ToolStripMenuItem
    Friend WithEvents mnuBalanceAccount As ToolStripMenuItem
    Friend WithEvents tsToolMenuSeparator1 As ToolStripSeparator
    Friend WithEvents mnuLoanCalculator As ToolStripMenuItem
    Friend WithEvents mnuCalc As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnuCheckforUpdate As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuCheckbookHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents tmrFilterTimer As Timer
    Friend WithEvents stStatusStrip As StatusStrip
    Friend WithEvents DownloadUpdateProgressBar As ToolStripProgressBar
    Friend WithEvents DownloadUpdateLabel As ToolStripStatusLabel
    Friend WithEvents stLabel As ToolStripStatusLabel
    Friend WithEvents mnuEditPayment As ToolStripMenuItem
    Friend WithEvents mnuCategories As ToolStripMenuItem
    Friend WithEvents mnuViewReceipt As ToolStripMenuItem
    Friend WithEvents mnuPayees As ToolStripMenuItem
    Friend WithEvents mnuEditType As ToolStripMenuItem
    Friend WithEvents mnuEditDeposit As ToolStripMenuItem
    Friend WithEvents mnuSpendingOverview As ToolStripMenuItem
    Friend WithEvents mnuMonthlyIncome As ToolStripMenuItem
    Friend WithEvents mnuBudgets As ToolStripMenuItem
    Friend WithEvents mnuMostUsed As ToolStripMenuItem
End Class
