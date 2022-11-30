﻿namespace mtg_lite
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.libraryDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay();
            this.graveyardDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay();
            this.handDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay();
            this.manaPoolDisplay = new mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay();
            this.battlefieldDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay();
            this.SuspendLayout();
            // 
            // libraryDisplay
            // 
            this.libraryDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryDisplay.Location = new System.Drawing.Point(10, 10);
            this.libraryDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.libraryDisplay.Name = "libraryDisplay";
            this.libraryDisplay.Size = new System.Drawing.Size(163, 241);
            this.libraryDisplay.TabIndex = 0;
            this.libraryDisplay.Zone = null;
            // 
            // graveyardDisplay
            // 
            this.graveyardDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graveyardDisplay.Location = new System.Drawing.Point(10, 255);
            this.graveyardDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graveyardDisplay.Name = "graveyardDisplay";
            this.graveyardDisplay.Size = new System.Drawing.Size(163, 241);
            this.graveyardDisplay.TabIndex = 1;
            this.graveyardDisplay.Zone = null;
            // 
            // handDisplay
            // 
            this.handDisplay.Hand = null;
            this.handDisplay.Location = new System.Drawing.Point(184, 546);
            this.handDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.handDisplay.Name = "handDisplay";
            this.handDisplay.Size = new System.Drawing.Size(1300, 271);
            this.handDisplay.TabIndex = 3;
            // 
            // manaPoolDisplay
            // 
            this.manaPoolDisplay.Location = new System.Drawing.Point(10, 548);
            this.manaPoolDisplay.ManaPool = null;
            this.manaPoolDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manaPoolDisplay.Name = "manaPoolDisplay";
            this.manaPoolDisplay.Size = new System.Drawing.Size(170, 269);
            this.manaPoolDisplay.TabIndex = 4;
            this.manaPoolDisplay.Load += new System.EventHandler(this.manaPoolDisplay_Load);
            // 
            // battlefieldDisplay
            // 
            this.battlefieldDisplay.Battlefield = null;
            this.battlefieldDisplay.Location = new System.Drawing.Point(187, 10);
            this.battlefieldDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.battlefieldDisplay.Name = "battlefieldDisplay";
            this.battlefieldDisplay.Size = new System.Drawing.Size(1297, 531);
            this.battlefieldDisplay.TabIndex = 5;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 834);
            this.Controls.Add(this.battlefieldDisplay);
            this.Controls.Add(this.manaPoolDisplay);
            this.Controls.Add(this.handDisplay);
            this.Controls.Add(this.graveyardDisplay);
            this.Controls.Add(this.libraryDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGame";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControls.ZoneDisplays.TopCardZoneDisplay libraryDisplay;
        private Views.UserControls.ZoneDisplays.TopCardZoneDisplay graveyardDisplay;
        private Views.UserControls.ZoneDisplays.HandDisplay handDisplay;
        private Views.UserControls.ManaDisplays.ManaPoolDisplay manaPoolDisplay;
        private Views.UserControls.ZoneDisplays.BattlefieldDisplay battlefieldDisplay;
    }
}