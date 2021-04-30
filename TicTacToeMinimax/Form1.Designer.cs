
namespace TicTacToeMinimax
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tile9 = new System.Windows.Forms.Button();
            this.Tile8 = new System.Windows.Forms.Button();
            this.Tile7 = new System.Windows.Forms.Button();
            this.Tile6 = new System.Windows.Forms.Button();
            this.Tile5 = new System.Windows.Forms.Button();
            this.Tile4 = new System.Windows.Forms.Button();
            this.Tile3 = new System.Windows.Forms.Button();
            this.Tile2 = new System.Windows.Forms.Button();
            this.Tile1 = new System.Windows.Forms.Button();
            this.Player1Label = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.MultipleGamesLabel = new System.Windows.Forms.Label();
            this.MultipleGamesNumericSelect = new System.Windows.Forms.NumericUpDown();
            this.MultipleGamesCheck = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.Player2SearchLabel = new System.Windows.Forms.Label();
            this.Player2NumericSelect = new System.Windows.Forms.NumericUpDown();
            this.Player1SearchLabel = new System.Windows.Forms.Label();
            this.Player1NumericSelect = new System.Windows.Forms.NumericUpDown();
            this.Player2Combo = new System.Windows.Forms.ComboBox();
            this.Player1Combo = new System.Windows.Forms.ComboBox();
            this.Player2Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.GamePanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleGamesNumericSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2NumericSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1NumericSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(324, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(166, 35);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Tic-Tac-Toe";
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.Control;
            this.GamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GamePanel.Controls.Add(this.label4);
            this.GamePanel.Controls.Add(this.label3);
            this.GamePanel.Controls.Add(this.label2);
            this.GamePanel.Controls.Add(this.label1);
            this.GamePanel.Controls.Add(this.Tile9);
            this.GamePanel.Controls.Add(this.Tile8);
            this.GamePanel.Controls.Add(this.Tile7);
            this.GamePanel.Controls.Add(this.Tile6);
            this.GamePanel.Controls.Add(this.Tile5);
            this.GamePanel.Controls.Add(this.Tile4);
            this.GamePanel.Controls.Add(this.Tile3);
            this.GamePanel.Controls.Add(this.Tile2);
            this.GamePanel.Controls.Add(this.Tile1);
            this.GamePanel.Location = new System.Drawing.Point(29, 74);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(400, 400);
            this.GamePanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 5);
            this.label4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(-2, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 5);
            this.label3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(260, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 403);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(133, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 403);
            this.label1.TabIndex = 10;
            // 
            // Tile9
            // 
            this.Tile9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile9.Location = new System.Drawing.Point(276, 283);
            this.Tile9.Name = "Tile9";
            this.Tile9.Size = new System.Drawing.Size(100, 100);
            this.Tile9.TabIndex = 8;
            this.Tile9.UseVisualStyleBackColor = false;
            this.Tile9.Click += new System.EventHandler(this.Tile9_Click);
            // 
            // Tile8
            // 
            this.Tile8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile8.Location = new System.Drawing.Point(149, 283);
            this.Tile8.Name = "Tile8";
            this.Tile8.Size = new System.Drawing.Size(100, 100);
            this.Tile8.TabIndex = 7;
            this.Tile8.UseVisualStyleBackColor = false;
            this.Tile8.Click += new System.EventHandler(this.Tile8_Click);
            // 
            // Tile7
            // 
            this.Tile7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile7.Location = new System.Drawing.Point(20, 283);
            this.Tile7.Name = "Tile7";
            this.Tile7.Size = new System.Drawing.Size(100, 100);
            this.Tile7.TabIndex = 6;
            this.Tile7.UseVisualStyleBackColor = false;
            this.Tile7.Click += new System.EventHandler(this.Tile7_Click);
            // 
            // Tile6
            // 
            this.Tile6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile6.Location = new System.Drawing.Point(276, 148);
            this.Tile6.Name = "Tile6";
            this.Tile6.Size = new System.Drawing.Size(100, 100);
            this.Tile6.TabIndex = 5;
            this.Tile6.UseVisualStyleBackColor = false;
            this.Tile6.Click += new System.EventHandler(this.Tile6_Click);
            // 
            // Tile5
            // 
            this.Tile5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile5.Location = new System.Drawing.Point(149, 148);
            this.Tile5.Name = "Tile5";
            this.Tile5.Size = new System.Drawing.Size(100, 100);
            this.Tile5.TabIndex = 4;
            this.Tile5.UseVisualStyleBackColor = false;
            this.Tile5.Click += new System.EventHandler(this.Tile5_Click);
            // 
            // Tile4
            // 
            this.Tile4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile4.Location = new System.Drawing.Point(20, 148);
            this.Tile4.Name = "Tile4";
            this.Tile4.Size = new System.Drawing.Size(100, 100);
            this.Tile4.TabIndex = 3;
            this.Tile4.UseVisualStyleBackColor = false;
            this.Tile4.Click += new System.EventHandler(this.Tile4_Click);
            // 
            // Tile3
            // 
            this.Tile3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile3.Location = new System.Drawing.Point(276, 14);
            this.Tile3.Name = "Tile3";
            this.Tile3.Size = new System.Drawing.Size(100, 100);
            this.Tile3.TabIndex = 2;
            this.Tile3.UseVisualStyleBackColor = false;
            this.Tile3.Click += new System.EventHandler(this.Tile3_Click);
            // 
            // Tile2
            // 
            this.Tile2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile2.Location = new System.Drawing.Point(149, 14);
            this.Tile2.Name = "Tile2";
            this.Tile2.Size = new System.Drawing.Size(100, 100);
            this.Tile2.TabIndex = 1;
            this.Tile2.UseVisualStyleBackColor = false;
            this.Tile2.Click += new System.EventHandler(this.Tile2_Click);
            // 
            // Tile1
            // 
            this.Tile1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tile1.Location = new System.Drawing.Point(20, 14);
            this.Tile1.Name = "Tile1";
            this.Tile1.Size = new System.Drawing.Size(100, 100);
            this.Tile1.TabIndex = 0;
            this.Tile1.UseVisualStyleBackColor = false;
            this.Tile1.Click += new System.EventHandler(this.Tile1_Click);
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(107, 19);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(86, 23);
            this.Player1Label.TabIndex = 2;
            this.Player1Label.Text = "Player 1:";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.MultipleGamesLabel);
            this.SettingsPanel.Controls.Add(this.MultipleGamesNumericSelect);
            this.SettingsPanel.Controls.Add(this.MultipleGamesCheck);
            this.SettingsPanel.Controls.Add(this.ResetButton);
            this.SettingsPanel.Controls.Add(this.StartButton);
            this.SettingsPanel.Controls.Add(this.Player2SearchLabel);
            this.SettingsPanel.Controls.Add(this.Player2NumericSelect);
            this.SettingsPanel.Controls.Add(this.Player1SearchLabel);
            this.SettingsPanel.Controls.Add(this.Player1NumericSelect);
            this.SettingsPanel.Controls.Add(this.Player2Combo);
            this.SettingsPanel.Controls.Add(this.Player1Combo);
            this.SettingsPanel.Controls.Add(this.Player2Label);
            this.SettingsPanel.Controls.Add(this.Player1Label);
            this.SettingsPanel.Location = new System.Drawing.Point(465, 71);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(290, 402);
            this.SettingsPanel.TabIndex = 3;
            // 
            // MultipleGamesLabel
            // 
            this.MultipleGamesLabel.AutoSize = true;
            this.MultipleGamesLabel.Location = new System.Drawing.Point(44, 356);
            this.MultipleGamesLabel.Name = "MultipleGamesLabel";
            this.MultipleGamesLabel.Size = new System.Drawing.Size(92, 13);
            this.MultipleGamesLabel.TabIndex = 14;
            this.MultipleGamesLabel.Text = "Number of Games";
            // 
            // MultipleGamesNumericSelect
            // 
            this.MultipleGamesNumericSelect.Location = new System.Drawing.Point(152, 354);
            this.MultipleGamesNumericSelect.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MultipleGamesNumericSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MultipleGamesNumericSelect.Name = "MultipleGamesNumericSelect";
            this.MultipleGamesNumericSelect.Size = new System.Drawing.Size(91, 20);
            this.MultipleGamesNumericSelect.TabIndex = 13;
            this.MultipleGamesNumericSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MultipleGamesCheck
            // 
            this.MultipleGamesCheck.AutoSize = true;
            this.MultipleGamesCheck.Location = new System.Drawing.Point(47, 331);
            this.MultipleGamesCheck.Name = "MultipleGamesCheck";
            this.MultipleGamesCheck.Size = new System.Drawing.Size(121, 17);
            this.MultipleGamesCheck.TabIndex = 12;
            this.MultipleGamesCheck.Text = "Run Multiple Games";
            this.MultipleGamesCheck.UseVisualStyleBackColor = true;
            this.MultipleGamesCheck.CheckedChanged += new System.EventHandler(this.MultipleGamesCheck_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(152, 278);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 35);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(47, 278);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(91, 35);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Player2SearchLabel
            // 
            this.Player2SearchLabel.AutoSize = true;
            this.Player2SearchLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2SearchLabel.Location = new System.Drawing.Point(66, 219);
            this.Player2SearchLabel.Name = "Player2SearchLabel";
            this.Player2SearchLabel.Size = new System.Drawing.Size(127, 16);
            this.Player2SearchLabel.TabIndex = 9;
            this.Player2SearchLabel.Text = "Tree Search Depth";
            // 
            // Player2NumericSelect
            // 
            this.Player2NumericSelect.Location = new System.Drawing.Point(199, 219);
            this.Player2NumericSelect.Name = "Player2NumericSelect";
            this.Player2NumericSelect.Size = new System.Drawing.Size(31, 20);
            this.Player2NumericSelect.TabIndex = 8;
            this.Player2NumericSelect.ValueChanged += new System.EventHandler(this.Player2NumericSelect_ValueChanged);
            // 
            // Player1SearchLabel
            // 
            this.Player1SearchLabel.AutoSize = true;
            this.Player1SearchLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1SearchLabel.Location = new System.Drawing.Point(66, 81);
            this.Player1SearchLabel.Name = "Player1SearchLabel";
            this.Player1SearchLabel.Size = new System.Drawing.Size(127, 16);
            this.Player1SearchLabel.TabIndex = 7;
            this.Player1SearchLabel.Text = "Tree Search Depth";
            // 
            // Player1NumericSelect
            // 
            this.Player1NumericSelect.Location = new System.Drawing.Point(199, 81);
            this.Player1NumericSelect.Name = "Player1NumericSelect";
            this.Player1NumericSelect.Size = new System.Drawing.Size(31, 20);
            this.Player1NumericSelect.TabIndex = 6;
            this.Player1NumericSelect.ValueChanged += new System.EventHandler(this.Player1NumericSelect_ValueChanged);
            // 
            // Player2Combo
            // 
            this.Player2Combo.FormattingEnabled = true;
            this.Player2Combo.Location = new System.Drawing.Point(47, 183);
            this.Player2Combo.Name = "Player2Combo";
            this.Player2Combo.Size = new System.Drawing.Size(196, 21);
            this.Player2Combo.TabIndex = 5;
            this.Player2Combo.SelectedIndexChanged += new System.EventHandler(this.Player2Combo_SelectedIndexChanged);
            // 
            // Player1Combo
            // 
            this.Player1Combo.FormattingEnabled = true;
            this.Player1Combo.Location = new System.Drawing.Point(47, 45);
            this.Player1Combo.Name = "Player1Combo";
            this.Player1Combo.Size = new System.Drawing.Size(196, 21);
            this.Player1Combo.TabIndex = 4;
            this.Player1Combo.SelectedIndexChanged += new System.EventHandler(this.Player1Combo_SelectedIndexChanged);
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Label.Location = new System.Drawing.Point(107, 153);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(86, 23);
            this.Player2Label.TabIndex = 3;
            this.Player2Label.Text = "Player 2:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(347, 477);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(117, 20);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "Player 1 Wins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.MainLabel);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GamePanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleGamesNumericSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2NumericSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1NumericSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button Tile9;
        private System.Windows.Forms.Button Tile8;
        private System.Windows.Forms.Button Tile7;
        private System.Windows.Forms.Button Tile6;
        private System.Windows.Forms.Button Tile5;
        private System.Windows.Forms.Button Tile4;
        private System.Windows.Forms.Button Tile3;
        private System.Windows.Forms.Button Tile2;
        private System.Windows.Forms.Button Tile1;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Label MultipleGamesLabel;
        private System.Windows.Forms.NumericUpDown MultipleGamesNumericSelect;
        private System.Windows.Forms.CheckBox MultipleGamesCheck;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Player2SearchLabel;
        private System.Windows.Forms.NumericUpDown Player2NumericSelect;
        private System.Windows.Forms.Label Player1SearchLabel;
        private System.Windows.Forms.NumericUpDown Player1NumericSelect;
        private System.Windows.Forms.ComboBox Player2Combo;
        private System.Windows.Forms.ComboBox Player1Combo;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

