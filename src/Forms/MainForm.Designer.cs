
namespace OnLineFM
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.srchbtn = new System.Windows.Forms.Button();
            this.stationslist = new System.Windows.Forms.ListBox();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.playbtn = new System.Windows.Forms.Button();
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titl = new System.Windows.Forms.ToolStripMenuItem();
            this.showndbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.stopbtnitem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.customTbox = new System.Windows.Forms.TextBox();
            this.mutebtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.playTbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.sleepTimerLabel = new System.Windows.Forms.Label();
            this.sleepTimerBtn = new System.Windows.Forms.Button();
            this.sleepTimerBox = new System.Windows.Forms.TextBox();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.favbox = new System.Windows.Forms.ListBox();
            this.addfavbtn = new System.Windows.Forms.Button();
            this.rmfavbtn = new System.Windows.Forms.Button();
            this.addfavurlbtn = new System.Windows.Forms.Button();
            this.editfavbtn = new System.Windows.Forms.Button();
            this.playfavbtn = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.srchbtn.FlatAppearance.BorderSize = 0;
            this.srchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.srchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.srchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbtn.ForeColor = System.Drawing.Color.White;
            this.srchbtn.Location = new System.Drawing.Point(211, 185);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(63, 23);
            this.srchbtn.TabIndex = 0;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // stationslist
            // 
            this.stationslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.stationslist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stationslist.ForeColor = System.Drawing.Color.White;
            this.stationslist.FormattingEnabled = true;
            this.stationslist.ItemHeight = 15;
            this.stationslist.Location = new System.Drawing.Point(12, 57);
            this.stationslist.Name = "stationslist";
            this.stationslist.Size = new System.Drawing.Size(262, 122);
            this.stationslist.Sorted = true;
            this.stationslist.TabIndex = 2;
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbox.ForeColor = System.Drawing.Color.White;
            this.searchbox.Location = new System.Drawing.Point(12, 185);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(193, 23);
            this.searchbox.TabIndex = 3;
            // 
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.playbtn.FlatAppearance.BorderSize = 0;
            this.playbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.playbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbtn.ForeColor = System.Drawing.Color.White;
            this.playbtn.Location = new System.Drawing.Point(12, 214);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(262, 27);
            this.playbtn.TabIndex = 4;
            this.playbtn.Text = "Play Station";
            this.playbtn.UseVisualStyleBackColor = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // noti
            // 
            this.noti.ContextMenuStrip = this.contextMenu;
            this.noti.Icon = ((System.Drawing.Icon)(resources.GetObject("noti.Icon")));
            this.noti.Text = "OnLineRadio";
            this.noti.Visible = true;
            this.noti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noti_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titl,
            this.showndbtn,
            this.stopbtnitem,
            this.toolStripMenuItem1});
            this.contextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(195, 92);
            // 
            // titl
            // 
            this.titl.Enabled = false;
            this.titl.Name = "titl";
            this.titl.Size = new System.Drawing.Size(194, 22);
            this.titl.Text = "OnLineFM";
            // 
            // showndbtn
            // 
            this.showndbtn.Name = "showndbtn";
            this.showndbtn.Size = new System.Drawing.Size(194, 22);
            this.showndbtn.Text = "Show window";
            this.showndbtn.Click += new System.EventHandler(this.showndbtn_Click);
            // 
            // stopbtnitem
            // 
            this.stopbtnitem.Name = "stopbtnitem";
            this.stopbtnitem.Size = new System.Drawing.Size(194, 22);
            this.stopbtnitem.Text = "Stop";
            this.stopbtnitem.Click += new System.EventHandler(this.stopbtnitem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem1.Text = "Made by @D4n13l3k00";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 16);
            this.toolStripTextBox1.Text = "OnLineFM";
            // 
            // customTbox
            // 
            this.customTbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.customTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTbox.ForeColor = System.Drawing.Color.White;
            this.customTbox.Location = new System.Drawing.Point(12, 299);
            this.customTbox.Name = "customTbox";
            this.customTbox.Size = new System.Drawing.Size(193, 23);
            this.customTbox.TabIndex = 5;
            // 
            // mutebtn
            // 
            this.mutebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.mutebtn.FlatAppearance.BorderSize = 0;
            this.mutebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.mutebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.mutebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mutebtn.ForeColor = System.Drawing.Color.White;
            this.mutebtn.Location = new System.Drawing.Point(12, 247);
            this.mutebtn.Name = "mutebtn";
            this.mutebtn.Size = new System.Drawing.Size(125, 27);
            this.mutebtn.TabIndex = 9;
            this.mutebtn.Text = "Mute";
            this.mutebtn.UseVisualStyleBackColor = false;
            this.mutebtn.Click += new System.EventHandler(this.mutebtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.stopbtn.FlatAppearance.BorderSize = 0;
            this.stopbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.stopbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.stopbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopbtn.ForeColor = System.Drawing.Color.White;
            this.stopbtn.Location = new System.Drawing.Point(149, 247);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(125, 27);
            this.stopbtn.TabIndex = 11;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = false;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // playTbtn
            // 
            this.playTbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.playTbtn.FlatAppearance.BorderSize = 0;
            this.playTbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.playTbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.playTbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playTbtn.ForeColor = System.Drawing.Color.White;
            this.playTbtn.Location = new System.Drawing.Point(211, 299);
            this.playTbtn.Name = "playTbtn";
            this.playTbtn.Size = new System.Drawing.Size(63, 23);
            this.playTbtn.TabIndex = 12;
            this.playTbtn.Text = "Play";
            this.playTbtn.UseVisualStyleBackColor = false;
            this.playTbtn.Click += new System.EventHandler(this.playTbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Custom station by link";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "OnLineFM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.Location = new System.Drawing.Point(12, 39);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(530, 15);
            this.stateLabel.TabIndex = 15;
            this.stateLabel.Text = "Waiting...";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stateLabel.Click += new System.EventHandler(this.stateLabel_Click);
            // 
            // sleepTimerLabel
            // 
            this.sleepTimerLabel.AutoSize = true;
            this.sleepTimerLabel.Location = new System.Drawing.Point(12, 325);
            this.sleepTimerLabel.Name = "sleepTimerLabel";
            this.sleepTimerLabel.Size = new System.Drawing.Size(121, 15);
            this.sleepTimerLabel.TabIndex = 16;
            this.sleepTimerLabel.Text = "SleepTimer in minutes";
            // 
            // sleepTimerBtn
            // 
            this.sleepTimerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.sleepTimerBtn.FlatAppearance.BorderSize = 0;
            this.sleepTimerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.sleepTimerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.sleepTimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleepTimerBtn.ForeColor = System.Drawing.Color.White;
            this.sleepTimerBtn.Location = new System.Drawing.Point(76, 343);
            this.sleepTimerBtn.Name = "sleepTimerBtn";
            this.sleepTimerBtn.Size = new System.Drawing.Size(67, 23);
            this.sleepTimerBtn.TabIndex = 17;
            this.sleepTimerBtn.Text = "Start";
            this.sleepTimerBtn.UseVisualStyleBackColor = false;
            this.sleepTimerBtn.Click += new System.EventHandler(this.sleepTimerBtn_Click);
            // 
            // sleepTimerBox
            // 
            this.sleepTimerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.sleepTimerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sleepTimerBox.ForeColor = System.Drawing.Color.White;
            this.sleepTimerBox.Location = new System.Drawing.Point(12, 343);
            this.sleepTimerBox.Name = "sleepTimerBox";
            this.sleepTimerBox.Size = new System.Drawing.Size(58, 23);
            this.sleepTimerBox.TabIndex = 18;
            this.sleepTimerBox.Text = "30";
            this.sleepTimerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sleepTimerBox_KeyPress);
            // 
            // aboutbtn
            // 
            this.aboutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.aboutbtn.FlatAppearance.BorderSize = 0;
            this.aboutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.aboutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.ForeColor = System.Drawing.Color.White;
            this.aboutbtn.Location = new System.Drawing.Point(149, 328);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(125, 38);
            this.aboutbtn.TabIndex = 19;
            this.aboutbtn.Text = "About App";
            this.aboutbtn.UseVisualStyleBackColor = false;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // favbox
            // 
            this.favbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.favbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favbox.ForeColor = System.Drawing.Color.White;
            this.favbox.FormattingEnabled = true;
            this.favbox.ItemHeight = 15;
            this.favbox.Location = new System.Drawing.Point(280, 57);
            this.favbox.Name = "favbox";
            this.favbox.Size = new System.Drawing.Size(262, 242);
            this.favbox.TabIndex = 20;
            // 
            // addfavbtn
            // 
            this.addfavbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.addfavbtn.FlatAppearance.BorderSize = 0;
            this.addfavbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.addfavbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.addfavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfavbtn.ForeColor = System.Drawing.Color.White;
            this.addfavbtn.Location = new System.Drawing.Point(280, 306);
            this.addfavbtn.Name = "addfavbtn";
            this.addfavbtn.Size = new System.Drawing.Size(79, 27);
            this.addfavbtn.TabIndex = 24;
            this.addfavbtn.Text = "Add";
            this.addfavbtn.UseVisualStyleBackColor = false;
            this.addfavbtn.Click += new System.EventHandler(this.addfavbtn_Click);
            // 
            // rmfavbtn
            // 
            this.rmfavbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.rmfavbtn.FlatAppearance.BorderSize = 0;
            this.rmfavbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.rmfavbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.rmfavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmfavbtn.ForeColor = System.Drawing.Color.White;
            this.rmfavbtn.Location = new System.Drawing.Point(280, 339);
            this.rmfavbtn.Name = "rmfavbtn";
            this.rmfavbtn.Size = new System.Drawing.Size(67, 27);
            this.rmfavbtn.TabIndex = 27;
            this.rmfavbtn.Text = "Remove";
            this.rmfavbtn.UseVisualStyleBackColor = false;
            this.rmfavbtn.Click += new System.EventHandler(this.rmfavbtn_Click);
            // 
            // addfavurlbtn
            // 
            this.addfavurlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.addfavurlbtn.FlatAppearance.BorderSize = 0;
            this.addfavurlbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.addfavurlbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.addfavurlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfavurlbtn.ForeColor = System.Drawing.Color.White;
            this.addfavurlbtn.Location = new System.Drawing.Point(365, 306);
            this.addfavurlbtn.Name = "addfavurlbtn";
            this.addfavurlbtn.Size = new System.Drawing.Size(67, 27);
            this.addfavurlbtn.TabIndex = 28;
            this.addfavurlbtn.Text = "Add URL";
            this.addfavurlbtn.UseVisualStyleBackColor = false;
            this.addfavurlbtn.Click += new System.EventHandler(this.addfavurlbtn_Click);
            // 
            // editfavbtn
            // 
            this.editfavbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.editfavbtn.FlatAppearance.BorderSize = 0;
            this.editfavbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.editfavbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.editfavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editfavbtn.ForeColor = System.Drawing.Color.White;
            this.editfavbtn.Location = new System.Drawing.Point(353, 339);
            this.editfavbtn.Name = "editfavbtn";
            this.editfavbtn.Size = new System.Drawing.Size(79, 27);
            this.editfavbtn.TabIndex = 29;
            this.editfavbtn.Text = "Edit";
            this.editfavbtn.UseVisualStyleBackColor = false;
            this.editfavbtn.Click += new System.EventHandler(this.editfavbtn_Click);
            // 
            // playfavbtn
            // 
            this.playfavbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(97)))));
            this.playfavbtn.FlatAppearance.BorderSize = 0;
            this.playfavbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.playfavbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
            this.playfavbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playfavbtn.ForeColor = System.Drawing.Color.White;
            this.playfavbtn.Location = new System.Drawing.Point(438, 306);
            this.playfavbtn.Name = "playfavbtn";
            this.playfavbtn.Size = new System.Drawing.Size(104, 61);
            this.playfavbtn.TabIndex = 30;
            this.playfavbtn.Text = "Play";
            this.playfavbtn.UseVisualStyleBackColor = false;
            this.playfavbtn.Click += new System.EventHandler(this.playfavbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.playfavbtn);
            this.Controls.Add(this.editfavbtn);
            this.Controls.Add(this.addfavurlbtn);
            this.Controls.Add(this.rmfavbtn);
            this.Controls.Add(this.addfavbtn);
            this.Controls.Add(this.favbox);
            this.Controls.Add(this.aboutbtn);
            this.Controls.Add(this.sleepTimerBox);
            this.Controls.Add(this.sleepTimerBtn);
            this.Controls.Add(this.sleepTimerLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playTbtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.mutebtn);
            this.Controls.Add(this.customTbox);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.stationslist);
            this.Controls.Add(this.srchbtn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnLineFM";
            this.TopMost = true;
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.ListBox stationslist;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.NotifyIcon noti;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem stopbtnitem;
        private System.Windows.Forms.ToolStripMenuItem titl;
        private System.Windows.Forms.ToolStripMenuItem showndbtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox customTbox;
        private System.Windows.Forms.Button mutebtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button playTbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label sleepTimerLabel;
        private System.Windows.Forms.Button sleepTimerBtn;
        private System.Windows.Forms.TextBox sleepTimerBox;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.ListBox favbox;
        private System.Windows.Forms.Button addfavbtn;
        private System.Windows.Forms.Button rmfavbtn;
        private System.Windows.Forms.Button addfavurlbtn;
        private System.Windows.Forms.Button editfavbtn;
        private System.Windows.Forms.Button playfavbtn;
    }
}

