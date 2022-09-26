
namespace AvoidTheCat
{
    partial class FRM_AvoidTheCat
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.TMR_GameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_DogSleeping = new System.Windows.Forms.Label();
            this.LBL_CatHunting = new System.Windows.Forms.Label();
            this.LBL_MouseDead = new System.Windows.Forms.Label();
            this.LBL_TimeSurvived = new System.Windows.Forms.Label();
            this.GB_Info = new System.Windows.Forms.GroupBox();
            this.LBL_DogWakesUpIn = new System.Windows.Forms.Label();
            this.LBL_DogFallsAsleepIn = new System.Windows.Forms.Label();
            this.GB_LocationEditor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Animal = new System.Windows.Forms.ComboBox();
            this.NUD_DogSleepTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_DogAwakeTime = new System.Windows.Forms.NumericUpDown();
            this.GB_DogModifier = new System.Windows.Forms.GroupBox();
            this.GB_GameModifier = new System.Windows.Forms.GroupBox();
            this.BTN_ApplyGameModifier = new System.Windows.Forms.Button();
            this.NUD_GameSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_MouseInvincible = new System.Windows.Forms.ComboBox();
            this.GB_LocationInfo = new System.Windows.Forms.GroupBox();
            this.LBL_MouseX = new System.Windows.Forms.Label();
            this.LBL_CatY = new System.Windows.Forms.Label();
            this.LBL_DogX = new System.Windows.Forms.Label();
            this.LBL_MouseY = new System.Windows.Forms.Label();
            this.LBL_DogY = new System.Windows.Forms.Label();
            this.LBL_CatX = new System.Windows.Forms.Label();
            this.GB_ExtraInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_MouseMovementDirection = new System.Windows.Forms.Label();
            this.LBL_CornerEscape = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_CatMovementDirection = new System.Windows.Forms.Label();
            this.LBL_DogMovementDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_Info.SuspendLayout();
            this.GB_LocationEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DogSleepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DogAwakeTime)).BeginInit();
            this.GB_DogModifier.SuspendLayout();
            this.GB_GameModifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_GameSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GB_LocationInfo.SuspendLayout();
            this.GB_ExtraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Start.Location = new System.Drawing.Point(12, 12);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(977, 507);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // TMR_GameTime
            // 
            this.TMR_GameTime.Interval = 50;
            this.TMR_GameTime.Tick += new System.EventHandler(this.TMR_GameTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(1003, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 532);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_DogSleeping
            // 
            this.LBL_DogSleeping.AutoSize = true;
            this.LBL_DogSleeping.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_DogSleeping.Location = new System.Drawing.Point(6, 18);
            this.LBL_DogSleeping.Name = "LBL_DogSleeping";
            this.LBL_DogSleeping.Size = new System.Drawing.Size(117, 17);
            this.LBL_DogSleeping.TabIndex = 2;
            this.LBL_DogSleeping.Text = "Dog sleeping: No";
            // 
            // LBL_CatHunting
            // 
            this.LBL_CatHunting.AutoSize = true;
            this.LBL_CatHunting.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_CatHunting.Location = new System.Drawing.Point(6, 35);
            this.LBL_CatHunting.Name = "LBL_CatHunting";
            this.LBL_CatHunting.Size = new System.Drawing.Size(112, 17);
            this.LBL_CatHunting.TabIndex = 3;
            this.LBL_CatHunting.Text = "Cat hunting: Yes";
            // 
            // LBL_MouseDead
            // 
            this.LBL_MouseDead.AutoSize = true;
            this.LBL_MouseDead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_MouseDead.Location = new System.Drawing.Point(6, 52);
            this.LBL_MouseDead.Name = "LBL_MouseDead";
            this.LBL_MouseDead.Size = new System.Drawing.Size(112, 17);
            this.LBL_MouseDead.TabIndex = 4;
            this.LBL_MouseDead.Text = "Mouse dead: No";
            // 
            // LBL_TimeSurvived
            // 
            this.LBL_TimeSurvived.AutoSize = true;
            this.LBL_TimeSurvived.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_TimeSurvived.Location = new System.Drawing.Point(6, 103);
            this.LBL_TimeSurvived.Name = "LBL_TimeSurvived";
            this.LBL_TimeSurvived.Size = new System.Drawing.Size(116, 17);
            this.LBL_TimeSurvived.TabIndex = 5;
            this.LBL_TimeSurvived.Text = "Time survived: 0 ";
            // 
            // GB_Info
            // 
            this.GB_Info.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GB_Info.Controls.Add(this.LBL_DogWakesUpIn);
            this.GB_Info.Controls.Add(this.LBL_DogFallsAsleepIn);
            this.GB_Info.Controls.Add(this.LBL_DogSleeping);
            this.GB_Info.Controls.Add(this.LBL_TimeSurvived);
            this.GB_Info.Controls.Add(this.LBL_CatHunting);
            this.GB_Info.Controls.Add(this.LBL_MouseDead);
            this.GB_Info.Location = new System.Drawing.Point(1015, 140);
            this.GB_Info.Name = "GB_Info";
            this.GB_Info.Size = new System.Drawing.Size(166, 125);
            this.GB_Info.TabIndex = 6;
            this.GB_Info.TabStop = false;
            this.GB_Info.Text = "Info";
            // 
            // LBL_DogWakesUpIn
            // 
            this.LBL_DogWakesUpIn.AutoSize = true;
            this.LBL_DogWakesUpIn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_DogWakesUpIn.Location = new System.Drawing.Point(6, 86);
            this.LBL_DogWakesUpIn.Name = "LBL_DogWakesUpIn";
            this.LBL_DogWakesUpIn.Size = new System.Drawing.Size(116, 17);
            this.LBL_DogWakesUpIn.TabIndex = 7;
            this.LBL_DogWakesUpIn.Text = "Dog wakes up in:";
            // 
            // LBL_DogFallsAsleepIn
            // 
            this.LBL_DogFallsAsleepIn.AutoSize = true;
            this.LBL_DogFallsAsleepIn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_DogFallsAsleepIn.Location = new System.Drawing.Point(6, 69);
            this.LBL_DogFallsAsleepIn.Name = "LBL_DogFallsAsleepIn";
            this.LBL_DogFallsAsleepIn.Size = new System.Drawing.Size(132, 17);
            this.LBL_DogFallsAsleepIn.TabIndex = 6;
            this.LBL_DogFallsAsleepIn.Text = "Dog falls asleep in: ";
            // 
            // GB_LocationEditor
            // 
            this.GB_LocationEditor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GB_LocationEditor.Controls.Add(this.label1);
            this.GB_LocationEditor.Controls.Add(this.CB_Animal);
            this.GB_LocationEditor.Location = new System.Drawing.Point(1187, 140);
            this.GB_LocationEditor.Name = "GB_LocationEditor";
            this.GB_LocationEditor.Size = new System.Drawing.Size(166, 70);
            this.GB_LocationEditor.TabIndex = 7;
            this.GB_LocationEditor.TabStop = false;
            this.GB_LocationEditor.Text = "Location Editor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change animal location";
            // 
            // CB_Animal
            // 
            this.CB_Animal.DisplayMember = "Dog";
            this.CB_Animal.FormattingEnabled = true;
            this.CB_Animal.Items.AddRange(new object[] {
            "Mouse",
            "Dog",
            "Cat"});
            this.CB_Animal.Location = new System.Drawing.Point(6, 38);
            this.CB_Animal.Name = "CB_Animal";
            this.CB_Animal.Size = new System.Drawing.Size(154, 24);
            this.CB_Animal.TabIndex = 0;
            this.CB_Animal.Text = "Nothing";
            // 
            // NUD_DogSleepTime
            // 
            this.NUD_DogSleepTime.Location = new System.Drawing.Point(6, 83);
            this.NUD_DogSleepTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_DogSleepTime.Name = "NUD_DogSleepTime";
            this.NUD_DogSleepTime.Size = new System.Drawing.Size(153, 22);
            this.NUD_DogSleepTime.TabIndex = 7;
            this.NUD_DogSleepTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUD_DogSleepTime.ValueChanged += new System.EventHandler(this.NUD_DogSleepTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change dog sleep time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Change dog awake time";
            // 
            // NUD_DogAwakeTime
            // 
            this.NUD_DogAwakeTime.Location = new System.Drawing.Point(6, 38);
            this.NUD_DogAwakeTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_DogAwakeTime.Name = "NUD_DogAwakeTime";
            this.NUD_DogAwakeTime.Size = new System.Drawing.Size(153, 22);
            this.NUD_DogAwakeTime.TabIndex = 10;
            this.NUD_DogAwakeTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUD_DogAwakeTime.ValueChanged += new System.EventHandler(this.NUD_DogAwakeTime_ValueChanged);
            // 
            // GB_DogModifier
            // 
            this.GB_DogModifier.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GB_DogModifier.Controls.Add(this.label2);
            this.GB_DogModifier.Controls.Add(this.NUD_DogAwakeTime);
            this.GB_DogModifier.Controls.Add(this.NUD_DogSleepTime);
            this.GB_DogModifier.Controls.Add(this.label3);
            this.GB_DogModifier.Location = new System.Drawing.Point(1187, 322);
            this.GB_DogModifier.Name = "GB_DogModifier";
            this.GB_DogModifier.Size = new System.Drawing.Size(166, 114);
            this.GB_DogModifier.TabIndex = 8;
            this.GB_DogModifier.TabStop = false;
            this.GB_DogModifier.Text = "Dog Modifier";
            // 
            // GB_GameModifier
            // 
            this.GB_GameModifier.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GB_GameModifier.Controls.Add(this.BTN_ApplyGameModifier);
            this.GB_GameModifier.Controls.Add(this.NUD_GameSpeed);
            this.GB_GameModifier.Controls.Add(this.label4);
            this.GB_GameModifier.Location = new System.Drawing.Point(1187, 216);
            this.GB_GameModifier.Name = "GB_GameModifier";
            this.GB_GameModifier.Size = new System.Drawing.Size(166, 100);
            this.GB_GameModifier.TabIndex = 8;
            this.GB_GameModifier.TabStop = false;
            this.GB_GameModifier.Text = "Game Modifier";
            // 
            // BTN_ApplyGameModifier
            // 
            this.BTN_ApplyGameModifier.Location = new System.Drawing.Point(6, 66);
            this.BTN_ApplyGameModifier.Name = "BTN_ApplyGameModifier";
            this.BTN_ApplyGameModifier.Size = new System.Drawing.Size(153, 26);
            this.BTN_ApplyGameModifier.TabIndex = 12;
            this.BTN_ApplyGameModifier.Text = "Apply";
            this.BTN_ApplyGameModifier.UseVisualStyleBackColor = true;
            this.BTN_ApplyGameModifier.Click += new System.EventHandler(this.BTN_ApplyGameModifier_Click);
            // 
            // NUD_GameSpeed
            // 
            this.NUD_GameSpeed.Location = new System.Drawing.Point(6, 38);
            this.NUD_GameSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_GameSpeed.Name = "NUD_GameSpeed";
            this.NUD_GameSpeed.Size = new System.Drawing.Size(153, 22);
            this.NUD_GameSpeed.TabIndex = 12;
            this.NUD_GameSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change game speed";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB_MouseInvincible);
            this.groupBox1.Location = new System.Drawing.Point(1187, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse Modifier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mouse invincible";
            // 
            // CB_MouseInvincible
            // 
            this.CB_MouseInvincible.DisplayMember = "Dog";
            this.CB_MouseInvincible.FormattingEnabled = true;
            this.CB_MouseInvincible.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CB_MouseInvincible.Location = new System.Drawing.Point(6, 38);
            this.CB_MouseInvincible.Name = "CB_MouseInvincible";
            this.CB_MouseInvincible.Size = new System.Drawing.Size(154, 24);
            this.CB_MouseInvincible.TabIndex = 0;
            this.CB_MouseInvincible.Text = "No";
            // 
            // GB_LocationInfo
            // 
            this.GB_LocationInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GB_LocationInfo.Controls.Add(this.LBL_MouseX);
            this.GB_LocationInfo.Controls.Add(this.LBL_CatY);
            this.GB_LocationInfo.Controls.Add(this.LBL_DogX);
            this.GB_LocationInfo.Controls.Add(this.LBL_MouseY);
            this.GB_LocationInfo.Controls.Add(this.LBL_DogY);
            this.GB_LocationInfo.Controls.Add(this.LBL_CatX);
            this.GB_LocationInfo.Location = new System.Drawing.Point(1015, 271);
            this.GB_LocationInfo.Name = "GB_LocationInfo";
            this.GB_LocationInfo.Size = new System.Drawing.Size(166, 124);
            this.GB_LocationInfo.TabIndex = 8;
            this.GB_LocationInfo.TabStop = false;
            this.GB_LocationInfo.Text = "Location Info";
            // 
            // LBL_MouseX
            // 
            this.LBL_MouseX.AutoSize = true;
            this.LBL_MouseX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_MouseX.Location = new System.Drawing.Point(6, 86);
            this.LBL_MouseX.Name = "LBL_MouseX";
            this.LBL_MouseX.Size = new System.Drawing.Size(64, 17);
            this.LBL_MouseX.TabIndex = 7;
            this.LBL_MouseX.Text = "Mouse x:";
            // 
            // LBL_CatY
            // 
            this.LBL_CatY.AutoSize = true;
            this.LBL_CatY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_CatY.Location = new System.Drawing.Point(6, 69);
            this.LBL_CatY.Name = "LBL_CatY";
            this.LBL_CatY.Size = new System.Drawing.Size(44, 17);
            this.LBL_CatY.TabIndex = 6;
            this.LBL_CatY.Text = "Cat y:";
            // 
            // LBL_DogX
            // 
            this.LBL_DogX.AutoSize = true;
            this.LBL_DogX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_DogX.Location = new System.Drawing.Point(6, 18);
            this.LBL_DogX.Name = "LBL_DogX";
            this.LBL_DogX.Size = new System.Drawing.Size(48, 17);
            this.LBL_DogX.TabIndex = 2;
            this.LBL_DogX.Text = "Dog x:";
            // 
            // LBL_MouseY
            // 
            this.LBL_MouseY.AutoSize = true;
            this.LBL_MouseY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_MouseY.Location = new System.Drawing.Point(6, 103);
            this.LBL_MouseY.Name = "LBL_MouseY";
            this.LBL_MouseY.Size = new System.Drawing.Size(65, 17);
            this.LBL_MouseY.TabIndex = 5;
            this.LBL_MouseY.Text = "Mouse y:";
            // 
            // LBL_DogY
            // 
            this.LBL_DogY.AutoSize = true;
            this.LBL_DogY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_DogY.Location = new System.Drawing.Point(6, 35);
            this.LBL_DogY.Name = "LBL_DogY";
            this.LBL_DogY.Size = new System.Drawing.Size(49, 17);
            this.LBL_DogY.TabIndex = 3;
            this.LBL_DogY.Text = "Dog y:";
            // 
            // LBL_CatX
            // 
            this.LBL_CatX.AutoSize = true;
            this.LBL_CatX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_CatX.Location = new System.Drawing.Point(6, 52);
            this.LBL_CatX.Name = "LBL_CatX";
            this.LBL_CatX.Size = new System.Drawing.Size(43, 17);
            this.LBL_CatX.TabIndex = 4;
            this.LBL_CatX.Text = "Cat x:";
            // 
            // GB_ExtraInfo
            // 
            this.GB_ExtraInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GB_ExtraInfo.Controls.Add(this.label6);
            this.GB_ExtraInfo.Controls.Add(this.LBL_MouseMovementDirection);
            this.GB_ExtraInfo.Controls.Add(this.LBL_CornerEscape);
            this.GB_ExtraInfo.Controls.Add(this.label9);
            this.GB_ExtraInfo.Controls.Add(this.LBL_CatMovementDirection);
            this.GB_ExtraInfo.Controls.Add(this.LBL_DogMovementDirection);
            this.GB_ExtraInfo.Location = new System.Drawing.Point(1015, 12);
            this.GB_ExtraInfo.Name = "GB_ExtraInfo";
            this.GB_ExtraInfo.Size = new System.Drawing.Size(338, 125);
            this.GB_ExtraInfo.TabIndex = 8;
            this.GB_ExtraInfo.TabStop = false;
            this.GB_ExtraInfo.Text = "Extra Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "l";
            // 
            // LBL_MouseMovementDirection
            // 
            this.LBL_MouseMovementDirection.AutoSize = true;
            this.LBL_MouseMovementDirection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_MouseMovementDirection.Location = new System.Drawing.Point(6, 69);
            this.LBL_MouseMovementDirection.Name = "LBL_MouseMovementDirection";
            this.LBL_MouseMovementDirection.Size = new System.Drawing.Size(220, 17);
            this.LBL_MouseMovementDirection.TabIndex = 6;
            this.LBL_MouseMovementDirection.Text = "Mouse movement direction: (WIP)";
            // 
            // LBL_CornerEscape
            // 
            this.LBL_CornerEscape.AutoSize = true;
            this.LBL_CornerEscape.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_CornerEscape.Location = new System.Drawing.Point(6, 18);
            this.LBL_CornerEscape.Name = "LBL_CornerEscape";
            this.LBL_CornerEscape.Size = new System.Drawing.Size(153, 17);
            this.LBL_CornerEscape.TabIndex = 2;
            this.LBL_CornerEscape.Text = "Mouse corner escape: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "l";
            // 
            // LBL_CatMovementDirection
            // 
            this.LBL_CatMovementDirection.AutoSize = true;
            this.LBL_CatMovementDirection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_CatMovementDirection.Location = new System.Drawing.Point(6, 35);
            this.LBL_CatMovementDirection.Name = "LBL_CatMovementDirection";
            this.LBL_CatMovementDirection.Size = new System.Drawing.Size(160, 17);
            this.LBL_CatMovementDirection.TabIndex = 3;
            this.LBL_CatMovementDirection.Text = "Cat movement direction:";
            // 
            // LBL_DogMovementDirection
            // 
            this.LBL_DogMovementDirection.AutoSize = true;
            this.LBL_DogMovementDirection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LBL_DogMovementDirection.Location = new System.Drawing.Point(6, 52);
            this.LBL_DogMovementDirection.Name = "LBL_DogMovementDirection";
            this.LBL_DogMovementDirection.Size = new System.Drawing.Size(204, 17);
            this.LBL_DogMovementDirection.TabIndex = 4;
            this.LBL_DogMovementDirection.Text = "Dog movement direction: (WIP)";
            // 
            // FRM_AvoidTheCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1361, 531);
            this.Controls.Add(this.GB_ExtraInfo);
            this.Controls.Add(this.GB_LocationInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_GameModifier);
            this.Controls.Add(this.GB_DogModifier);
            this.Controls.Add(this.GB_LocationEditor);
            this.Controls.Add(this.GB_Info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Start);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FRM_AvoidTheCat";
            this.Text = "Avoid The Cat!";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRM_AvoidTheCat_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_Info.ResumeLayout(false);
            this.GB_Info.PerformLayout();
            this.GB_LocationEditor.ResumeLayout(false);
            this.GB_LocationEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DogSleepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_DogAwakeTime)).EndInit();
            this.GB_DogModifier.ResumeLayout(false);
            this.GB_DogModifier.PerformLayout();
            this.GB_GameModifier.ResumeLayout(false);
            this.GB_GameModifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_GameSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_LocationInfo.ResumeLayout(false);
            this.GB_LocationInfo.PerformLayout();
            this.GB_ExtraInfo.ResumeLayout(false);
            this.GB_ExtraInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Timer TMR_GameTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_DogSleeping;
        private System.Windows.Forms.Label LBL_CatHunting;
        private System.Windows.Forms.Label LBL_MouseDead;
        private System.Windows.Forms.Label LBL_TimeSurvived;
        private System.Windows.Forms.GroupBox GB_Info;
        private System.Windows.Forms.GroupBox GB_LocationEditor;
        private System.Windows.Forms.ComboBox CB_Animal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_DogSleepTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_DogAwakeTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GB_DogModifier;
        private System.Windows.Forms.GroupBox GB_GameModifier;
        private System.Windows.Forms.Button BTN_ApplyGameModifier;
        private System.Windows.Forms.NumericUpDown NUD_GameSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_DogWakesUpIn;
        private System.Windows.Forms.Label LBL_DogFallsAsleepIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_MouseInvincible;
        private System.Windows.Forms.GroupBox GB_LocationInfo;
        private System.Windows.Forms.Label LBL_MouseX;
        private System.Windows.Forms.Label LBL_CatY;
        private System.Windows.Forms.Label LBL_DogX;
        private System.Windows.Forms.Label LBL_MouseY;
        private System.Windows.Forms.Label LBL_DogY;
        private System.Windows.Forms.Label LBL_CatX;
        private System.Windows.Forms.GroupBox GB_ExtraInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_MouseMovementDirection;
        private System.Windows.Forms.Label LBL_CornerEscape;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_CatMovementDirection;
        private System.Windows.Forms.Label LBL_DogMovementDirection;
    }
}

