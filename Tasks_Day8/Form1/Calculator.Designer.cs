namespace Form1
{
    partial class Calculator
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
            this.rtb_equation = new System.Windows.Forms.TextBox();
            this.btn_1_click = new System.Windows.Forms.Button();
            this.btn_2_click = new System.Windows.Forms.Button();
            this.btn_3_click = new System.Windows.Forms.Button();
            this.btn_4_click = new System.Windows.Forms.Button();
            this.btn_5_click = new System.Windows.Forms.Button();
            this.btn_AC_click = new System.Windows.Forms.Button();
            this.btn_plus_click = new System.Windows.Forms.Button();
            this.btn_minus_click = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_divide_click = new System.Windows.Forms.Button();
            this.btn_reminder_click = new System.Windows.Forms.Button();
            this.btn_equal_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_equation
            // 
            this.rtb_equation.Location = new System.Drawing.Point(2, 3);
            this.rtb_equation.Multiline = true;
            this.rtb_equation.Name = "rtb_equation";
            this.rtb_equation.Size = new System.Drawing.Size(797, 207);
            this.rtb_equation.TabIndex = 0;
            // 
            // btn_1_click
            // 
            this.btn_1_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1_click.Location = new System.Drawing.Point(22, 233);
            this.btn_1_click.Name = "btn_1_click";
            this.btn_1_click.Size = new System.Drawing.Size(94, 52);
            this.btn_1_click.TabIndex = 1;
            this.btn_1_click.Text = "1";
            this.btn_1_click.UseVisualStyleBackColor = false;
            this.btn_1_click.Click += new System.EventHandler(this.btn_1_click_Click);
            // 
            // btn_2_click
            // 
            this.btn_2_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_2_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2_click.Location = new System.Drawing.Point(157, 233);
            this.btn_2_click.Name = "btn_2_click";
            this.btn_2_click.Size = new System.Drawing.Size(94, 52);
            this.btn_2_click.TabIndex = 2;
            this.btn_2_click.Text = "2";
            this.btn_2_click.UseVisualStyleBackColor = false;
            this.btn_2_click.Click += new System.EventHandler(this.btn_2_click_Click);
            // 
            // btn_3_click
            // 
            this.btn_3_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_3_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_3_click.Location = new System.Drawing.Point(294, 233);
            this.btn_3_click.Name = "btn_3_click";
            this.btn_3_click.Size = new System.Drawing.Size(94, 52);
            this.btn_3_click.TabIndex = 3;
            this.btn_3_click.Text = "3";
            this.btn_3_click.UseVisualStyleBackColor = false;
            this.btn_3_click.Click += new System.EventHandler(this.btn_3_click_Click);
            // 
            // btn_4_click
            // 
            this.btn_4_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_4_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_4_click.Location = new System.Drawing.Point(430, 233);
            this.btn_4_click.Name = "btn_4_click";
            this.btn_4_click.Size = new System.Drawing.Size(94, 52);
            this.btn_4_click.TabIndex = 4;
            this.btn_4_click.Text = "4";
            this.btn_4_click.UseVisualStyleBackColor = false;
            this.btn_4_click.Click += new System.EventHandler(this.btn_4_click_Click);
            // 
            // btn_5_click
            // 
            this.btn_5_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_5_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_5_click.Location = new System.Drawing.Point(546, 233);
            this.btn_5_click.Name = "btn_5_click";
            this.btn_5_click.Size = new System.Drawing.Size(94, 52);
            this.btn_5_click.TabIndex = 5;
            this.btn_5_click.Text = "5";
            this.btn_5_click.UseVisualStyleBackColor = false;
            this.btn_5_click.Click += new System.EventHandler(this.btn_5_click_Click);
            // 
            // btn_AC_click
            // 
            this.btn_AC_click.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AC_click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AC_click.Location = new System.Drawing.Point(675, 229);
            this.btn_AC_click.Name = "btn_AC_click";
            this.btn_AC_click.Size = new System.Drawing.Size(99, 61);
            this.btn_AC_click.TabIndex = 6;
            this.btn_AC_click.Text = "AC";
            this.btn_AC_click.UseVisualStyleBackColor = false;
            this.btn_AC_click.Click += new System.EventHandler(this.btn_AC_click_Click);
            // 
            // btn_plus_click
            // 
            this.btn_plus_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_plus_click.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_plus_click.Location = new System.Drawing.Point(22, 334);
            this.btn_plus_click.Name = "btn_plus_click";
            this.btn_plus_click.Size = new System.Drawing.Size(94, 52);
            this.btn_plus_click.TabIndex = 7;
            this.btn_plus_click.Text = "+";
            this.btn_plus_click.UseVisualStyleBackColor = false;
            this.btn_plus_click.Click += new System.EventHandler(this.btn_plus_click_Click);
            // 
            // btn_minus_click
            // 
            this.btn_minus_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minus_click.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_minus_click.Location = new System.Drawing.Point(157, 334);
            this.btn_minus_click.Name = "btn_minus_click";
            this.btn_minus_click.Size = new System.Drawing.Size(94, 52);
            this.btn_minus_click.TabIndex = 8;
            this.btn_minus_click.Text = "-";
            this.btn_minus_click.UseVisualStyleBackColor = false;
            this.btn_minus_click.Click += new System.EventHandler(this.btn_minus_click_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mul.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mul.Location = new System.Drawing.Point(280, 334);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(94, 52);
            this.btn_mul.TabIndex = 9;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_divide_click
            // 
            this.btn_divide_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_divide_click.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_divide_click.Location = new System.Drawing.Point(412, 334);
            this.btn_divide_click.Name = "btn_divide_click";
            this.btn_divide_click.Size = new System.Drawing.Size(94, 52);
            this.btn_divide_click.TabIndex = 10;
            this.btn_divide_click.Text = "/";
            this.btn_divide_click.UseVisualStyleBackColor = false;
            this.btn_divide_click.Click += new System.EventHandler(this.btn_divide_click_Click);
            // 
            // btn_reminder_click
            // 
            this.btn_reminder_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reminder_click.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reminder_click.Location = new System.Drawing.Point(546, 334);
            this.btn_reminder_click.Name = "btn_reminder_click";
            this.btn_reminder_click.Size = new System.Drawing.Size(94, 52);
            this.btn_reminder_click.TabIndex = 11;
            this.btn_reminder_click.Text = "%";
            this.btn_reminder_click.UseVisualStyleBackColor = false;
            this.btn_reminder_click.Click += new System.EventHandler(this.btn_reminder_click_Click);
            // 
            // btn_equal_click
            // 
            this.btn_equal_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_equal_click.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_equal_click.Location = new System.Drawing.Point(675, 334);
            this.btn_equal_click.Name = "btn_equal_click";
            this.btn_equal_click.Size = new System.Drawing.Size(94, 52);
            this.btn_equal_click.TabIndex = 12;
            this.btn_equal_click.Text = "=";
            this.btn_equal_click.UseVisualStyleBackColor = false;
            this.btn_equal_click.Click += new System.EventHandler(this.btn_equal_click_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_equal_click);
            this.Controls.Add(this.btn_reminder_click);
            this.Controls.Add(this.btn_divide_click);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_minus_click);
            this.Controls.Add(this.btn_plus_click);
            this.Controls.Add(this.btn_AC_click);
            this.Controls.Add(this.btn_5_click);
            this.Controls.Add(this.btn_4_click);
            this.Controls.Add(this.btn_3_click);
            this.Controls.Add(this.btn_2_click);
            this.Controls.Add(this.btn_1_click);
            this.Controls.Add(this.rtb_equation);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox rtb_equation;
        private Button btn_1_click;
        private Button btn_2_click;
        private Button btn_3_click;
        private Button btn_4_click;
        private Button btn_5_click;
        private Button btn_AC_click;
        private Button btn_plus_click;
        private Button btn_minus_click;
        private Button btn_mul;
        private Button btn_divide_click;
        private Button btn_reminder_click;
        private Button btn_equal_click;
    }
}