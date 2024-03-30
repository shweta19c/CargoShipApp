namespace CargoShipApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            track_MotorCycles = new TrackBar();
            track_Cars = new TrackBar();
            track_Trucks = new TrackBar();
            track_Trains = new TrackBar();
            label_CycleCount = new Label();
            label_CarCount = new Label();
            label_TruckCount = new Label();
            label_TrainCount = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_NewShip = new Button();
            label_ShipLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)track_MotorCycles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)track_Cars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)track_Trucks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)track_Trains).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(903, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(315, 21);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(521, 148);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 45;
            progressBar1.Click += progressBar1_Click;
            // 
            // track_MotorCycles
            // 
            track_MotorCycles.Location = new Point(61, 341);
            track_MotorCycles.Name = "track_MotorCycles";
            track_MotorCycles.Size = new Size(183, 56);
            track_MotorCycles.TabIndex = 2;
            track_MotorCycles.Scroll += track_MotorCycles_Scroll;
            // 
            // track_Cars
            // 
            track_Cars.Location = new Point(61, 467);
            track_Cars.Name = "track_Cars";
            track_Cars.Size = new Size(183, 56);
            track_Cars.TabIndex = 6;
            track_Cars.Scroll += track_Cars_Scroll;
            // 
            // track_Trucks
            // 
            track_Trucks.Location = new Point(689, 341);
            track_Trucks.Name = "track_Trucks";
            track_Trucks.Size = new Size(183, 56);
            track_Trucks.TabIndex = 4;
            track_Trucks.Scroll += track_Trucks_Scroll;
            // 
            // track_Trains
            // 
            track_Trains.Location = new Point(689, 467);
            track_Trains.Name = "track_Trains";
            track_Trains.Size = new Size(183, 56);
            track_Trains.TabIndex = 5;
            track_Trains.Scroll += track_Trains_Scroll;
            // 
            // label_CycleCount
            // 
            label_CycleCount.AutoSize = true;
            label_CycleCount.Location = new Point(122, 317);
            label_CycleCount.Name = "label_CycleCount";
            label_CycleCount.Size = new Size(50, 20);
            label_CycleCount.TabIndex = 8;
            label_CycleCount.Text = "label1";
            // 
            // label_CarCount
            // 
            label_CarCount.AutoSize = true;
            label_CarCount.Location = new Point(122, 442);
            label_CarCount.Name = "label_CarCount";
            label_CarCount.Size = new Size(50, 20);
            label_CarCount.TabIndex = 9;
            label_CarCount.Text = "label2";
            // 
            // label_TruckCount
            // 
            label_TruckCount.AutoSize = true;
            label_TruckCount.Location = new Point(763, 317);
            label_TruckCount.Name = "label_TruckCount";
            label_TruckCount.Size = new Size(50, 20);
            label_TruckCount.TabIndex = 10;
            label_TruckCount.Text = "label3";
            // 
            // label_TrainCount
            // 
            label_TrainCount.AutoSize = true;
            label_TrainCount.Location = new Point(763, 444);
            label_TrainCount.Name = "label_TrainCount";
            label_TrainCount.Size = new Size(50, 20);
            label_TrainCount.TabIndex = 11;
            label_TrainCount.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 386);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 12;
            label5.Text = "MotorCycles (3 unit)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(731, 386);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 13;
            label6.Text = "Trucks (11 units)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 514);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 14;
            label7.Text = "Cars(5 units)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(740, 514);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 15;
            label8.Text = "Train cars(17 units)";
            // 
            // btn_NewShip
            // 
            btn_NewShip.Location = new Point(33, 558);
            btn_NewShip.Name = "btn_NewShip";
            btn_NewShip.Size = new Size(187, 59);
            btn_NewShip.TabIndex = 16;
            btn_NewShip.Text = "New Ship";
            btn_NewShip.UseVisualStyleBackColor = true;
            btn_NewShip.Click += btn_NewShip_Click;
            // 
            // label_ShipLabel
            // 
            label_ShipLabel.AutoSize = true;
            label_ShipLabel.Location = new Point(162, 199);
            label_ShipLabel.Name = "label_ShipLabel";
            label_ShipLabel.Size = new Size(50, 20);
            label_ShipLabel.TabIndex = 17;
            label_ShipLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 629);
            Controls.Add(label_ShipLabel);
            Controls.Add(btn_NewShip);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label_TrainCount);
            Controls.Add(label_TruckCount);
            Controls.Add(label_CarCount);
            Controls.Add(label_CycleCount);
            Controls.Add(track_Trains);
            Controls.Add(track_Trucks);
            Controls.Add(track_Cars);
            Controls.Add(track_MotorCycles);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Load the Ship";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)track_MotorCycles).EndInit();
            ((System.ComponentModel.ISupportInitialize)track_Cars).EndInit();
            ((System.ComponentModel.ISupportInitialize)track_Trucks).EndInit();
            ((System.ComponentModel.ISupportInitialize)track_Trains).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private TrackBar track_MotorCycles;
        private TrackBar track_Cars;
        private TrackBar track_Trucks;
        private TrackBar track_Trains;
        private Label label_CycleCount;
        private Label label_CarCount;
        private Label label_TruckCount;
        private Label label_TrainCount;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_NewShip;
        private Label label_ShipLabel;
    }
}
