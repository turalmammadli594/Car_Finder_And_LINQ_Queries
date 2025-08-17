namespace Car_Finder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdBrandName = new ComboBox();
            cmdModelName = new ComboBox();
            label2 = new Label();
            btnChoose = new Button();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grbProjectInformation = new GroupBox();
            groupBox2 = new GroupBox();
            btnLinq = new Button();
            cmdMetodList = new ComboBox();
            label6 = new Label();
            cmdProperties = new ComboBox();
            txtValue = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label9 = new Label();
            dataGridViewInfo = new DataGridView();
            label10 = new Label();
            grbProjectInformation.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            SuspendLayout();
            // 
            // cmdBrandName
            // 
            cmdBrandName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdBrandName.FormattingEnabled = true;
            cmdBrandName.Items.AddRange(new object[] { "Toyota", "BMW", "Mercedes", "Fiat", "Chevrolet", "Lada", "Kia", "Ford", "Hyundai" });
            cmdBrandName.Location = new Point(6, 96);
            cmdBrandName.Name = "cmdBrandName";
            cmdBrandName.Size = new Size(195, 29);
            cmdBrandName.TabIndex = 0;
            // 
            // cmdModelName
            // 
            cmdModelName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdModelName.FormattingEnabled = true;
            cmdModelName.Location = new Point(207, 96);
            cmdModelName.Name = "cmdModelName";
            cmdModelName.Size = new Size(333, 29);
            cmdModelName.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.SaddleBrown;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(162, 33);
            label2.Name = "label2";
            label2.Size = new Size(586, 78);
            label2.TabIndex = 3;
            label2.Text = "The first part is about car brands, and each brand has several models. We use ComboBox to select the model we want, and we display the information about the selected model using a MessageBox.";
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.DimGray;
            btnChoose.FlatStyle = FlatStyle.Flat;
            btnChoose.Font = new Font("Segoe UI", 18F);
            btnChoose.Location = new Point(6, 33);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(195, 57);
            btnChoose.TabIndex = 5;
            btnChoose.Text = "Choose Brand";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(207, 33);
            button1.Name = "button1";
            button1.Size = new Size(333, 57);
            button1.TabIndex = 6;
            button1.Text = "Choose Model and Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.SaddleBrown;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(162, 128);
            label3.Name = "label3";
            label3.Size = new Size(586, 54);
            label3.TabIndex = 7;
            label3.Text = "The Second part involves working with LINQ methods, such as reading, modifying data and etc. from collections in the background.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 14, 144, 167);
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 8;
            label4.Text = "First Project ====>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 14, 144, 167);
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 128);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 9;
            label5.Text = "Second Project ==>";
            // 
            // grbProjectInformation
            // 
            grbProjectInformation.BackColor = Color.Yellow;
            grbProjectInformation.Controls.Add(label4);
            grbProjectInformation.Controls.Add(label3);
            grbProjectInformation.Controls.Add(label5);
            grbProjectInformation.Controls.Add(label2);
            grbProjectInformation.Font = new Font("Segoe UI", 12F);
            grbProjectInformation.ForeColor = Color.Black;
            grbProjectInformation.Location = new Point(12, 12);
            grbProjectInformation.Name = "grbProjectInformation";
            grbProjectInformation.Size = new Size(759, 214);
            grbProjectInformation.TabIndex = 10;
            grbProjectInformation.TabStop = false;
            grbProjectInformation.Text = "My project consist of two parts";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SaddleBrown;
            groupBox2.Controls.Add(btnChoose);
            groupBox2.Controls.Add(cmdBrandName);
            groupBox2.Controls.Add(cmdModelName);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(565, 180);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "The First Project";
            // 
            // btnLinq
            // 
            btnLinq.BackColor = Color.DimGray;
            btnLinq.FlatStyle = FlatStyle.Flat;
            btnLinq.Font = new Font("Segoe UI", 17F);
            btnLinq.Location = new Point(17, 28);
            btnLinq.Name = "btnLinq";
            btnLinq.Size = new Size(152, 125);
            btnLinq.TabIndex = 13;
            btnLinq.Text = "Give The Result";
            btnLinq.UseVisualStyleBackColor = false;
            btnLinq.Click += btnLinq_Click;
            // 
            // cmdMetodList
            // 
            cmdMetodList.BackColor = Color.White;
            cmdMetodList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdMetodList.FormattingEnabled = true;
            cmdMetodList.Items.AddRange(new object[] { "Where", "Any", "All", "First", "FirstOrDefault", "Last", "LastOrDefault", "Single", "SingleOrDefault", "Count", "Max", "Min", "Sum", "Average", "Distinct", "OrderBy", "OrderByDescending", "GroupBy", "Take", "Skip", "TakeWhile", "SkipWhile" });
            cmdMetodList.Location = new Point(195, 61);
            cmdMetodList.Name = "cmdMetodList";
            cmdMetodList.Size = new Size(179, 29);
            cmdMetodList.TabIndex = 14;
            cmdMetodList.SelectedIndexChanged += cmdMetodList_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(149, 69, 53);
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(952, 74);
            label6.Name = "label6";
            label6.Size = new Size(258, 85);
            label6.TabIndex = 15;
            label6.Text = "In the second Project we have a collection and we perform some operations on this collection with LINQ methods.";
            // 
            // cmdProperties
            // 
            cmdProperties.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdProperties.FormattingEnabled = true;
            cmdProperties.Items.AddRange(new object[] { "ModelName", "BodyType", "Year", "FuelType", "DriveType", "EngineVolume", "EnginePower", "Price", "GearBox", "NumberOfSeat" });
            cmdProperties.Location = new Point(399, 61);
            cmdProperties.Name = "cmdProperties";
            cmdProperties.Size = new Size(179, 29);
            cmdProperties.TabIndex = 17;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(378, 124);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(200, 29);
            txtValue.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SaddleBrown;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(cmdProperties);
            groupBox1.Controls.Add(cmdMetodList);
            groupBox1.Controls.Add(btnLinq);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(602, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 180);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "The Second Project";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(194, 127);
            label8.Name = "label8";
            label8.Size = new Size(169, 21);
            label8.TabIndex = 21;
            label8.Text = "Write Property Value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 25);
            label7.Name = "label7";
            label7.Size = new Size(136, 21);
            label7.TabIndex = 20;
            label7.Text = "Choose Property";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 28);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 19;
            label1.Text = "Choose Method";
            // 
            // label9
            // 
            label9.Location = new Point(952, 159);
            label9.Name = "label9";
            label9.Size = new Size(13, 95);
            label9.TabIndex = 20;
            label9.Text = "||||||||||||";
            // 
            // dataGridViewInfo
            // 
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(12, 517);
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.Size = new Size(1189, 154);
            dataGridViewInfo.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 486);
            label10.Name = "label10";
            label10.Size = new Size(431, 28);
            label10.TabIndex = 23;
            label10.Text = "Information provided by the second project:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1370, 698);
            Controls.Add(label10);
            Controls.Add(dataGridViewInfo);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(grbProjectInformation);
            Name = "Form1";
            Text = "Form1";
            grbProjectInformation.ResumeLayout(false);
            grbProjectInformation.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmdBrandName;
        private ComboBox cmdModelName;
        private Label label1;
        private Label label2;
        private Button btnChoose;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox grbProjectInformation;
        private GroupBox groupBox2;
        private Button btnLinq;
        private ComboBox cmdMetodList;
        private Label label6;
        private ComboBox cmdProperties;
        private TextBox txtValue;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label9;
        private DataGridView dataGridViewInfo;
        private Label label10;
    }
}
