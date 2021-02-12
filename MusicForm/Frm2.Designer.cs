
namespace MusicForm
{
    partial class Frm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.tBGenre = new System.Windows.Forms.TextBox();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.tBRating = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Label();
            this.dateTimePickerSortie = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Music";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rating";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tBTitle
            // 
            this.tBTitle.Location = new System.Drawing.Point(23, 135);
            this.tBTitle.Multiline = true;
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(313, 40);
            this.tBTitle.TabIndex = 7;
            // 
            // tBGenre
            // 
            this.tBGenre.Location = new System.Drawing.Point(23, 361);
            this.tBGenre.Multiline = true;
            this.tBGenre.Name = "tBGenre";
            this.tBGenre.Size = new System.Drawing.Size(313, 40);
            this.tBGenre.TabIndex = 9;
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(23, 475);
            this.tBPrice.Multiline = true;
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(313, 40);
            this.tBPrice.TabIndex = 10;
            this.tBPrice.TextChanged += new System.EventHandler(this.tBPrice_TextChanged);
            // 
            // tBRating
            // 
            this.tBRating.Location = new System.Drawing.Point(23, 603);
            this.tBRating.Multiline = true;
            this.tBRating.Name = "tBRating";
            this.tBRating.Size = new System.Drawing.Size(313, 40);
            this.tBRating.TabIndex = 11;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(23, 681);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(120, 69);
            this.BtnCreate.TabIndex = 12;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Back.Location = new System.Drawing.Point(296, 718);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(119, 32);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back to List";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dateTimePickerSortie
            // 
            this.dateTimePickerSortie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSortie.Location = new System.Drawing.Point(23, 258);
            this.dateTimePickerSortie.Name = "dateTimePickerSortie";
            this.dateTimePickerSortie.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSortie.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 787);
            this.Controls.Add(this.dateTimePickerSortie);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.tBRating);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.tBGenre);
            this.Controls.Add(this.tBTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Frm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une musique";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.TextBox tBGenre;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.TextBox tBRating;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.DateTimePicker dateTimePickerSortie;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}