namespace DijkstraGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.noOfNodes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceNodeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationNodeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startingLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connectionText = new System.Windows.Forms.TextBox();
            this.connectionBtn = new System.Windows.Forms.Button();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.connectionDisplayList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.floydListbox = new System.Windows.Forms.ListBox();
            this.pathFloydText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.namesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noOfNodes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No of Nodes:";
            // 
            // noOfNodes
            // 
            this.noOfNodes.Location = new System.Drawing.Point(183, 16);
            this.noOfNodes.Name = "noOfNodes";
            this.noOfNodes.Size = new System.Drawing.Size(51, 20);
            this.noOfNodes.TabIndex = 2;
            this.noOfNodes.ValueChanged += new System.EventHandler(this.noOfNodes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source Node:";
            // 
            // sourceNodeComboBox
            // 
            this.sourceNodeComboBox.FormattingEnabled = true;
            this.sourceNodeComboBox.Location = new System.Drawing.Point(183, 43);
            this.sourceNodeComboBox.Name = "sourceNodeComboBox";
            this.sourceNodeComboBox.Size = new System.Drawing.Size(51, 21);
            this.sourceNodeComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination Node:";
            // 
            // destinationNodeComboBox
            // 
            this.destinationNodeComboBox.FormattingEnabled = true;
            this.destinationNodeComboBox.Location = new System.Drawing.Point(183, 71);
            this.destinationNodeComboBox.Name = "destinationNodeComboBox";
            this.destinationNodeComboBox.Size = new System.Drawing.Size(51, 21);
            this.destinationNodeComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cost and Connection:  From Node";
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingLabel.Location = new System.Drawing.Point(234, 100);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(18, 17);
            this.startingLabel.TabIndex = 4;
            this.startingLabel.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "to";
            // 
            // connectionText
            // 
            this.connectionText.Location = new System.Drawing.Point(160, 124);
            this.connectionText.Name = "connectionText";
            this.connectionText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.connectionText.Size = new System.Drawing.Size(118, 20);
            this.connectionText.TabIndex = 5;
            // 
            // connectionBtn
            // 
            this.connectionBtn.Location = new System.Drawing.Point(284, 125);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(65, 19);
            this.connectionBtn.TabIndex = 6;
            this.connectionBtn.Text = "Add";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.connectionBtn_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(191, 299);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(158, 47);
            this.CalculateBtn.TabIndex = 8;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(501, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Shortest Path Method (Dijsktra\'s and Floyd\'s Method)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cost From Source to Destination:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(228, 18);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(18, 17);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Path from Source to Destination:";
            // 
            // connectionDisplayList
            // 
            this.connectionDisplayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionDisplayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionDisplayList.FormattingEnabled = true;
            this.connectionDisplayList.HorizontalScrollbar = true;
            this.connectionDisplayList.ItemHeight = 16;
            this.connectionDisplayList.Location = new System.Drawing.Point(18, 161);
            this.connectionDisplayList.Name = "connectionDisplayList";
            this.connectionDisplayList.ScrollAlwaysVisible = true;
            this.connectionDisplayList.Size = new System.Drawing.Size(331, 130);
            this.connectionDisplayList.TabIndex = 10;
            this.connectionDisplayList.DoubleClick += new System.EventHandler(this.connectionDisplayList_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costLabel);
            this.groupBox1.Controls.Add(this.pathText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dijsktra\'s Method";
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(231, 43);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pathText.Size = new System.Drawing.Size(95, 20);
            this.pathText.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connectionDisplayList);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.CalculateBtn);
            this.groupBox2.Controls.Add(this.connectionBtn);
            this.groupBox2.Controls.Add(this.connectionText);
            this.groupBox2.Controls.Add(this.startingLabel);
            this.groupBox2.Controls.Add(this.destinationNodeComboBox);
            this.groupBox2.Controls.Add(this.sourceNodeComboBox);
            this.groupBox2.Controls.Add(this.noOfNodes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 358);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(395, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 390);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OUTPUT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.floydListbox);
            this.groupBox4.Controls.Add(this.pathFloydText);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(11, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 283);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Floyd\'s Method";
            // 
            // floydListbox
            // 
            this.floydListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.floydListbox.FormattingEnabled = true;
            this.floydListbox.HorizontalScrollbar = true;
            this.floydListbox.Location = new System.Drawing.Point(6, 32);
            this.floydListbox.Name = "floydListbox";
            this.floydListbox.ScrollAlwaysVisible = true;
            this.floydListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.floydListbox.Size = new System.Drawing.Size(320, 210);
            this.floydListbox.TabIndex = 10;
            // 
            // pathFloydText
            // 
            this.pathFloydText.Location = new System.Drawing.Point(110, 252);
            this.pathFloydText.Name = "pathFloydText";
            this.pathFloydText.ReadOnly = true;
            this.pathFloydText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pathFloydText.Size = new System.Drawing.Size(216, 20);
            this.pathFloydText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cost and Path From Any Node to Any Node";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Shortest Path:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesLabel.Location = new System.Drawing.Point(128, 34);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(763, 13);
            this.namesLabel.TabIndex = 14;
            this.namesLabel.Text = "Developed by Group 15: Adeyemi Jamal (150407003), Yusuf Abubakar  (150407025), Ba" +
    "da Abdul-Fatai  (160407509), Nwabuokei Christopher  (160407517).......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 462);
            this.Controls.Add(this.namesLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SPM";
            ((System.ComponentModel.ISupportInitialize)(this.noOfNodes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown noOfNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sourceNodeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox destinationNodeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label startingLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox connectionText;
        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox connectionDisplayList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox floydListbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathFloydText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label namesLabel;
    }
}

