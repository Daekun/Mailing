﻿using System;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Xml;

namespace 시험
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        
        public static bool sw_Login=false;
        public static String user_id="";
        public static bool sw_Upload = false;
        static void Main()
        {
            /*XslTransform myXslTransform;
            myXslTransform = new XslTransform();
            myXslTransform.Load("XHTML.xslt");
            myXslTransform.Transform("fyxwix12.xml", "output.xml");*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Member());
            Application.ExitThread();
            Home Temp_1 = new Home();
            if (sw_Login == true)
            {
                Application.Run(Temp_1);
            }
            Application.ExitThread();
        }
    }
}   
