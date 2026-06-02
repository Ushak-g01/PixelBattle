namespace ClientPB
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnConnect = new Button();
            TextServerIP = new TextBox();
            canvas = new Panel();
            worldList = new ComboBox();
            btnJoin = new Button();
            btnCreate = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            btnColor7 = new Button();
            btnColor6 = new Button();
            btnColor5 = new Button();
            btnColor4 = new Button();
            btnColor3 = new Button();
            btnColor2 = new Button();
            btnColor1 = new Button();
            btnColor0 = new Button();
            lblStatus = new Label();
            lblCooldown = new Label();
            coldownTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Сервера";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 76);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(197, 31);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Подключиться к серверу";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // TextServerIP
            // 
            TextServerIP.Location = new Point(84, 44);
            TextServerIP.Name = "TextServerIP";
            TextServerIP.Size = new Size(100, 23);
            TextServerIP.TabIndex = 2;
            TextServerIP.Text = "127.0.0.1";
            // 
            // canvas
            // 
            canvas.BackColor = Color.Black;
            canvas.Location = new Point(215, 12);
            canvas.Name = "canvas";
            canvas.Size = new Size(500, 500);
            canvas.TabIndex = 3;
            canvas.Paint += canvas_Paint;
            canvas.MouseClick += canvas_MouseClick;
            // 
            // worldList
            // 
            worldList.Enabled = false;
            worldList.FormattingEnabled = true;
            worldList.Location = new Point(12, 151);
            worldList.Name = "worldList";
            worldList.Size = new Size(196, 23);
            worldList.TabIndex = 4;
            // 
            // btnJoin
            // 
            btnJoin.Enabled = false;
            btnJoin.Location = new Point(12, 222);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(197, 31);
            btnJoin.TabIndex = 5;
            btnJoin.Text = "Зайти на мир";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += button2_Click;
            // 
            // btnCreate
            // 
            btnCreate.Enabled = false;
            btnCreate.Location = new Point(12, 271);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(197, 31);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Создать мир";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Enabled = false;
            btnRefresh.Location = new Point(12, 319);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(197, 31);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Обновить список миров";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnColor7);
            panel1.Controls.Add(btnColor6);
            panel1.Controls.Add(btnColor5);
            panel1.Controls.Add(btnColor4);
            panel1.Controls.Add(btnColor3);
            panel1.Controls.Add(btnColor2);
            panel1.Controls.Add(btnColor1);
            panel1.Controls.Add(btnColor0);
            panel1.Location = new Point(760, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 36);
            panel1.TabIndex = 8;
            // 
            // btnColor7
            // 
            btnColor7.BackColor = Color.Cyan;
            btnColor7.Location = new Point(290, 3);
            btnColor7.Name = "btnColor7";
            btnColor7.Size = new Size(35, 30);
            btnColor7.TabIndex = 7;
            btnColor7.UseVisualStyleBackColor = false;
            // 
            // btnColor6
            // 
            btnColor6.BackColor = Color.Magenta;
            btnColor6.Location = new Point(249, 3);
            btnColor6.Name = "btnColor6";
            btnColor6.Size = new Size(35, 30);
            btnColor6.TabIndex = 6;
            btnColor6.UseVisualStyleBackColor = false;
            // 
            // btnColor5
            // 
            btnColor5.BackColor = Color.Yellow;
            btnColor5.Location = new Point(208, 3);
            btnColor5.Name = "btnColor5";
            btnColor5.Size = new Size(35, 30);
            btnColor5.TabIndex = 5;
            btnColor5.UseVisualStyleBackColor = false;
            btnColor5.Click += btnColor5_Click;
            // 
            // btnColor4
            // 
            btnColor4.BackColor = Color.Blue;
            btnColor4.Location = new Point(167, 3);
            btnColor4.Name = "btnColor4";
            btnColor4.Size = new Size(35, 30);
            btnColor4.TabIndex = 4;
            btnColor4.UseVisualStyleBackColor = false;
            // 
            // btnColor3
            // 
            btnColor3.BackColor = Color.Green;
            btnColor3.Location = new Point(126, 3);
            btnColor3.Name = "btnColor3";
            btnColor3.Size = new Size(35, 30);
            btnColor3.TabIndex = 3;
            btnColor3.UseVisualStyleBackColor = false;
            // 
            // btnColor2
            // 
            btnColor2.BackColor = Color.Red;
            btnColor2.Location = new Point(85, 3);
            btnColor2.Name = "btnColor2";
            btnColor2.Size = new Size(35, 30);
            btnColor2.TabIndex = 2;
            btnColor2.UseVisualStyleBackColor = false;
            // 
            // btnColor1
            // 
            btnColor1.BackColor = Color.White;
            btnColor1.Location = new Point(44, 3);
            btnColor1.Name = "btnColor1";
            btnColor1.Size = new Size(35, 30);
            btnColor1.TabIndex = 1;
            btnColor1.UseVisualStyleBackColor = false;
            // 
            // btnColor0
            // 
            btnColor0.BackColor = Color.Black;
            btnColor0.Location = new Point(3, 3);
            btnColor0.Name = "btnColor0";
            btnColor0.Size = new Size(35, 30);
            btnColor0.TabIndex = 0;
            btnColor0.UseVisualStyleBackColor = false;
            btnColor0.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(732, 175);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Статус";
            // 
            // lblCooldown
            // 
            lblCooldown.AutoSize = true;
            lblCooldown.Location = new Point(732, 205);
            lblCooldown.Name = "lblCooldown";
            lblCooldown.Size = new Size(25, 15);
            lblCooldown.TabIndex = 10;
            lblCooldown.Text = "КД:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 551);
            Controls.Add(lblCooldown);
            Controls.Add(lblStatus);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnCreate);
            Controls.Add(btnJoin);
            Controls.Add(worldList);
            Controls.Add(canvas);
            Controls.Add(TextServerIP);
            Controls.Add(btnConnect);
            Controls.Add(label1);
            Enabled = false;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConnect;
        private TextBox TextServerIP;
        private Panel canvas;
        private ComboBox worldList;
        private Button btnJoin;
        private Button btnCreate;
        private Button btnRefresh;
        private Panel panel1;
        private Button btnColor0;
        private Button btnColor3;
        private Button btnColor2;
        private Button btnColor1;
        private Button btnColor7;
        private Button btnColor6;
        private Button btnColor5;
        private Button btnColor4;
        private Label lblStatus;
        private Label lblCooldown;
        private System.Windows.Forms.Timer coldownTimer;
    }
}
