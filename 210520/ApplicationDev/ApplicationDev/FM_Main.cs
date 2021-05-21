using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEV_Form;

namespace ApplicationDev
{
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
            FM_Login Login = new FM_Login();
            Login.ShowDialog();
            tssUserName.Text = Login.Tag.ToString();
            if (Login.Tag.ToString() == "FAIL")//태그가 fail일 때 종료
            {
               Application.ExitThread();
                Application.Exit();
              //  System.Environment.Exit(0);
            }

            this.stbExit.Click += new System.EventHandler(this.stbExit_Click);
            //메뉴클릭 이벤트 추가
            this.M_SYSTEM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_SYSTEM_DropDownItemClicked);

        }

        private void stbSearch_Click(object sender, EventArgs e)
        {

        }

        private void stbInsert_Click(object sender, EventArgs e)
        {

        }

        private void stbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tssUserName_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Click(object sender, EventArgs e)
        {
            tssNowDate.Text = DateTime.Now.ToString();
        }

        private void tssNowDate_Click(object sender, EventArgs e)
        {

        }

        private void FM_Main_Load(object sender, EventArgs e)
        {

        }

        private void MDI_TEST_Click(object sender, EventArgs e)
        {

        }

        private void M_SYSTEM_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //1. 단순히 폼을 호출하는 경우
            //MDI_TEST Form = new MDI_TEST(); //DEV_Form.Form1 FROM = new DEV_Form.Form1();
            //Form.MdiParent = this;
            //Form.Show();

            //2.프로그램을 호출
            Assembly assemb = Assembly.LoadFrom(Application.StartupPath + @"\" + "DEV_Form.dll");
            Type typeForm = assemb.GetType("DEV_Form." + e.ClickedItem.Name.ToString(), true);
            Form ShowForm = (Form)Activator.CreateInstance(typeForm);

            ShowForm.MdiParent = this;
            ShowForm.Show();

        }

        private void M_SYSTEM_Click(object sender, EventArgs e)
        {

        }
    }
}
