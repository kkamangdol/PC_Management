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

namespace PC_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ORACLEL DB TABLE 연결
        private DataTable GetData()
        {
            string strConn = "Data Source = DEV_DDF; User ID = DKPS; Password = dkps";
            OracleConnection conn = new OracleConnection(strConn);
            OracleDataAdapter adapter = new OracleDataAdapter("select * from CPU_TABLE", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            //Waitting
            this.Cursor = Cursors.WaitCursor;

            DataTable dt = GetData();

            dataGridView1.DataSource = dt;

            // 컬럼명 변경
/*            this.dataGridView1.Columns[0].HeaderText = "제품코드";
            this.dataGridView1.Columns[1].HeaderText = "제품명";
            this.dataGridView1.Columns[2].HeaderText = "제품약어명";
            this.dataGridView1.Columns[3].HeaderText = "제품영문명";
            this.dataGridView1.Columns[4].HeaderText = "제품구분";
            this.dataGridView1.Columns[5].HeaderText = "제품소분류";
            this.dataGridView1.Columns[6].HeaderText = "제품중분류";
            this.dataGridView1.Columns[7].HeaderText = "제품생산개시일";
            this.dataGridView1.Columns[8].HeaderText = "제품생산종료일";
            this.dataGridView1.Columns[9].HeaderText = "기준단가";*/

            // 테이블 컬럼숨기기
            // this.dataGridView1.Columns[1].Visible = false;

            // 데이터 조회시 끊김 줄이기
            dataGridView1.DoubleBuffered(true);

            // 행 색변경
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            // 여러 행 선택 방지
            dataGridView1.MultiSelect = false;

            // 전체 컬럼의 Sorting 기능 차단
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 자동으로 선택되는 셀 해제
            dataGridView1.CurrentCell = null;

            //원래대로
            this.Cursor = Cursors.Default;
        }

    }
    // 데이터 조회시 끊김 줄이기
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
