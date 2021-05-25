using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.ExceptionServices;

namespace DEV_Form
{
    public partial class FM_ITEM : Form
    {
        private SqlConnection Connect = null;//접속정보 객체선언
        private string strConn = "Data Source = 61.105.9.203; Initial Catalog = AppDev; User ID = kfqs1; Password=1234";

        public FM_ITEM()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

 

        private void FM_ITEM_Load(object sender, EventArgs e)
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
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                cboItemDesc.DataSource = dtTemp;       //dttemp 데이터소스로 쓸거다
                cboItemDesc.DisplayMember = "ITEMDESC"; //눈으로 보여줄 항목
                cboItemDesc.ValueMember = "ITEMDESC"; //실제 데이터를 처리할 코드항목
                cboItemDesc.Text = "";

                //원하는 날짜 픽스
                dtpStart.Text = string.Format("{0:yyyy-MM-01}", DateTime.Now);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                string sItemCode = txtItemCode.Text;   //품목 코드
                string sItemName = txtItemName.Text;   //품목 명
                string sStartDate = dtpStart.Text;     //출시 시작 일자
                string sEndDate = dtpEnd.Text;         //출시 종료 일자
                string sItemdesc = cboItemDesc.Text;   //품목 상세

                string sEndFlag = "N";
                if (rdoEnd.Checked == true) sEndFlag = "Y";       //단종여부
                if (chkNameOnly.Checked == true) sItemCode = "";  //이름으로만 검색

                //조회조건
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT ITEMCODE,  "                          +
                                                            "       ITEMNAME,  "                          +
                                                            "       ITEMDESC,  "                          +
                                                            "       ITEMDESC2, "                          +
                                                            "       CASE WHEN ENDFLAG = 'Y' THEN '단종'" +
                                                            " WHEN ENDFLAG = 'N' THEN '생산'END AS ENDFLAG, " +
                                                            "       PRODDATE,  "                          +
                                                            "       MAKEDATE,  "                          +
                                                            "       MAKER,     "                          +
                                                            "       EDITDATE,  "                          +
                                                            "       EDITOR     "                          +
                                                            "  FROM TB_TESTITEM_MSW WITH(NOLOCK) "        +
                                                            " WHERE ITEMCODE LIKE '%" + sItemCode + "%' " +
                                                            "   AND ITEMNAME LIKE '%" + sItemName + "%' " +
                                                            "   AND ITEMDESC LIKE '%" + sItemdesc + "%' " +
                                                            "   AND ENDFLAG  = '" + sEndFlag + "'"         
                                                          //  "   AND PRODDATE BETWEEN  = '" + sStartDate + "' AND '"+ sEndDate+"'"
                                                            , Connect);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0) 
                {
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = dtTemp;//데이터 그리드 뷰에 데이터 테이블 등록

                //그리드뷰의 헤더 명칭 선언
                dgvGrid.Columns["ITEMCODE"].HeaderText = "품목 코드";
                dgvGrid.Columns["ITEMNAME"].HeaderText = "품목 명";
                dgvGrid.Columns["ITEMDESC"].HeaderText = "품목 상세";
                dgvGrid.Columns["ITEMDESC2"].HeaderText = "품목 상세2";
                dgvGrid.Columns["ENDFLAG"].HeaderText = "단종 여부";
                dgvGrid.Columns["PRODDATE"].HeaderText = "출시 일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록 일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                //그리드 뷰의 폭 지정
                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 200;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;

                //칼럼의 수정여부를 지정한다
                dgvGrid.Columns["ITEMCODE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;

          


            }
            catch (Exception)
            {

            }
            finally
            { 
            
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
            dgvGrid.Columns["ITEMCODE"].ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //선택된 행 삭제
            if (this.dgvGrid.Rows.Count == 0) return;
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
                string Itemcode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_TESTITEM_MSW WHERE ITEMCODE = '" + Itemcode + "'";

                cmd.ExecuteNonQuery();

                //성공시 DB commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제하였습니다.");
                btnSearch_Click(null, null);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //선택된 행 데이터 저장
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 등록 하시겠습니까?", "데이터 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;
            string sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
            string sItemName = dgvGrid.CurrentRow.Cells["ITEMNAME"].Value.ToString();
            string sItemDesc = dgvGrid.CurrentRow.Cells["ITEMDESC"].Value.ToString();
            string sItemDesc2 = dgvGrid.CurrentRow.Cells["ITEMDESC2"].Value.ToString();
            string sItemEndFlag = dgvGrid.CurrentRow.Cells["ENDFLAG"].Value.ToString();
            string sProdDate = dgvGrid.CurrentRow.Cells["PRODDATE"].Value.ToString();

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strConn);
            Connect.Open();

            //데이터 조회 후 해당 데이터가 있는지 확인 후 update, insert구문 분기
            string sSql = "SELECT ITEMCODE  FROM TB_TESTITEM_MSW WHERE ITEMCODE = '"+ sItemCode+ "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            //트랜잭션 설정
            Tran = Connect.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;

            cmd.CommandText = "UPDATE TB_TestItem_MSW                                                    " +
                                      "    SET ITEMNAME = '" + sItemName + "',                       " +
                                      "        ITEMDESC = '" + sItemDesc + "',                       " +
                                      "        ITEMDESC2 = '" + sItemDesc2 + "',                     " +
                                      "        ENDFLAG = '" + "N" + "',                              " +
                                      "        PRODDATE = '" + sProdDate + "',                       " +
                                      "        EDITOR = '"    + Common.LogInId + "',         " +
                                      "        EDITDATE = GETDATE()                                  " +
                                      "  WHERE ITEMCODE = '" + sItemCode + "'                        " +
                                      " IF (@@ROWCOUNT =0)                                           " +
                                      "INSERT INTO TB_TestItem_MSW(ITEMCODE,           ITEMNAME,            ITEMDESC,           ITEMDESC2,          ENDFLAG,           PRODDATE,      MAKEDATE,     MAKER) " +
                                      "VALUES('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + "N" + "','" + sProdDate + "',GETDATE(),'')";

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

        private void chkNameOnly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
