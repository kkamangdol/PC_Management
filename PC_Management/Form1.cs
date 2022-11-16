using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

// 데이터 조회시 끊김 줄이기
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32.SafeHandles;

namespace PC_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 오라클DB 연결
        private string strConn =  "Data Source = DEV_DDF; User ID = DKPS; Password = dkps";


// 1. 전체 조회 
        private DataTable GetData()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from CPU_TABLE where CPU_TYPE = NVL('" + Cb_CPU_Type.Text + "', CPU_TYPE) and USER_TEAM = NVL('" + Cb_User_Team.Text + "', USER_TEAM) order by CPU_Num DESC", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // 조회 버튼
        private void bt_search_Click(object sender, EventArgs e)
        {
            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = GetData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "컴퓨터 종류";
            this.dataGridView1.Columns[2].HeaderText = "윈도우 버전";
            this.dataGridView1.Columns[3].HeaderText = "구매일";
            this.dataGridView1.Columns[4].HeaderText = "사용 여부";
            this.dataGridView1.Columns[5].HeaderText = "IP 주소";
            this.dataGridView1.Columns[6].HeaderText = "사용자 이름";
            this.dataGridView1.Columns[7].HeaderText = "사용팀";
            this.dataGridView1.Columns[8].HeaderText = "사용 지역";
            this.dataGridView1.Columns[9].HeaderText = "사용 구분";

            // 데이터 조회시 끊김 줄이기
            dataGridView1.DoubleBuffered(true);

            // 행 색변경
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // 여러 행 선택 방지
            dataGridView1.MultiSelect = false;

            // 전체 컬럼의 Sorting 기능 차단
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            // 자동으로 선택되는 셀 해제
            dataGridView1.CurrentCell = null;

            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;
        }


//  2. 콤보박스 조회

        // 컴퓨터타입 조회(콤보박스)
        private DataTable Search_CPU_TypeData()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from CPU_TABLE where CPU_TYPE = NVL('" + Cb_CPU_Type.Text + "', CPU_TYPE) and USER_TEAM = NVL('" + Cb_User_Team.Text + "', USER_TEAM) order by CPU_Num DESC", conn);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);

            return dt1;
        }

        private void Cb_CPU_Type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = Search_CPU_TypeData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "컴퓨터 종류";
            this.dataGridView1.Columns[2].HeaderText = "윈도우 버전";
            this.dataGridView1.Columns[3].HeaderText = "구매일";
            this.dataGridView1.Columns[4].HeaderText = "사용 여부";
            this.dataGridView1.Columns[5].HeaderText = "IP 주소";
            this.dataGridView1.Columns[6].HeaderText = "사용자 이름";
            this.dataGridView1.Columns[7].HeaderText = "사용팀";
            this.dataGridView1.Columns[8].HeaderText = "사용 지역";
            this.dataGridView1.Columns[9].HeaderText = "사용 구분";

            // 데이터 조회시 끊김 줄이기
            dataGridView1.DoubleBuffered(true);

            // 행 색변경
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // 여러 행 선택 방지
            dataGridView1.MultiSelect = false;

            // 전체 컬럼의 Sorting 기능 차단
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 자동으로 선택되는 셀 해제
            dataGridView1.CurrentCell = null;


            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;
        }

        // 사용팀 조회(콤보박스)
        private DataTable Search_User_TeamData()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from CPU_TABLE where CPU_TYPE = NVL('" + Cb_CPU_Type.Text + "', CPU_TYPE) and USER_TEAM = NVL('" + Cb_User_Team.Text + "', USER_TEAM) order by CPU_Num DESC", conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);

            return dt2;
        }
        private void Cb_User_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = Search_User_TeamData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "컴퓨터 종류";
            this.dataGridView1.Columns[2].HeaderText = "윈도우 버전";
            this.dataGridView1.Columns[3].HeaderText = "구매일";
            this.dataGridView1.Columns[4].HeaderText = "사용 여부";
            this.dataGridView1.Columns[5].HeaderText = "IP 주소";
            this.dataGridView1.Columns[6].HeaderText = "사용자 이름";
            this.dataGridView1.Columns[7].HeaderText = "사용팀";
            this.dataGridView1.Columns[8].HeaderText = "사용 지역";
            this.dataGridView1.Columns[9].HeaderText = "사용 구분";

            // 데이터 조회시 끊김 줄이기
            dataGridView1.DoubleBuffered(true);

            // 행 색변경
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // 여러 행 선택 방지
            dataGridView1.MultiSelect = false;

            // 전체 컬럼의 Sorting 기능 차단
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 자동으로 선택되는 셀 해제
            dataGridView1.CurrentCell = null;

            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;
        }


 // 3. 콤보박스에 보여질 DB 아이템 

        // Fixed_Table(Cpu_Type) 연결
        public DataTable Cpu_TypeData()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select code_data from Fixed_Table where code_part = 'CPU_TYPE'", conn);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);

            return dt1;
        }

        // Fixed_Table(User_Team) 연결
        private DataTable User_TeamData()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select code_data from Fixed_Table where code_part = 'USER_TEAM'", conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);

            return dt2;
        }

        // 화면켰을때 콤보박스
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fixed_Table(Cpu_Type) ComboBpx
            DataTable dt1 = Cpu_TypeData();
            Cb_CPU_Type.DataSource = dt1;
            Cb_CPU_Type.DisplayMember = "CODE_DATA";
            Cb_CPU_Type.SelectedIndex = 0;

            //Fixed_Table(User_Team) ComboBox
            DataTable dt2 = User_TeamData();
            Cb_User_Team.DataSource = dt2;
            Cb_User_Team.DisplayMember = "CODE_DATA";
            Cb_User_Team.SelectedIndex = 0;

            // Fixed_Table(Cpu_Type) ComboBpx
            DataTable dt1_c = Cpu_TypeData();
            Cb_CPU_Type_c.DataSource = dt1_c;
            Cb_CPU_Type_c.DisplayMember = "CODE_DATA";
            Cb_CPU_Type_c.SelectedIndex = 0;

            //Fixed_Table(User_Team) ComboBox
            DataTable dt2_c = User_TeamData();
            Cb_User_Team_c.DataSource = dt2_c;
            Cb_User_Team_c.DisplayMember = "CODE_DATA";
            Cb_User_Team_c.SelectedIndex = 0;
        }


