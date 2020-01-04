namespace Warehouse_unit_DBapp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bMaterialsExistAdd = new System.Windows.Forms.Button();
            this.lMaterialExistMeasureUnit = new System.Windows.Forms.Label();
            this.tbExistMaterialQuantity = new System.Windows.Forms.TextBox();
            this.cbMaterialExistSelect = new System.Windows.Forms.ComboBox();
            this.gbNewMaterial = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bMatrialNewAdd = new System.Windows.Forms.Button();
            this.bMaterialNewClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbMaterialsNewQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaterialsNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaterialsNewMeasureUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaterialsNewProvider = new System.Windows.Forms.TextBox();
            this.lMaterialReceipt = new System.Windows.Forms.Label();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lqbel10 = new System.Windows.Forms.Label();
            this.cbInvoiceNewPerson = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInvoiceNewDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tvInvoice = new System.Windows.Forms.TreeView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cbInvoiceMaterialSelect = new System.Windows.Forms.ComboBox();
            this.tbInvoiceQuantity = new System.Windows.Forms.TextBox();
            this.lInvoiceMeasureUnit = new System.Windows.Forms.Label();
            this.bInvoiceAddLine = new System.Windows.Forms.Button();
            this.bInvoiceAdd = new System.Windows.Forms.Button();
            this.bInvoiceClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbInvoiceNewLines = new System.Windows.Forms.ListBox();
            this.rtbSqlQuery = new System.Windows.Forms.RichTextBox();
            this.bSqlQueryExecute = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.lQueryResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbNewMaterial.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvMaterials);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Материалы";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbNewMaterial);
            this.panel1.Controls.Add(this.lMaterialReceipt);
            this.panel1.Location = new System.Drawing.Point(8, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 268);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bMaterialsExistAdd);
            this.groupBox1.Controls.Add(this.lMaterialExistMeasureUnit);
            this.groupBox1.Controls.Add(this.tbExistMaterialQuantity);
            this.groupBox1.Controls.Add(this.cbMaterialExistSelect);
            this.groupBox1.Location = new System.Drawing.Point(7, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имеется на складе";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // bMaterialsExistAdd
            // 
            this.bMaterialsExistAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bMaterialsExistAdd.Location = new System.Drawing.Point(623, 19);
            this.bMaterialsExistAdd.Name = "bMaterialsExistAdd";
            this.bMaterialsExistAdd.Size = new System.Drawing.Size(75, 23);
            this.bMaterialsExistAdd.TabIndex = 0;
            this.bMaterialsExistAdd.Text = "Добавить";
            this.bMaterialsExistAdd.UseVisualStyleBackColor = true;
            this.bMaterialsExistAdd.Click += new System.EventHandler(this.bMaterialsExistAdd_Click);
            // 
            // lMaterialExistMeasureUnit
            // 
            this.lMaterialExistMeasureUnit.AutoSize = true;
            this.lMaterialExistMeasureUnit.Location = new System.Drawing.Point(303, 23);
            this.lMaterialExistMeasureUnit.Name = "lMaterialExistMeasureUnit";
            this.lMaterialExistMeasureUnit.Size = new System.Drawing.Size(0, 13);
            this.lMaterialExistMeasureUnit.TabIndex = 5;
            // 
            // tbExistMaterialQuantity
            // 
            this.tbExistMaterialQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbExistMaterialQuantity.Location = new System.Drawing.Point(195, 21);
            this.tbExistMaterialQuantity.Name = "tbExistMaterialQuantity";
            this.tbExistMaterialQuantity.Size = new System.Drawing.Size(102, 20);
            this.tbExistMaterialQuantity.TabIndex = 4;
            this.tbExistMaterialQuantity.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cbMaterialExistSelect
            // 
            this.cbMaterialExistSelect.FormattingEnabled = true;
            this.cbMaterialExistSelect.Location = new System.Drawing.Point(13, 20);
            this.cbMaterialExistSelect.Name = "cbMaterialExistSelect";
            this.cbMaterialExistSelect.Size = new System.Drawing.Size(138, 21);
            this.cbMaterialExistSelect.TabIndex = 0;
            this.cbMaterialExistSelect.SelectedIndexChanged += new System.EventHandler(this.cbMaterialExistSelect_SelectedIndexChanged);
            // 
            // gbNewMaterial
            // 
            this.gbNewMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewMaterial.Controls.Add(this.flowLayoutPanel1);
            this.gbNewMaterial.Controls.Add(this.tableLayoutPanel1);
            this.gbNewMaterial.Location = new System.Drawing.Point(7, 37);
            this.gbNewMaterial.Name = "gbNewMaterial";
            this.gbNewMaterial.Size = new System.Drawing.Size(707, 171);
            this.gbNewMaterial.TabIndex = 2;
            this.gbNewMaterial.TabStop = false;
            this.gbNewMaterial.Text = "Новый материал";
            this.gbNewMaterial.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.bMatrialNewAdd);
            this.flowLayoutPanel1.Controls.Add(this.bMaterialNewClear);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 31);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bMatrialNewAdd
            // 
            this.bMatrialNewAdd.Location = new System.Drawing.Point(616, 3);
            this.bMatrialNewAdd.Name = "bMatrialNewAdd";
            this.bMatrialNewAdd.Size = new System.Drawing.Size(75, 23);
            this.bMatrialNewAdd.TabIndex = 0;
            this.bMatrialNewAdd.Text = "Добавить";
            this.bMatrialNewAdd.UseVisualStyleBackColor = true;
            this.bMatrialNewAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bMaterialNewClear
            // 
            this.bMaterialNewClear.Location = new System.Drawing.Point(535, 3);
            this.bMaterialNewClear.Name = "bMaterialNewClear";
            this.bMaterialNewClear.Size = new System.Drawing.Size(75, 23);
            this.bMaterialNewClear.TabIndex = 1;
            this.bMaterialNewClear.Text = "Очистить";
            this.bMaterialNewClear.UseVisualStyleBackColor = true;
            this.bMaterialNewClear.Click += new System.EventHandler(this.bMaterialNewClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.68362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.31638F));
            this.tableLayoutPanel1.Controls.Add(this.tbMaterialsNewQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMaterialsNewName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMaterialsNewMeasureUnit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbMaterialsNewProvider, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(694, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbMaterialsNewQuantity
            // 
            this.tbMaterialsNewQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbMaterialsNewQuantity.Location = new System.Drawing.Point(195, 29);
            this.tbMaterialsNewQuantity.Name = "tbMaterialsNewQuantity";
            this.tbMaterialsNewQuantity.Size = new System.Drawing.Size(102, 20);
            this.tbMaterialsNewQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование материала";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tbMaterialsNewName
            // 
            this.tbMaterialsNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaterialsNewName.Location = new System.Drawing.Point(195, 3);
            this.tbMaterialsNewName.Name = "tbMaterialsNewName";
            this.tbMaterialsNewName.Size = new System.Drawing.Size(496, 20);
            this.tbMaterialsNewName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество материала";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbMaterialsNewMeasureUnit
            // 
            this.tbMaterialsNewMeasureUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbMaterialsNewMeasureUnit.Location = new System.Drawing.Point(195, 55);
            this.tbMaterialsNewMeasureUnit.Name = "tbMaterialsNewMeasureUnit";
            this.tbMaterialsNewMeasureUnit.Size = new System.Drawing.Size(102, 20);
            this.tbMaterialsNewMeasureUnit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Еденица измерения";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поставщик";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbMaterialsNewProvider
            // 
            this.tbMaterialsNewProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaterialsNewProvider.Location = new System.Drawing.Point(195, 82);
            this.tbMaterialsNewProvider.Name = "tbMaterialsNewProvider";
            this.tbMaterialsNewProvider.Size = new System.Drawing.Size(496, 20);
            this.tbMaterialsNewProvider.TabIndex = 5;
            // 
            // lMaterialReceipt
            // 
            this.lMaterialReceipt.AutoSize = true;
            this.lMaterialReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lMaterialReceipt.Location = new System.Drawing.Point(11, 2);
            this.lMaterialReceipt.Name = "lMaterialReceipt";
            this.lMaterialReceipt.Size = new System.Drawing.Size(200, 17);
            this.lMaterialReceipt.TabIndex = 0;
            this.lMaterialReceipt.Text = "Поступление материалов";
            this.lMaterialReceipt.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Location = new System.Drawing.Point(6, 6);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.Size = new System.Drawing.Size(721, 307);
            this.dgvMaterials.TabIndex = 0;
            this.dgvMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterials_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.tvInvoice);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Накладные";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // lqbel10
            // 
            this.lqbel10.AutoSize = true;
            this.lqbel10.Location = new System.Drawing.Point(-1, 68);
            this.lqbel10.Name = "lqbel10";
            this.lqbel10.Size = new System.Drawing.Size(72, 13);
            this.lqbel10.TabIndex = 6;
            this.lqbel10.Text = "Содержимое";
            this.lqbel10.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbInvoiceNewPerson
            // 
            this.cbInvoiceNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInvoiceNewPerson.FormattingEnabled = true;
            this.cbInvoiceNewPerson.Location = new System.Drawing.Point(254, 34);
            this.cbInvoiceNewPerson.Name = "cbInvoiceNewPerson";
            this.cbInvoiceNewPerson.Size = new System.Drawing.Size(465, 21);
            this.cbInvoiceNewPerson.TabIndex = 5;
            this.cbInvoiceNewPerson.SelectedIndexChanged += new System.EventHandler(this.cbInvoiceNewPerson_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "МОЛ";
            // 
            // tbInvoiceNewDate
            // 
            this.tbInvoiceNewDate.Location = new System.Drawing.Point(78, 35);
            this.tbInvoiceNewDate.Name = "tbInvoiceNewDate";
            this.tbInvoiceNewDate.Size = new System.Drawing.Size(121, 20);
            this.tbInvoiceNewDate.TabIndex = 3;
            this.tbInvoiceNewDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата выдачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-1, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Оформление накладной";
            // 
            // tvInvoice
            // 
            this.tvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvInvoice.Location = new System.Drawing.Point(7, 6);
            this.tvInvoice.Name = "tvInvoice";
            this.tvInvoice.Size = new System.Drawing.Size(719, 272);
            this.tvInvoice.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lQueryResult);
            this.tabPage5.Controls.Add(this.clear);
            this.tabPage5.Controls.Add(this.bSqlQueryExecute);
            this.tabPage5.Controls.Add(this.rtbSqlQuery);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(728, 598);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SQL запрос";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Новая строка";
            // 
            // cbInvoiceMaterialSelect
            // 
            this.cbInvoiceMaterialSelect.FormattingEnabled = true;
            this.cbInvoiceMaterialSelect.Location = new System.Drawing.Point(78, 219);
            this.cbInvoiceMaterialSelect.Name = "cbInvoiceMaterialSelect";
            this.cbInvoiceMaterialSelect.Size = new System.Drawing.Size(181, 21);
            this.cbInvoiceMaterialSelect.TabIndex = 10;
            this.cbInvoiceMaterialSelect.SelectedIndexChanged += new System.EventHandler(this.cbInvoiceMaterialSelect_SelectedIndexChanged);
            // 
            // tbInvoiceQuantity
            // 
            this.tbInvoiceQuantity.Location = new System.Drawing.Point(265, 219);
            this.tbInvoiceQuantity.Name = "tbInvoiceQuantity";
            this.tbInvoiceQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbInvoiceQuantity.TabIndex = 11;
            // 
            // lInvoiceMeasureUnit
            // 
            this.lInvoiceMeasureUnit.AutoSize = true;
            this.lInvoiceMeasureUnit.Location = new System.Drawing.Point(371, 222);
            this.lInvoiceMeasureUnit.Name = "lInvoiceMeasureUnit";
            this.lInvoiceMeasureUnit.Size = new System.Drawing.Size(0, 13);
            this.lInvoiceMeasureUnit.TabIndex = 12;
            this.lInvoiceMeasureUnit.Click += new System.EventHandler(this.lInvoiceMeasureUnit_Click);
            // 
            // bInvoiceAddLine
            // 
            this.bInvoiceAddLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInvoiceAddLine.Location = new System.Drawing.Point(600, 217);
            this.bInvoiceAddLine.Name = "bInvoiceAddLine";
            this.bInvoiceAddLine.Size = new System.Drawing.Size(119, 23);
            this.bInvoiceAddLine.TabIndex = 13;
            this.bInvoiceAddLine.Text = "Добавить строку";
            this.bInvoiceAddLine.UseVisualStyleBackColor = true;
            this.bInvoiceAddLine.Click += new System.EventHandler(this.bInvoiceAddLine_Click);
            // 
            // bInvoiceAdd
            // 
            this.bInvoiceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bInvoiceAdd.Location = new System.Drawing.Point(591, 282);
            this.bInvoiceAdd.Name = "bInvoiceAdd";
            this.bInvoiceAdd.Size = new System.Drawing.Size(128, 23);
            this.bInvoiceAdd.TabIndex = 14;
            this.bInvoiceAdd.Text = "Добавить накладную";
            this.bInvoiceAdd.UseVisualStyleBackColor = true;
            this.bInvoiceAdd.Click += new System.EventHandler(this.bInvoiceAdd_Click);
            // 
            // bInvoiceClear
            // 
            this.bInvoiceClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bInvoiceClear.Location = new System.Drawing.Point(501, 282);
            this.bInvoiceClear.Name = "bInvoiceClear";
            this.bInvoiceClear.Size = new System.Drawing.Size(84, 23);
            this.bInvoiceClear.TabIndex = 15;
            this.bInvoiceClear.Text = "Очистить";
            this.bInvoiceClear.UseVisualStyleBackColor = true;
            this.bInvoiceClear.Click += new System.EventHandler(this.bInvoiceClear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbInvoiceNewLines);
            this.panel2.Controls.Add(this.bInvoiceClear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bInvoiceAdd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bInvoiceAddLine);
            this.panel2.Controls.Add(this.tbInvoiceNewDate);
            this.panel2.Controls.Add(this.lInvoiceMeasureUnit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbInvoiceQuantity);
            this.panel2.Controls.Add(this.cbInvoiceNewPerson);
            this.panel2.Controls.Add(this.cbInvoiceMaterialSelect);
            this.panel2.Controls.Add(this.lqbel10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 308);
            this.panel2.TabIndex = 16;
            // 
            // lbInvoiceNewLines
            // 
            this.lbInvoiceNewLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceNewLines.FormattingEnabled = true;
            this.lbInvoiceNewLines.Location = new System.Drawing.Point(78, 68);
            this.lbInvoiceNewLines.Name = "lbInvoiceNewLines";
            this.lbInvoiceNewLines.Size = new System.Drawing.Size(639, 134);
            this.lbInvoiceNewLines.TabIndex = 16;
            // 
            // rtbSqlQuery
            // 
            this.rtbSqlQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSqlQuery.Font = new System.Drawing.Font("Consolas", 14.75F);
            this.rtbSqlQuery.Location = new System.Drawing.Point(8, 4);
            this.rtbSqlQuery.Name = "rtbSqlQuery";
            this.rtbSqlQuery.Size = new System.Drawing.Size(714, 556);
            this.rtbSqlQuery.TabIndex = 0;
            this.rtbSqlQuery.Text = "";
            this.rtbSqlQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbSqlQuery_KeyPress);
            // 
            // bSqlQueryExecute
            // 
            this.bSqlQueryExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSqlQueryExecute.Location = new System.Drawing.Point(645, 569);
            this.bSqlQueryExecute.Name = "bSqlQueryExecute";
            this.bSqlQueryExecute.Size = new System.Drawing.Size(75, 23);
            this.bSqlQueryExecute.TabIndex = 1;
            this.bSqlQueryExecute.Text = "Выполнить";
            this.bSqlQueryExecute.UseVisualStyleBackColor = true;
            this.bSqlQueryExecute.Click += new System.EventHandler(this.bSqlQueryExecute_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(564, 569);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lQueryResult
            // 
            this.lQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lQueryResult.AutoSize = true;
            this.lQueryResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQueryResult.Location = new System.Drawing.Point(7, 572);
            this.lQueryResult.Name = "lQueryResult";
            this.lQueryResult.Size = new System.Drawing.Size(0, 16);
            this.lQueryResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 621);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Складское предприятие";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbNewMaterial.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lMaterialReceipt;
        private System.Windows.Forms.GroupBox gbNewMaterial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaterialsNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaterialsNewQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaterialsNewProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bMatrialNewAdd;
        private System.Windows.Forms.TextBox tbMaterialsNewMeasureUnit;
        private System.Windows.Forms.ComboBox cbMaterialExistSelect;
        private System.Windows.Forms.Button bMaterialNewClear;
        private System.Windows.Forms.Button bMaterialsExistAdd;
        private System.Windows.Forms.Label lMaterialExistMeasureUnit;
        private System.Windows.Forms.TextBox tbExistMaterialQuantity;
        private System.Windows.Forms.TreeView tvInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbInvoiceNewPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInvoiceNewDate;
        private System.Windows.Forms.Label lqbel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bInvoiceAddLine;
        private System.Windows.Forms.Label lInvoiceMeasureUnit;
        private System.Windows.Forms.TextBox tbInvoiceQuantity;
        private System.Windows.Forms.ComboBox cbInvoiceMaterialSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bInvoiceClear;
        private System.Windows.Forms.Button bInvoiceAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbInvoiceNewLines;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button bSqlQueryExecute;
        private System.Windows.Forms.RichTextBox rtbSqlQuery;
        private System.Windows.Forms.Label lQueryResult;

    }
}

