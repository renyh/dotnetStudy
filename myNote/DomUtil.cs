using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace myNote
{
    // DomUtil类包含XML DOM的一些扩展功能函数
    public class DomUtil
    {
        // 编写者: 谢涛
        public static string GetElementText(XmlNode nodeRoot,
            string strXpath)
        {
            XmlNode node = nodeRoot.SelectSingleNode(strXpath);
            if (node == null)
                return "";

            XmlNode nodeText;
            nodeText = node.SelectSingleNode("text()");

            if (nodeText == null)
                return "";
            else
                return nodeText.Value;
        }


    } // DomUtil类结束


}
