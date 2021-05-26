using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ApplicationDev;

namespace DEV_Form
{
    public partial class FM_CUSTOMER : Form
    {
        private SqlConnection Connect = null;//접속정보 객체선언
        private string strConn = "Data Source = 61.105.9.203; Initial Catalog = AppDev; User ID = kfqs1; Password=1234";



        public FM_CUSTOMER()
        {
            InitializeComponent();
        }

        private void FM_CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                //콤보박스 품목 상세 데이터 조회 및 추가
                Connect = new SqlConnection(strConn);//접속 정보 커넥션에 등록 및 객체 선언
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                    return;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(" SELECT DISTINCT ITEMDESC FROM TB_TESTITEM_MSW ", Connect);
                DataTable dtTemp1 = new DataTable();
                adapter.Fill(dtTemp1);

                //원하는 날짜 픽스
                dtpStart.Text = string.Format("{0:yyyy-01-01 hh:mm:ss}", DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }

        }

        private void dgvCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdoSCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoACar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoCut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoPump_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(strConn);
                Connect.Open();
                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                    return;
                }

                //조회를 위한 파라미터 설정
                string sCusCode = txtCustCode.Text;   //품목 코드
                string sCusName = txtCustName .Text;   //품목 명
                string sStartDate = dtpStart.Text;     //출시 시작 일자
                string sEndDate = dtpEnd.Text;         //출시 종료 일자

                string sonlyType = "";
                if (chkCustOnly.Checked==true) sonlyType = "C";

                string sproType = "";
                if (rdoSCar.Checked == true) sproType = "상용차 부품";
                else if (rdoACar.Checked == true) sproType = "자동차부품";
                else if (rdoCut.Checked == true) sproType = "절삭가공";
                else if (rdoPump.Checked == true) sproType = "펌프압축기";

                //조회조건
                string sSql = "SELECT CUSTCODE,  "
                                                            + "       CASE WHEN CUSTTYPE = 'C' THEN '고객사'"
                                                            + " WHEN CUSTTYPE = 'V' THEN '협력사'END AS CUSTTYPE, "
                                                            + "       CUSTNAME,  "
                                                            + "       BIZCLASS, "
                                                            + "       BIZTYPE, "
                                                            + "       USEFLAG,  "
                                                            + "       FIRSTDATE,  "
                                                            + "       MAKEDATE,  "
                                                            + "       MAKER,     "
                                                            + "       EDITDATE,  "
                                                            + "       EDITOR     "
                                                            + "  FROM TB_CUSTOMER_MSW WITH(NOLOCK) "
                                                            + " WHERE CUSTTYPE LIKE '%" + sonlyType + "%' "
                                                            + " AND isnull(BIZTYPE,'') LIKE '%" + sproType + "%' ";

                 
                SqlDataAdapter Adapter = new SqlDataAdapter(sSql , Connect);

                if (chkCustOnly.Checked == true)
                {
                    SqlDataAdapter Adapter1 = new SqlDataAdapter("SELECT CUSTCODE,  " +
                                                                "       CUSTTYPE,  " +
                                                                "       CUSTNAME,  " +
                                                                "       BIZCLASS, " +
                                                                "       USEFLAG,  " +
                                                                "       FIRSTDATE,  " +
                                                                "       MAKEDATE,  " +
                                                                "       MAKER,     " +
                                                                "       EDITDATE,  " +
                                                                "       EDITOR     " +
                                                                "  FROM TB_CUSTOMER_MSW  WITH(NOLOCK)" +
                                                                " WHERE CUSTTYPE = 'C'" 
                                                                 , Connect);
                }

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {
                    dgvCus.DataSource = null;
                    return;
                }
                dgvCus.DataSource = dtTemp;//데이터 그리드 뷰에 데이터 테이블 등록

                //그리드뷰의 헤더 명칭 선언
                dgvCus.Columns["CUSTCODE"].HeaderText = "거래처 코드";
                dgvCus.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                dgvCus.Columns["CUSTNAME"].HeaderText = "거래처 명";
                dgvCus.Columns["BIZCLASS"].HeaderText = "업태";
                dgvCus.Columns["BIZTYPE"].HeaderText = "종목";
                dgvCus.Columns["USEFLAG"].HeaderText = "사용여부";
                dgvCus.Columns["FIRSTDATE"].HeaderText = "거래일자";
                dgvCus.Columns["MAKEDATE"].HeaderText = "등록 일시";
                dgvCus.Columns["MAKER"].HeaderText = "등록자";
                dgvCus.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvCus.Columns["EDITOR"].HeaderText = "수정자";

                //그리드 뷰의 폭 지정
                dgvCus.Columns[0].Width = 100;
                dgvCus.Columns[1].Width = 200;
                dgvCus.Columns[2].Width = 200;
                dgvCus.Columns[3].Width = 200;
                dgvCus.Columns[4].Width = 100;

            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }



        private void btnAddC_Click(object sender, EventArgs e)
        {
            DataRow dr = ((DataTable)dgvCus.DataSource).NewRow();
            ((DataTable)dgvCus.DataSource).Rows.Add(dr);
            dgvCus.Columns["CUSTCODE"].ReadOnly = false;
        }

        private void btnSaveC_Click(object sender, EventArgs e)
        {
            //선택된 행 데이터 저장
            if (dgvCus.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 등록 하시겠습니까?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;
            string sItemCode = dgvCus.CurrentRow.Cells["CUSTCODE"].Value.ToString();
            string sItemName = dgvCus.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
            string sItemDesc = dgvCus.CurrentRow.Cells["CUSTNAME"].Value.ToString();
            string sItemDesc2 = dgvCus.CurrentRow.Cells["BIZCLASS"].Value.ToString();
            string sBType = dgvCus.CurrentRow.Cells["BIZTYPE"].Value.ToString();

            string sItemEndFlag = dgvCus.CurrentRow.Cells["USEFLAG"].Value.ToString();
            string sProdDate = dgvCus.CurrentRow.Cells["FIRSTDATE"].Value.ToString();
            string sMakedate = dgvCus.CurrentRow.Cells["MAKEDATE"].Value.ToString();
            string sMaker = dgvCus.CurrentRow.Cells["MAKER"].Value.ToString();
            string sEditdate = dgvCus.CurrentRow.Cells["EDITDATE"].Value.ToString();
            string sEditor = dgvCus.CurrentRow.Cells["EDITDATE"].Value.ToString();





            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            //데이터 조회 후 해당 데이터가 있는지 확인 후 update, insert구문 분기
            string sSql = "SELECT CUSTCODE  FROM TB_CUSTOMER_MSW WHERE CUSTCODE = '" + sItemCode + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            //트랜잭션 설정
            Tran = Connect.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;

            cmd.CommandText = "UPDATE TB_CUSTOMER_MSW                                                " +
                                      "    SET CUSTCODE = '" + sItemCode + "',                       " +
                                      "        CUSTTYPE = '" + sItemName + "',                       " +
                                      "        CUSTNAME = '" + sItemDesc + "',                       " +
                                      "        BIZCLASS = '" + sItemDesc2 + "',                      " +
                                      "        BIZTYPE = '" + sBType + "',                           " +

                                      "        USEFLAG = '" + sItemEndFlag + "',                     " +
                                      "        FIRSTDATE = '" + sProdDate + "',                      " +
                                      "        MAKEDATE = '" + sMakedate + "',                       " +
                                      "        MAKER = '" + sMaker + "',                             " +
                                      "        EDITOR = '" + Common.LogInId + "',                    " +
                                      "        EDITDATE = '" + DateTime.Now + "'                     " +
                                      "  WHERE CUSTCODE = '" + sItemCode + "'                        " +
                                      " IF (@@ROWCOUNT =0)                                           " +
                                      "INSERT INTO TB_CUSTOMER_MSW(CUSTCODE,           CUSTTYPE,            CUSTNAME,           BIZCLASS,  BIZTYPE  ,     USEFLAG,           FIRSTDATE,      MAKEDATE,     MAKER, EDITOR, EDITDATE) " +
                                      "VALUES('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" +sBType+"','"+ sItemEndFlag+ "','"
                                       + sProdDate + "','" + sMakedate + "','"+ sMaker+"','" + Common.LogInId +"',"+" GETDATE())";


            //e데이터가 잇는 경우 update, 없는 경우 insert
            //if (dtTemp.Rows.Count == 0)
            //{
            //    //데이터가 없으니 INSERT해라
            //    cmd.CommandText = "INSERT INTO TB_TESTITEM_MSW (ITEMCODE,       ITEMNAME,                 ITEMDESC,        ITEMDESC2,         ENDFLAG,                 PRODDATE,      MAKEDATE,   MAKER)" +
            //                           "                      VALUES ('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + "N" + "','" + sProdDate + "',GETDATE(),'" + "" + "')";

            //}
            //else
            //{ 
            //    //데이터가 있으니 UPDATE해라
            //    cmd.CommandText = "UPDATE TB_TESTITEM_MSW                    " +
            //                      "    SET ITEMNAME = '" + sItemName + "',   " +
            //                      "        ITEMDESC = '" + sItemDesc + "',   " +
            //                      "        ITEMDESC2 = '" + sItemDesc2 + "', " +
            //                      "        ENDFLAG = '" + "N" + "', " +
            //                      "        PRODDATE = '" + sProdDate + "',   " +
            //                      "        EDITOR = '',                      " +
            //                      //"        EDITOR = '"    + Commoncs.LoginUserID + "',  " +
            //                      "        EDITDATE = GETDATE()     "   +
            //                      "  WHERE ITEMCODE = '" + sItemCode + "'";
            //}

            cmd.ExecuteNonQuery();

            //성공시 DB COMMIT
            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Connect.Close();
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if (this.dgvCus.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            tran = Connect.BeginTransaction("TranStart");
            cmd.Transaction = tran;
            cmd.Connection = Connect;

            try
            {
                string custcode = dgvCus.CurrentRow.Cells["CUSTCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_CUSTOMER_MSW WHERE CUSTCODE = '" + custcode + "'";

                cmd.ExecuteNonQuery();

                //성공시 DB commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제하였습니다.");
                btnCSearch_Click(null, null);
            }

            catch
            {
                tran.Rollback();
                MessageBox.Show("데이터 삭제에 실패했습니다.");

            }
            finally
            {
                Connect.Close();
            }
        }
    }
}
