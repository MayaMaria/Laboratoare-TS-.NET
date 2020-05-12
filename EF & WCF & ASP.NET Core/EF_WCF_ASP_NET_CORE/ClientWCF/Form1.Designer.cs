namespace ClientWCF
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewComment = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.extensionDataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extensionDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postPostIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComment
            // 
            this.dataGridViewComment.AutoGenerateColumns = false;
            this.dataGridViewComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extensionDataDataGridViewTextBoxColumn,
            this.commentIdDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.postPostIdDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn});
            this.dataGridViewComment.DataSource = this.commentBindingSource;
            this.dataGridViewComment.Location = new System.Drawing.Point(28, 29);
            this.dataGridViewComment.Name = "dataGridViewComment";
            this.dataGridViewComment.Size = new System.Drawing.Size(335, 375);
            this.dataGridViewComment.TabIndex = 0;
            this.dataGridViewComment.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgp_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extensionDataDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.domainDataGridViewTextBoxColumn,
            this.postIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.postBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(409, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(362, 375);
            this.dataGridView2.TabIndex = 1;
            // 
            // extensionDataDataGridViewTextBoxColumn1
            // 
            this.extensionDataDataGridViewTextBoxColumn1.DataPropertyName = "ExtensionData";
            this.extensionDataDataGridViewTextBoxColumn1.HeaderText = "ExtensionData";
            this.extensionDataDataGridViewTextBoxColumn1.Name = "extensionDataDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // domainDataGridViewTextBoxColumn
            // 
            this.domainDataGridViewTextBoxColumn.DataPropertyName = "Domain";
            this.domainDataGridViewTextBoxColumn.HeaderText = "Domain";
            this.domainDataGridViewTextBoxColumn.Name = "domainDataGridViewTextBoxColumn";
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(PostComment.Post);
            // 
            // extensionDataDataGridViewTextBoxColumn
            // 
            this.extensionDataDataGridViewTextBoxColumn.DataPropertyName = "ExtensionData";
            this.extensionDataDataGridViewTextBoxColumn.HeaderText = "ExtensionData";
            this.extensionDataDataGridViewTextBoxColumn.Name = "extensionDataDataGridViewTextBoxColumn";
            // 
            // commentIdDataGridViewTextBoxColumn
            // 
            this.commentIdDataGridViewTextBoxColumn.DataPropertyName = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.HeaderText = "CommentId";
            this.commentIdDataGridViewTextBoxColumn.Name = "commentIdDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // postPostIdDataGridViewTextBoxColumn
            // 
            this.postPostIdDataGridViewTextBoxColumn.DataPropertyName = "PostPostId";
            this.postPostIdDataGridViewTextBoxColumn.HeaderText = "PostPostId";
            this.postPostIdDataGridViewTextBoxColumn.Name = "postPostIdDataGridViewTextBoxColumn";
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(PostComment.Comment);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewComment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComment;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postPostIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}

