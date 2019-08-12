/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2018, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

namespace BHoM_Pull_Sample
{
    partial class Form_Main
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
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Pull = new System.Windows.Forms.Button();
            this.ListBox_Main = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Close
            // 
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.Location = new System.Drawing.Point(341, 359);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 23);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Pull
            // 
            this.Button_Pull.Location = new System.Drawing.Point(12, 12);
            this.Button_Pull.Name = "Button_Pull";
            this.Button_Pull.Size = new System.Drawing.Size(149, 23);
            this.Button_Pull.TabIndex = 1;
            this.Button_Pull.Text = "Pull";
            this.Button_Pull.UseVisualStyleBackColor = true;
            this.Button_Pull.Click += new System.EventHandler(this.Button_Pull_Click);
            // 
            // ListBox_Main
            // 
            this.ListBox_Main.FormattingEnabled = true;
            this.ListBox_Main.Location = new System.Drawing.Point(12, 41);
            this.ListBox_Main.Name = "ListBox_Main";
            this.ListBox_Main.Size = new System.Drawing.Size(404, 303);
            this.ListBox_Main.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Push";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.Button_Close;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.Button_Close;
            this.ClientSize = new System.Drawing.Size(428, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListBox_Main);
            this.Controls.Add(this.Button_Pull);
            this.Controls.Add(this.Button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Text = "BHoM Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Pull;
        private System.Windows.Forms.ListBox ListBox_Main;
        private System.Windows.Forms.Button button1;
    }
}

