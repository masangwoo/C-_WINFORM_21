using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev

{    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null; //데이터베이스 접속정보
        private SqlTransaction Tran;          //데이터베이스 관리 권한
        private SqlCommand cmd = new SqlCommand();  //데이터베이스 명령 전달

        public FM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=61.105.9.203;Initial Catalog=AppDev;User ID=kfqs;Password=1234";

            Connect = new SqlConnection(strCon);

            Connect.Open(); //데이터베이스에 접속한다

            //DB접속이 되지 않았을 경우 메세지 리턴 후 이벤트 종료
            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터베이스 연결에 실패하였습니다.");
                return;
            }
            //1. ID존재여부 확인
            string sLoinid = string.Empty;//로그인ID
            string sLoinPw = string.Empty;

            sLoinid = txt_ID.Text;
            sLoinPw = txt_Password.Text;

            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_MSW WHERE USERID = '" + sLoinid + "'", Connect);

            //데이터를 담을 그릇
            DataTable DtTemp = new DataTable();

            //어댑터 실행 후 그릇에 데이터 담기
            Adapter.Fill(DtTemp);

            //데이터가 없는 경우 사용자가 없다고 메세지 및 리턴
            if (DtTemp.Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사용자 입니다.");
                return;
            }

            //2. 이전 비밀번호 일치하는지 확인
            else if (DtTemp.Rows[0]["PW"].ToString() == sLoinPw)
            {
                MessageBox.Show("환영합니다.");
                return;
            }

            else { return; }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pwchange_Click(object sender, EventArgs e)
        {
            //비밀번호 변경화면 팝업을 호출
            this.Visible = false; //로그인화면을 보이지 않게 한다
            FM_passWord FmPassWord = new FM_passWord();
            FmPassWord.ShowDialog();//password창이 닫히기 전까지는 다른작업을 못함
            this.Visible = true;


        }
    }
}