// 4. 등록하기
        private void Bt_Create_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection conn = new OracleConnection(strConn);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "insert into CPU_TABLE values ('" + text_CPU_Num.Text + "','" + Cb_CPU_Type_c.Text + "','" + text_Win_Ver.Text + "','" + dtp_Purchase_Date.Text + "','" + text_Usage_Status.Text + "','" + text_CPU_IP.Text + "','" + text_User_Name.Text + "','" + Cb_User_Team_c.Text + "','" + text_User_Area.Text + "','" + text_User_Usage.Text + "')";
                cmd.ExecuteNonQuery();

                conn.Close();

                // 마우스 커서 Waitting
                this.Cursor = Cursors.WaitCursor;

                // 데이터그리드뷰에 띄우기
                DataTable dt = GetData();
                dataGridView1.DataSource = dt;

                // 자동으로 선택되는 셀 해제
                dataGridView1.CurrentCell = null;

                // 메세지박스
                MessageBox.Show("등록이 완료되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 컬럼명 변경
                this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
                this.dataGridView1.Columns[1].HeaderText = "컴퓨터 종류";
                this.dataGridView1.Columns[2].HeaderText = "윈도우 버전";
                this.dataGridView1.Columns[3].HeaderText = "구매일";
                this.dataGridView1.Columns[4].HeaderText = "사용여부";
                this.dataGridView1.Columns[5].HeaderText = "IP 주소";
                this.dataGridView1.Columns[6].HeaderText = "사용자 이름";
                this.dataGridView1.Columns[7].HeaderText = "사용팀";
                this.dataGridView1.Columns[8].HeaderText = "사용 지역";
                this.dataGridView1.Columns[9].HeaderText = "사용 구분";

                // 데이터 조회시 끊김 줄이기
                dataGridView1.DoubleBuffered(true);

                // 행 색변경
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                // 여러 행 선택 방지
                dataGridView1.MultiSelect = false;

                // 전체 컬럼의 Sorting 기능 차단
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    item.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                // 마우스 커서 원래대로
                this.Cursor = Cursors.Default;

                // 텍스트박스 빈칸
                text_CPU_Num.Clear();
                text_Win_Ver.Clear();
                text_Usage_Status.Clear();
                text_CPU_IP.Clear();
                text_User_Name.Clear();
                text_User_Area.Clear();
                text_User_Usage.Clear();
                Cb_User_Team_c.SelectedIndex = 0;
                Cb_CPU_Type_c.SelectedIndex = 0;
            }

            // 예외처리
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                // 메세지박스
                MessageBox.Show("컴퓨터 번호 중복 혹은 필수란에 빈칸이 있습니다!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


// 5. 수정하기
        private void Bt_Update_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from CPU_TABLE", conn);
            DataTable dt1 = new DataTable();

            conn.ConnectionString = strConn;
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update CPU_TABLE SET cpu_type = '" + Cb_CPU_Type_c.Text + "',win_ver = '" + text_Win_Ver.Text + "', purchase_date = '" + dtp_Purchase_Date.Text + "',usage_status = '" + text_Usage_Status.Text + "',cpu_ip = '" + text_CPU_IP.Text + "',user_name = '" + text_User_Name.Text + "', user_team = '" + Cb_User_Team_c.Text + "',user_area = '" + text_User_Area.Text + "', user_usage = '" + text_User_Usage.Text + "' where cpu_num = '" + text_CPU_Num.Text + "'";
            cmd.ExecuteNonQuery();

            adapter = new OracleDataAdapter(cmd);   
            adapter.Fill(dt1);

            conn.Close();

            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = GetData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "컴퓨터 종류";
            this.dataGridView1.Columns[2].HeaderText = "윈도우 버전";
            this.dataGridView1.Columns[3].HeaderText = "구매일";
            this.dataGridView1.Columns[4].HeaderText = "사용 여부";
            this.dataGridView1.Columns[5].HeaderText = "IP 주소";
            this.dataGridView1.Columns[6].HeaderText = "사용자 이름";
            this.dataGridView1.Columns[7].HeaderText = "사용팀";
            this.dataGridView1.Columns[8].HeaderText = "사용 지역";
            this.dataGridView1.Columns[9].HeaderText = "사용 구분";

            // 데이터 조회시 끊김 줄이기
            dataGridView1.DoubleBuffered(true);

            // 행 색변경
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // 여러 행 선택 방지
            dataGridView1.MultiSelect = false;

            // 전체 컬럼의 Sorting 기능 차단
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 자동으로 선택되는 셀 해제
            dataGridView1.CurrentCell = null;


            // 메세지박스
            MessageBox.Show("수정이 완료되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;

            // 텍스트박스 빈칸
            text_CPU_Num.Clear();
            text_Win_Ver.Clear();
            text_Usage_Status.Clear();
            text_CPU_IP.Clear();
            text_User_Name.Clear();
            text_User_Area.Clear();
            text_User_Usage.Clear();
            Cb_User_Team_c.SelectedIndex = 0;
            Cb_CPU_Type_c.SelectedIndex = 0;
        }


// 6.삭제하기

        // cpu_table 삭제
        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from CPU_TABLE", conn);
            DataTable dt1 = new DataTable();

            conn.ConnectionString = strConn;
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "DELETE FROM CPU_TABLE WHERE cpu_num = '" + text_CPU_Num.Text + "'";
            cmd.ExecuteNonQuery();

            adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dt1);

            conn.Close();

            // program_serial 데이터 삭제
            OracleConnection conn2 = new OracleConnection(strConn);
            OracleDataAdapter adapter2 = new OracleDataAdapter("select * from PROGRAN_SERIAL", conn2);
            DataTable dt2 = new DataTable();

            conn2.ConnectionString = strConn;
            conn2.Open();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn2;

            cmd2.CommandText = "DELETE FROM PROGRAM_SERIAL WHERE cpu_num = '" + text_CPU_Num.Text + "'";
            cmd2.ExecuteNonQuery();

            adapter2 = new OracleDataAdapter(cmd2);
            adapter2.Fill(dt2);

            conn2.Close();


            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = GetData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "컴퓨터 종류";
            this.dataGridView1.Columns[2].HeaderText = "윈도우 버전";
            this.dataGridView1.Columns[3].HeaderText = "구매일";
            this.dataGridView1.Columns[4].HeaderText = "사용 여부";
            this.dataGridView1.Columns[5].HeaderText = "IP 주소";
            this.dataGridView1.Columns[6].HeaderText = "사용자 이름";
            this.dataGridView1.Columns[7].HeaderText = "사용팀";
            this.dataGridView1.Columns[8].HeaderText = "사용 지역";
            this.dataGridView1.Columns[9].HeaderText = "사용 구분";

            // 데이터 조회시 끊김 줄이기
            dataGridView1.DoubleBuffered(true);

            // 행 색변경
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // 여러 행 선택 방지
            dataGridView1.MultiSelect = false;

            // 전체 컬럼의 Sorting 기능 차단
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 자동으로 선택되는 셀 해제
            dataGridView1.CurrentCell = null;

            // 메세지박스
            MessageBox.Show("삭제가 완료되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;

            // 텍스트박스 빈칸
            text_CPU_Num.Clear();
            text_Win_Ver.Clear();
            text_Usage_Status.Clear();
            text_CPU_IP.Clear();
            text_User_Name.Clear();
            text_User_Area.Clear();
            text_User_Usage.Clear();
            Cb_User_Team_c.SelectedIndex = 0;
            Cb_CPU_Type_c.SelectedIndex = 0;

        }


