namespace  AnimalForm
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
            this.btnLegs = new System.Windows.Forms.Button();
            this.btnSkin = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnEats = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnUnique = new System.Windows.Forms.Button();
            this.rbtnDog = new System.Windows.Forms.RadioButton();
            this.rbtnCat = new System.Windows.Forms.RadioButton();
            this.rbtnRhino = new System.Windows.Forms.RadioButton();
            this.lblInxtns = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbtnMouse = new System.Windows.Forms.RadioButton();
            this.txtMessage1 = new System.Windows.Forms.RichTextBox();
            this.AnimalPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLegs
            // 
            this.btnLegs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLegs.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnLegs.FlatAppearance.BorderSize = 3;
            this.btnLegs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnLegs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLegs.Location = new System.Drawing.Point(12, 228);
            this.btnLegs.Name = "btnLegs";
            this.btnLegs.Size = new System.Drawing.Size(75, 23);
            this.btnLegs.TabIndex = 6;
            this.btnLegs.Text = "&Legs";
            this.btnLegs.UseVisualStyleBackColor = false;
            this.btnLegs.Click += new System.EventHandler(this.btnLegs_Click);
            // 
            // btnSkin
            // 
            this.btnSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSkin.Location = new System.Drawing.Point(12, 286);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(75, 23);
            this.btnSkin.TabIndex = 8;
            this.btnSkin.Text = "&Skin";
            this.btnSkin.UseVisualStyleBackColor = false;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // btnTalk
            // 
            this.btnTalk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTalk.Location = new System.Drawing.Point(12, 344);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(75, 23);
            this.btnTalk.TabIndex = 10;
            this.btnTalk.Text = "&Talk";
            this.btnTalk.UseVisualStyleBackColor = false;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnEats
            // 
            this.btnEats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEats.Location = new System.Drawing.Point(12, 257);
            this.btnEats.Name = "btnEats";
            this.btnEats.Size = new System.Drawing.Size(75, 23);
            this.btnEats.TabIndex = 7;
            this.btnEats.Text = "&Eat";
            this.btnEats.UseVisualStyleBackColor = false;
            this.btnEats.Click += new System.EventHandler(this.btnEats_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMove.Location = new System.Drawing.Point(12, 315);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 9;
            this.btnMove.Text = "&Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnUnique
            // 
            this.btnUnique.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnique.Location = new System.Drawing.Point(12, 373);
            this.btnUnique.Name = "btnUnique";
            this.btnUnique.Size = new System.Drawing.Size(75, 23);
            this.btnUnique.TabIndex = 11;
            this.btnUnique.Text = "&Unique";
            this.btnUnique.UseVisualStyleBackColor = false;
            this.btnUnique.Click += new System.EventHandler(this.btnUnique_Click);
            // 
            // rbtnDog
            // 
            this.rbtnDog.AutoSize = true;
            this.rbtnDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnDog.Location = new System.Drawing.Point(29, 79);
            this.rbtnDog.Name = "rbtnDog";
            this.rbtnDog.Size = new System.Drawing.Size(48, 17);
            this.rbtnDog.TabIndex = 3;
            this.rbtnDog.TabStop = true;
            this.rbtnDog.Text = "Dog";
            this.rbtnDog.UseVisualStyleBackColor = true;
            // 
            // rbtnCat
            // 
            this.rbtnCat.AutoSize = true;
            this.rbtnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnCat.Location = new System.Drawing.Point(29, 102);
            this.rbtnCat.Name = "rbtnCat";
            this.rbtnCat.Size = new System.Drawing.Size(44, 17);
            this.rbtnCat.TabIndex = 4;
            this.rbtnCat.TabStop = true;
            this.rbtnCat.Text = "Cat";
            this.rbtnCat.UseVisualStyleBackColor = true;
            // 
            // rbtnRhino
            // 
            this.rbtnRhino.AutoSize = true;
            this.rbtnRhino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRhino.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnRhino.Location = new System.Drawing.Point(29, 125);
            this.rbtnRhino.Name = "rbtnRhino";
            this.rbtnRhino.Size = new System.Drawing.Size(58, 17);
            this.rbtnRhino.TabIndex = 5;
            this.rbtnRhino.TabStop = true;
            this.rbtnRhino.Text = "Rhino";
            this.rbtnRhino.UseVisualStyleBackColor = true;
            // 
            // lblInxtns
            // 
            this.lblInxtns.AutoSize = true;
            this.lblInxtns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInxtns.Location = new System.Drawing.Point(27, 29);
            this.lblInxtns.Name = "lblInxtns";
            this.lblInxtns.Size = new System.Drawing.Size(352, 13);
            this.lblInxtns.TabIndex = 0;
            this.lblInxtns.Text = "Select an Animal, then you may select a button to view its characteristics ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(141, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbtnMouse
            // 
            this.rbtnMouse.AutoSize = true;
            this.rbtnMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMouse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnMouse.Location = new System.Drawing.Point(29, 56);
            this.rbtnMouse.Name = "rbtnMouse";
            this.rbtnMouse.Size = new System.Drawing.Size(62, 17);
            this.rbtnMouse.TabIndex = 2;
            this.rbtnMouse.TabStop = true;
            this.rbtnMouse.Text = "Mouse";
            this.rbtnMouse.UseVisualStyleBackColor = true;
            // 
            // txtMessage1
            // 
            this.txtMessage1.Location = new System.Drawing.Point(116, 55);
            this.txtMessage1.Name = "txtMessage1";
            this.txtMessage1.Size = new System.Drawing.Size(244, 40);
            this.txtMessage1.TabIndex = 13;
            this.txtMessage1.Text = "";
            this.txtMessage1.Visible = false;
            // 
            // AnimalPicture
            // 
            this.AnimalPicture.Image = global::AnimalForm.Properties.Resources.rhinoagain;
            this.AnimalPicture.Location = new System.Drawing.Point(97, 125);
            this.AnimalPicture.Name = "AnimalPicture";
            this.AnimalPicture.Size = new System.Drawing.Size(299, 242);
            this.AnimalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimalPicture.TabIndex = 12;
            this.AnimalPicture.TabStop = false;
            this.AnimalPicture.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(419, 421);
            this.Controls.Add(this.txtMessage1);
            this.Controls.Add(this.AnimalPicture);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInxtns);
            this.Controls.Add(this.rbtnRhino);
            this.Controls.Add(this.rbtnCat);
            this.Controls.Add(this.rbtnDog);
            this.Controls.Add(this.btnUnique);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnEats);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.btnSkin);
            this.Controls.Add(this.btnLegs);
            this.Controls.Add(this.rbtnMouse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Animal Form";
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

private System.Windows.Forms.RadioButton rbtnMouse;
private System.Windows.Forms.Button btnLegs;
private System.Windows.Forms.Button btnSkin;
private System.Windows.Forms.Button btnTalk;
private System.Windows.Forms.Button btnEats;
private System.Windows.Forms.Button btnMove;
private System.Windows.Forms.Button btnUnique;
private System.Windows.Forms.RadioButton rbtnDog;
private System.Windows.Forms.RadioButton rbtnCat;
private System.Windows.Forms.RadioButton rbtnRhino;
private System.Windows.Forms.Label lblInxtns;
private System.Windows.Forms.Button btnExit;
private System.Windows.Forms.PictureBox AnimalPicture;
private System.Windows.Forms.RichTextBox txtMessage1;
    }
}