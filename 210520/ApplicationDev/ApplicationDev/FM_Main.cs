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
            //로그인 폼 호출
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
            this.stbClose.Click += new System.EventHandler(this.stbClose_Click);
            

        }
        private void stbClose_Click(object sender, EventArgs e)
        {
            //하나라도 열린 화면이 있어야 닫을 수 있기 때문에 validation
            //열려있는 화면이 있는지 확인
            if (myTabControl1.TabPages.Count == 0) return;
            //선택된 탭 페이지를 닫는다
            myTabControl1.SelectedTab.Dispose();
        }

        private void stbSearch_Click(object sender, EventArgs e)
        {

        }

        private void stbInsert_Click(object sender, EventArgs e)
        {

        }

        //버튼에 종료 이벤트 추가
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

            //해당되는 폼이 이미 오픈되어 있는지 확인 후 활성화 또는 리턴한다.
            for (int i = 0; i < myTabControl1.TabPages.Count; i++)
            {
                if (myTabControl1.TabPages[i].Name == e.ClickedItem.Name.ToString()) 
                {
                    myTabControl1.SelectedTab = myTabControl1.TabPages[i];
                    return;
                }              
            }

           /* ShowForm.MdiParent = this;
            ShowForm.Show();*/
            myTabControl1.AddForm(ShowForm); // 탭페이지에 폼을 추가하여 오픈한다

        }
        private void M_SYSTEM_Click(object sender, EventArgs e)
        {

        }

        private void MDI_TEST2_Click(object sender, EventArgs e)
        {

        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {

        }
    }

    public partial class MDIForm : TabPage
    {

    }
    public partial class MyTabControl : TabControl
    {
        public void AddForm(Form NewForm)
        {
            if (NewForm == null) return;       // 인자로 받은 폼이 없을경우 시행 중지
            NewForm.TopLevel = false;          // 인자로 받은 폼이 최상위 개체가 아님을 선언
            MDIForm page = new MDIForm();      // 탭 페이지 객체 생성
            page.Controls.Clear();             // 페이지 초기화
            page.Controls.Add(NewForm);        // 페이지에 폼 추가
            page.Text = NewForm.Text;          // 폼에서 지정한 명칭으로 탭 페이지 설정
            page.Name = NewForm.Name;          // 폼에서 설정한 이름으로 탭 페이지 설정
            base.TabPages.Add(page);           // 탭 컨트롤에 페이지를 추가한다
            NewForm.Show();                    // 인자로 받은 폼을 보여준다
            base.SelectedTab = page;           // 현재 선택된 페이지를 호출한 폼의 페이지로 설정한다
        }
    }


}
