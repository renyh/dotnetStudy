using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myNote
{
    public partial class Form_Main : Form
    {
        // 笔记集合对象
        public NoteManager _noteManager = null;

        // 当前记录ID
        public string _currentID = "";
        private ListViewItem _currentListViewItem = null;

        // 构造函数
        public Form_Main()
        {
            InitializeComponent();
        }

        #region 窗体事件

        // 窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置界面的列表ListView
            this.listView_log.View = View.Details;//详细的列表  
            this.listView_log.Columns.Add("ID", 0, HorizontalAlignment.Left);
            this.listView_log.Columns.Add("标题", 200, HorizontalAlignment.Left);
            this.listView_log.Columns.Add("分类", 100, HorizontalAlignment.Left);
            this.listView_log.Columns.Add("优先级", 70, HorizontalAlignment.Left);
            this.listView_log.Columns.Add("修改时间", 150, HorizontalAlignment.Left);
            this.listView_log.Columns.Add("详细内容", 250, HorizontalAlignment.Left);

            // 初始化内存集合
            string error = "";
            string xmlFilePath = Application.StartupPath + "\\notes\\notes.xml";
            this._noteManager = new NoteManager();
            int nRet = this._noteManager.Init(xmlFilePath, out error);
            if (nRet == -1)
            {
                MessageBox.Show(this, error);
                return;
            }
            foreach (NoteItem note in this._noteManager.Notes)
            {
                this.AddToListView(note);
            }

        }

        // 窗体关闭
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 保存内存的数据到文件
            this._noteManager.Save();
        }

        #endregion

        #region 按钮 和 列表事件

        // 新增按钮，点击事件
        private void button_add_Click(object sender, EventArgs e)
        {
            NoteItem note = this.CreateNoteItem(true);
            if (note == null)
                return;
            
            //// 清空当前记录
            this._currentID = "";
            this._currentListViewItem = null;
            this.button_delete.Enabled = false;
            this.button_edit.Enabled = false;

            // 给内存集合增加一条记录
            this._noteManager.Add(note);

            //给界面的listview填加一行  
            this.AddToListView(note);

            // 清空控件
            this.ClearControl();
        }

        // 编辑按钮，点击事件
        private void button_edit_Click(object sender, EventArgs e)
        {
            this.Edit();
        }

        // 右键菜单 修改
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edit();
        }


        //编辑
        private void Edit()
        {
            if (string.IsNullOrEmpty(this._currentID) == false)
            {
                NoteItem note = this.CreateNoteItem(false);
                this._noteManager.Edit(note);

                // 更新listview当前记录
                this._currentListViewItem.SubItems.Clear();
                ListViewItem item = this._currentListViewItem;
                item.Text = note.ID;
                item.SubItems.Add(note.Title);
                item.SubItems.Add(note.Catalog);
                item.SubItems.Add(note.Level);
                item.SubItems.Add(note.UpdateTime);
                item.SubItems.Add(note.Content);


                // 清空控件
                this.ClearControl();
            }
        }

        // 右键菜单 删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        // 删除
        private void button_delete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void Delete()
        {
            if (string.IsNullOrEmpty(this._currentID) == false)
            {
                this._noteManager.Delete(this._currentID);

                this.listView_log.Items.Remove(this._currentListViewItem);

                // 清空控件
                this.ClearControl();
            }
        }


        // 当前列表的选中记录发生变化
        private void listView_log_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView_log.SelectedItems.Count > 0)
            {
                this._currentListViewItem =this.listView_log.SelectedItems[0];
                this._currentID = this._currentListViewItem.Text;
                NoteItem item = this._noteManager.Get(this._currentID);

                // 将信息设到输入控件上
                this.SetControlInfo(item);

                //编辑与删除按钮可用
                this.button_edit.Enabled = true;
                this.button_delete.Enabled = true;
                //this.button_add.Enabled = false;
               
            }
            else
            {
                this._currentListViewItem = null;
                this._currentID = "";

                // 编辑与删除按钮不可用
                this.button_edit.Enabled = false;
                this.button_delete.Enabled = false;
                //this.button_add.Enabled = true;

                // 清空控件
                this.ClearControl();
            }
        }

        #endregion

        #region 通用函数

        // 将内存对象NoteItem加到界面列表中
        private void AddToListView(NoteItem note)
        {
            //给界面的listview填加一行  
            ListViewItem item = new ListViewItem();
            item.Text = note.ID;
            item.SubItems.Add(note.Title);
            item.SubItems.Add(note.Catalog);
            item.SubItems.Add(note.Level);
            item.SubItems.Add(note.UpdateTime);
            item.SubItems.Add(note.Content);

            this.listView_log.BeginUpdate();
            this.listView_log.Items.Add(item);
            this.listView_log.Items[this.listView_log.Items.Count - 1].EnsureVisible();//滚动到最后  
            this.listView_log.EndUpdate();

        }

        // 根据界面输入的信息创建一个NoteItem对象
        private NoteItem CreateNoteItem(bool bNew)
        {
            string id = "";
            if (bNew== true)
                id = Guid.NewGuid().ToString();
            else
                id = this._currentID;

            string title = this.textBox_title.Text.Trim();
            if (title == "")
            {
                MessageBox.Show(this, "尚未输入标题");
                return null;
            }
            string catalog = this.textBox_catalog.Text.Trim();
            string level = this.comboBox_level.Text;
            string content = this.textBox_content.Text.Trim();
            string updateTime = GetNowTime();

            NoteItem note = new NoteItem()
            {
                ID = id,
                Title = title,
                Level = level,
                Catalog = catalog,
                Content = content,
                UpdateTime = updateTime,
            };

            return note;
        }

        //清空界面信息
        private void ClearControl()
        {
            this.textBox_title.Text = "";
            this.textBox_catalog.Text = "";
            this.comboBox_level.Text = "低";
            this.textBox_content.Text = "";
            this.textBox_updateTime.Text = "";
        }

        // 根据内存对象设置界面信息
        private void SetControlInfo(NoteItem item)
        {
            if (item == null)
                return;

            this._currentID = item.ID;
            this.textBox_title.Text = item.Title;
            this.textBox_catalog.Text = item.Catalog;
            this.comboBox_level.Text = item.Level;
            this.textBox_content.Text = item.Content;
            this.textBox_updateTime.Text = item.UpdateTime;
        }

        // 当前时间
        public static string GetNowTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        #endregion






    }

    
}
