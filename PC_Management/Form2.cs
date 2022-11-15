using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PC_Management
{
    public partial class Form2 : Form
    {
        // 데이터를 수신할 전역변수
        string RecivedData;

        public Form2(string Data)
        {
            InitializeComponent();

            // 부모폼에서 데이터를 받아 전역변수에 넣는다.
            RecivedData = Data;
        }

        // 오라클DB 연결
        private string strConn = "Data Source = DEV_DDF; User ID = DKPS; Password = dkps";


//1. 오픈시 조회
        private DataTable DetailData()
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from program_serial where CPU_Num like '" + text_CPU_Num2.Text + "' order by CPU_Num ", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // 조회
        private void Form2_Load(object sender, EventArgs e)
        {

            // 부모폼에서 받은 데이터를 텍스트박스에 넣는다.
            text_CPU_Num2.Text =RecivedData;

            DataTable dt = DetailData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "프로그램명";
            this.dataGridView1.Columns[2].HeaderText = "씨리얼넘버";

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
        }


// 2. 데이터 가져오기

        //  셀 선택해서 데이터 뽑아오기
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            text_Program2.Text = row.Cells[1].Value.ToString();
            text_Serial2.Text = row.Cells[2].Value.ToString();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            text_Program2.Text = row.Cells[1].Value.ToString();
            text_Serial2.Text = row.Cells[2].Value.ToString();
        }

        // 뽑아온 데이터 지우기
        private void button1_Click(object sender, EventArgs e)
        {
            text_Program2.Clear();
            text_Serial2.Clear();
        }


// 3. 등록하기
        private void Bt_Create2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into PROGRAM_SERIAL values ('" + text_CPU_Num2.Text + "','" + text_Program2.Text + "','" + text_Serial2.Text + "')";
            cmd.ExecuteNonQuery();

            conn.Close();

            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = DetailData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "프로그램명";
            this.dataGridView1.Columns[2].HeaderText = "씨리얼넘버";

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
            MessageBox.Show("등록이 완료되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 마우스 커서 원래대로
            this.Cursor = Cursors.Default;

            // 텍스트박스 빈칸
            text_Program2.Clear();
            text_Serial2.Clear();
        }


// 4. 삭제하기
        private void Bt_Delete2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from PROGRAM_SERIAL", conn);
            DataTable dt1 = new DataTable();

            conn.ConnectionString = strConn;
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "DELETE FROM PROGRAM_SERIAL WHERE Serial = '" + text_Serial2.Text + "'";
            cmd.ExecuteNonQuery();

            adapter = new OracleDataAdapter(cmd);
            adapter.Fill(dt1);

            conn.Close();

            // 마우스 커서 Waitting
            this.Cursor = Cursors.WaitCursor;

            // 데이터그리드뷰에 띄우기
            DataTable dt = DetailData();
            dataGridView1.DataSource = dt;

            // 컬럼명 변경
            this.dataGridView1.Columns[0].HeaderText = "컴퓨터 번호";
            this.dataGridView1.Columns[1].HeaderText = "프로그램명";
            this.dataGridView1.Columns[2].HeaderText = "씨리얼넘버";

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
            text_Program2.Clear();
            text_Serial2.Clear();
        }
    }
}
