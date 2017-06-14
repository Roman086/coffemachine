/*
 * Created by SharpDevelop.
 * User: Roman
 * Date: 12.06.2017
 * Time: 20:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cofe
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.por1 = new System.Windows.Forms.Label();
			this.por2 = new System.Windows.Forms.Label();
			this.por3 = new System.Windows.Forms.Label();
			this.por4 = new System.Windows.Forms.Label();
			this.por5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label_money = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label_sdacha = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(-2, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Виды кофе";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Вид 1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(12, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 38);
			this.button2.TabIndex = 2;
			this.button2.Text = "Вид 2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(12, 281);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(92, 38);
			this.button3.TabIndex = 3;
			this.button3.Text = "Вид 3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(12, 325);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(92, 38);
			this.button4.TabIndex = 4;
			this.button4.Text = "Вид 4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(12, 369);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(92, 38);
			this.button5.TabIndex = 5;
			this.button5.Text = "Вид 5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(249, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Осталось порций";
			// 
			// por1
			// 
			this.por1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.por1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.por1.Location = new System.Drawing.Point(253, 194);
			this.por1.Name = "por1";
			this.por1.Size = new System.Drawing.Size(74, 38);
			this.por1.TabIndex = 7;
			this.por1.Text = "20";
			this.por1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// por2
			// 
			this.por2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.por2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.por2.Location = new System.Drawing.Point(253, 237);
			this.por2.Name = "por2";
			this.por2.Size = new System.Drawing.Size(75, 38);
			this.por2.TabIndex = 8;
			this.por2.Text = "20";
			this.por2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// por3
			// 
			this.por3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.por3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.por3.Location = new System.Drawing.Point(253, 281);
			this.por3.Name = "por3";
			this.por3.Size = new System.Drawing.Size(75, 38);
			this.por3.TabIndex = 9;
			this.por3.Text = "20";
			this.por3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// por4
			// 
			this.por4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.por4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.por4.Location = new System.Drawing.Point(253, 325);
			this.por4.Name = "por4";
			this.por4.Size = new System.Drawing.Size(74, 38);
			this.por4.TabIndex = 10;
			this.por4.Text = "20";
			this.por4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// por5
			// 
			this.por5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.por5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.por5.Location = new System.Drawing.Point(253, 369);
			this.por5.Name = "por5";
			this.por5.Size = new System.Drawing.Size(75, 38);
			this.por5.TabIndex = 11;
			this.por5.Text = "20";
			this.por5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(117, 167);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 22);
			this.label8.TabIndex = 12;
			this.label8.Text = "Цена порции";
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(123, 193);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 37);
			this.label9.TabIndex = 13;
			this.label9.Text = "45";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(123, 238);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(101, 37);
			this.label10.TabIndex = 14;
			this.label10.Text = "50";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(123, 282);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(101, 37);
			this.label11.TabIndex = 15;
			this.label11.Text = "55";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(123, 325);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(101, 37);
			this.label12.TabIndex = 16;
			this.label12.Text = "60";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(123, 370);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(101, 37);
			this.label13.TabIndex = 17;
			this.label13.Text = "65";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 50;
			this.trackBar1.Location = new System.Drawing.Point(12, 71);
			this.trackBar1.Maximum = 500;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(583, 45);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 18;
			this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1Scroll);
			// 
			// label_money
			// 
			this.label_money.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_money.Location = new System.Drawing.Point(166, 114);
			this.label_money.Name = "label_money";
			this.label_money.Size = new System.Drawing.Size(140, 44);
			this.label_money.TabIndex = 19;
			this.label_money.Text = "0 руб.";
			this.label_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(12, 28);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(333, 40);
			this.label14.TabIndex = 20;
			this.label14.Text = "Внести деньги:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(12, 119);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(148, 39);
			this.label15.TabIndex = 21;
			this.label15.Text = "Вы внесли";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(413, 237);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(182, 37);
			this.label16.TabIndex = 22;
			this.label16.Text = "Осталось сдачи:";
			// 
			// label_sdacha
			// 
			this.label_sdacha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label_sdacha.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_sdacha.Location = new System.Drawing.Point(413, 282);
			this.label_sdacha.Name = "label_sdacha";
			this.label_sdacha.Size = new System.Drawing.Size(182, 36);
			this.label_sdacha.TabIndex = 23;
			this.label_sdacha.Text = "1000 руб.";
			this.label_sdacha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 415);
			this.Controls.Add(this.label_sdacha);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label_money);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.por5);
			this.Controls.Add(this.por4);
			this.Controls.Add(this.por3);
			this.Controls.Add(this.por2);
			this.Controls.Add(this.por1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Кофейный автомат";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label_sdacha;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label_money;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label por5;
		private System.Windows.Forms.Label por4;
		private System.Windows.Forms.Label por3;
		private System.Windows.Forms.Label por2;
		private System.Windows.Forms.Label por1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
