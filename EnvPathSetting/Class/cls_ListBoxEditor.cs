using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace EnvPathSetting.Class
{
    class cls_ListBoxEditor
    {
        private ListBox _listBox;
        private string _itemSplitter;
        private TextBox _txtBox;

        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static void PostMess(IntPtr hwmd, int msg)
        {
            PostMessage(hwmd, msg, 0, 0);
        }

        public cls_ListBoxEditor(ListBox listBox, string itemSplitter = ";") 
        { 
            ListBox = listBox; 
            ItemSplitter = itemSplitter; 
        }

        public ListBox ListBox
        {
            get { return _listBox; }
            set
            {
                _listBox = value;
                if (_listBox != null)
                {
                    _listBox.MouseDoubleClick += ListBoxMouseDoubleClick;
                }
            }
        }

        public string ItemSplitter
        {
            get { return _itemSplitter; }
            set { _itemSplitter = value; }
        }

        private void ListBoxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_txtBox == null) { _txtBox = new TextBox(); }
            string str = null;
            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                if (i == 0) { str = ListBox.Items[i].ToString(); }
                else { str += ItemSplitter + ListBox.Items[i].ToString(); }
            }

            _txtBox.Font = ListBox.Font;
            _txtBox.Multiline = true;
            _txtBox.WordWrap = true;
            _txtBox.ScrollBars = ScrollBars.Vertical;
            _txtBox.Text = str;
            ListBox.Parent.Controls.Add(_txtBox);
            _txtBox.Location = ListBox.Location;
            _txtBox.Size = ListBox.Size;
            _txtBox.Visible = true;
            _txtBox.BringToFront();
            _txtBox.KeyPress += TextBoxKeyPress;
            _txtBox.Focus();
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==((char)Keys.Escape))
                CloseTextBox();
        }

        private void CloseTextBox()
        {
            ListBox.Items.Clear();
            string[] strs = Regex.Split(_txtBox.Text, ItemSplitter, RegexOptions.IgnoreCase);
            if (strs != null && strs.Count() > 0)
            {
                ListBox.Items.AddRange(strs);
            }
            ListBox.Parent.Controls.Remove(_txtBox);
            _txtBox = null;

            PostMess(cls_Common.hwndFrmMain, cls_Common.RELEASE_SAVE_AND_UNMAKE);
        }
    }
}