// 7. 데이터 가져오기

        //  셀 선택해서 데이터 뽑아오기(마우스 클릭)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            text_CPU_Num.Text = row.Cells[0].Value.ToString();
            Cb_CPU_Type_c.Text = row.Cells[1].Value.ToString();
            text_Win_Ver.Text = row.Cells[2].Value.ToString();
            dtp_Purchase_Date.Text = row.Cells[3].Value.ToString();
            text_Usage_Status.Text = row.Cells[4].Value.ToString();
            text_CPU_IP.Text = row.Cells[5].Value.ToString();
            text_User_Name.Text = row.Cells[6].Value.ToString();
            Cb_User_Team_c.Text = row.Cells[7].Value.ToString();
            text_User_Area.Text = row.Cells[8].Value.ToString();
            text_User_Usage.Text = row.Cells[9].Value.ToString();

        }

        //  셀 선택해서 데이터 뽑아오기(키패드) 
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            text_CPU_Num.Text = row.Cells[0].Value.ToString();
            Cb_CPU_Type_c.Text = row.Cells[1].Value.ToString();
            text_Win_Ver.Text = row.Cells[2].Value.ToString();
            dtp_Purchase_Date.Text = row.Cells[3].Value.ToString();
            text_Usage_Status.Text = row.Cells[4].Value.ToString();
            text_CPU_IP.Text = row.Cells[5].Value.ToString();
            text_User_Name.Text = row.Cells[6].Value.ToString();
            Cb_User_Team_c.Text = row.Cells[7].Value.ToString();
            text_User_Area.Text = row.Cells[8].Value.ToString();
            text_User_Usage.Text = row.Cells[9].Value.ToString();
        }


        // 뽑아온 데이터 지우기
        private void button1_Click(object sender, EventArgs e)
        {
            text_CPU_Num.Clear();
            text_Win_Ver.Clear();
            text_Usage_Status.Clear();
            text_CPU_IP.Clear();
            text_User_Name.Clear();
            text_User_Area.Clear();
            text_User_Usage.Clear();

            Cb_User_Team_c.SelectedIndex = 0;
            Cb_CPU_Type_c.SelectedIndex = 0;
        }


// 8. 상세보기(씨리얼넘버)

        // 데이터를 수신할 전역변수 선언
        public string RecivedData;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 상세화면 띄우기

            // 자식 폼을 호출하면서 txt데이터를 전송.
            Form2 newform2 = new Form2(text_CPU_Num.Text);
            newform2.ShowDialog();

            // 자식폼의 Owner를 선언
            newform2.Owner = this;

            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;
        }
    }


    // 9. 데이터 조회시 끊김 줄이기
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
