namespace Cafe_management
{
    partial class Dashboard
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnInsertItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_UpdateItems1 = new Cafe_management.AllUserControl.UC_UpdateItems();
            this.uC_PlaceOrder1 = new Cafe_management.AllUserControl.UC_PlaceOrder();
            this.uC_InsertItem1 = new Cafe_management.AllUserControl.UC_InsertItem();
            this.uC_Welcome1 = new Cafe_management.AllUserControl.UC_Welcome();
            this.uC_RemoveItems1 = new Cafe_management.AllUserControl.UC_RemoveItems();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2GradientCircleButton1);
            this.panel1.Controls.Add(this.btnInsertItem);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.btnUpdateItem);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnlogout
            // 
            this.btnlogout.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.btnlogout, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.LinkColor = System.Drawing.Color.Black;
            this.btnlogout.Location = new System.Drawing.Point(81, 452);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(64, 19);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.TabStop = true;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlogout_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2Transition1.SetDecoration(this.guna2GradientCircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(0, 3);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(46, 57);
            this.guna2GradientCircleButton1.TabIndex = 4;
            this.guna2GradientCircleButton1.Text = "X";
            this.guna2GradientCircleButton1.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.BorderRadius = 14;
            this.btnInsertItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInsertItem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnInsertItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnInsertItem.CheckedState.Parent = this.btnInsertItem;
            this.btnInsertItem.CustomImages.Parent = this.btnInsertItem;
            this.guna2Transition1.SetDecoration(this.btnInsertItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnInsertItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertItem.ForeColor = System.Drawing.Color.Black;
            this.btnInsertItem.HoverState.Parent = this.btnInsertItem;
            this.btnInsertItem.Location = new System.Drawing.Point(33, 142);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.ShadowDecoration.Parent = this.btnInsertItem;
            this.btnInsertItem.Size = new System.Drawing.Size(177, 45);
            this.btnInsertItem.TabIndex = 3;
            this.btnInsertItem.Text = "Insert Item";
            this.btnInsertItem.Click += new System.EventHandler(this.btnInsertItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BorderRadius = 14;
            this.btnDeleteItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeleteItem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDeleteItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteItem.CheckedState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.CustomImages.Parent = this.btnDeleteItem;
            this.guna2Transition1.SetDecoration(this.btnDeleteItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDeleteItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItem.HoverState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Location = new System.Drawing.Point(33, 273);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.ShadowDecoration.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Size = new System.Drawing.Size(177, 45);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BorderRadius = 14;
            this.btnUpdateItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateItem.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateItem.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateItem.CheckedState.Parent = this.btnUpdateItem;
            this.btnUpdateItem.CustomImages.Parent = this.btnUpdateItem;
            this.guna2Transition1.SetDecoration(this.btnUpdateItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdateItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItem.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateItem.HoverState.Parent = this.btnUpdateItem;
            this.btnUpdateItem.Location = new System.Drawing.Point(33, 202);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.ShadowDecoration.Parent = this.btnUpdateItem;
            this.btnUpdateItem.Size = new System.Drawing.Size(177, 45);
            this.btnUpdateItem.TabIndex = 1;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 14;
            this.btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaceOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlaceOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.CheckedState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.CustomImages.Parent = this.btnPlaceOrder;
            this.guna2Transition1.SetDecoration(this.btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlaceOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPlaceOrder.HoverState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(33, 79);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.ShadowDecoration.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Size = new System.Drawing.Size(177, 45);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.uC_RemoveItems1);
            this.panel3.Controls.Add(this.uC_UpdateItems1);
            this.panel3.Controls.Add(this.uC_PlaceOrder1);
            this.panel3.Controls.Add(this.uC_InsertItem1);
            this.panel3.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(201, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 511);
            this.panel3.TabIndex = 1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel3;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel3;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel3;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel3;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(3, 3);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(1172, 791);
            this.uC_PlaceOrder1.TabIndex = 2;
            this.uC_PlaceOrder1.Load += new System.EventHandler(this.uC_PlaceOrder1_Load);
            // 
            // uC_InsertItem1
            // 
            this.uC_InsertItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_InsertItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_InsertItem1.Location = new System.Drawing.Point(0, -15);
            this.uC_InsertItem1.Name = "uC_InsertItem1";
            this.uC_InsertItem1.Size = new System.Drawing.Size(781, 529);
            this.uC_InsertItem1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(3, 3);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // uC_RemoveItems1
            // 
            this.uC_RemoveItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItems1.Location = new System.Drawing.Point(6, -6);
            this.uC_RemoveItems1.Name = "uC_RemoveItems1";
            this.uC_RemoveItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItems1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnInsertItem;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItem;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItem;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel btnlogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControl.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControl.UC_InsertItem uC_InsertItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControl.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControl.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControl.UC_RemoveItems uC_RemoveItems1;
    }
}