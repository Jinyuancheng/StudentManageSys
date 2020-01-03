namespace StudentManageSys.FormInfo
{
    partial class fmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_stuInfo = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_nv = new System.Windows.Forms.CheckBox();
            this.cb_nan = new System.Windows.Forms.CheckBox();
            this.add_english = new System.Windows.Forms.TextBox();
            this.add_chinese = new System.Windows.Forms.TextBox();
            this.add_math = new System.Windows.Forms.TextBox();
            this.add_age = new System.Windows.Forms.TextBox();
            this.add_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_sex = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.年龄 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.性别 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.数学成绩 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.语文成绩 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.英语成绩 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modify_math = new System.Windows.Forms.TextBox();
            this.modify_english = new System.Windows.Forms.TextBox();
            this.modify_chinese = new System.Windows.Forms.TextBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_stuInfo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 617);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lv_stuInfo
            // 
            this.lv_stuInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.姓名,
            this.年龄,
            this.性别,
            this.数学成绩,
            this.语文成绩,
            this.英语成绩});
            this.lv_stuInfo.FullRowSelect = true;
            this.lv_stuInfo.HideSelection = false;
            this.lv_stuInfo.Location = new System.Drawing.Point(12, 123);
            this.lv_stuInfo.Name = "lv_stuInfo";
            this.lv_stuInfo.Size = new System.Drawing.Size(513, 467);
            this.lv_stuInfo.TabIndex = 2;
            this.lv_stuInfo.UseCompatibleStateImageBehavior = false;
            this.lv_stuInfo.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(555, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 617);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_delete);
            this.groupBox6.Location = new System.Drawing.Point(7, 462);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(591, 128);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "删除学生信息";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_modify);
            this.groupBox5.Controls.Add(this.modify_chinese);
            this.groupBox5.Controls.Add(this.modify_math);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.modify_english);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(7, 264);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(591, 172);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "修改学生信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Controls.Add(this.cb_nv);
            this.groupBox4.Controls.Add(this.cb_nan);
            this.groupBox4.Controls.Add(this.add_english);
            this.groupBox4.Controls.Add(this.add_chinese);
            this.groupBox4.Controls.Add(this.add_math);
            this.groupBox4.Controls.Add(this.add_age);
            this.groupBox4.Controls.Add(this.add_name);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.add_sex);
            this.groupBox4.Controls.Add(this.age);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 238);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加学生信息";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(385, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(187, 204);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_nv
            // 
            this.cb_nv.AutoSize = true;
            this.cb_nv.Location = new System.Drawing.Point(206, 93);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(36, 16);
            this.cb_nv.TabIndex = 2;
            this.cb_nv.Text = "女";
            this.cb_nv.UseVisualStyleBackColor = true;
            this.cb_nv.CheckedChanged += new System.EventHandler(this.cb_nv_CheckedChanged);
            // 
            // cb_nan
            // 
            this.cb_nan.AutoSize = true;
            this.cb_nan.Checked = true;
            this.cb_nan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_nan.Location = new System.Drawing.Point(106, 94);
            this.cb_nan.Name = "cb_nan";
            this.cb_nan.Size = new System.Drawing.Size(36, 16);
            this.cb_nan.TabIndex = 2;
            this.cb_nan.Text = "男";
            this.cb_nan.UseVisualStyleBackColor = true;
            this.cb_nan.CheckedChanged += new System.EventHandler(this.cb_nan_CheckedChanged);
            // 
            // add_english
            // 
            this.add_english.Location = new System.Drawing.Point(105, 187);
            this.add_english.Name = "add_english";
            this.add_english.Size = new System.Drawing.Size(250, 21);
            this.add_english.TabIndex = 4;
            // 
            // add_chinese
            // 
            this.add_chinese.Location = new System.Drawing.Point(105, 157);
            this.add_chinese.Name = "add_chinese";
            this.add_chinese.Size = new System.Drawing.Size(250, 21);
            this.add_chinese.TabIndex = 3;
            // 
            // add_math
            // 
            this.add_math.Location = new System.Drawing.Point(105, 124);
            this.add_math.Name = "add_math";
            this.add_math.Size = new System.Drawing.Size(250, 21);
            this.add_math.TabIndex = 2;
            // 
            // add_age
            // 
            this.add_age.Location = new System.Drawing.Point(105, 60);
            this.add_age.Name = "add_age";
            this.add_age.Size = new System.Drawing.Size(250, 21);
            this.add_age.TabIndex = 1;
            // 
            // add_name
            // 
            this.add_name.Location = new System.Drawing.Point(105, 28);
            this.add_name.Name = "add_name";
            this.add_name.Size = new System.Drawing.Size(250, 21);
            this.add_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "英语 :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(19, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "语文 :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "数学 :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(19, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "数学 :";
            // 
            // add_sex
            // 
            this.add_sex.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_sex.Location = new System.Drawing.Point(19, 93);
            this.add_sex.Name = "add_sex";
            this.add_sex.Size = new System.Drawing.Size(99, 23);
            this.add_sex.TabIndex = 0;
            this.add_sex.Text = "性别 :";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.age.Location = new System.Drawing.Point(19, 61);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(99, 23);
            this.age.TabIndex = 0;
            this.age.Text = "年龄 :";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(19, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(99, 23);
            this.name.TabIndex = 0;
            this.name.Text = "姓名 :";
            // 
            // Id
            // 
            this.Id.Width = 51;
            // 
            // 姓名
            // 
            this.姓名.Width = 90;
            // 
            // 年龄
            // 
            this.年龄.Width = 70;
            // 
            // 性别
            // 
            this.性别.Width = 81;
            // 
            // 数学成绩
            // 
            this.数学成绩.Width = 86;
            // 
            // 语文成绩
            // 
            this.语文成绩.Width = 68;
            // 
            // 英语成绩
            // 
            this.英语成绩.Width = 63;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "数学 :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(19, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "语文 :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(19, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "英语 :";
            // 
            // modify_math
            // 
            this.modify_math.Location = new System.Drawing.Point(105, 46);
            this.modify_math.Name = "modify_math";
            this.modify_math.Size = new System.Drawing.Size(250, 21);
            this.modify_math.TabIndex = 2;
            // 
            // modify_english
            // 
            this.modify_english.Location = new System.Drawing.Point(105, 109);
            this.modify_english.Name = "modify_english";
            this.modify_english.Size = new System.Drawing.Size(250, 21);
            this.modify_english.TabIndex = 4;
            // 
            // modify_chinese
            // 
            this.modify_chinese.Location = new System.Drawing.Point(105, 79);
            this.modify_chinese.Name = "modify_chinese";
            this.modify_chinese.Size = new System.Drawing.Size(250, 21);
            this.modify_chinese.TabIndex = 2;
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_modify.Location = new System.Drawing.Point(385, 20);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(187, 131);
            this.btn_modify.TabIndex = 5;
            this.btn_modify.Text = "修改";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.Location = new System.Drawing.Point(7, 20);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(578, 102);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // fmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_stuInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label add_sex;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add_english;
        private System.Windows.Forms.TextBox add_chinese;
        private System.Windows.Forms.TextBox add_math;
        private System.Windows.Forms.TextBox add_age;
        private System.Windows.Forms.TextBox add_name;
        private System.Windows.Forms.CheckBox cb_nv;
        private System.Windows.Forms.CheckBox cb_nan;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 年龄;
        private System.Windows.Forms.ColumnHeader 性别;
        private System.Windows.Forms.ColumnHeader 数学成绩;
        private System.Windows.Forms.ColumnHeader 语文成绩;
        private System.Windows.Forms.ColumnHeader 英语成绩;
        private System.Windows.Forms.TextBox modify_chinese;
        private System.Windows.Forms.TextBox modify_math;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modify_english;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
    }
}