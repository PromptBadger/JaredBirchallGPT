namespace JaredBirchillGPT
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
            this.txtPromptText = new System.Windows.Forms.TextBox();
            this.btnPromptSend = new System.Windows.Forms.Button();
            this.rtUserInput = new System.Windows.Forms.RichTextBox();
            this.rtResponse = new System.Windows.Forms.RichTextBox();
            this.lblUserPrompt = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPromptText
            // 
            this.txtPromptText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.txtPromptText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPromptText.Font = new System.Drawing.Font("Poppins", 18F);
            this.txtPromptText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.txtPromptText.Location = new System.Drawing.Point(256, 824);
            this.txtPromptText.Multiline = true;
            this.txtPromptText.Name = "txtPromptText";
            this.txtPromptText.Size = new System.Drawing.Size(1451, 63);
            this.txtPromptText.TabIndex = 0;
            this.txtPromptText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPromptSend
            // 
            this.btnPromptSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.btnPromptSend.FlatAppearance.BorderSize = 0;
            this.btnPromptSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromptSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromptSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnPromptSend.Location = new System.Drawing.Point(1724, 824);
            this.btnPromptSend.Name = "btnPromptSend";
            this.btnPromptSend.Size = new System.Drawing.Size(145, 63);
            this.btnPromptSend.TabIndex = 1;
            this.btnPromptSend.Text = "➤";
            this.btnPromptSend.UseVisualStyleBackColor = false;
            this.btnPromptSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtUserInput
            // 
            this.rtUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.rtUserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtUserInput.Location = new System.Drawing.Point(256, 101);
            this.rtUserInput.Name = "rtUserInput";
            this.rtUserInput.Size = new System.Drawing.Size(1613, 141);
            this.rtUserInput.TabIndex = 2;
            this.rtUserInput.Text = "";
            // 
            // rtResponse
            // 
            this.rtResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.rtResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtResponse.Font = new System.Drawing.Font("Poppins", 12F);
            this.rtResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.rtResponse.Location = new System.Drawing.Point(266, 294);
            this.rtResponse.Name = "rtResponse";
            this.rtResponse.ReadOnly = true;
            this.rtResponse.Size = new System.Drawing.Size(1613, 464);
            this.rtResponse.TabIndex = 3;
            this.rtResponse.Text = "";
            // 
            // lblUserPrompt
            // 
            this.lblUserPrompt.AutoSize = true;
            this.lblUserPrompt.Font = new System.Drawing.Font("Poppins", 18F);
            this.lblUserPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblUserPrompt.Location = new System.Drawing.Point(55, 101);
            this.lblUserPrompt.Name = "lblUserPrompt";
            this.lblUserPrompt.Size = new System.Drawing.Size(195, 64);
            this.lblUserPrompt.TabIndex = 4;
            this.lblUserPrompt.Text = "User Ask: ";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Poppins", 18F);
            this.lblResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.lblResponse.Location = new System.Drawing.Point(31, 303);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(219, 64);
            this.lblResponse.TabIndex = 5;
            this.lblResponse.Text = "Response: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(159)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 13F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.button1.Location = new System.Drawing.Point(1851, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(159)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins", 13F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.button2.Location = new System.Drawing.Point(1792, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1906, 920);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblUserPrompt);
            this.Controls.Add(this.rtResponse);
            this.Controls.Add(this.rtUserInput);
            this.Controls.Add(this.btnPromptSend);
            this.Controls.Add(this.txtPromptText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HackTheChatAIDK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPromptText;
        private System.Windows.Forms.Button btnPromptSend;
        private System.Windows.Forms.RichTextBox rtUserInput;
        private System.Windows.Forms.RichTextBox rtResponse;
        private System.Windows.Forms.Label lblUserPrompt;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

