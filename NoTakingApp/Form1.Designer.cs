namespace NoTakingApp
{
    partial class NoTaker
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
            this.txtbTitle = new System.Windows.Forms.TextBox();
            this.txtbNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prevNotes = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prevNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbTitle
            // 
            this.txtbTitle.Location = new System.Drawing.Point(302, 27);
            this.txtbTitle.Name = "txtbTitle";
            this.txtbTitle.Size = new System.Drawing.Size(486, 20);
            this.txtbTitle.TabIndex = 0;
            // 
            // txtbNote
            // 
            this.txtbNote.Location = new System.Drawing.Point(302, 70);
            this.txtbNote.Multiline = true;
            this.txtbNote.Name = "txtbNote";
            this.txtbNote.Size = new System.Drawing.Size(486, 398);
            this.txtbNote.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prevNotes
            // 
            this.prevNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prevNotes.BackgroundColor = System.Drawing.Color.White;
            this.prevNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prevNotes.GridColor = System.Drawing.Color.White;
            this.prevNotes.Location = new System.Drawing.Point(12, 12);
            this.prevNotes.Name = "prevNotes";
            this.prevNotes.Size = new System.Drawing.Size(284, 366);
            this.prevNotes.TabIndex = 4;
            this.prevNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prevNotes_CellDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(12, 384);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 39);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(155, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(155, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.BackColor = System.Drawing.Color.White;
            this.btnNewNote.Location = new System.Drawing.Point(12, 429);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(137, 39);
            this.btnNewNote.TabIndex = 8;
            this.btnNewNote.Text = "New Note";
            this.btnNewNote.UseVisualStyleBackColor = false;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // NoTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.prevNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNote);
            this.Controls.Add(this.txtbTitle);
            this.Name = "NoTaker";
            this.Text = "No Taker";
            this.Load += new System.EventHandler(this.NoTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prevNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbTitle;
        private System.Windows.Forms.TextBox txtbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView prevNotes;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewNote;
    }
}

