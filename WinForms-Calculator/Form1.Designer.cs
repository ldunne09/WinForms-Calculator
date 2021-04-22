
namespace WinForms_Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNBOX = new System.Windows.Forms.GroupBox();
            this.num8BTN = new System.Windows.Forms.Button();
            this.num0BTN = new System.Windows.Forms.Button();
            this.num9BTN = new System.Windows.Forms.Button();
            this.equalsBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.num5BTN = new System.Windows.Forms.Button();
            this.num3BTN = new System.Windows.Forms.Button();
            this.num2BTN = new System.Windows.Forms.Button();
            this.num4BTN = new System.Windows.Forms.Button();
            this.num6BTN = new System.Windows.Forms.Button();
            this.multiBTN = new System.Windows.Forms.Button();
            this.num1BTN = new System.Windows.Forms.Button();
            this.minusBTN = new System.Windows.Forms.Button();
            this.num7BTN = new System.Windows.Forms.Button();
            this.divBTN = new System.Windows.Forms.Button();
            this.ceBTN = new System.Windows.Forms.Button();
            this.clrBTN = new System.Windows.Forms.Button();
            this.lblStore = new System.Windows.Forms.Label();
            this.BTNBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTNBOX
            // 
            this.BTNBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNBOX.AutoSize = true;
            this.BTNBOX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNBOX.Controls.Add(this.num8BTN);
            this.BTNBOX.Controls.Add(this.num0BTN);
            this.BTNBOX.Controls.Add(this.num9BTN);
            this.BTNBOX.Controls.Add(this.equalsBTN);
            this.BTNBOX.Controls.Add(this.addBTN);
            this.BTNBOX.Controls.Add(this.num5BTN);
            this.BTNBOX.Controls.Add(this.num3BTN);
            this.BTNBOX.Controls.Add(this.num2BTN);
            this.BTNBOX.Controls.Add(this.num4BTN);
            this.BTNBOX.Controls.Add(this.num6BTN);
            this.BTNBOX.Controls.Add(this.multiBTN);
            this.BTNBOX.Controls.Add(this.num1BTN);
            this.BTNBOX.Controls.Add(this.minusBTN);
            this.BTNBOX.Controls.Add(this.num7BTN);
            this.BTNBOX.Controls.Add(this.divBTN);
            this.BTNBOX.Controls.Add(this.ceBTN);
            this.BTNBOX.Controls.Add(this.clrBTN);
            this.BTNBOX.Location = new System.Drawing.Point(12, 38);
            this.BTNBOX.Name = "BTNBOX";
            this.BTNBOX.Size = new System.Drawing.Size(243, 404);
            this.BTNBOX.TabIndex = 1;
            this.BTNBOX.TabStop = false;
            // 
            // num8BTN
            // 
            this.num8BTN.Location = new System.Drawing.Point(81, 143);
            this.num8BTN.Name = "num8BTN";
            this.num8BTN.Size = new System.Drawing.Size(75, 56);
            this.num8BTN.TabIndex = 8;
            this.num8BTN.Text = "8";
            this.num8BTN.UseVisualStyleBackColor = true;
            this.num8BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // num0BTN
            // 
            this.num0BTN.Location = new System.Drawing.Point(0, 329);
            this.num0BTN.Name = "num0BTN";
            this.num0BTN.Size = new System.Drawing.Size(156, 56);
            this.num0BTN.TabIndex = 8;
            this.num0BTN.Text = "0";
            this.num0BTN.UseVisualStyleBackColor = true;
            this.num0BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // num9BTN
            // 
            this.num9BTN.Location = new System.Drawing.Point(162, 143);
            this.num9BTN.Name = "num9BTN";
            this.num9BTN.Size = new System.Drawing.Size(75, 56);
            this.num9BTN.TabIndex = 8;
            this.num9BTN.Text = "9";
            this.num9BTN.UseVisualStyleBackColor = true;
            this.num9BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // equalsBTN
            // 
            this.equalsBTN.Location = new System.Drawing.Point(162, 329);
            this.equalsBTN.Name = "equalsBTN";
            this.equalsBTN.Size = new System.Drawing.Size(75, 56);
            this.equalsBTN.TabIndex = 7;
            this.equalsBTN.Text = "=";
            this.equalsBTN.UseVisualStyleBackColor = true;
            this.equalsBTN.Click += new System.EventHandler(this.equals_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(0, 81);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 56);
            this.addBTN.TabIndex = 6;
            this.addBTN.Text = "+";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.operand_Click);
            // 
            // num5BTN
            // 
            this.num5BTN.Location = new System.Drawing.Point(81, 205);
            this.num5BTN.Name = "num5BTN";
            this.num5BTN.Size = new System.Drawing.Size(75, 56);
            this.num5BTN.TabIndex = 7;
            this.num5BTN.Text = "5";
            this.num5BTN.UseVisualStyleBackColor = true;
            this.num5BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // num3BTN
            // 
            this.num3BTN.Location = new System.Drawing.Point(162, 267);
            this.num3BTN.Name = "num3BTN";
            this.num3BTN.Size = new System.Drawing.Size(75, 56);
            this.num3BTN.TabIndex = 7;
            this.num3BTN.Text = "3";
            this.num3BTN.UseVisualStyleBackColor = true;
            this.num3BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // num2BTN
            // 
            this.num2BTN.Location = new System.Drawing.Point(81, 267);
            this.num2BTN.Name = "num2BTN";
            this.num2BTN.Size = new System.Drawing.Size(75, 56);
            this.num2BTN.TabIndex = 7;
            this.num2BTN.Text = "2";
            this.num2BTN.UseVisualStyleBackColor = true;
            this.num2BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // num4BTN
            // 
            this.num4BTN.Location = new System.Drawing.Point(0, 205);
            this.num4BTN.Name = "num4BTN";
            this.num4BTN.Size = new System.Drawing.Size(75, 56);
            this.num4BTN.TabIndex = 6;
            this.num4BTN.Text = "4";
            this.num4BTN.UseVisualStyleBackColor = true;
            this.num4BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // num6BTN
            // 
            this.num6BTN.Location = new System.Drawing.Point(162, 205);
            this.num6BTN.Name = "num6BTN";
            this.num6BTN.Size = new System.Drawing.Size(75, 56);
            this.num6BTN.TabIndex = 6;
            this.num6BTN.Text = "6";
            this.num6BTN.UseVisualStyleBackColor = true;
            this.num6BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // multiBTN
            // 
            this.multiBTN.Location = new System.Drawing.Point(162, 81);
            this.multiBTN.Name = "multiBTN";
            this.multiBTN.Size = new System.Drawing.Size(75, 56);
            this.multiBTN.TabIndex = 7;
            this.multiBTN.Text = "*";
            this.multiBTN.UseVisualStyleBackColor = true;
            this.multiBTN.Click += new System.EventHandler(this.operand_Click);
            // 
            // num1BTN
            // 
            this.num1BTN.Location = new System.Drawing.Point(0, 267);
            this.num1BTN.Name = "num1BTN";
            this.num1BTN.Size = new System.Drawing.Size(75, 56);
            this.num1BTN.TabIndex = 5;
            this.num1BTN.Text = "1";
            this.num1BTN.UseVisualStyleBackColor = true;
            this.num1BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // minusBTN
            // 
            this.minusBTN.Location = new System.Drawing.Point(81, 81);
            this.minusBTN.Name = "minusBTN";
            this.minusBTN.Size = new System.Drawing.Size(75, 56);
            this.minusBTN.TabIndex = 4;
            this.minusBTN.Text = "-";
            this.minusBTN.UseVisualStyleBackColor = true;
            this.minusBTN.Click += new System.EventHandler(this.operand_Click);
            // 
            // num7BTN
            // 
            this.num7BTN.Location = new System.Drawing.Point(0, 143);
            this.num7BTN.Name = "num7BTN";
            this.num7BTN.Size = new System.Drawing.Size(75, 56);
            this.num7BTN.TabIndex = 3;
            this.num7BTN.Text = "7";
            this.num7BTN.UseVisualStyleBackColor = true;
            this.num7BTN.Click += new System.EventHandler(this.button_Click);
            // 
            // divBTN
            // 
            this.divBTN.Location = new System.Drawing.Point(162, 19);
            this.divBTN.Name = "divBTN";
            this.divBTN.Size = new System.Drawing.Size(75, 56);
            this.divBTN.TabIndex = 2;
            this.divBTN.Text = "/";
            this.divBTN.UseVisualStyleBackColor = true;
            this.divBTN.Click += new System.EventHandler(this.operand_Click);
            // 
            // ceBTN
            // 
            this.ceBTN.Location = new System.Drawing.Point(81, 19);
            this.ceBTN.Name = "ceBTN";
            this.ceBTN.Size = new System.Drawing.Size(75, 56);
            this.ceBTN.TabIndex = 1;
            this.ceBTN.Text = "CE";
            this.ceBTN.UseVisualStyleBackColor = true;
            this.ceBTN.Click += new System.EventHandler(this.ce_Click);
            // 
            // clrBTN
            // 
            this.clrBTN.Location = new System.Drawing.Point(0, 19);
            this.clrBTN.Name = "clrBTN";
            this.clrBTN.Size = new System.Drawing.Size(75, 56);
            this.clrBTN.TabIndex = 0;
            this.clrBTN.Text = "C";
            this.clrBTN.UseVisualStyleBackColor = true;
            this.clrBTN.Click += new System.EventHandler(this.c_Click);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(213, -1);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(0, 13);
            this.lblStore.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 450);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.BTNBOX);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BTNBOX.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox BTNBOX;
        private System.Windows.Forms.Button multiBTN;
        private System.Windows.Forms.Button num1BTN;
        private System.Windows.Forms.Button minusBTN;
        private System.Windows.Forms.Button num7BTN;
        private System.Windows.Forms.Button divBTN;
        private System.Windows.Forms.Button ceBTN;
        private System.Windows.Forms.Button clrBTN;
        private System.Windows.Forms.Button num8BTN;
        private System.Windows.Forms.Button num0BTN;
        private System.Windows.Forms.Button num9BTN;
        private System.Windows.Forms.Button equalsBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button num5BTN;
        private System.Windows.Forms.Button num3BTN;
        private System.Windows.Forms.Button num2BTN;
        private System.Windows.Forms.Button num4BTN;
        private System.Windows.Forms.Button num6BTN;
        private System.Windows.Forms.Label lblStore;
    }
}

