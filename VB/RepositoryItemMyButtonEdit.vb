Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1

	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit
		#Region "DefaultCode"
		Shared Sub New()
			Register()
		End Sub

		Protected Overrides Sub OnButtons_CollectionChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
			MyBase.OnButtons_CollectionChanged(sender, e)
		End Sub
		Public Sub New()
			InitProperties()
		End Sub



		Friend Const EditorName As String = "MyButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), New MyButtonEditPainter(), True, CType(Nothing, Image), GetType(DevExpress.Accessibility.ButtonEditAccessible)))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
		#End Region

		Public Overrides Sub CreateDefaultButton()
			Dim btn As New EditorButton()
			btn.IsDefaultButton = True
			btn.Kind = ButtonPredefines.Glyph
			btn.Caption = "Button"
			Buttons.Add(btn)
		End Sub

		Private Sub InitProperties()
			TextEditStyle = TextEditStyles.HideTextEditor
			CheckedChar = "1"c
			UnchekedChar = "0"c
		End Sub

		Private _UnchekedChar As Char
		Public Property UnchekedChar() As Char
			Get
				Return _UnchekedChar
			End Get
			Set(ByVal value As Char)
				_UnchekedChar = value
			End Set
		End Property

		Private _CheckedChar As Char
		Public Property CheckedChar() As Char
			Get
				Return _CheckedChar
			End Get
			Set(ByVal value As Char)
				_CheckedChar = value
			End Set
		End Property


		Public Function IsButtonChecked(ByVal value As Object, ByVal index As Integer) As Boolean
			Return value.ToString().Chars(index) = CheckedChar
		End Function
	End Class


	''' <summary>
	''' MyButtonEdit is a descendant from ButtonEdit.
	''' It displays a dialog form below the text box when the edit button is clicked.
	''' </summary>


	Public Class MyButtonEdit
		Inherits ButtonEdit
		#Region "DefaultCode"
		Shared Sub New()
			RepositoryItemMyButtonEdit.Register()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyButtonEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyButtonEdit)
			End Get
		End Property
		#End Region

		Protected Overrides Sub OnClickButton(ByVal buttonInfo As EditorButtonObjectInfoArgs)
			ToogleButton(buttonInfo.Button.Index)
			MyBase.OnClickButton(buttonInfo)
		End Sub

		Private Function GetStringByDelta(ByVal delta As Integer) As String
			Dim result As String = String.Empty
			For i As Integer = 0 To delta - 1
				result &= Properties.UnchekedChar
			Next i
			Return result
		End Function

		Public Overrides Property EditValue() As Object
			Get
				Return GetEditValue(MyBase.EditValue)
			End Get
			Set(ByVal value As Object)
				MyBase.EditValue = value
			End Set
		End Property

		Private Function GetEditValue(ByVal value As Object) As String
			Dim result As String
			If value Is Nothing Then
				result = String.Empty
			Else
				result = value.ToString()
			End If
			Dim delta As Integer = Properties.Buttons.Count - result.Length
			If delta > 0 Then
				result &= GetStringByDelta(delta)
			End If
			Return result
		End Function



		Private Sub ToogleButton(ByVal index As Integer)
			Dim value As String = EditValue.ToString()
			Dim isChecked As Boolean = Properties.IsButtonChecked(EditValue, index)
			Dim s As Char
			If isChecked Then
				s = Properties.UnchekedChar
			Else
				s = Properties.CheckedChar
			End If
			value = value.Remove(index,1)
			value = value.Insert(index, s.ToString())
			EditValue = value
		End Sub
	End Class



	Public Class MyButtonEditPainter
		Inherits ButtonEditPainter

		Protected Overrides Sub DrawButton(ByVal viewInfo As ButtonEditViewInfo, ByVal info As EditorButtonObjectInfoArgs)
			If (TryCast(viewInfo.Item, RepositoryItemMyButtonEdit)).IsButtonChecked(viewInfo.EditValue, info.Button.Index) Then
				info.State = ObjectState.Hot
			Else
				info.State = ObjectState.Normal
			End If
			MyBase.DrawButton(viewInfo, info)
		End Sub
	End Class
End Namespace
