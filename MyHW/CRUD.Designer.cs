
namespace MyHW
{
    partial class CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            System.Windows.Forms.Label imageIDLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label imageLabel;
            this.myAlbumDataSet = new MyHW.MyAlbumDataSet();
            this.imageTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableTableAdapter = new MyHW.MyAlbumDataSetTableAdapters.ImageTableTableAdapter();
            this.tableAdapterManager = new MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager();
            this.imageTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.imageTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imageTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageIDTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            imageIDLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTableBindingNavigator)).BeginInit();
            this.imageTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myAlbumDataSet
            // 
            this.myAlbumDataSet.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageTableBindingSource
            // 
            this.imageTableBindingSource.DataMember = "ImageTable";
            this.imageTableBindingSource.DataSource = this.myAlbumDataSet;
            // 
            // imageTableTableAdapter
            // 
            this.imageTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImageTableTableAdapter = this.imageTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imageTableBindingNavigator
            // 
            this.imageTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imageTableBindingNavigator.BindingSource = this.imageTableBindingSource;
            this.imageTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imageTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imageTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.imageTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.imageTableBindingNavigatorSaveItem});
            this.imageTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imageTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imageTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imageTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imageTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imageTableBindingNavigator.Name = "imageTableBindingNavigator";
            this.imageTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imageTableBindingNavigator.Size = new System.Drawing.Size(809, 27);
            this.imageTableBindingNavigator.TabIndex = 0;
            this.imageTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 19);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // imageTableBindingNavigatorSaveItem
            // 
            this.imageTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imageTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imageTableBindingNavigatorSaveItem.Image")));
            this.imageTableBindingNavigatorSaveItem.Name = "imageTableBindingNavigatorSaveItem";
            this.imageTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.imageTableBindingNavigatorSaveItem.Text = "儲存資料";
            this.imageTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.imageTableBindingNavigatorSaveItem_Click);
            // 
            // imageTableDataGridView
            // 
            this.imageTableDataGridView.AutoGenerateColumns = false;
            this.imageTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.imageTableDataGridView.DataSource = this.imageTableBindingSource;
            this.imageTableDataGridView.Location = new System.Drawing.Point(12, 77);
            this.imageTableDataGridView.Name = "imageTableDataGridView";
            this.imageTableDataGridView.RowHeadersWidth = 51;
            this.imageTableDataGridView.RowTemplate.Height = 27;
            this.imageTableDataGridView.Size = new System.Drawing.Size(488, 256);
            this.imageTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ImageID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ImageID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn2.HeaderText = "Country";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // imageIDLabel
            // 
            imageIDLabel.AutoSize = true;
            imageIDLabel.Location = new System.Drawing.Point(506, 77);
            imageIDLabel.Name = "imageIDLabel";
            imageIDLabel.Size = new System.Drawing.Size(65, 15);
            imageIDLabel.TabIndex = 2;
            imageIDLabel.Text = "Image ID:";
            // 
            // imageIDTextBox
            // 
            this.imageIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageTableBindingSource, "ImageID", true));
            this.imageIDTextBox.Location = new System.Drawing.Point(577, 74);
            this.imageIDTextBox.Name = "imageIDTextBox";
            this.imageIDTextBox.Size = new System.Drawing.Size(191, 25);
            this.imageIDTextBox.TabIndex = 3;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(506, 108);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(57, 15);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imageTableBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(577, 105);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(191, 25);
            this.countryTextBox.TabIndex = 5;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(506, 136);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(46, 15);
            imageLabel.TabIndex = 6;
            imageLabel.Text = "Image:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imageTableBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(577, 136);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(191, 186);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 7;
            this.imagePictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "瀏覽...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(imageIDLabel);
            this.Controls.Add(this.imageIDTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.imageTableDataGridView);
            this.Controls.Add(this.imageTableBindingNavigator);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTableBindingNavigator)).EndInit();
            this.imageTableBindingNavigator.ResumeLayout(false);
            this.imageTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyAlbumDataSet myAlbumDataSet;
        private System.Windows.Forms.BindingSource imageTableBindingSource;
        private MyAlbumDataSetTableAdapters.ImageTableTableAdapter imageTableTableAdapter;
        private MyAlbumDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imageTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton imageTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView imageTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox imageIDTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}