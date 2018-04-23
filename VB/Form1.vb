Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication1
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyButtonEdit1 As RepositoryItemMyButtonEdit
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemMyButtonEdit2 As RepositoryItemMyButtonEdit
        Friend WithEvents MyButtonEdit1 As WindowsApplication1.MyButtonEdit
        Friend WithEvents MyButtonEdit2 As WindowsApplication1.MyButtonEdit
        Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemMyButtonEdit1 = New WindowsApplication1.RepositoryItemMyButtonEdit
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemMyButtonEdit2 = New WindowsApplication1.RepositoryItemMyButtonEdit
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.MyButtonEdit1 = New WindowsApplication1.MyButtonEdit
            Me.MyButtonEdit2 = New WindowsApplication1.MyButtonEdit
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMyButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MyButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MyButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMyButtonEdit1, Me.repositoryItemMyButtonEdit2})
            Me.gridControl1.Size = New System.Drawing.Size(584, 384)
            Me.gridControl1.TabIndex = 2
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "gridColumn1"
            Me.gridColumn1.FieldName = "Date"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "gridColumn2"
            Me.gridColumn2.FieldName = "Name"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "gridColumn3"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemMyButtonEdit1
            Me.gridColumn3.FieldName = "Button1"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            '
            'repositoryItemMyButtonEdit1
            '
            Me.repositoryItemMyButtonEdit1.AutoHeight = False
            Me.repositoryItemMyButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Test", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing)})
            Me.repositoryItemMyButtonEdit1.CheckedChar = Global.Microsoft.VisualBasic.ChrW(49)
            Me.repositoryItemMyButtonEdit1.Name = "repositoryItemMyButtonEdit1"
            Me.repositoryItemMyButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.repositoryItemMyButtonEdit1.UnchekedChar = Global.Microsoft.VisualBasic.ChrW(48)
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "gridColumn4"
            Me.gridColumn4.ColumnEdit = Me.repositoryItemMyButtonEdit2
            Me.gridColumn4.FieldName = "Button2"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            '
            'repositoryItemMyButtonEdit2
            '
            Me.repositoryItemMyButtonEdit2.AutoHeight = False
            Me.repositoryItemMyButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "TEST", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
            Me.repositoryItemMyButtonEdit2.CheckedChar = Global.Microsoft.VisualBasic.ChrW(49)
            Me.repositoryItemMyButtonEdit2.Name = "repositoryItemMyButtonEdit2"
            Me.repositoryItemMyButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.repositoryItemMyButtonEdit2.UnchekedChar = Global.Microsoft.VisualBasic.ChrW(48)
            '
            'gridView2
            '
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.Name = "gridView2"
            '
            'MyButtonEdit1
            '
            Me.MyButtonEdit1.EditValue = "0"
            Me.MyButtonEdit1.Location = New System.Drawing.Point(27, 12)
            Me.MyButtonEdit1.Name = "MyButtonEdit1"
            Me.MyButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Button", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing)})
            Me.MyButtonEdit1.Properties.CheckedChar = Global.Microsoft.VisualBasic.ChrW(49)
            Me.MyButtonEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.MyButtonEdit1.Properties.UnchekedChar = Global.Microsoft.VisualBasic.ChrW(48)
            Me.MyButtonEdit1.Size = New System.Drawing.Size(100, 20)
            Me.MyButtonEdit1.TabIndex = 3
            '
            'MyButtonEdit2
            '
            Me.MyButtonEdit2.EditValue = "10101100110011"
            Me.MyButtonEdit2.Location = New System.Drawing.Point(151, 12)
            Me.MyButtonEdit2.Name = "MyButtonEdit2"
            Me.MyButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Button", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing), New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton, New DevExpress.XtraEditors.Controls.EditorButton})
            Me.MyButtonEdit2.Properties.CheckedChar = Global.Microsoft.VisualBasic.ChrW(49)
            Me.MyButtonEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            Me.MyButtonEdit2.Properties.UnchekedChar = Global.Microsoft.VisualBasic.ChrW(48)
            Me.MyButtonEdit2.Size = New System.Drawing.Size(421, 20)
            Me.MyButtonEdit2.TabIndex = 4
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(584, 384)
            Me.Controls.Add(Me.MyButtonEdit2)
            Me.Controls.Add(Me.MyButtonEdit1)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMyButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MyButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MyButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

			Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("Button1", GetType(String))
			tbl.Columns.Add("Button2", GetType(String))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), DateTime.Now.AddDays(i), i Mod 2, (i Mod 3).ToString() & (i Mod 5).ToString() })
			Next i
			Return tbl
			End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = CreateTable(20)
		End Sub

	End Class
End Namespace
