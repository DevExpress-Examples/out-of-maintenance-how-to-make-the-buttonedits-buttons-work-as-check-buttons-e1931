using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1 {

	[UserRepositoryItem("Register")]
	public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit
    {
        #region DefaultCode
        static RepositoryItemMyButtonEdit() { 
			Register(); 
		}

        protected override void OnButtons_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            base.OnButtons_CollectionChanged(sender, e);
        }
        public RepositoryItemMyButtonEdit() { InitProperties(); }

       
		
		internal const string EditorName = "MyButtonEdit";

		public static void Register() {
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(ButtonEditViewInfo), 
				new MyButtonEditPainter(), true, null));
		}
		public override string EditorTypeName { 
			get { return EditorName; }
        }
        #endregion

        public override void CreateDefaultButton()
        {
            EditorButton btn = new EditorButton();
            btn.IsDefaultButton = true;
            btn.Kind = ButtonPredefines.Glyph;
            btn.Caption = "Button";
            Buttons.Add(btn);
        }

        private void InitProperties()
        {
            TextEditStyle = TextEditStyles.HideTextEditor;
            CheckedChar = '1';
            UnchekedChar = '0';
        }

        private char _UnchekedChar;
        public char UnchekedChar
        {
            get { return _UnchekedChar; }
            set { _UnchekedChar = value; }
        }

        private char _CheckedChar;
        public char CheckedChar
        {
            get { return _CheckedChar; }
            set { _CheckedChar = value; }
        }


        public bool IsButtonChecked(object value, int index)
        {
            return value.ToString()[index] == CheckedChar;
        }
    }


	/// <summary>
	/// MyButtonEdit is a descendant from ButtonEdit.
	/// It displays a dialog form below the text box when the edit button is clicked.
	/// </summary>


	public class MyButtonEdit : ButtonEdit
    {
        #region DefaultCode
        static MyButtonEdit() {
			RepositoryItemMyButtonEdit.Register();
		}
		public override string EditorTypeName { 
			get { return RepositoryItemMyButtonEdit.EditorName; } 
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemMyButtonEdit Properties { 
			get { return base.Properties as RepositoryItemMyButtonEdit; }
        }
        #endregion

        protected override void OnClickButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            ToogleButton(buttonInfo.Button.Index);
            base.OnClickButton(buttonInfo);
        }

        string GetStringByDelta(int delta)
        {
            string result = string.Empty;
            for (int i = 0; i < delta; i++)
            {
                result += Properties.UnchekedChar;
            }
            return result;
        }

        public override object EditValue
        {
            get
            {
                return GetEditValue(base.EditValue);
            }
            set
            {
                base.EditValue = value;
            }
        }

        string GetEditValue(object value)
        {
            string result = value == null ? string.Empty : value.ToString();
            int delta = Properties.Buttons.Count - result.Length;
            if (delta > 0) result += GetStringByDelta(delta);
            return result;
        }



        void ToogleButton(int index)
        {
            string value = EditValue.ToString();
            bool isChecked = Properties.IsButtonChecked(EditValue, index);
            char s = isChecked ? Properties.UnchekedChar : Properties.CheckedChar;
            value = value.Remove(index,1);
            value = value.Insert(index, s.ToString());
            EditValue = value;
        }
    }

   

    public class MyButtonEditPainter : ButtonEditPainter
    {

        protected override void DrawButton(ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info)
        {
            info.State = (viewInfo.Item as RepositoryItemMyButtonEdit).IsButtonChecked(viewInfo.EditValue,  info.Button.Index) ? ObjectState.Hot : ObjectState.Normal;
            base.DrawButton(viewInfo, info);
        }
    }
}
