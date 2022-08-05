using JANL.Locales;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Environment;

namespace JANL.Forms
{
    /// <summary>
    /// Окно для отображения ошибки
    /// </summary>
    /// <remarks>
    /// Для показа номеров строк необходимо наличие pdb в сборке.
    /// StackTrace различается между Debug и Release из-за встраивания(Inlining) методов
    /// </remarks>
    public partial class ExceptionBox : Form
    {
        private static List<string> Comments = new List<string>();
        private static Random Rnd = new Random();
        private readonly Exception Exception;
        private Exception Selected;

        public ExceptionBox(Exception ex)
        {
            InitializeComponent();

            Text = EB_Strings.EB_Header;
            //Buttons
            B_Ignore.Text = EB_Strings.EB_Continue;
            B_Exit.Text = EB_Strings.EB_Exit;
            B_MailTo.Text = EB_Strings.EB_Mail;
            B_Copy.Text = EB_Strings.EB_Copy;
            //Labels
            L_Text.Text = EB_Strings.EB_Text;
            L_Description.Text = EB_Strings.EB_ErrDesc;
            L_Message.Text = EB_Strings.EB_Message;
            L_Method.Text = EB_Strings.EB_Method;
            L_Type.Text = EB_Strings.EB_Type;
            Icon = SystemIcons.Error;

            if (string.IsNullOrWhiteSpace(DefaultText)) { L_Text.Text = DefaultText; }
            if (WittyComments != null) { Text += $" - {GetComment()}"; }
            StartPosition = FormStartPosition.CenterScreen;
            Exception = ex;
            Selected = ex;
            B_MailTo.Visible = MailInfo != null;
            UpdateTree();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.None) { DialogResult = DialogResult.Ignore; }
            base.OnFormClosing(e);
        }

        private string EXtoString(Exception ex)
        {
            var L = new List<string>
            {
                $"{L_Type.Text}: {ex.GetType()}",
                $"{L_Method.Text}: {ex.TargetSite.DeclaringType.FullName}.{ex.TargetSite.Name}",
                $"{L_Message.Text}: {ex.Message}",
                "StackTrace:",
                ex.StackTrace
            };
            if (ex.InnerException != null)
            {
                L.Add("");
                L.Add("With internal exception:");
                L.Add(EXtoString(ex.InnerException));
            }
            return string.Join(NewLine, L);
        }

        private string GetComment()
        {
            if (Comments.Count == 0) { Comments.AddRange(WittyComments); }
            var i = Rnd.Next(Comments.Count);
            var Comment = Comments[i];
            Comments.RemoveAt(i);
            return Comment;
        }

        private string GetMail() => $"{MailInfo.Text}{NewLine}{NewLine}{GetText()}";

        private string GetText() => $"Exception:{NewLine}{EXtoString(Exception)}";

        private void UpdateTree()
        {
            if (Exception == null) { return; }
            try
            {
                //TV_Exceptions.BeginUpdate();
                TV_Exceptions.Nodes.Clear();
                var EX = Exception;
                TreeNode ParentNode = null, ChildNode = null;
                while (EX != null)
                {
                    ChildNode = new TreeNode(EX.GetType().FullName) { Tag = EX };
                    if (ParentNode == null)
                    {
                        TV_Exceptions.Nodes.Add(ChildNode);
                    }
                    else
                    {
                        ParentNode.Nodes.Add(ChildNode);
                    }
                    ParentNode = ChildNode;
                    EX = EX.InnerException;
                }
                TV_Exceptions.ExpandAll();
                TV_Exceptions.SelectedNode = ChildNode;
                TV_Exceptions.Select();
            }
            finally
            {
                //TV_Exceptions.EndUpdate();
            }
        }

        #region Static Properties

        /// <summary>
        /// Текст по умолчанию
        /// </summary>
        public static string DefaultText { get; set; }

        /// <summary>
        /// Данные для создания письма
        /// </summary>
        public static EMail MailInfo { get; set; }

        /// <summary>
        /// Остроумные комментарии
        /// </summary>
        public static IEnumerable<string> WittyComments { get; set; }

        #endregion Static Properties

        #region UI Events

        private void B_Copy_Click(object sender, EventArgs e) => Clipboard.SetText(GetText());

        private void B_Exit_Click(object sender, EventArgs e) => DialogResult = DialogResult.Abort;

        private void B_Ignore_Click(object sender, EventArgs e) => DialogResult = DialogResult.Ignore;

        private void B_MailTo_Click(object sender, EventArgs e)
        {
            var Body = GetMail();
            var Mail = $"mailto:{MailInfo.To}?subject={MailInfo.Subject}&body={Body.Replace(NewLine, "%0A")}";
            Process.Start(Mail);
        }

        private void TV_Exceptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TV_Exceptions.SelectedNode != null)
            {
                Selected = (Exception)TV_Exceptions.SelectedNode.Tag;
                TB_Type.Text = Selected.GetType().ToString();
                TB_Name.Text = Selected.TargetSite.DeclaringType.FullName + "." + Selected.TargetSite.Name;
                TB_Message.Text = Selected.Message;
                TB_StackTrace.Text = Selected.StackTrace;
            }
        }

        #endregion UI Events

        public class EMail
        {
            public string Subject { get; set; } = "";
            public string Text { get; set; } = "";
            public string To { get; set; } = "";
        }
    }
}