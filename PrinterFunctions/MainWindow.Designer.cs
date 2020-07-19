namespace PrinterFunctions
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPauseSelected = new System.Windows.Forms.Button();
            this.btnResumeSelected = new System.Windows.Forms.Button();
            this.cbQueue = new System.Windows.Forms.ComboBox();
            this.btnReloadQueues = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(0, 115);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(438, 44);
            this.btnDeleteAll.TabIndex = 0;
            this.btnDeleteAll.Text = "Delete All ";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPauseSelected, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnResumeSelected, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 41);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnPauseSelected
            // 
            this.btnPauseSelected.BackColor = System.Drawing.Color.Green;
            this.btnPauseSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPauseSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseSelected.ForeColor = System.Drawing.Color.White;
            this.btnPauseSelected.Location = new System.Drawing.Point(222, 3);
            this.btnPauseSelected.Name = "btnPauseSelected";
            this.btnPauseSelected.Size = new System.Drawing.Size(213, 35);
            this.btnPauseSelected.TabIndex = 3;
            this.btnPauseSelected.Text = "Pause Selected";
            this.btnPauseSelected.UseVisualStyleBackColor = false;
            this.btnPauseSelected.Click += new System.EventHandler(this.btnResumeAll_Click);
            // 
            // btnResumeSelected
            // 
            this.btnResumeSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btnResumeSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResumeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeSelected.Location = new System.Drawing.Point(3, 3);
            this.btnResumeSelected.Name = "btnResumeSelected";
            this.btnResumeSelected.Size = new System.Drawing.Size(213, 35);
            this.btnResumeSelected.TabIndex = 2;
            this.btnResumeSelected.Text = "Resume Selected";
            this.btnResumeSelected.UseVisualStyleBackColor = false;
            this.btnResumeSelected.Click += new System.EventHandler(this.btnResumeSelected_Click);
            // 
            // cbQueue
            // 
            this.cbQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbQueue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQueue.FormattingEnabled = true;
            this.cbQueue.Location = new System.Drawing.Point(0, 0);
            this.cbQueue.Name = "cbQueue";
            this.cbQueue.Size = new System.Drawing.Size(438, 32);
            this.cbQueue.TabIndex = 2;
            // 
            // btnReloadQueues
            // 
            this.btnReloadQueues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.btnReloadQueues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReloadQueues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadQueues.ForeColor = System.Drawing.Color.White;
            this.btnReloadQueues.Location = new System.Drawing.Point(0, 32);
            this.btnReloadQueues.Name = "btnReloadQueues";
            this.btnReloadQueues.Size = new System.Drawing.Size(438, 42);
            this.btnReloadQueues.TabIndex = 3;
            this.btnReloadQueues.Text = "Reload Queues";
            this.btnReloadQueues.UseVisualStyleBackColor = false;
            this.btnReloadQueues.Click += new System.EventHandler(this.btnReloadQueues_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 159);
            this.Controls.Add(this.btnReloadQueues);
            this.Controls.Add(this.cbQueue);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDeleteAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Printer Job Quick Tool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPauseSelected;
        private System.Windows.Forms.Button btnResumeSelected;
        private System.Windows.Forms.ComboBox cbQueue;
        private System.Windows.Forms.Button btnReloadQueues;
    }
}

