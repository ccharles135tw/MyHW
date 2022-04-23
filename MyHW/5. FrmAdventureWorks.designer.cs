
namespace MyHW
{
    partial class FrmAdventureWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdventureWorks));
            this.productPhotoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productPhotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aWDataSet = new MyHW.AWDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productPhotoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productPhotoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productPhotoTableAdapter = new MyHW.AWDataSetTableAdapters.ProductPhotoTableAdapter();
            this.tableAdapterManager = new MyHW.AWDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingNavigator)).BeginInit();
            this.productPhotoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productPhotoBindingNavigator
            // 
            this.productPhotoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productPhotoBindingNavigator.BindingSource = this.productPhotoBindingSource;
            this.productPhotoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productPhotoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productPhotoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.productPhotoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productPhotoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productPhotoBindingNavigatorSaveItem});
            this.productPhotoBindingNavigator.Location = new System.Drawing.Point(375, 151);
            this.productPhotoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productPhotoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productPhotoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productPhotoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productPhotoBindingNavigator.Name = "productPhotoBindingNavigator";
            this.productPhotoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productPhotoBindingNavigator.Size = new System.Drawing.Size(335, 31);
            this.productPhotoBindingNavigator.TabIndex = 0;
            this.productPhotoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // productPhotoBindingSource
            // 
            this.productPhotoBindingSource.DataMember = "ProductPhoto";
            this.productPhotoBindingSource.DataSource = this.aWDataSet;
            this.productPhotoBindingSource.CurrentChanged += new System.EventHandler(this.productPhotoBindingSource_CurrentChanged);
            // 
            // aWDataSet
            // 
            this.aWDataSet.DataSetName = "AWDataSet";
            this.aWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // productPhotoBindingNavigatorSaveItem
            // 
            this.productPhotoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productPhotoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productPhotoBindingNavigatorSaveItem.Image")));
            this.productPhotoBindingNavigatorSaveItem.Name = "productPhotoBindingNavigatorSaveItem";
            this.productPhotoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.productPhotoBindingNavigatorSaveItem.Text = "儲存資料";
            this.productPhotoBindingNavigatorSaveItem.Click += new System.EventHandler(this.productPhotoBindingNavigatorSaveItem_Click);
            // 
            // productPhotoDataGridView
            // 
            this.productPhotoDataGridView.AutoGenerateColumns = false;
            this.productPhotoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productPhotoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productPhotoDataGridView.DataSource = this.productPhotoBindingSource;
            this.productPhotoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPhotoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productPhotoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productPhotoDataGridView.Name = "productPhotoDataGridView";
            this.productPhotoDataGridView.RowHeadersWidth = 51;
            this.productPhotoDataGridView.RowTemplate.Height = 24;
            this.productPhotoDataGridView.Size = new System.Drawing.Size(1112, 490);
            this.productPhotoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductPhotoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductPhotoID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "ThumbNailPhoto";
            this.dataGridViewImageColumn1.HeaderText = "ThumbNailPhoto";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ThumbnailPhotoFileName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ThumbnailPhotoFileName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "LargePhoto";
            this.dataGridViewImageColumn2.HeaderText = "LargePhoto";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LargePhotoFileName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LargePhotoFileName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 98;
            this.button2.Text = "排序";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 97;
            this.label3.Text = "AWDataSetModel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 96;
            this.label4.Text = "label4";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(311, 136);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(61, 49);
            this.button16.TabIndex = 95;
            this.button16.Text = ">>";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(244, 136);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 49);
            this.button15.TabIndex = 94;
            this.button15.Text = ">";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(85, 136);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(61, 49);
            this.button14.TabIndex = 93;
            this.button14.Text = "<";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(19, 136);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(61, 49);
            this.button13.TabIndex = 92;
            this.button13.Text = "<<";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(761, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 23);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 90;
            this.label2.Text = "Year:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 29);
            this.button1.TabIndex = 88;
            this.button1.Text = " 某 日期區間 的腳踏車";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 82);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 25);
            this.dateTimePicker2.TabIndex = 87;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 82);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 25);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.productPhotoDataGridView);
            this.panel1.Location = new System.Drawing.Point(-5, 210);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 490);
            this.panel1.TabIndex = 99;
            // 
            // productPhotoTableAdapter
            // 
            this.productPhotoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductPhotoTableAdapter = this.productPhotoTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyHW.AWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmAdventureWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.productPhotoBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdventureWorks";
            this.Text = "FrmAdventureWorks";
            this.Load += new System.EventHandler(this.FrmAdventureWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingNavigator)).EndInit();
            this.productPhotoBindingNavigator.ResumeLayout(false);
            this.productPhotoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyHW.AWDataSet aWDataSet;
        private System.Windows.Forms.BindingSource productPhotoBindingSource;
        private MyHW.AWDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter;
        private MyHW.AWDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productPhotoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productPhotoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productPhotoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}