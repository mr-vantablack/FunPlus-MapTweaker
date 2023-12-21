namespace FunPlus_MapTweaker
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
            this.sceneTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buildButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coopCombo = new System.Windows.Forms.ComboBox();
            this.vsCombo = new System.Windows.Forms.ComboBox();
            this.surCombo = new System.Windows.Forms.ComboBox();
            this.timeCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeCombo = new System.Windows.Forms.ComboBox();
            this.outsideCheckBox = new System.Windows.Forms.CheckBox();
            this.MapNameLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.customWavesGroup = new System.Windows.Forms.GroupBox();
            this.waveTextbox = new System.Windows.Forms.TextBox();
            this.waveRemoveButton = new System.Windows.Forms.Button();
            this.waveAddButton = new System.Windows.Forms.Button();
            this.wavePrevButton = new System.Windows.Forms.Button();
            this.waveNextButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.defaultNPCname = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.specialNPCname = new System.Windows.Forms.ComboBox();
            this.specialNPClist = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.specialRemoveButton = new System.Windows.Forms.Button();
            this.spawnChanceNum = new System.Windows.Forms.NumericUpDown();
            this.specialAddButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.isBossCheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countNum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.maxNPCnum = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.customWavesGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spawnChanceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNPCnum)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneTextBox
            // 
            this.sceneTextBox.Location = new System.Drawing.Point(6, 55);
            this.sceneTextBox.Name = "sceneTextBox";
            this.sceneTextBox.Size = new System.Drawing.Size(180, 23);
            this.sceneTextBox.TabIndex = 0;
            this.sceneTextBox.TextChanged += new System.EventHandler(this.sceneTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buildButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.coopCombo);
            this.groupBox1.Controls.Add(this.vsCombo);
            this.groupBox1.Controls.Add(this.surCombo);
            this.groupBox1.Controls.Add(this.timeCheckBox);
            this.groupBox1.Controls.Add(this.sizeCombo);
            this.groupBox1.Controls.Add(this.outsideCheckBox);
            this.groupBox1.Controls.Add(this.MapNameLabel);
            this.groupBox1.Controls.Add(this.sceneTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MapTweaker";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 46);
            this.button3.TabIndex = 15;
            this.button3.Text = "Create waves.json";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Version";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(6, 279);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(180, 46);
            this.buildButton.TabIndex = 12;
            this.buildButton.Text = "Create map.ini";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "COOP/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "VS/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "SUR/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Map size";
            // 
            // coopCombo
            // 
            this.coopCombo.FormattingEnabled = true;
            this.coopCombo.Items.AddRange(new object[] {
            "TinkyWinky",
            "TinkyTank",
            "PoMutated",
            "Po",
            "OrangeTubby",
            "ShadowTubby",
            "HeadlessDipsy",
            "MountainTubby",
            "GhostGirl",
            "LaaLaa",
            "Dipsy",
            "Announcer",
            "PoPhase1",
            "Crawler",
            "WhiteTubby",
            "Imposter",
            "BruteTubby",
            "BruteTubby1",
            "CaveTubby",
            "TinkyWinkyOld",
            "LaaLaaPhase1",
            "Newborn"});
            this.coopCombo.Location = new System.Drawing.Point(65, 250);
            this.coopCombo.Name = "coopCombo";
            this.coopCombo.Size = new System.Drawing.Size(121, 23);
            this.coopCombo.TabIndex = 7;
            this.coopCombo.SelectedIndexChanged += new System.EventHandler(this.coopCombo_SelectedIndexChanged);
            // 
            // vsCombo
            // 
            this.vsCombo.FormattingEnabled = true;
            this.vsCombo.Items.AddRange(new object[] {
            "PlayerAnnouncer",
            "PlayerAnnouncerBig",
            "PlayerBrute",
            "PlayerCaveTubby",
            "PlayerCrawler",
            "PlayerDipsy",
            "PlayerCustard",
            "PlayerDroid",
            "PlayerGeneral",
            "PlayerGhostGirl",
            "PlayerRunner",
            "PlayerShadowTubby",
            "PlayerTank",
            "PlayerTinky",
            "PlayerTinkyOld",
            "PlayerWhiteTubby",
            "PlayerHeadlessDipsy",
            "PlayerImposter",
            "PlayerLaaLaa",
            "PlayerLaaLaaPhase1",
            "PlayerMountainTubby",
            "PlayerNewborn",
            "PlayerOrangeTubby",
            "PlayerPo",
            "PlayerPoMutated",
            "PlayerPoPhase1"});
            this.vsCombo.Location = new System.Drawing.Point(65, 221);
            this.vsCombo.Name = "vsCombo";
            this.vsCombo.Size = new System.Drawing.Size(121, 23);
            this.vsCombo.TabIndex = 6;
            this.vsCombo.SelectedIndexChanged += new System.EventHandler(this.vsCombo_SelectedIndexChanged);
            // 
            // surCombo
            // 
            this.surCombo.FormattingEnabled = true;
            this.surCombo.Items.AddRange(new object[] {
            "BossRunner",
            "BossSecurity",
            "BossBeserker",
            "BossCavePhase1",
            "BossCave",
            "BossMountainPhase1",
            "BossMountains",
            "BossOrangeTubbyPhase1",
            "BossOrangeTubby",
            "BossWhiteTubby",
            "BossCrawler",
            "BossBrute",
            "BossGhostGirl",
            "BossShadow",
            "BossAnnouncer",
            "BossTinky",
            "BossTank",
            "BossPo",
            "BossPoMutated",
            "BossHeadlessDipsy",
            "BossDipsy",
            "BossLaaLaaPhase1",
            "BossLaaLaa",
            "BossPoPhase1",
            "BossRon",
            "BossImposter"});
            this.surCombo.Location = new System.Drawing.Point(65, 192);
            this.surCombo.Name = "surCombo";
            this.surCombo.Size = new System.Drawing.Size(121, 23);
            this.surCombo.TabIndex = 5;
            this.surCombo.SelectedIndexChanged += new System.EventHandler(this.surCombo_SelectedIndexChanged);
            // 
            // timeCheckBox
            // 
            this.timeCheckBox.AutoSize = true;
            this.timeCheckBox.Location = new System.Drawing.Point(6, 138);
            this.timeCheckBox.Name = "timeCheckBox";
            this.timeCheckBox.Size = new System.Drawing.Size(125, 19);
            this.timeCheckBox.TabIndex = 4;
            this.timeCheckBox.Text = "use day and night?";
            this.timeCheckBox.UseVisualStyleBackColor = true;
            this.timeCheckBox.CheckedChanged += new System.EventHandler(this.timeCheckBox_CheckedChanged);
            // 
            // sizeCombo
            // 
            this.sizeCombo.FormattingEnabled = true;
            this.sizeCombo.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.sizeCombo.Location = new System.Drawing.Point(65, 163);
            this.sizeCombo.Name = "sizeCombo";
            this.sizeCombo.Size = new System.Drawing.Size(121, 23);
            this.sizeCombo.TabIndex = 3;
            this.sizeCombo.SelectedIndexChanged += new System.EventHandler(this.sizeCombo_SelectedIndexChanged);
            // 
            // outsideCheckBox
            // 
            this.outsideCheckBox.AutoSize = true;
            this.outsideCheckBox.Location = new System.Drawing.Point(6, 113);
            this.outsideCheckBox.Name = "outsideCheckBox";
            this.outsideCheckBox.Size = new System.Drawing.Size(81, 19);
            this.outsideCheckBox.TabIndex = 2;
            this.outsideCheckBox.Text = "is outside?";
            this.outsideCheckBox.UseVisualStyleBackColor = true;
            this.outsideCheckBox.CheckedChanged += new System.EventHandler(this.outsideCheckBox_CheckedChanged);
            // 
            // MapNameLabel
            // 
            this.MapNameLabel.AutoSize = true;
            this.MapNameLabel.Location = new System.Drawing.Point(6, 37);
            this.MapNameLabel.Name = "MapNameLabel";
            this.MapNameLabel.Size = new System.Drawing.Size(71, 15);
            this.MapNameLabel.TabIndex = 1;
            this.MapNameLabel.Text = "Scene name";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "map.ini";
            // 
            // customWavesGroup
            // 
            this.customWavesGroup.Controls.Add(this.waveTextbox);
            this.customWavesGroup.Controls.Add(this.waveRemoveButton);
            this.customWavesGroup.Controls.Add(this.waveAddButton);
            this.customWavesGroup.Controls.Add(this.wavePrevButton);
            this.customWavesGroup.Controls.Add(this.waveNextButton);
            this.customWavesGroup.Controls.Add(this.groupBox3);
            this.customWavesGroup.Location = new System.Drawing.Point(209, 12);
            this.customWavesGroup.Name = "customWavesGroup";
            this.customWavesGroup.Size = new System.Drawing.Size(466, 375);
            this.customWavesGroup.TabIndex = 2;
            this.customWavesGroup.TabStop = false;
            this.customWavesGroup.Text = "Custom Waves";
            // 
            // waveTextbox
            // 
            this.waveTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waveTextbox.Location = new System.Drawing.Point(294, 331);
            this.waveTextbox.Name = "waveTextbox";
            this.waveTextbox.ReadOnly = true;
            this.waveTextbox.Size = new System.Drawing.Size(90, 29);
            this.waveTextbox.TabIndex = 31;
            // 
            // waveRemoveButton
            // 
            this.waveRemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waveRemoveButton.Location = new System.Drawing.Point(112, 331);
            this.waveRemoveButton.Name = "waveRemoveButton";
            this.waveRemoveButton.Size = new System.Drawing.Size(100, 29);
            this.waveRemoveButton.TabIndex = 30;
            this.waveRemoveButton.Text = "Remove";
            this.waveRemoveButton.UseVisualStyleBackColor = true;
            this.waveRemoveButton.Click += new System.EventHandler(this.waveRemoveButton_Click);
            // 
            // waveAddButton
            // 
            this.waveAddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waveAddButton.Location = new System.Drawing.Point(6, 331);
            this.waveAddButton.Name = "waveAddButton";
            this.waveAddButton.Size = new System.Drawing.Size(100, 29);
            this.waveAddButton.TabIndex = 29;
            this.waveAddButton.Text = "Add";
            this.waveAddButton.UseVisualStyleBackColor = true;
            this.waveAddButton.Click += new System.EventHandler(this.waveAddButton_Click);
            // 
            // wavePrevButton
            // 
            this.wavePrevButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wavePrevButton.Location = new System.Drawing.Point(218, 331);
            this.wavePrevButton.Name = "wavePrevButton";
            this.wavePrevButton.Size = new System.Drawing.Size(70, 29);
            this.wavePrevButton.TabIndex = 28;
            this.wavePrevButton.Text = "<";
            this.wavePrevButton.UseVisualStyleBackColor = true;
            this.wavePrevButton.Click += new System.EventHandler(this.wavePrevButton_Click);
            // 
            // waveNextButton
            // 
            this.waveNextButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waveNextButton.Location = new System.Drawing.Point(390, 331);
            this.waveNextButton.Name = "waveNextButton";
            this.waveNextButton.Size = new System.Drawing.Size(70, 29);
            this.waveNextButton.TabIndex = 27;
            this.waveNextButton.Text = ">";
            this.waveNextButton.UseVisualStyleBackColor = true;
            this.waveNextButton.Click += new System.EventHandler(this.waveNextButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.defaultNPCname);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.countNum);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.maxNPCnum);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 303);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wave";
            // 
            // defaultNPCname
            // 
            this.defaultNPCname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defaultNPCname.FormattingEnabled = true;
            this.defaultNPCname.Items.AddRange(new object[] {
            "BossRunner",
            "BossSecurity",
            "BossBeserker",
            "BossCavePhase1",
            "BossCave",
            "BossMountainPhase1",
            "BossMountains",
            "BossOrangeTubbyPhase1",
            "BossOrangeTubby",
            "BossWhiteTubby",
            "BossCrawler",
            "BossBrute",
            "BossGhostGirl",
            "BossShadow",
            "BossAnnouncer",
            "BossTinky",
            "BossTank",
            "BossPo",
            "BossPoMutated",
            "BossHeadlessDipsy",
            "BossDipsy",
            "BossLaaLaaPhase1",
            "BossLaaLaa",
            "BossPoPhase1",
            "BossRon",
            "BossImposter"});
            this.defaultNPCname.Location = new System.Drawing.Point(113, 180);
            this.defaultNPCname.Name = "defaultNPCname";
            this.defaultNPCname.Size = new System.Drawing.Size(204, 29);
            this.defaultNPCname.TabIndex = 27;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.specialNPCname);
            this.groupBox4.Controls.Add(this.specialNPClist);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.specialRemoveButton);
            this.groupBox4.Controls.Add(this.spawnChanceNum);
            this.groupBox4.Controls.Add(this.specialAddButton);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.isBossCheck);
            this.groupBox4.Location = new System.Drawing.Point(9, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 152);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Special NPCs";
            // 
            // specialNPCname
            // 
            this.specialNPCname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialNPCname.FormattingEnabled = true;
            this.specialNPCname.Items.AddRange(new object[] {
            "NewBorn_Bot",
            "NewBorn_Runner_Bot",
            "Crawler_Droid_Bot",
            "NewBorn_Ranged_Bot",
            "NewBorn_Tall_Bot",
            "Security_Bot",
            "NewBorn_Beserker_Bot",
            "BossRunner",
            "BossSecurity",
            "BossBeserker",
            "BossCavePhase1",
            "BossCave",
            "BossMountainPhase1",
            "BossMountains",
            "BossOrangeTubbyPhase1",
            "BossOrangeTubby",
            "BossWhiteTubby",
            "BossCrawler",
            "BossBrute",
            "BossGhostGirl",
            "BossShadow",
            "BossAnnouncer",
            "BossTinky",
            "BossTank",
            "BossPo",
            "BossPoMutated",
            "BossHeadlessDipsy",
            "BossDipsy",
            "BossLaaLaaPhase1",
            "BossLaaLaa",
            "BossPoPhase1",
            "BossRon",
            "BossImposter"});
            this.specialNPCname.Location = new System.Drawing.Point(10, 46);
            this.specialNPCname.Name = "specialNPCname";
            this.specialNPCname.Size = new System.Drawing.Size(204, 29);
            this.specialNPCname.TabIndex = 19;
            // 
            // specialNPClist
            // 
            this.specialNPClist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialNPClist.ItemHeight = 21;
            this.specialNPClist.Items.AddRange(new object[] {
            "Crawler_Droid_Bot|10|false",
            "NewBorn_Runner_Bot|6|false"});
            this.specialNPClist.Location = new System.Drawing.Point(219, 22);
            this.specialNPClist.Name = "specialNPClist";
            this.specialNPClist.Size = new System.Drawing.Size(204, 88);
            this.specialNPClist.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Special NPC name";
            // 
            // specialRemoveButton
            // 
            this.specialRemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialRemoveButton.Location = new System.Drawing.Point(325, 116);
            this.specialRemoveButton.Name = "specialRemoveButton";
            this.specialRemoveButton.Size = new System.Drawing.Size(98, 29);
            this.specialRemoveButton.TabIndex = 26;
            this.specialRemoveButton.Text = "Remove";
            this.specialRemoveButton.UseVisualStyleBackColor = true;
            this.specialRemoveButton.Click += new System.EventHandler(this.specialRemoveButton_Click);
            // 
            // spawnChanceNum
            // 
            this.spawnChanceNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spawnChanceNum.Location = new System.Drawing.Point(163, 81);
            this.spawnChanceNum.Name = "spawnChanceNum";
            this.spawnChanceNum.Size = new System.Drawing.Size(50, 29);
            this.spawnChanceNum.TabIndex = 20;
            // 
            // specialAddButton
            // 
            this.specialAddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialAddButton.Location = new System.Drawing.Point(219, 116);
            this.specialAddButton.Name = "specialAddButton";
            this.specialAddButton.Size = new System.Drawing.Size(100, 29);
            this.specialAddButton.TabIndex = 25;
            this.specialAddButton.Text = "Add";
            this.specialAddButton.UseVisualStyleBackColor = true;
            this.specialAddButton.Click += new System.EventHandler(this.specialAddButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Spawn chance";
            // 
            // isBossCheck
            // 
            this.isBossCheck.AutoSize = true;
            this.isBossCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isBossCheck.Location = new System.Drawing.Point(131, 116);
            this.isBossCheck.Name = "isBossCheck";
            this.isBossCheck.Size = new System.Drawing.Size(83, 25);
            this.isBossCheck.TabIndex = 22;
            this.isBossCheck.Text = "is boss?";
            this.isBossCheck.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "NPC count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Default NPC";
            // 
            // countNum
            // 
            this.countNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countNum.Location = new System.Drawing.Point(113, 220);
            this.countNum.Name = "countNum";
            this.countNum.Size = new System.Drawing.Size(64, 29);
            this.countNum.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Max NPC";
            // 
            // maxNPCnum
            // 
            this.maxNPCnum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxNPCnum.Location = new System.Drawing.Point(113, 257);
            this.maxNPCnum.Name = "maxNPCnum";
            this.maxNPCnum.Size = new System.Drawing.Size(64, 29);
            this.maxNPCnum.TabIndex = 23;
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "waves.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 399);
            this.Controls.Add(this.customWavesGroup);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FunPlus MapTweaker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customWavesGroup.ResumeLayout(false);
            this.customWavesGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spawnChanceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNPCnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox sceneTextBox;
        private GroupBox groupBox1;
        private Button buildButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox coopCombo;
        private ComboBox vsCombo;
        private ComboBox surCombo;
        private CheckBox timeCheckBox;
        private ComboBox sizeCombo;
        private CheckBox outsideCheckBox;
        private Label MapNameLabel;
        private SaveFileDialog saveFileDialog1;
        private Label label5;
        private TextBox textBox1;
        private GroupBox customWavesGroup;
        private GroupBox groupBox3;
        private ListBox specialNPClist;
        private Button specialRemoveButton;
        private Button specialAddButton;
        private CheckBox isBossCheck;
        private Label label8;
        private NumericUpDown spawnChanceNum;
        private ComboBox specialNPCname;
        private Label label7;
        private Label label6;
        private Button button3;
        private Button wavePrevButton;
        private Button waveNextButton;
        private ComboBox defaultNPCname;
        private GroupBox groupBox4;
        private Label label10;
        private NumericUpDown countNum;
        private Label label9;
        private NumericUpDown maxNPCnum;
        private Button waveRemoveButton;
        private Button waveAddButton;
        private TextBox waveTextbox;
        private SaveFileDialog saveFileDialog2;
    }
}