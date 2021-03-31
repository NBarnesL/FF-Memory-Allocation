
namespace cs471_project2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AutoCreate_button = new System.Windows.Forms.Button();
            this.garbage_collect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Terminate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newProcessName_TextBox = new System.Windows.Forms.TextBox();
            this.createProcess_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allocateButton = new System.Windows.Forms.Button();
            this.setup_selection_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SetUp_Button = new System.Windows.Forms.Button();
            this.BlockList_text = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(206, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // AutoCreate_button
            // 
            this.AutoCreate_button.Location = new System.Drawing.Point(348, 63);
            this.AutoCreate_button.Margin = new System.Windows.Forms.Padding(1);
            this.AutoCreate_button.Name = "AutoCreate_button";
            this.AutoCreate_button.Size = new System.Drawing.Size(75, 21);
            this.AutoCreate_button.TabIndex = 2;
            this.AutoCreate_button.Text = "AutoCreate";
            this.AutoCreate_button.UseVisualStyleBackColor = true;
            this.AutoCreate_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // garbage_collect
            // 
            this.garbage_collect.Location = new System.Drawing.Point(463, 273);
            this.garbage_collect.Margin = new System.Windows.Forms.Padding(1);
            this.garbage_collect.Name = "garbage_collect";
            this.garbage_collect.Size = new System.Drawing.Size(76, 56);
            this.garbage_collect.TabIndex = 3;
            this.garbage_collect.Text = "Collect Garbage";
            this.garbage_collect.UseVisualStyleBackColor = true;
            this.garbage_collect.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Terminate
            // 
            this.button_Terminate.Location = new System.Drawing.Point(349, 306);
            this.button_Terminate.Name = "button_Terminate";
            this.button_Terminate.Size = new System.Drawing.Size(75, 23);
            this.button_Terminate.TabIndex = 5;
            this.button_Terminate.Text = "Terminate";
            this.button_Terminate.UseVisualStyleBackColor = true;
            this.button_Terminate.Click += new System.EventHandler(this.button_Terminate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newProcessName_TextBox
            // 
            this.newProcessName_TextBox.Location = new System.Drawing.Point(232, 39);
            this.newProcessName_TextBox.Name = "newProcessName_TextBox";
            this.newProcessName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.newProcessName_TextBox.TabIndex = 8;
            // 
            // createProcess_Button
            // 
            this.createProcess_Button.Location = new System.Drawing.Point(349, 36);
            this.createProcess_Button.Name = "createProcess_Button";
            this.createProcess_Button.Size = new System.Drawing.Size(75, 23);
            this.createProcess_Button.TabIndex = 11;
            this.createProcess_Button.Text = "Create Process";
            this.createProcess_Button.UseVisualStyleBackColor = true;
            this.createProcess_Button.Click += new System.EventHandler(this.createProcess_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Process Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Process ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Process List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Memory";
            // 
            // allocateButton
            // 
            this.allocateButton.Location = new System.Drawing.Point(463, 194);
            this.allocateButton.Name = "allocateButton";
            this.allocateButton.Size = new System.Drawing.Size(75, 54);
            this.allocateButton.TabIndex = 21;
            this.allocateButton.Text = "Allocate Top to Memory";
            this.allocateButton.UseVisualStyleBackColor = true;
            this.allocateButton.Click += new System.EventHandler(this.allocateButton_Click_1);
            // 
            // setup_selection_box
            // 
            this.setup_selection_box.FormattingEnabled = true;
            this.setup_selection_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.setup_selection_box.Location = new System.Drawing.Point(232, 210);
            this.setup_selection_box.Name = "setup_selection_box";
            this.setup_selection_box.Size = new System.Drawing.Size(96, 21);
            this.setup_selection_box.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "1. If the free space is used and the top is empty and the bottom is empty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "2. If the top is full and the bottom is empty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "3. If the top is empty and the bottom is full";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "4. if all spaces are full";
            // 
            // SetUp_Button
            // 
            this.SetUp_Button.Location = new System.Drawing.Point(347, 210);
            this.SetUp_Button.Name = "SetUp_Button";
            this.SetUp_Button.Size = new System.Drawing.Size(75, 23);
            this.SetUp_Button.TabIndex = 27;
            this.SetUp_Button.Text = "Set Up";
            this.SetUp_Button.UseVisualStyleBackColor = true;
            this.SetUp_Button.Click += new System.EventHandler(this.SetUp_Button_Click);
            // 
            // BlockList_text
            // 
            this.BlockList_text.Location = new System.Drawing.Point(583, 39);
            this.BlockList_text.Name = "BlockList_text";
            this.BlockList_text.Size = new System.Drawing.Size(226, 321);
            this.BlockList_text.TabIndex = 29;
            this.BlockList_text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 385);
            this.Controls.Add(this.BlockList_text);
            this.Controls.Add(this.SetUp_Button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setup_selection_box);
            this.Controls.Add(this.allocateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createProcess_Button);
            this.Controls.Add(this.newProcessName_TextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Terminate);
            this.Controls.Add(this.garbage_collect);
            this.Controls.Add(this.AutoCreate_button);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "First Fit Memory Allocation Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AutoCreate_button;
        private System.Windows.Forms.Button garbage_collect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Terminate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox newProcessName_TextBox;
        private System.Windows.Forms.Button createProcess_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allocateButton;
        private System.Windows.Forms.ComboBox setup_selection_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SetUp_Button;
        private System.Windows.Forms.RichTextBox BlockList_text;
    }
}

