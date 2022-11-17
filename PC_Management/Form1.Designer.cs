namespace PC_Management
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_Create = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Cb_CPU_Type = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_User_Team = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bt_Reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_User_Usage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_CPU_IP = new System.Windows.Forms.TextBox();
            this.text_User_Area = new System.Windows.Forms.TextBox();
            this.Cb_User_Team_c = new System.Windows.Forms.ComboBox();
            this.Cb_CPU_Type_c = new System.Windows.Forms.ComboBox();
            this.text_User_Name = new System.Windows.Forms.TextBox();
            this.dtp_Purchase_Date = new System.Windows.Forms.DateTimePicker();
            this.text_CPU_Num = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Cb_Win_Ver_c = new System.Windows.Forms.ComboBox();
            this.Cb_Usage_Status_c = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2421, 1420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2421, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 1320);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(2421, 100);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(400, 100);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1921, 1220);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1915, 1114);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 15;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631579F));
            this.tableLayoutPanel5.Controls.Add(this.Bt_Delete, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.Bt_Update, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.Bt_Create, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.bt_search, 13, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 9, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 11, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1921, 100);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Delete.Location = new System.Drawing.Point(557, 23);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(196, 54);
            this.Bt_Delete.TabIndex = 2;
            this.Bt_Delete.Text = "삭제하기";
            this.Bt_Delete.UseVisualStyleBackColor = true;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // Bt_Update
            // 
            this.Bt_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Update.Location = new System.Drawing.Point(305, 23);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(196, 54);
            this.Bt_Update.TabIndex = 1;
            this.Bt_Update.Text = "수정하기";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Bt_Create
            // 
            this.Bt_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Create.Location = new System.Drawing.Point(53, 23);
            this.Bt_Create.Name = "Bt_Create";
            this.Bt_Create.Size = new System.Drawing.Size(196, 54);
            this.Bt_Create.TabIndex = 0;
            this.Bt_Create.Text = "등록하기";
            this.Bt_Create.UseVisualStyleBackColor = true;
            this.Bt_Create.Click += new System.EventHandler(this.Bt_Create_Click);
            // 
            // bt_search
            // 
            this.bt_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_search.Location = new System.Drawing.Point(1667, 23);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(196, 54);
            this.bt_search.TabIndex = 0;
            this.bt_search.Text = "조회하기";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.Cb_CPU_Type, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1109, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel5.SetRowSpan(this.tableLayoutPanel7, 3);
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(202, 100);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // Cb_CPU_Type
            // 
            this.Cb_CPU_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_CPU_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_CPU_Type.FormattingEnabled = true;
            this.Cb_CPU_Type.Location = new System.Drawing.Point(8, 57);
            this.Cb_CPU_Type.Name = "Cb_CPU_Type";
            this.Cb_CPU_Type.Size = new System.Drawing.Size(185, 26);
            this.Cb_CPU_Type.TabIndex = 2;
            this.Cb_CPU_Type.SelectionChangeCommitted += new System.EventHandler(this.Cb_CPU_Type_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 40);
            this.label12.TabIndex = 4;
            this.label12.Text = "컴퓨터 종류";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.Cb_User_Team, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1361, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel5.SetRowSpan(this.tableLayoutPanel8, 3);
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(202, 100);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "사용팀";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cb_User_Team
            // 
            this.Cb_User_Team.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_User_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_User_Team.FormattingEnabled = true;
            this.Cb_User_Team.Location = new System.Drawing.Point(4, 57);
            this.Cb_User_Team.Name = "Cb_User_Team";
            this.Cb_User_Team.Size = new System.Drawing.Size(194, 26);
            this.Cb_User_Team.TabIndex = 4;
            this.Cb_User_Team.SelectionChangeCommitted += new System.EventHandler(this.Cb_User_Team_SelectionChangeCommitted);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.label5, 1, 9);
            this.tableLayoutPanel6.Controls.Add(this.label6, 1, 11);
            this.tableLayoutPanel6.Controls.Add(this.Bt_Reset, 1, 22);
            this.tableLayoutPanel6.Controls.Add(this.label7, 1, 13);
            this.tableLayoutPanel6.Controls.Add(this.text_User_Usage, 1, 20);
            this.tableLayoutPanel6.Controls.Add(this.label8, 1, 15);
            this.tableLayoutPanel6.Controls.Add(this.label9, 1, 17);
            this.tableLayoutPanel6.Controls.Add(this.label10, 1, 19);
            this.tableLayoutPanel6.Controls.Add(this.text_CPU_IP, 1, 12);
            this.tableLayoutPanel6.Controls.Add(this.text_User_Area, 1, 18);
            this.tableLayoutPanel6.Controls.Add(this.Cb_User_Team_c, 1, 16);
            this.tableLayoutPanel6.Controls.Add(this.Cb_CPU_Type_c, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.text_User_Name, 1, 14);
            this.tableLayoutPanel6.Controls.Add(this.dtp_Purchase_Date, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.text_CPU_Num, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Cb_Win_Ver_c, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.Cb_Usage_Status_c, 1, 10);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 24;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.064516F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.225806F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.612903F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(400, 1220);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(100, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "* 컴퓨터 종류";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(100, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "* 윈도우 버젼";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(100, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "구매일";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(100, 490);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 59);
            this.label5.TabIndex = 4;
            this.label5.Text = "* 사용 여부";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(100, 588);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 59);
            this.label6.TabIndex = 5;
            this.label6.Text = "* IP 주소";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_Reset
            // 
            this.Bt_Reset.Location = new System.Drawing.Point(103, 1140);
            this.Bt_Reset.Name = "Bt_Reset";
            this.Bt_Reset.Size = new System.Drawing.Size(194, 53);
            this.Bt_Reset.TabIndex = 3;
            this.Bt_Reset.Text = "내용 지우기";
            this.Bt_Reset.UseVisualStyleBackColor = true;
            this.Bt_Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(100, 686);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 59);
            this.label7.TabIndex = 6;
            this.label7.Text = "사용자 이름";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_User_Usage
            // 
            this.text_User_Usage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_User_Usage.Location = new System.Drawing.Point(103, 1044);
            this.text_User_Usage.Name = "text_User_Usage";
            this.text_User_Usage.Size = new System.Drawing.Size(193, 28);
            this.text_User_Usage.TabIndex = 16;
            this.text_User_Usage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(100, 784);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 59);
            this.label8.TabIndex = 7;
            this.label8.Text = "* 사용팀";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(100, 882);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 59);
            this.label9.TabIndex = 8;
            this.label9.Text = "사용 지역";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(100, 980);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 59);
            this.label10.TabIndex = 9;
            this.label10.Text = "사용 구분";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_CPU_IP
            // 
            this.text_CPU_IP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_CPU_IP.Location = new System.Drawing.Point(103, 652);
            this.text_CPU_IP.Name = "text_CPU_IP";
            this.text_CPU_IP.Size = new System.Drawing.Size(193, 28);
            this.text_CPU_IP.TabIndex = 13;
            this.text_CPU_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_User_Area
            // 
            this.text_User_Area.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_User_Area.Location = new System.Drawing.Point(103, 946);
            this.text_User_Area.Name = "text_User_Area";
            this.text_User_Area.Size = new System.Drawing.Size(193, 28);
            this.text_User_Area.TabIndex = 15;
            this.text_User_Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cb_User_Team_c
            // 
            this.Cb_User_Team_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_User_Team_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_User_Team_c.FormattingEnabled = true;
            this.Cb_User_Team_c.Location = new System.Drawing.Point(103, 849);
            this.Cb_User_Team_c.Name = "Cb_User_Team_c";
            this.Cb_User_Team_c.Size = new System.Drawing.Size(193, 26);
            this.Cb_User_Team_c.TabIndex = 19;
            // 
            // Cb_CPU_Type_c
            // 
            this.Cb_CPU_Type_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_CPU_Type_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_CPU_Type_c.FormattingEnabled = true;
            this.Cb_CPU_Type_c.Location = new System.Drawing.Point(103, 261);
            this.Cb_CPU_Type_c.Name = "Cb_CPU_Type_c";
            this.Cb_CPU_Type_c.Size = new System.Drawing.Size(193, 26);
            this.Cb_CPU_Type_c.TabIndex = 18;
            // 
            // text_User_Name
            // 
            this.text_User_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_User_Name.Location = new System.Drawing.Point(103, 750);
            this.text_User_Name.Name = "text_User_Name";
            this.text_User_Name.Size = new System.Drawing.Size(193, 28);
            this.text_User_Name.TabIndex = 14;
            this.text_User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_Purchase_Date
            // 
            this.dtp_Purchase_Date.CustomFormat = "yyyy-MM-dd";
            this.dtp_Purchase_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Purchase_Date.Location = new System.Drawing.Point(104, 455);
            this.dtp_Purchase_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Purchase_Date.Name = "dtp_Purchase_Date";
            this.dtp_Purchase_Date.Size = new System.Drawing.Size(190, 28);
            this.dtp_Purchase_Date.TabIndex = 20;
            // 
            // text_CPU_Num
            // 
            this.text_CPU_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_CPU_Num.Location = new System.Drawing.Point(103, 162);
            this.text_CPU_Num.Name = "text_CPU_Num";
            this.text_CPU_Num.Size = new System.Drawing.Size(193, 28);
            this.text_CPU_Num.TabIndex = 17;
            this.text_CPU_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(100, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 59);
            this.label11.TabIndex = 21;
            this.label11.Text = "* 컴퓨터 번호";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel6.SetColumnSpan(this.tableLayoutPanel9, 3);
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(400, 98);
            this.tableLayoutPanel9.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(400, 98);
            this.label13.TabIndex = 0;
            this.label13.Text = "※ * 표시 필수 기입 바랍니다 ※";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cb_Win_Ver_c
            // 
            this.Cb_Win_Ver_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_Win_Ver_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Win_Ver_c.FormattingEnabled = true;
            this.Cb_Win_Ver_c.Location = new System.Drawing.Point(103, 359);
            this.Cb_Win_Ver_c.Name = "Cb_Win_Ver_c";
            this.Cb_Win_Ver_c.Size = new System.Drawing.Size(194, 26);
            this.Cb_Win_Ver_c.TabIndex = 23;
            // 
            // Cb_Usage_Status_c
            // 
            this.Cb_Usage_Status_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cb_Usage_Status_c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Usage_Status_c.FormattingEnabled = true;
            this.Cb_Usage_Status_c.Location = new System.Drawing.Point(103, 555);
            this.Cb_Usage_Status_c.Name = "Cb_Usage_Status_c";
            this.Cb_Usage_Status_c.Size = new System.Drawing.Size(194, 26);
            this.Cb_Usage_Status_c.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2421, 1420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ComboBox Cb_CPU_Type;
        private System.Windows.Forms.Button Bt_Create;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_CPU_IP;
        private System.Windows.Forms.TextBox text_User_Area;
        private System.Windows.Forms.TextBox text_CPU_Num;
        private System.Windows.Forms.ComboBox Cb_User_Team_c;
        private System.Windows.Forms.ComboBox Cb_CPU_Type_c;
        private System.Windows.Forms.TextBox text_User_Name;
        private System.Windows.Forms.Button Bt_Reset;
        private System.Windows.Forms.TextBox text_User_Usage;
        private System.Windows.Forms.DateTimePicker dtp_Purchase_Date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_User_Team;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Cb_Win_Ver_c;
        private System.Windows.Forms.ComboBox Cb_Usage_Status_c;
    }
}

