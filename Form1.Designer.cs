namespace expresionRegular
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTexto = new System.Windows.Forms.RadioButton();
            this.rbTextRegex = new System.Windows.Forms.RadioButton();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.lblRegex = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.gbRegex = new System.Windows.Forms.GroupBox();
            this.rbURL = new System.Windows.Forms.RadioButton();
            this.rbIP = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbRegex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 122);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(148, 20);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Entrada a evaluar =>";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(170, 119);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(350, 27);
            this.txtInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTexto);
            this.groupBox1.Controls.Add(this.rbTextRegex);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluaremos ...";
            // 
            // rbTexto
            // 
            this.rbTexto.AutoSize = true;
            this.rbTexto.Location = new System.Drawing.Point(14, 26);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(114, 24);
            this.rbTexto.TabIndex = 1;
            this.rbTexto.TabStop = true;
            this.rbTexto.Text = "Validar texto";
            this.rbTexto.UseVisualStyleBackColor = true;
            this.rbTexto.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbTextRegex
            // 
            this.rbTextRegex.AutoSize = true;
            this.rbTextRegex.Location = new System.Drawing.Point(14, 56);
            this.rbTextRegex.Name = "rbTextRegex";
            this.rbTextRegex.Size = new System.Drawing.Size(217, 24);
            this.rbTextRegex.TabIndex = 0;
            this.rbTextRegex.TabStop = true;
            this.rbTextRegex.Text = "Texto con Expresión Regular";
            this.rbTextRegex.UseVisualStyleBackColor = true;
            this.rbTextRegex.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(170, 162);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(350, 27);
            this.txtRegex.TabIndex = 4;
            // 
            // lblRegex
            // 
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(12, 165);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(152, 20);
            this.lblRegex.TabIndex = 3;
            this.lblRegex.Text = "Expresión Regular =>";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(211, 305);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(64, 20);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Mensaje";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(175, 216);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 29);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Evaluar expresión";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // gbRegex
            // 
            this.gbRegex.Controls.Add(this.rbURL);
            this.gbRegex.Controls.Add(this.rbIP);
            this.gbRegex.Controls.Add(this.rbEmail);
            this.gbRegex.Controls.Add(this.rbDate);
            this.gbRegex.Location = new System.Drawing.Point(269, 12);
            this.gbRegex.Name = "gbRegex";
            this.gbRegex.Size = new System.Drawing.Size(251, 96);
            this.gbRegex.TabIndex = 8;
            this.gbRegex.TabStop = false;
            this.gbRegex.Text = "Expresiones Regulares";
            // 
            // rbURL
            // 
            this.rbURL.AutoSize = true;
            this.rbURL.Location = new System.Drawing.Point(135, 26);
            this.rbURL.Name = "rbURL";
            this.rbURL.Size = new System.Drawing.Size(56, 24);
            this.rbURL.TabIndex = 3;
            this.rbURL.TabStop = true;
            this.rbURL.Text = "URL";
            this.rbURL.UseVisualStyleBackColor = true;
            this.rbURL.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.Location = new System.Drawing.Point(135, 56);
            this.rbIP.Name = "rbIP";
            this.rbIP.Size = new System.Drawing.Size(109, 24);
            this.rbIP.TabIndex = 2;
            this.rbIP.TabStop = true;
            this.rbIP.Text = "Dirección IP";
            this.rbIP.UseVisualStyleBackColor = true;
            this.rbIP.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(14, 26);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(75, 24);
            this.rbEmail.TabIndex = 1;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Correo";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(14, 56);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(68, 24);
            this.rbDate.TabIndex = 0;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Fecha";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 379);
            this.Controls.Add(this.gbRegex);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.lblRegex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Expresiones Regulares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRegex.ResumeLayout(false);
            this.gbRegex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private GroupBox groupBox1;
        private RadioButton rbTexto;
        private RadioButton rbTextRegex;
        private TextBox txtRegex;
        private Label lblRegex;
        private Label lblMessage;
        private Button btnTest;
        private GroupBox gbRegex;
        private RadioButton rbURL;
        private RadioButton rbIP;
        private RadioButton rbEmail;
        private RadioButton rbDate;
    }
}