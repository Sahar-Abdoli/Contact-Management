namespace Contact
{
	partial class ContactForm
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
			this.AddButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.NameTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FamilyTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PhoneTextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EmailTextbox = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(12, 27);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(146, 23);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "Add Contact";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddContact);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(322, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete Contact";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.DeleteButton);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(164, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Edit Contact";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.EditContact);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			// 
			// NameTextbox
			// 
			this.NameTextbox.Location = new System.Drawing.Point(140, 67);
			this.NameTextbox.Name = "NameTextbox";
			this.NameTextbox.Size = new System.Drawing.Size(330, 20);
			this.NameTextbox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Family";
			// 
			// FamilyTextbox
			// 
			this.FamilyTextbox.Location = new System.Drawing.Point(140, 95);
			this.FamilyTextbox.Name = "FamilyTextbox";
			this.FamilyTextbox.Size = new System.Drawing.Size(330, 20);
			this.FamilyTextbox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Phone";
			// 
			// PhoneTextbox
			// 
			this.PhoneTextbox.Location = new System.Drawing.Point(140, 124);
			this.PhoneTextbox.Name = "PhoneTextbox";
			this.PhoneTextbox.Size = new System.Drawing.Size(330, 20);
			this.PhoneTextbox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Email";
			// 
			// EmailTextbox
			// 
			this.EmailTextbox.Location = new System.Drawing.Point(140, 152);
			this.EmailTextbox.Name = "EmailTextbox";
			this.EmailTextbox.Size = new System.Drawing.Size(330, 20);
			this.EmailTextbox.TabIndex = 10;
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.F,
            this.P,
            this.E,
            this.i});
			this.dataGridView.Location = new System.Drawing.Point(12, 198);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(458, 214);
			this.dataGridView.TabIndex = 11;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// N
			// 
			this.N.HeaderText = "Name";
			this.N.Name = "N";
			// 
			// F
			// 
			this.F.HeaderText = "Family";
			this.F.Name = "F";
			// 
			// P
			// 
			this.P.HeaderText = "Phone";
			this.P.Name = "P";
			// 
			// E
			// 
			this.E.HeaderText = "Email";
			this.E.Name = "E";
			// 
			// i
			// 
			this.i.HeaderText = "I";
			this.i.Name = "i";
			this.i.Visible = false;
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 433);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.EmailTextbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.PhoneTextbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FamilyTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameTextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.AddButton);
			this.Name = "ContactForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact management";
			this.Load += new System.EventHandler(this.ContactForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NameTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FamilyTextbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PhoneTextbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox EmailTextbox;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn N;
		private System.Windows.Forms.DataGridViewTextBoxColumn F;
		private System.Windows.Forms.DataGridViewTextBoxColumn P;
		private System.Windows.Forms.DataGridViewTextBoxColumn E;
		private System.Windows.Forms.DataGridViewTextBoxColumn i;
	}
}

