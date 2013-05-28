namespace fuzzy_sets_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Readed_listBox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вБуферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Con_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Dil_toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.Euclid_toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.Hemming_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Dop_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Clearset_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LineEuclid_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LineHemming_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Instructions_textBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Error_Log_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Universal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Result_listBox = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Version_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.считатьМножестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьОписанныеНижеДействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_textBox
            // 
            this.Input_textBox.BackColor = System.Drawing.Color.White;
            this.Input_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input_textBox.ForeColor = System.Drawing.Color.Black;
            this.Input_textBox.Location = new System.Drawing.Point(3, 16);
            this.Input_textBox.Multiline = true;
            this.Input_textBox.Name = "Input_textBox";
            this.Input_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input_textBox.Size = new System.Drawing.Size(324, 133);
            this.Input_textBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Input_textBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // Readed_listBox
            // 
            this.Readed_listBox.BackColor = System.Drawing.Color.White;
            this.Readed_listBox.ContextMenuStrip = this.contextMenuStrip1;
            this.Readed_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Readed_listBox.ForeColor = System.Drawing.Color.Black;
            this.Readed_listBox.FormattingEnabled = true;
            this.Readed_listBox.HorizontalScrollbar = true;
            this.Readed_listBox.Location = new System.Drawing.Point(3, 16);
            this.Readed_listBox.Name = "Readed_listBox";
            this.Readed_listBox.Size = new System.Drawing.Size(324, 163);
            this.Readed_listBox.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикToolStripMenuItem,
            this.вБуферToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 48);
            // 
            // построитьГрафикToolStripMenuItem
            // 
            this.построитьГрафикToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._1;
            this.построитьГрафикToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
            this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.построитьГрафикToolStripMenuItem.Text = "Построить график";
            this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
            // 
            // вБуферToolStripMenuItem
            // 
            this.вБуферToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._2;
            this.вБуферToolStripMenuItem.Name = "вБуферToolStripMenuItem";
            this.вБуферToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.вБуферToolStripMenuItem.Text = "В буфер";
            this.вБуферToolStripMenuItem.Click += new System.EventHandler(this.вБуферToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.Instructions_textBox);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 152);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources.BG;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.Con_toolStripButton,
            this.Dil_toolStripButton4,
            this.Euclid_toolStripButton5,
            this.Hemming_toolStripButton,
            this.Dop_toolStripButton,
            this.Clearset_toolStripButton,
            this.LineEuclid_toolStripButton,
            this.LineHemming_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(324, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::fuzzy_sets_GUI.Properties.Resources.Union;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "∪";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::fuzzy_sets_GUI.Properties.Resources.Intersection;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "∩";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Con_toolStripButton
            // 
            this.Con_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Con_toolStripButton.Image = global::fuzzy_sets_GUI.Properties.Resources.Conc;
            this.Con_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Con_toolStripButton.Name = "Con_toolStripButton";
            this.Con_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Con_toolStripButton.Text = "Con";
            this.Con_toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Dil_toolStripButton4
            // 
            this.Dil_toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dil_toolStripButton4.Image = global::fuzzy_sets_GUI.Properties.Resources.Dil;
            this.Dil_toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dil_toolStripButton4.Name = "Dil_toolStripButton4";
            this.Dil_toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.Dil_toolStripButton4.Text = "Dil";
            this.Dil_toolStripButton4.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Euclid_toolStripButton5
            // 
            this.Euclid_toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Euclid_toolStripButton5.Image = global::fuzzy_sets_GUI.Properties.Resources.Euclid;
            this.Euclid_toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Euclid_toolStripButton5.Name = "Euclid_toolStripButton5";
            this.Euclid_toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.Euclid_toolStripButton5.Text = "Euclid";
            this.Euclid_toolStripButton5.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Hemming_toolStripButton
            // 
            this.Hemming_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Hemming_toolStripButton.Image = global::fuzzy_sets_GUI.Properties.Resources.Hemming;
            this.Hemming_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Hemming_toolStripButton.Name = "Hemming_toolStripButton";
            this.Hemming_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Hemming_toolStripButton.Text = "Hemming";
            this.Hemming_toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Dop_toolStripButton
            // 
            this.Dop_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dop_toolStripButton.Image = global::fuzzy_sets_GUI.Properties.Resources.Dop;
            this.Dop_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dop_toolStripButton.Name = "Dop_toolStripButton";
            this.Dop_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Dop_toolStripButton.Text = "!";
            this.Dop_toolStripButton.BackColorChanged += new System.EventHandler(this.toolStripButton_Click);
            this.Dop_toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Clearset_toolStripButton
            // 
            this.Clearset_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clearset_toolStripButton.Image = global::fuzzy_sets_GUI.Properties.Resources.ToSets;
            this.Clearset_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clearset_toolStripButton.Name = "Clearset_toolStripButton";
            this.Clearset_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Clearset_toolStripButton.Text = "Clearset";
            this.Clearset_toolStripButton.BackColorChanged += new System.EventHandler(this.toolStripButton_Click);
            this.Clearset_toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // LineEuclid_toolStripButton
            // 
            this.LineEuclid_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineEuclid_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LineEuclid_toolStripButton.Image")));
            this.LineEuclid_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineEuclid_toolStripButton.Name = "LineEuclid_toolStripButton";
            this.LineEuclid_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LineEuclid_toolStripButton.Text = "LineEuclid";
            this.LineEuclid_toolStripButton.BackColorChanged += new System.EventHandler(this.toolStripButton_Click);
            this.LineEuclid_toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // LineHemming_toolStripButton
            // 
            this.LineHemming_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineHemming_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LineHemming_toolStripButton.Image")));
            this.LineHemming_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineHemming_toolStripButton.Name = "LineHemming_toolStripButton";
            this.LineHemming_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LineHemming_toolStripButton.Text = "LineHemming";
            this.LineHemming_toolStripButton.BackColorChanged += new System.EventHandler(this.toolStripButton_Click);
            this.LineHemming_toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // Instructions_textBox
            // 
            this.Instructions_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Instructions_textBox.BackColor = System.Drawing.Color.White;
            this.Instructions_textBox.ForeColor = System.Drawing.Color.Black;
            this.Instructions_textBox.Location = new System.Drawing.Point(3, 37);
            this.Instructions_textBox.Multiline = true;
            this.Instructions_textBox.Name = "Instructions_textBox";
            this.Instructions_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Instructions_textBox.Size = new System.Drawing.Size(324, 109);
            this.Instructions_textBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.Error_Log_textBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(3, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 104);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Консоль ошибок, предупреждений и действий";
            // 
            // Error_Log_textBox
            // 
            this.Error_Log_textBox.BackColor = System.Drawing.Color.Black;
            this.Error_Log_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Error_Log_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Error_Log_textBox.Location = new System.Drawing.Point(3, 16);
            this.Error_Log_textBox.Multiline = true;
            this.Error_Log_textBox.Name = "Error_Log_textBox";
            this.Error_Log_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Error_Log_textBox.Size = new System.Drawing.Size(660, 85);
            this.Error_Log_textBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "U=";
            // 
            // Universal
            // 
            this.Universal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Universal.BackColor = System.Drawing.Color.White;
            this.Universal.ForeColor = System.Drawing.Color.Black;
            this.Universal.Location = new System.Drawing.Point(30, 3);
            this.Universal.Name = "Universal";
            this.Universal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Universal.Size = new System.Drawing.Size(296, 20);
            this.Universal.TabIndex = 9;
            this.Universal.Text = "{0;1;2;5;3;8;7}";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Version_label, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 478);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Result_listBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(339, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(330, 152);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Результаты";
            // 
            // Result_listBox
            // 
            this.Result_listBox.BackColor = System.Drawing.Color.White;
            this.Result_listBox.ContextMenuStrip = this.contextMenuStrip1;
            this.Result_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result_listBox.ForeColor = System.Drawing.Color.Black;
            this.Result_listBox.FormattingEnabled = true;
            this.Result_listBox.HorizontalScrollbar = true;
            this.Result_listBox.Location = new System.Drawing.Point(3, 16);
            this.Result_listBox.Name = "Result_listBox";
            this.Result_listBox.Size = new System.Drawing.Size(324, 133);
            this.Result_listBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Universal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 24);
            this.panel1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Readed_listBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(339, 3);
            this.groupBox4.Name = "groupBox4";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(330, 182);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Распознано";
            // 
            // Version_label
            // 
            this.Version_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Version_label.ForeColor = System.Drawing.Color.Black;
            this.Version_label.Location = new System.Drawing.Point(339, 456);
            this.Version_label.Name = "Version_label";
            this.Version_label.Size = new System.Drawing.Size(330, 22);
            this.Version_label.TabIndex = 12;
            this.Version_label.Text = "Version: ";
            this.Version_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources.BG;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.считатьМножестваToolStripMenuItem,
            this.выполнитьОписанныеНижеДействияToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.файлToolStripMenuItem.Text = "Действия";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // считатьМножестваToolStripMenuItem
            // 
            this.считатьМножестваToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._1;
            this.считатьМножестваToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.считатьМножестваToolStripMenuItem.Name = "считатьМножестваToolStripMenuItem";
            this.считатьМножестваToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.считатьМножестваToolStripMenuItem.Text = "Считать множества";
            this.считатьМножестваToolStripMenuItem.Click += new System.EventHandler(this.считатьМножестваToolStripMenuItem_Click);
            // 
            // выполнитьОписанныеНижеДействияToolStripMenuItem
            // 
            this.выполнитьОписанныеНижеДействияToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._2;
            this.выполнитьОписанныеНижеДействияToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.выполнитьОписанныеНижеДействияToolStripMenuItem.Name = "выполнитьОписанныеНижеДействияToolStripMenuItem";
            this.выполнитьОписанныеНижеДействияToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.выполнитьОписанныеНижеДействияToolStripMenuItem.Text = "Выполнить описанные ниже действия";
            this.выполнитьОписанныеНижеДействияToolStripMenuItem.Click += new System.EventHandler(this.выполнитьОписанныеНижеДействияToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._3;
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._4;
            this.загрузитьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackgroundImage = global::fuzzy_sets_GUI.Properties.Resources._1;
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Нечеткие множества";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox Input_textBox;
        private System.Windows.Forms.ToolStripMenuItem считатьМножестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьОписанныеНижеДействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Error_Log_textBox;
        private System.Windows.Forms.TextBox Instructions_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox Readed_listBox;
        private System.Windows.Forms.TextBox Universal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Version_label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton Con_toolStripButton;
        private System.Windows.Forms.ToolStripButton Dil_toolStripButton4;
        private System.Windows.Forms.ToolStripButton Euclid_toolStripButton5;
        private System.Windows.Forms.ToolStripButton Hemming_toolStripButton;
        private System.Windows.Forms.ToolStripButton Dop_toolStripButton;
        private System.Windows.Forms.CheckedListBox Result_listBox;
        private System.Windows.Forms.ToolStripMenuItem вБуферToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Clearset_toolStripButton;
        private System.Windows.Forms.ToolStripButton LineEuclid_toolStripButton;
        private System.Windows.Forms.ToolStripButton LineHemming_toolStripButton;
    }
}

