namespace Afleveringsopgave_1
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
            this.button1Navn = new System.Windows.Forms.Button();
            this.textBox1Navn = new System.Windows.Forms.TextBox();
            this.label1Navn = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPostition = new System.Windows.Forms.TextBox();
            this.buttonPostition = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1Navne = new System.Windows.Forms.GroupBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.labelDebug = new System.Windows.Forms.Label();
            this.groupBox1Navne.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Navn
            // 
            this.button1Navn.Location = new System.Drawing.Point(52, 123);
            this.button1Navn.Name = "button1Navn";
            this.button1Navn.Size = new System.Drawing.Size(121, 23);
            this.button1Navn.TabIndex = 0;
            this.button1Navn.Text = "Tilføj Navn";
            this.button1Navn.UseVisualStyleBackColor = true;
            this.button1Navn.Click += new System.EventHandler(this.button1Navn_Click);
            // 
            // textBox1Navn
            // 
            this.textBox1Navn.Location = new System.Drawing.Point(113, 79);
            this.textBox1Navn.Name = "textBox1Navn";
            this.textBox1Navn.Size = new System.Drawing.Size(342, 23);
            this.textBox1Navn.TabIndex = 1;
            // 
            // label1Navn
            // 
            this.label1Navn.AutoSize = true;
            this.label1Navn.Location = new System.Drawing.Point(52, 82);
            this.label1Navn.Name = "label1Navn";
            this.label1Navn.Size = new System.Drawing.Size(38, 15);
            this.label1Navn.TabIndex = 2;
            this.label1Navn.Text = "Navn:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(52, 170);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(50, 15);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Position";
            // 
            // textBoxPostition
            // 
            this.textBoxPostition.Location = new System.Drawing.Point(113, 167);
            this.textBoxPostition.Name = "textBoxPostition";
            this.textBoxPostition.Size = new System.Drawing.Size(107, 23);
            this.textBoxPostition.TabIndex = 5;
            // 
            // buttonPostition
            // 
            this.buttonPostition.Location = new System.Drawing.Point(52, 211);
            this.buttonPostition.Name = "buttonPostition";
            this.buttonPostition.Size = new System.Drawing.Size(121, 23);
            this.buttonPostition.TabIndex = 4;
            this.buttonPostition.Text = "Slet Position";
            this.buttonPostition.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(10, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 319);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1Navne
            // 
            this.groupBox1Navne.Controls.Add(this.listBox1);
            this.groupBox1Navne.Location = new System.Drawing.Point(484, 52);
            this.groupBox1Navne.Name = "groupBox1Navne";
            this.groupBox1Navne.Size = new System.Drawing.Size(294, 357);
            this.groupBox1Navne.TabIndex = 3;
            this.groupBox1Navne.TabStop = false;
            this.groupBox1Navne.Text = "Navne:";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Location = new System.Drawing.Point(21, 52);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(457, 357);
            this.groupBoxData.TabIndex = 7;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data:";
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(21, 445);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.Size = new System.Drawing.Size(757, 83);
            this.textBoxDebug.TabIndex = 8;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(21, 427);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(45, 15);
            this.labelDebug.TabIndex = 9;
            this.labelDebug.Text = "Debug:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.textBoxDebug);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.textBoxPostition);
            this.Controls.Add(this.buttonPostition);
            this.Controls.Add(this.groupBox1Navne);
            this.Controls.Add(this.label1Navn);
            this.Controls.Add(this.textBox1Navn);
            this.Controls.Add(this.button1Navn);
            this.Controls.Add(this.groupBoxData);
            this.Name = "Form1";
            this.Text = "Afleveringsopgave 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1Navne.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1Navn;
        private TextBox textBox1Navn;
        private Label label1Navn;
        private Label labelPosition;
        private TextBox textBoxPostition;
        private Button buttonPostition;
        private GroupBox groupBox1Navne;
        private GroupBox groupBoxData;
        private Label labelDebug;
        public TextBox textBoxDebug;
        public ListBox listBox1;
    }
}