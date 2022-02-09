
namespace NotHesaplamaUygulaması
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.finalorttxt = new System.Windows.Forms.Label();
			this.vizeorttxt = new System.Windows.Forms.Label();
			this.ödevorttxt = new System.Windows.Forms.Label();
			this.finalorttxtbox = new System.Windows.Forms.TextBox();
			this.vizeorttxtbox = new System.Windows.Forms.TextBox();
			this.ödevorttxtbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ödevtxtbox = new System.Windows.Forms.TextBox();
			this.vizetxtbox = new System.Windows.Forms.TextBox();
			this.finaltxtbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.finalvizeödevtxt = new System.Windows.Forms.Label();
			this.sonuçtxt = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.otobtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// finalorttxt
			// 
			this.finalorttxt.AutoSize = true;
			this.finalorttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.finalorttxt.Location = new System.Drawing.Point(32, 33);
			this.finalorttxt.Name = "finalorttxt";
			this.finalorttxt.Size = new System.Drawing.Size(94, 13);
			this.finalorttxt.TabIndex = 0;
			this.finalorttxt.Text = "Final Etki Oranı\r\n";
			this.finalorttxt.Click += new System.EventHandler(this.label1_Click);
			// 
			// vizeorttxt
			// 
			this.vizeorttxt.AutoSize = true;
			this.vizeorttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.vizeorttxt.Location = new System.Drawing.Point(32, 82);
			this.vizeorttxt.Name = "vizeorttxt";
			this.vizeorttxt.Size = new System.Drawing.Size(91, 13);
			this.vizeorttxt.TabIndex = 1;
			this.vizeorttxt.Text = "Vize Etki Oranı\r\n";
			this.vizeorttxt.Click += new System.EventHandler(this.label2_Click);
			// 
			// ödevorttxt
			// 
			this.ödevorttxt.AutoSize = true;
			this.ödevorttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ödevorttxt.Location = new System.Drawing.Point(32, 129);
			this.ödevorttxt.Name = "ödevorttxt";
			this.ödevorttxt.Size = new System.Drawing.Size(97, 13);
			this.ödevorttxt.TabIndex = 2;
			this.ödevorttxt.Text = "Ödev Etki Oranı\r\n";
			// 
			// finalorttxtbox
			// 
			this.finalorttxtbox.Location = new System.Drawing.Point(178, 33);
			this.finalorttxtbox.Multiline = true;
			this.finalorttxtbox.Name = "finalorttxtbox";
			this.finalorttxtbox.Size = new System.Drawing.Size(52, 29);
			this.finalorttxtbox.TabIndex = 3;
			this.finalorttxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// vizeorttxtbox
			// 
			this.vizeorttxtbox.Location = new System.Drawing.Point(178, 82);
			this.vizeorttxtbox.Multiline = true;
			this.vizeorttxtbox.Name = "vizeorttxtbox";
			this.vizeorttxtbox.Size = new System.Drawing.Size(52, 29);
			this.vizeorttxtbox.TabIndex = 4;
			// 
			// ödevorttxtbox
			// 
			this.ödevorttxtbox.Location = new System.Drawing.Point(178, 129);
			this.ödevorttxtbox.Multiline = true;
			this.ödevorttxtbox.Name = "ödevorttxtbox";
			this.ödevorttxtbox.Size = new System.Drawing.Size(52, 29);
			this.ödevorttxtbox.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(345, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 49);
			this.button1.TabIndex = 6;
			this.button1.Text = "Göster";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Göster_Click);
			// 
			// ödevtxtbox
			// 
			this.ödevtxtbox.Location = new System.Drawing.Point(177, 124);
			this.ödevtxtbox.Multiline = true;
			this.ödevtxtbox.Name = "ödevtxtbox";
			this.ödevtxtbox.Size = new System.Drawing.Size(52, 29);
			this.ödevtxtbox.TabIndex = 12;
			// 
			// vizetxtbox
			// 
			this.vizetxtbox.Location = new System.Drawing.Point(177, 77);
			this.vizetxtbox.Multiline = true;
			this.vizetxtbox.Name = "vizetxtbox";
			this.vizetxtbox.Size = new System.Drawing.Size(52, 29);
			this.vizetxtbox.TabIndex = 11;
			// 
			// finaltxtbox
			// 
			this.finaltxtbox.Location = new System.Drawing.Point(177, 28);
			this.finaltxtbox.Multiline = true;
			this.finaltxtbox.Name = "finaltxtbox";
			this.finaltxtbox.Size = new System.Drawing.Size(52, 29);
			this.finaltxtbox.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(43, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Ödev Notu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(43, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Vize Notu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(43, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Final Notu";
			// 
			// finalvizeödevtxt
			// 
			this.finalvizeödevtxt.AutoSize = true;
			this.finalvizeödevtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.finalvizeödevtxt.Location = new System.Drawing.Point(151, 361);
			this.finalvizeödevtxt.Name = "finalvizeödevtxt";
			this.finalvizeödevtxt.Size = new System.Drawing.Size(106, 15);
			this.finalvizeödevtxt.TabIndex = 13;
			this.finalvizeödevtxt.Text = "Final Vize Ödev";
			this.finalvizeödevtxt.Click += new System.EventHandler(this.label4_Click);
			// 
			// sonuçtxt
			// 
			this.sonuçtxt.AutoSize = true;
			this.sonuçtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sonuçtxt.Location = new System.Drawing.Point(151, 397);
			this.sonuçtxt.Name = "sonuçtxt";
			this.sonuçtxt.Size = new System.Drawing.Size(47, 15);
			this.sonuçtxt.TabIndex = 14;
			this.sonuçtxt.Text = "Sonuç";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(253, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(265, 24);
			this.label4.TabIndex = 15;
			this.label4.Text = "Not Hesaplama Uygulaması";
			this.label4.Click += new System.EventHandler(this.label4_Click_1);
			// 
			// otobtn
			// 
			this.otobtn.BackColor = System.Drawing.Color.Black;
			this.otobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.otobtn.ForeColor = System.Drawing.Color.White;
			this.otobtn.Location = new System.Drawing.Point(90, 163);
			this.otobtn.Name = "otobtn";
			this.otobtn.Size = new System.Drawing.Size(75, 31);
			this.otobtn.TabIndex = 16;
			this.otobtn.Text = "OTO";
			this.otobtn.UseVisualStyleBackColor = false;
			this.otobtn.Click += new System.EventHandler(this.otobtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
			this.groupBox1.Controls.Add(this.vizeorttxtbox);
			this.groupBox1.Controls.Add(this.otobtn);
			this.groupBox1.Controls.Add(this.finalorttxt);
			this.groupBox1.Controls.Add(this.vizeorttxt);
			this.groupBox1.Controls.Add(this.ödevorttxt);
			this.groupBox1.Controls.Add(this.finalorttxtbox);
			this.groupBox1.Controls.Add(this.ödevorttxtbox);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(51, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 209);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Etki Oranı%";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
			this.groupBox2.Controls.Add(this.ödevtxtbox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.finaltxtbox);
			this.groupBox2.Controls.Add(this.vizetxtbox);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(483, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(269, 209);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Not";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.sonuçtxt);
			this.Controls.Add(this.finalvizeödevtxt);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label finalorttxt;
		private System.Windows.Forms.Label vizeorttxt;
		private System.Windows.Forms.Label ödevorttxt;
		private System.Windows.Forms.TextBox finalorttxtbox;
		private System.Windows.Forms.TextBox vizeorttxtbox;
		private System.Windows.Forms.TextBox ödevorttxtbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox ödevtxtbox;
		private System.Windows.Forms.TextBox vizetxtbox;
		private System.Windows.Forms.TextBox finaltxtbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label finalvizeödevtxt;
		private System.Windows.Forms.Label sonuçtxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button otobtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

