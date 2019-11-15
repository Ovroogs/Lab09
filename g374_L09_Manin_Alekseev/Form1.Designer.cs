namespace g374_L09_Manin_Alekseev
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g374_Manin_AlekseevDataSet = new g374_L09_Manin_Alekseev.g374_Manin_AlekseevDataSet();
            this.l09planetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l09_planetsTableAdapter = new g374_L09_Manin_Alekseev.g374_Manin_AlekseevDataSetTableAdapters.l09_planetsTableAdapter();
            this.planetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceFromSunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imhabinatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g374_Manin_AlekseevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l09planetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planetNameDataGridViewTextBoxColumn,
            this.distanceFromSunDataGridViewTextBoxColumn,
            this.imhabinatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.l09planetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // g374_Manin_AlekseevDataSet
            // 
            this.g374_Manin_AlekseevDataSet.DataSetName = "g374_Manin_AlekseevDataSet";
            this.g374_Manin_AlekseevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // l09planetsBindingSource
            // 
            this.l09planetsBindingSource.DataMember = "l09-planets";
            this.l09planetsBindingSource.DataSource = this.g374_Manin_AlekseevDataSet;
            // 
            // l09_planetsTableAdapter
            // 
            this.l09_planetsTableAdapter.ClearBeforeFill = true;
            // 
            // planetNameDataGridViewTextBoxColumn
            // 
            this.planetNameDataGridViewTextBoxColumn.DataPropertyName = "PlanetName";
            this.planetNameDataGridViewTextBoxColumn.HeaderText = "PlanetName";
            this.planetNameDataGridViewTextBoxColumn.Name = "planetNameDataGridViewTextBoxColumn";
            // 
            // distanceFromSunDataGridViewTextBoxColumn
            // 
            this.distanceFromSunDataGridViewTextBoxColumn.DataPropertyName = "DistanceFromSun";
            this.distanceFromSunDataGridViewTextBoxColumn.HeaderText = "DistanceFromSun";
            this.distanceFromSunDataGridViewTextBoxColumn.Name = "distanceFromSunDataGridViewTextBoxColumn";
            // 
            // imhabinatsDataGridViewTextBoxColumn
            // 
            this.imhabinatsDataGridViewTextBoxColumn.DataPropertyName = "Imhabinats";
            this.imhabinatsDataGridViewTextBoxColumn.HeaderText = "Imhabinats";
            this.imhabinatsDataGridViewTextBoxColumn.Name = "imhabinatsDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "g374_L09_Manin_Alekseev";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g374_Manin_AlekseevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l09planetsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private g374_Manin_AlekseevDataSet g374_Manin_AlekseevDataSet;
        private System.Windows.Forms.BindingSource l09planetsBindingSource;
        private g374_Manin_AlekseevDataSetTableAdapters.l09_planetsTableAdapter l09_planetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceFromSunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imhabinatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

