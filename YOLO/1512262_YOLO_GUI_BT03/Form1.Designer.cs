using System;

namespace _1512262_YOLO_GUI_BT03
{
    partial class YOLO
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
            this.btn_LoadImg = new System.Windows.Forms.Button();
            this.txt_Prediction = new System.Windows.Forms.TextBox();
            this.btn_Predict = new System.Windows.Forms.Button();
            this.ptx_beforeYOLO = new System.Windows.Forms.PictureBox();
            this.ptx_afterYOLO = new System.Windows.Forms.PictureBox();
            this.lbl_Prediction = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Before = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_loadFullImg_beforeYOLO = new System.Windows.Forms.Button();
            this.btn_loadFullImg_afterYOLO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_beforeYOLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_afterYOLO)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadImg
            // 
            this.btn_LoadImg.Location = new System.Drawing.Point(786, 42);
            this.btn_LoadImg.Name = "btn_LoadImg";
            this.btn_LoadImg.Size = new System.Drawing.Size(84, 23);
            this.btn_LoadImg.TabIndex = 0;
            this.btn_LoadImg.Text = "Load Image";
            this.btn_LoadImg.UseVisualStyleBackColor = true;
            this.btn_LoadImg.Click += new System.EventHandler(this.btn_LoadImg_Click);
            // 
            // txt_Prediction
            // 
            this.txt_Prediction.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prediction.Location = new System.Drawing.Point(103, 324);
            this.txt_Prediction.Multiline = true;
            this.txt_Prediction.Name = "txt_Prediction";
            this.txt_Prediction.ReadOnly = true;
            this.txt_Prediction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Prediction.Size = new System.Drawing.Size(292, 26);
            this.txt_Prediction.TabIndex = 1;
            // 
            // btn_Predict
            // 
            this.btn_Predict.Location = new System.Drawing.Point(788, 171);
            this.btn_Predict.Name = "btn_Predict";
            this.btn_Predict.Size = new System.Drawing.Size(82, 23);
            this.btn_Predict.TabIndex = 0;
            this.btn_Predict.Text = "Predict!";
            this.btn_Predict.UseVisualStyleBackColor = true;
            this.btn_Predict.Click += new System.EventHandler(this.btn_Predict_Click);
            // 
            // ptx_beforeYOLO
            // 
            this.ptx_beforeYOLO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptx_beforeYOLO.Location = new System.Drawing.Point(15, 42);
            this.ptx_beforeYOLO.Name = "ptx_beforeYOLO";
            this.ptx_beforeYOLO.Size = new System.Drawing.Size(380, 272);
            this.ptx_beforeYOLO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptx_beforeYOLO.TabIndex = 2;
            this.ptx_beforeYOLO.TabStop = false;
            // 
            // ptx_afterYOLO
            // 
            this.ptx_afterYOLO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptx_afterYOLO.Location = new System.Drawing.Point(402, 42);
            this.ptx_afterYOLO.Name = "ptx_afterYOLO";
            this.ptx_afterYOLO.Size = new System.Drawing.Size(380, 272);
            this.ptx_afterYOLO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptx_afterYOLO.TabIndex = 2;
            this.ptx_afterYOLO.TabStop = false;
            // 
            // lbl_Prediction
            // 
            this.lbl_Prediction.AutoSize = true;
            this.lbl_Prediction.Location = new System.Drawing.Point(12, 324);
            this.lbl_Prediction.Name = "lbl_Prediction";
            this.lbl_Prediction.Size = new System.Drawing.Size(78, 13);
            this.lbl_Prediction.TabIndex = 3;
            this.lbl_Prediction.Text = "This is number:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(788, 288);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(82, 26);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear!";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Before
            // 
            this.lbl_Before.AutoSize = true;
            this.lbl_Before.Location = new System.Drawing.Point(12, 13);
            this.lbl_Before.Name = "lbl_Before";
            this.lbl_Before.Size = new System.Drawing.Size(98, 13);
            this.lbl_Before.TabIndex = 5;
            this.lbl_Before.Text = "Before using YOLO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "After using YOLO";
            // 
            // btn_loadFullImg_beforeYOLO
            // 
            this.btn_loadFullImg_beforeYOLO.Location = new System.Drawing.Point(275, 8);
            this.btn_loadFullImg_beforeYOLO.Name = "btn_loadFullImg_beforeYOLO";
            this.btn_loadFullImg_beforeYOLO.Size = new System.Drawing.Size(118, 23);
            this.btn_loadFullImg_beforeYOLO.TabIndex = 0;
            this.btn_loadFullImg_beforeYOLO.Text = "Load Full Image";
            this.btn_loadFullImg_beforeYOLO.UseVisualStyleBackColor = true;
            this.btn_loadFullImg_beforeYOLO.Click += new System.EventHandler(this.btn_loadFullImg_beforeYOLO_Click);
            // 
            // btn_loadFullImg_afterYOLO
            // 
            this.btn_loadFullImg_afterYOLO.Location = new System.Drawing.Point(664, 8);
            this.btn_loadFullImg_afterYOLO.Name = "btn_loadFullImg_afterYOLO";
            this.btn_loadFullImg_afterYOLO.Size = new System.Drawing.Size(118, 23);
            this.btn_loadFullImg_afterYOLO.TabIndex = 7;
            this.btn_loadFullImg_afterYOLO.Text = "Load Full Image";
            this.btn_loadFullImg_afterYOLO.UseVisualStyleBackColor = true;
            this.btn_loadFullImg_afterYOLO.Click += new System.EventHandler(this.btn_loadFullImg_afterYOLO_Click);
            // 
            // YOLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 430);
            this.Controls.Add(this.btn_loadFullImg_afterYOLO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Before);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Prediction);
            this.Controls.Add(this.ptx_afterYOLO);
            this.Controls.Add(this.ptx_beforeYOLO);
            this.Controls.Add(this.txt_Prediction);
            this.Controls.Add(this.btn_Predict);
            this.Controls.Add(this.btn_loadFullImg_beforeYOLO);
            this.Controls.Add(this.btn_LoadImg);
            this.Name = "YOLO";
            this.Text = "MNIST_YOLO Detection";
            ((System.ComponentModel.ISupportInitialize)(this.ptx_beforeYOLO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_afterYOLO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.Button btn_LoadImg;
        private System.Windows.Forms.TextBox txt_Prediction;
        private System.Windows.Forms.Button btn_Predict;
        private System.Windows.Forms.PictureBox ptx_beforeYOLO;
        private System.Windows.Forms.PictureBox ptx_afterYOLO;
        private System.Windows.Forms.Label lbl_Prediction;
        private System.Windows.Forms.Label lbl_Before;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_loadFullImg_beforeYOLO;
        private System.Windows.Forms.Button btn_loadFullImg_afterYOLO;
    }
}

