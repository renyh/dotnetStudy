using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace myNote
{
    public class NoteManager
    {
        // xml文件
        string _fileName = "";

        // 集合
        List<NoteItem> _notes = new List<NoteItem>();
        public List<NoteItem> Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        // 初始化
        public int Init(string filePath,out string error)
        {
            _fileName = filePath;
            error = "";

            XmlDocument dom = new XmlDocument();
            if (File.Exists(this._fileName) == false)
            {
                // 如果目录不存在，创建好目录，dom保存时会自动创建文件
                string dir= Path.GetDirectoryName(this._fileName);
                if (Directory.Exists(dir) == false)
                    Directory.CreateDirectory(dir);

                dom.LoadXml("<root/>");
            }
            else
            {
                try
                {
                    dom.Load(this._fileName);
                }
                catch (Exception ex)
                {
                    error = "加载笔记xml文件出错："+ex.Message;
                    return -1;
                }
                this.ParseXml(dom);
            }

            return 0;
        }



        /*
<root>
    <note>
        <id>123</id>
        <title>test</title>
        <catalog/>
        <level/>
        <content/>
        <updateTime/>
    </note>
    <note>...</note>
</root>
         */
        private void ParseXml(XmlDocument dom)
        {
            XmlNode root = dom.DocumentElement;

            XmlNodeList noteList = root.SelectNodes("note");
            foreach (XmlNode node in noteList)
            {
                string id = DomUtil.GetElementText(node,"id");
                string title = DomUtil.GetElementText(node, "title");
                string catalog = DomUtil.GetElementText(node, "catalog");
                string level = DomUtil.GetElementText(node, "level");
                string content = DomUtil.GetElementText(node, "content");
                string updateTime = DomUtil.GetElementText(node, "updateTime");

                // 创建NoteItem对象
                NoteItem item = new NoteItem()
                {
                    ID = id,
                    Title = title,
                    Catalog = catalog,
                    Level = level,
                    Content = content,
                    UpdateTime = updateTime,
                };
                // 加到集合中
                this.Notes.Add(item);
            }
        }

        // 获取事项
        public NoteItem Get(string id)
        {
            foreach (NoteItem item in this.Notes)
            {
                if (item.ID == id)
                    return item;
            }

            return null;
        }

        // 新增事项
        public void Add(NoteItem item)
        {
            Debug.Assert(item != null, "item参数不能为null");

            NoteItem temp = this.Get(item.ID);
            if (temp != null)
            {
                throw new Exception("id为["+item.ID+"]的事项已经存在.");
            }

            // 加到集合中
            this.Notes.Add(item);
        }

        // 编辑事项
        public void Edit(NoteItem item)
        {
            Debug.Assert(item != null, "item参数不能为null");

            NoteItem oldItem = this.Get(item.ID);
            if (oldItem == null)
            {
                throw new Exception("id为[" + item.ID + "]的事项不存在.");
            }

            //  更新内存中的数据
            oldItem.Title = item.Title;
            oldItem.Catalog = item.Catalog;
            oldItem.Level = item.Level;
            oldItem.Content = item.Content;
            oldItem.UpdateTime = item.UpdateTime;
        }

        //删除事项
        public void Delete(string id)
        {
            NoteItem item = this.Get(id);
            if (item != null)
            {
                // 从集合中移除
                this.Notes.Remove(item);
            }
        }

        // 内存数据保存到xml文件
        public void Save()
        {
            XmlDocument dom = new XmlDocument();
            string xml = "<root>";
            foreach (NoteItem item in this.Notes)
            {
                xml += "<note>"
                        + "<id>"+item.ID+"</id>"
                        + "<title>"+item.Title+"</title>"
                        + "<catalog>"+item.Catalog+"</catalog>"
                        + "<level>"+item.Level+"</level>"
                        + "<content>"+item.Content+"</content>"
                        + "<updateTime>"+item.UpdateTime+"</updateTime>"
                    + "</note>";
            }
            xml += "</root>";
            dom.LoadXml(xml);

           dom.Save(this._fileName);
        }

    }
}
