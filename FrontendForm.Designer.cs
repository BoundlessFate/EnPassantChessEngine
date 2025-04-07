namespace EnPassantEngine
{
    partial class FrontendForm
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontendForm));
            whiteLabel = new Label();
            blackLabel = new Label();
            whitePlayer = new ComboBox();
            blackPlayer = new ComboBox();
            whiteDepthLabel = new Label();
            blackDepthLabel = new Label();
            aThreeButton = new Button();
            bThreeButton = new Button();
            dThreeButton = new Button();
            cThreeButton = new Button();
            hThreeButton = new Button();
            gThreeButton = new Button();
            fThreeButton = new Button();
            eThreeButton = new Button();
            hFourButton = new Button();
            gFourButton = new Button();
            fFourButton = new Button();
            eFourButton = new Button();
            dFourButton = new Button();
            cFourButton = new Button();
            bFourButton = new Button();
            aFourButton = new Button();
            hSixButton = new Button();
            gSixButton = new Button();
            fSixButton = new Button();
            eSixButton = new Button();
            dSixButton = new Button();
            cSixButton = new Button();
            bSixButton = new Button();
            aSixButton = new Button();
            hFiveButton = new Button();
            gFiveButton = new Button();
            fFiveButton = new Button();
            eFiveButton = new Button();
            dFiveButton = new Button();
            cFiveButton = new Button();
            bFiveButton = new Button();
            aFiveButton = new Button();
            hEightButton = new Button();
            gEightButton = new Button();
            fEightButton = new Button();
            eEightButton = new Button();
            dEightButton = new Button();
            cEightButton = new Button();
            bEightButton = new Button();
            aEightButton = new Button();
            hSevenButton = new Button();
            gSevenButton = new Button();
            fSevenButton = new Button();
            eSevenButton = new Button();
            dSevenButton = new Button();
            cSevenButton = new Button();
            bSevenButton = new Button();
            aSevenButton = new Button();
            hTwoButton = new Button();
            gTwoButton = new Button();
            fTwoButton = new Button();
            eTwoButton = new Button();
            dTwoButton = new Button();
            cTwoButton = new Button();
            bTwoButton = new Button();
            aTwoButton = new Button();
            hOneButton = new Button();
            gOneButton = new Button();
            fOneButton = new Button();
            eOneButton = new Button();
            dOneButton = new Button();
            cOneButton = new Button();
            bOneButton = new Button();
            aOneButton = new Button();
            selectedPieceLabel = new Label();
            selectedPiece = new TextBox();
            deselectPieceButton = new Button();
            whiteDepth = new NumericUpDown();
            blackDepth = new NumericUpDown();
            PromoteKnightButton = new Button();
            PromoteBishopButton = new Button();
            PromoteRookButton = new Button();
            PromoteQueenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)whiteDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blackDepth).BeginInit();
            SuspendLayout();
            // 
            // whiteLabel
            // 
            whiteLabel.AutoSize = true;
            whiteLabel.Location = new Point(12, 9);
            whiteLabel.Name = "whiteLabel";
            whiteLabel.Size = new Size(96, 41);
            whiteLabel.TabIndex = 0;
            whiteLabel.Text = "White";
            // 
            // blackLabel
            // 
            blackLabel.AutoSize = true;
            blackLabel.Location = new Point(519, 9);
            blackLabel.Name = "blackLabel";
            blackLabel.Size = new Size(86, 41);
            blackLabel.TabIndex = 1;
            blackLabel.Text = "Black";
            // 
            // whitePlayer
            // 
            whitePlayer.DropDownStyle = ComboBoxStyle.DropDownList;
            whitePlayer.FormattingEnabled = true;
            whitePlayer.Location = new Point(114, 6);
            whitePlayer.Name = "whitePlayer";
            whitePlayer.Size = new Size(302, 49);
            whitePlayer.TabIndex = 2;
            // 
            // blackPlayer
            // 
            blackPlayer.DropDownStyle = ComboBoxStyle.DropDownList;
            blackPlayer.FormattingEnabled = true;
            blackPlayer.Location = new Point(611, 6);
            blackPlayer.Name = "blackPlayer";
            blackPlayer.Size = new Size(302, 49);
            blackPlayer.TabIndex = 3;
            // 
            // whiteDepthLabel
            // 
            whiteDepthLabel.AutoSize = true;
            whiteDepthLabel.Location = new Point(12, 63);
            whiteDepthLabel.Name = "whiteDepthLabel";
            whiteDepthLabel.Size = new Size(100, 41);
            whiteDepthLabel.TabIndex = 4;
            whiteDepthLabel.Text = "Depth";
            // 
            // blackDepthLabel
            // 
            blackDepthLabel.AutoSize = true;
            blackDepthLabel.Location = new Point(505, 66);
            blackDepthLabel.Name = "blackDepthLabel";
            blackDepthLabel.Size = new Size(100, 41);
            blackDepthLabel.TabIndex = 6;
            blackDepthLabel.Text = "Depth";
            // 
            // aThreeButton
            // 
            aThreeButton.BackColor = SystemColors.AppWorkspace;
            aThreeButton.FlatStyle = FlatStyle.Flat;
            aThreeButton.Location = new Point(249, 738);
            aThreeButton.Margin = new Padding(0);
            aThreeButton.Name = "aThreeButton";
            aThreeButton.Size = new Size(100, 100);
            aThreeButton.TabIndex = 8;
            aThreeButton.UseVisualStyleBackColor = false;
            aThreeButton.Click += Square_Click;
            // 
            // bThreeButton
            // 
            bThreeButton.BackColor = SystemColors.HighlightText;
            bThreeButton.FlatStyle = FlatStyle.Flat;
            bThreeButton.Location = new Point(349, 738);
            bThreeButton.Margin = new Padding(0);
            bThreeButton.Name = "bThreeButton";
            bThreeButton.Size = new Size(100, 100);
            bThreeButton.TabIndex = 9;
            bThreeButton.UseVisualStyleBackColor = false;
            bThreeButton.Click += Square_Click;
            // 
            // dThreeButton
            // 
            dThreeButton.BackColor = SystemColors.HighlightText;
            dThreeButton.FlatStyle = FlatStyle.Flat;
            dThreeButton.Location = new Point(549, 738);
            dThreeButton.Margin = new Padding(0);
            dThreeButton.Name = "dThreeButton";
            dThreeButton.Size = new Size(100, 100);
            dThreeButton.TabIndex = 11;
            dThreeButton.UseVisualStyleBackColor = false;
            dThreeButton.Click += Square_Click;
            // 
            // cThreeButton
            // 
            cThreeButton.BackColor = SystemColors.AppWorkspace;
            cThreeButton.FlatStyle = FlatStyle.Flat;
            cThreeButton.Location = new Point(449, 738);
            cThreeButton.Margin = new Padding(0);
            cThreeButton.Name = "cThreeButton";
            cThreeButton.Size = new Size(100, 100);
            cThreeButton.TabIndex = 10;
            cThreeButton.UseVisualStyleBackColor = false;
            cThreeButton.Click += Square_Click;
            // 
            // hThreeButton
            // 
            hThreeButton.BackColor = SystemColors.HighlightText;
            hThreeButton.FlatStyle = FlatStyle.Flat;
            hThreeButton.Location = new Point(949, 738);
            hThreeButton.Margin = new Padding(0);
            hThreeButton.Name = "hThreeButton";
            hThreeButton.Size = new Size(100, 100);
            hThreeButton.TabIndex = 15;
            hThreeButton.UseVisualStyleBackColor = false;
            hThreeButton.Click += Square_Click;
            // 
            // gThreeButton
            // 
            gThreeButton.BackColor = SystemColors.AppWorkspace;
            gThreeButton.FlatStyle = FlatStyle.Flat;
            gThreeButton.Location = new Point(849, 738);
            gThreeButton.Margin = new Padding(0);
            gThreeButton.Name = "gThreeButton";
            gThreeButton.Size = new Size(100, 100);
            gThreeButton.TabIndex = 14;
            gThreeButton.UseVisualStyleBackColor = false;
            gThreeButton.Click += Square_Click;
            // 
            // fThreeButton
            // 
            fThreeButton.BackColor = SystemColors.HighlightText;
            fThreeButton.FlatStyle = FlatStyle.Flat;
            fThreeButton.Location = new Point(749, 738);
            fThreeButton.Margin = new Padding(0);
            fThreeButton.Name = "fThreeButton";
            fThreeButton.Size = new Size(100, 100);
            fThreeButton.TabIndex = 13;
            fThreeButton.UseVisualStyleBackColor = false;
            fThreeButton.Click += Square_Click;
            // 
            // eThreeButton
            // 
            eThreeButton.BackColor = SystemColors.AppWorkspace;
            eThreeButton.FlatStyle = FlatStyle.Flat;
            eThreeButton.Location = new Point(649, 738);
            eThreeButton.Margin = new Padding(0);
            eThreeButton.Name = "eThreeButton";
            eThreeButton.Size = new Size(100, 100);
            eThreeButton.TabIndex = 12;
            eThreeButton.UseVisualStyleBackColor = false;
            eThreeButton.Click += Square_Click;
            // 
            // hFourButton
            // 
            hFourButton.BackColor = SystemColors.AppWorkspace;
            hFourButton.FlatStyle = FlatStyle.Flat;
            hFourButton.Location = new Point(949, 638);
            hFourButton.Margin = new Padding(0);
            hFourButton.Name = "hFourButton";
            hFourButton.Size = new Size(100, 100);
            hFourButton.TabIndex = 25;
            hFourButton.UseVisualStyleBackColor = false;
            hFourButton.Click += Square_Click;
            // 
            // gFourButton
            // 
            gFourButton.BackColor = SystemColors.HighlightText;
            gFourButton.FlatStyle = FlatStyle.Flat;
            gFourButton.Location = new Point(849, 638);
            gFourButton.Margin = new Padding(0);
            gFourButton.Name = "gFourButton";
            gFourButton.Size = new Size(100, 100);
            gFourButton.TabIndex = 24;
            gFourButton.UseVisualStyleBackColor = false;
            gFourButton.Click += Square_Click;
            // 
            // fFourButton
            // 
            fFourButton.BackColor = SystemColors.AppWorkspace;
            fFourButton.FlatStyle = FlatStyle.Flat;
            fFourButton.Location = new Point(749, 638);
            fFourButton.Margin = new Padding(0);
            fFourButton.Name = "fFourButton";
            fFourButton.Size = new Size(100, 100);
            fFourButton.TabIndex = 23;
            fFourButton.UseVisualStyleBackColor = false;
            fFourButton.Click += Square_Click;
            // 
            // eFourButton
            // 
            eFourButton.BackColor = SystemColors.HighlightText;
            eFourButton.FlatStyle = FlatStyle.Flat;
            eFourButton.Location = new Point(649, 638);
            eFourButton.Margin = new Padding(0);
            eFourButton.Name = "eFourButton";
            eFourButton.Size = new Size(100, 100);
            eFourButton.TabIndex = 22;
            eFourButton.UseVisualStyleBackColor = false;
            eFourButton.Click += Square_Click;
            // 
            // dFourButton
            // 
            dFourButton.BackColor = SystemColors.AppWorkspace;
            dFourButton.FlatStyle = FlatStyle.Flat;
            dFourButton.Location = new Point(549, 638);
            dFourButton.Margin = new Padding(0);
            dFourButton.Name = "dFourButton";
            dFourButton.Size = new Size(100, 100);
            dFourButton.TabIndex = 21;
            dFourButton.UseVisualStyleBackColor = false;
            dFourButton.Click += Square_Click;
            // 
            // cFourButton
            // 
            cFourButton.BackColor = SystemColors.HighlightText;
            cFourButton.FlatStyle = FlatStyle.Flat;
            cFourButton.Location = new Point(449, 638);
            cFourButton.Margin = new Padding(0);
            cFourButton.Name = "cFourButton";
            cFourButton.Size = new Size(100, 100);
            cFourButton.TabIndex = 20;
            cFourButton.UseVisualStyleBackColor = false;
            cFourButton.Click += Square_Click;
            // 
            // bFourButton
            // 
            bFourButton.BackColor = SystemColors.AppWorkspace;
            bFourButton.FlatStyle = FlatStyle.Flat;
            bFourButton.Location = new Point(349, 638);
            bFourButton.Margin = new Padding(0);
            bFourButton.Name = "bFourButton";
            bFourButton.Size = new Size(100, 100);
            bFourButton.TabIndex = 19;
            bFourButton.UseVisualStyleBackColor = false;
            bFourButton.Click += Square_Click;
            // 
            // aFourButton
            // 
            aFourButton.BackColor = SystemColors.HighlightText;
            aFourButton.FlatStyle = FlatStyle.Flat;
            aFourButton.Location = new Point(249, 638);
            aFourButton.Margin = new Padding(0);
            aFourButton.Name = "aFourButton";
            aFourButton.Size = new Size(100, 100);
            aFourButton.TabIndex = 18;
            aFourButton.UseVisualStyleBackColor = false;
            aFourButton.Click += Square_Click;
            // 
            // hSixButton
            // 
            hSixButton.BackColor = SystemColors.AppWorkspace;
            hSixButton.FlatStyle = FlatStyle.Flat;
            hSixButton.Location = new Point(949, 437);
            hSixButton.Margin = new Padding(0);
            hSixButton.Name = "hSixButton";
            hSixButton.Size = new Size(100, 100);
            hSixButton.TabIndex = 43;
            hSixButton.UseVisualStyleBackColor = false;
            hSixButton.Click += Square_Click;
            // 
            // gSixButton
            // 
            gSixButton.BackColor = SystemColors.HighlightText;
            gSixButton.FlatStyle = FlatStyle.Flat;
            gSixButton.Location = new Point(849, 437);
            gSixButton.Margin = new Padding(0);
            gSixButton.Name = "gSixButton";
            gSixButton.Size = new Size(100, 100);
            gSixButton.TabIndex = 42;
            gSixButton.UseVisualStyleBackColor = false;
            gSixButton.Click += Square_Click;
            // 
            // fSixButton
            // 
            fSixButton.BackColor = SystemColors.AppWorkspace;
            fSixButton.FlatStyle = FlatStyle.Flat;
            fSixButton.Location = new Point(749, 437);
            fSixButton.Margin = new Padding(0);
            fSixButton.Name = "fSixButton";
            fSixButton.Size = new Size(100, 100);
            fSixButton.TabIndex = 41;
            fSixButton.UseVisualStyleBackColor = false;
            fSixButton.Click += Square_Click;
            // 
            // eSixButton
            // 
            eSixButton.BackColor = SystemColors.HighlightText;
            eSixButton.FlatStyle = FlatStyle.Flat;
            eSixButton.Location = new Point(649, 437);
            eSixButton.Margin = new Padding(0);
            eSixButton.Name = "eSixButton";
            eSixButton.Size = new Size(100, 100);
            eSixButton.TabIndex = 40;
            eSixButton.UseVisualStyleBackColor = false;
            eSixButton.Click += Square_Click;
            // 
            // dSixButton
            // 
            dSixButton.BackColor = SystemColors.AppWorkspace;
            dSixButton.FlatStyle = FlatStyle.Flat;
            dSixButton.Location = new Point(549, 437);
            dSixButton.Margin = new Padding(0);
            dSixButton.Name = "dSixButton";
            dSixButton.Size = new Size(100, 100);
            dSixButton.TabIndex = 39;
            dSixButton.UseVisualStyleBackColor = false;
            dSixButton.Click += Square_Click;
            // 
            // cSixButton
            // 
            cSixButton.BackColor = SystemColors.HighlightText;
            cSixButton.FlatStyle = FlatStyle.Flat;
            cSixButton.Location = new Point(449, 437);
            cSixButton.Margin = new Padding(0);
            cSixButton.Name = "cSixButton";
            cSixButton.Size = new Size(100, 100);
            cSixButton.TabIndex = 38;
            cSixButton.UseVisualStyleBackColor = false;
            cSixButton.Click += Square_Click;
            // 
            // bSixButton
            // 
            bSixButton.BackColor = SystemColors.AppWorkspace;
            bSixButton.FlatStyle = FlatStyle.Flat;
            bSixButton.Location = new Point(349, 437);
            bSixButton.Margin = new Padding(0);
            bSixButton.Name = "bSixButton";
            bSixButton.Size = new Size(100, 100);
            bSixButton.TabIndex = 37;
            bSixButton.UseVisualStyleBackColor = false;
            bSixButton.Click += Square_Click;
            // 
            // aSixButton
            // 
            aSixButton.BackColor = SystemColors.HighlightText;
            aSixButton.FlatStyle = FlatStyle.Flat;
            aSixButton.Location = new Point(249, 437);
            aSixButton.Margin = new Padding(0);
            aSixButton.Name = "aSixButton";
            aSixButton.Size = new Size(100, 100);
            aSixButton.TabIndex = 36;
            aSixButton.UseVisualStyleBackColor = false;
            aSixButton.Click += Square_Click;
            // 
            // hFiveButton
            // 
            hFiveButton.BackColor = SystemColors.HighlightText;
            hFiveButton.FlatStyle = FlatStyle.Flat;
            hFiveButton.Location = new Point(949, 537);
            hFiveButton.Margin = new Padding(0);
            hFiveButton.Name = "hFiveButton";
            hFiveButton.Size = new Size(100, 100);
            hFiveButton.TabIndex = 33;
            hFiveButton.UseVisualStyleBackColor = false;
            hFiveButton.Click += Square_Click;
            // 
            // gFiveButton
            // 
            gFiveButton.BackColor = SystemColors.AppWorkspace;
            gFiveButton.FlatStyle = FlatStyle.Flat;
            gFiveButton.Location = new Point(849, 537);
            gFiveButton.Margin = new Padding(0);
            gFiveButton.Name = "gFiveButton";
            gFiveButton.Size = new Size(100, 100);
            gFiveButton.TabIndex = 32;
            gFiveButton.UseVisualStyleBackColor = false;
            gFiveButton.Click += Square_Click;
            // 
            // fFiveButton
            // 
            fFiveButton.BackColor = SystemColors.HighlightText;
            fFiveButton.FlatStyle = FlatStyle.Flat;
            fFiveButton.Location = new Point(749, 537);
            fFiveButton.Margin = new Padding(0);
            fFiveButton.Name = "fFiveButton";
            fFiveButton.Size = new Size(100, 100);
            fFiveButton.TabIndex = 31;
            fFiveButton.UseVisualStyleBackColor = false;
            fFiveButton.Click += Square_Click;
            // 
            // eFiveButton
            // 
            eFiveButton.BackColor = SystemColors.AppWorkspace;
            eFiveButton.FlatStyle = FlatStyle.Flat;
            eFiveButton.Location = new Point(649, 537);
            eFiveButton.Margin = new Padding(0);
            eFiveButton.Name = "eFiveButton";
            eFiveButton.Size = new Size(100, 100);
            eFiveButton.TabIndex = 30;
            eFiveButton.UseVisualStyleBackColor = false;
            eFiveButton.Click += Square_Click;
            // 
            // dFiveButton
            // 
            dFiveButton.BackColor = SystemColors.HighlightText;
            dFiveButton.FlatStyle = FlatStyle.Flat;
            dFiveButton.Location = new Point(549, 537);
            dFiveButton.Margin = new Padding(0);
            dFiveButton.Name = "dFiveButton";
            dFiveButton.Size = new Size(100, 100);
            dFiveButton.TabIndex = 29;
            dFiveButton.UseVisualStyleBackColor = false;
            dFiveButton.Click += Square_Click;
            // 
            // cFiveButton
            // 
            cFiveButton.BackColor = SystemColors.AppWorkspace;
            cFiveButton.FlatStyle = FlatStyle.Flat;
            cFiveButton.Location = new Point(449, 537);
            cFiveButton.Margin = new Padding(0);
            cFiveButton.Name = "cFiveButton";
            cFiveButton.Size = new Size(100, 100);
            cFiveButton.TabIndex = 28;
            cFiveButton.UseVisualStyleBackColor = false;
            cFiveButton.Click += Square_Click;
            // 
            // bFiveButton
            // 
            bFiveButton.BackColor = SystemColors.HighlightText;
            bFiveButton.FlatStyle = FlatStyle.Flat;
            bFiveButton.Location = new Point(349, 537);
            bFiveButton.Margin = new Padding(0);
            bFiveButton.Name = "bFiveButton";
            bFiveButton.Size = new Size(100, 100);
            bFiveButton.TabIndex = 27;
            bFiveButton.UseVisualStyleBackColor = false;
            bFiveButton.Click += Square_Click;
            // 
            // aFiveButton
            // 
            aFiveButton.BackColor = SystemColors.AppWorkspace;
            aFiveButton.FlatStyle = FlatStyle.Flat;
            aFiveButton.Location = new Point(249, 537);
            aFiveButton.Margin = new Padding(0);
            aFiveButton.Name = "aFiveButton";
            aFiveButton.Size = new Size(100, 100);
            aFiveButton.TabIndex = 26;
            aFiveButton.UseVisualStyleBackColor = false;
            aFiveButton.Click += Square_Click;
            // 
            // hEightButton
            // 
            hEightButton.BackColor = SystemColors.AppWorkspace;
            hEightButton.FlatStyle = FlatStyle.Flat;
            hEightButton.Location = new Point(949, 237);
            hEightButton.Margin = new Padding(0);
            hEightButton.Name = "hEightButton";
            hEightButton.Size = new Size(100, 100);
            hEightButton.TabIndex = 61;
            hEightButton.UseVisualStyleBackColor = false;
            hEightButton.Click += Square_Click;
            // 
            // gEightButton
            // 
            gEightButton.BackColor = SystemColors.HighlightText;
            gEightButton.FlatStyle = FlatStyle.Flat;
            gEightButton.Location = new Point(849, 237);
            gEightButton.Margin = new Padding(0);
            gEightButton.Name = "gEightButton";
            gEightButton.Size = new Size(100, 100);
            gEightButton.TabIndex = 60;
            gEightButton.UseVisualStyleBackColor = false;
            gEightButton.Click += Square_Click;
            // 
            // fEightButton
            // 
            fEightButton.BackColor = SystemColors.AppWorkspace;
            fEightButton.FlatStyle = FlatStyle.Flat;
            fEightButton.Location = new Point(749, 237);
            fEightButton.Margin = new Padding(0);
            fEightButton.Name = "fEightButton";
            fEightButton.Size = new Size(100, 100);
            fEightButton.TabIndex = 59;
            fEightButton.UseVisualStyleBackColor = false;
            fEightButton.Click += Square_Click;
            // 
            // eEightButton
            // 
            eEightButton.BackColor = SystemColors.HighlightText;
            eEightButton.FlatStyle = FlatStyle.Flat;
            eEightButton.Location = new Point(649, 237);
            eEightButton.Margin = new Padding(0);
            eEightButton.Name = "eEightButton";
            eEightButton.Size = new Size(100, 100);
            eEightButton.TabIndex = 58;
            eEightButton.UseVisualStyleBackColor = false;
            eEightButton.Click += Square_Click;
            // 
            // dEightButton
            // 
            dEightButton.BackColor = SystemColors.AppWorkspace;
            dEightButton.FlatStyle = FlatStyle.Flat;
            dEightButton.Location = new Point(549, 237);
            dEightButton.Margin = new Padding(0);
            dEightButton.Name = "dEightButton";
            dEightButton.Size = new Size(100, 100);
            dEightButton.TabIndex = 57;
            dEightButton.UseVisualStyleBackColor = false;
            dEightButton.Click += Square_Click;
            // 
            // cEightButton
            // 
            cEightButton.BackColor = SystemColors.HighlightText;
            cEightButton.FlatStyle = FlatStyle.Flat;
            cEightButton.Location = new Point(449, 237);
            cEightButton.Margin = new Padding(0);
            cEightButton.Name = "cEightButton";
            cEightButton.Size = new Size(100, 100);
            cEightButton.TabIndex = 56;
            cEightButton.UseVisualStyleBackColor = false;
            cEightButton.Click += Square_Click;
            // 
            // bEightButton
            // 
            bEightButton.BackColor = SystemColors.AppWorkspace;
            bEightButton.FlatStyle = FlatStyle.Flat;
            bEightButton.Location = new Point(349, 237);
            bEightButton.Margin = new Padding(0);
            bEightButton.Name = "bEightButton";
            bEightButton.Size = new Size(100, 100);
            bEightButton.TabIndex = 55;
            bEightButton.UseVisualStyleBackColor = false;
            bEightButton.Click += Square_Click;
            // 
            // aEightButton
            // 
            aEightButton.BackColor = SystemColors.HighlightText;
            aEightButton.FlatStyle = FlatStyle.Flat;
            aEightButton.Location = new Point(249, 237);
            aEightButton.Margin = new Padding(0);
            aEightButton.Name = "aEightButton";
            aEightButton.Size = new Size(100, 100);
            aEightButton.TabIndex = 54;
            aEightButton.UseVisualStyleBackColor = false;
            aEightButton.Click += Square_Click;
            // 
            // hSevenButton
            // 
            hSevenButton.BackColor = SystemColors.HighlightText;
            hSevenButton.FlatStyle = FlatStyle.Flat;
            hSevenButton.Location = new Point(949, 337);
            hSevenButton.Margin = new Padding(0);
            hSevenButton.Name = "hSevenButton";
            hSevenButton.Size = new Size(100, 100);
            hSevenButton.TabIndex = 51;
            hSevenButton.UseVisualStyleBackColor = false;
            hSevenButton.Click += Square_Click;
            // 
            // gSevenButton
            // 
            gSevenButton.BackColor = SystemColors.AppWorkspace;
            gSevenButton.FlatStyle = FlatStyle.Flat;
            gSevenButton.Location = new Point(849, 337);
            gSevenButton.Margin = new Padding(0);
            gSevenButton.Name = "gSevenButton";
            gSevenButton.Size = new Size(100, 100);
            gSevenButton.TabIndex = 50;
            gSevenButton.UseVisualStyleBackColor = false;
            gSevenButton.Click += Square_Click;
            // 
            // fSevenButton
            // 
            fSevenButton.BackColor = SystemColors.HighlightText;
            fSevenButton.FlatStyle = FlatStyle.Flat;
            fSevenButton.Location = new Point(749, 337);
            fSevenButton.Margin = new Padding(0);
            fSevenButton.Name = "fSevenButton";
            fSevenButton.Size = new Size(100, 100);
            fSevenButton.TabIndex = 49;
            fSevenButton.UseVisualStyleBackColor = false;
            fSevenButton.Click += Square_Click;
            // 
            // eSevenButton
            // 
            eSevenButton.BackColor = SystemColors.AppWorkspace;
            eSevenButton.FlatStyle = FlatStyle.Flat;
            eSevenButton.Location = new Point(649, 337);
            eSevenButton.Margin = new Padding(0);
            eSevenButton.Name = "eSevenButton";
            eSevenButton.Size = new Size(100, 100);
            eSevenButton.TabIndex = 48;
            eSevenButton.UseVisualStyleBackColor = false;
            eSevenButton.Click += Square_Click;
            // 
            // dSevenButton
            // 
            dSevenButton.BackColor = SystemColors.HighlightText;
            dSevenButton.FlatStyle = FlatStyle.Flat;
            dSevenButton.Location = new Point(549, 337);
            dSevenButton.Margin = new Padding(0);
            dSevenButton.Name = "dSevenButton";
            dSevenButton.Size = new Size(100, 100);
            dSevenButton.TabIndex = 47;
            dSevenButton.UseVisualStyleBackColor = false;
            dSevenButton.Click += Square_Click;
            // 
            // cSevenButton
            // 
            cSevenButton.BackColor = SystemColors.AppWorkspace;
            cSevenButton.FlatStyle = FlatStyle.Flat;
            cSevenButton.Location = new Point(449, 337);
            cSevenButton.Margin = new Padding(0);
            cSevenButton.Name = "cSevenButton";
            cSevenButton.Size = new Size(100, 100);
            cSevenButton.TabIndex = 46;
            cSevenButton.UseVisualStyleBackColor = false;
            cSevenButton.Click += Square_Click;
            // 
            // bSevenButton
            // 
            bSevenButton.BackColor = SystemColors.HighlightText;
            bSevenButton.FlatStyle = FlatStyle.Flat;
            bSevenButton.Location = new Point(349, 337);
            bSevenButton.Margin = new Padding(0);
            bSevenButton.Name = "bSevenButton";
            bSevenButton.Size = new Size(100, 100);
            bSevenButton.TabIndex = 45;
            bSevenButton.UseVisualStyleBackColor = false;
            bSevenButton.Click += Square_Click;
            // 
            // aSevenButton
            // 
            aSevenButton.BackColor = SystemColors.AppWorkspace;
            aSevenButton.FlatStyle = FlatStyle.Flat;
            aSevenButton.Location = new Point(249, 337);
            aSevenButton.Margin = new Padding(0);
            aSevenButton.Name = "aSevenButton";
            aSevenButton.Size = new Size(100, 100);
            aSevenButton.TabIndex = 44;
            aSevenButton.UseVisualStyleBackColor = false;
            aSevenButton.Click += Square_Click;
            // 
            // hTwoButton
            // 
            hTwoButton.BackColor = SystemColors.AppWorkspace;
            hTwoButton.FlatStyle = FlatStyle.Flat;
            hTwoButton.Location = new Point(949, 838);
            hTwoButton.Margin = new Padding(0);
            hTwoButton.Name = "hTwoButton";
            hTwoButton.Size = new Size(100, 100);
            hTwoButton.TabIndex = 79;
            hTwoButton.UseVisualStyleBackColor = false;
            hTwoButton.Click += Square_Click;
            // 
            // gTwoButton
            // 
            gTwoButton.BackColor = SystemColors.HighlightText;
            gTwoButton.FlatStyle = FlatStyle.Flat;
            gTwoButton.Location = new Point(849, 838);
            gTwoButton.Margin = new Padding(0);
            gTwoButton.Name = "gTwoButton";
            gTwoButton.Size = new Size(100, 100);
            gTwoButton.TabIndex = 78;
            gTwoButton.UseVisualStyleBackColor = false;
            gTwoButton.Click += Square_Click;
            // 
            // fTwoButton
            // 
            fTwoButton.BackColor = SystemColors.AppWorkspace;
            fTwoButton.FlatStyle = FlatStyle.Flat;
            fTwoButton.Location = new Point(749, 838);
            fTwoButton.Margin = new Padding(0);
            fTwoButton.Name = "fTwoButton";
            fTwoButton.Size = new Size(100, 100);
            fTwoButton.TabIndex = 77;
            fTwoButton.UseVisualStyleBackColor = false;
            fTwoButton.Click += Square_Click;
            // 
            // eTwoButton
            // 
            eTwoButton.BackColor = SystemColors.HighlightText;
            eTwoButton.FlatStyle = FlatStyle.Flat;
            eTwoButton.Location = new Point(649, 838);
            eTwoButton.Margin = new Padding(0);
            eTwoButton.Name = "eTwoButton";
            eTwoButton.Size = new Size(100, 100);
            eTwoButton.TabIndex = 76;
            eTwoButton.UseVisualStyleBackColor = false;
            eTwoButton.Click += Square_Click;
            // 
            // dTwoButton
            // 
            dTwoButton.BackColor = SystemColors.AppWorkspace;
            dTwoButton.FlatStyle = FlatStyle.Flat;
            dTwoButton.Location = new Point(549, 838);
            dTwoButton.Margin = new Padding(0);
            dTwoButton.Name = "dTwoButton";
            dTwoButton.Size = new Size(100, 100);
            dTwoButton.TabIndex = 75;
            dTwoButton.UseVisualStyleBackColor = false;
            dTwoButton.Click += Square_Click;
            // 
            // cTwoButton
            // 
            cTwoButton.BackColor = SystemColors.HighlightText;
            cTwoButton.FlatStyle = FlatStyle.Flat;
            cTwoButton.Location = new Point(449, 838);
            cTwoButton.Margin = new Padding(0);
            cTwoButton.Name = "cTwoButton";
            cTwoButton.Size = new Size(100, 100);
            cTwoButton.TabIndex = 74;
            cTwoButton.UseVisualStyleBackColor = false;
            cTwoButton.Click += Square_Click;
            // 
            // bTwoButton
            // 
            bTwoButton.BackColor = SystemColors.AppWorkspace;
            bTwoButton.FlatStyle = FlatStyle.Flat;
            bTwoButton.Location = new Point(349, 838);
            bTwoButton.Margin = new Padding(0);
            bTwoButton.Name = "bTwoButton";
            bTwoButton.Size = new Size(100, 100);
            bTwoButton.TabIndex = 73;
            bTwoButton.UseVisualStyleBackColor = false;
            bTwoButton.Click += Square_Click;
            // 
            // aTwoButton
            // 
            aTwoButton.BackColor = SystemColors.HighlightText;
            aTwoButton.FlatStyle = FlatStyle.Flat;
            aTwoButton.Location = new Point(249, 838);
            aTwoButton.Margin = new Padding(0);
            aTwoButton.Name = "aTwoButton";
            aTwoButton.Size = new Size(100, 100);
            aTwoButton.TabIndex = 72;
            aTwoButton.UseVisualStyleBackColor = false;
            aTwoButton.Click += Square_Click;
            // 
            // hOneButton
            // 
            hOneButton.BackColor = SystemColors.HighlightText;
            hOneButton.FlatStyle = FlatStyle.Flat;
            hOneButton.Location = new Point(949, 938);
            hOneButton.Margin = new Padding(0);
            hOneButton.Name = "hOneButton";
            hOneButton.Size = new Size(100, 100);
            hOneButton.TabIndex = 69;
            hOneButton.UseVisualStyleBackColor = false;
            hOneButton.Click += Square_Click;
            // 
            // gOneButton
            // 
            gOneButton.BackColor = SystemColors.AppWorkspace;
            gOneButton.FlatStyle = FlatStyle.Flat;
            gOneButton.Location = new Point(849, 938);
            gOneButton.Margin = new Padding(0);
            gOneButton.Name = "gOneButton";
            gOneButton.Size = new Size(100, 100);
            gOneButton.TabIndex = 68;
            gOneButton.UseVisualStyleBackColor = false;
            gOneButton.Click += Square_Click;
            // 
            // fOneButton
            // 
            fOneButton.BackColor = SystemColors.HighlightText;
            fOneButton.FlatStyle = FlatStyle.Flat;
            fOneButton.Location = new Point(749, 938);
            fOneButton.Margin = new Padding(0);
            fOneButton.Name = "fOneButton";
            fOneButton.Size = new Size(100, 100);
            fOneButton.TabIndex = 67;
            fOneButton.UseVisualStyleBackColor = false;
            fOneButton.Click += Square_Click;
            // 
            // eOneButton
            // 
            eOneButton.BackColor = SystemColors.AppWorkspace;
            eOneButton.FlatStyle = FlatStyle.Flat;
            eOneButton.Location = new Point(649, 938);
            eOneButton.Margin = new Padding(0);
            eOneButton.Name = "eOneButton";
            eOneButton.Size = new Size(100, 100);
            eOneButton.TabIndex = 66;
            eOneButton.UseVisualStyleBackColor = false;
            eOneButton.Click += Square_Click;
            // 
            // dOneButton
            // 
            dOneButton.BackColor = SystemColors.HighlightText;
            dOneButton.FlatStyle = FlatStyle.Flat;
            dOneButton.Location = new Point(549, 938);
            dOneButton.Margin = new Padding(0);
            dOneButton.Name = "dOneButton";
            dOneButton.Size = new Size(100, 100);
            dOneButton.TabIndex = 65;
            dOneButton.UseVisualStyleBackColor = false;
            dOneButton.Click += Square_Click;
            // 
            // cOneButton
            // 
            cOneButton.BackColor = SystemColors.AppWorkspace;
            cOneButton.FlatStyle = FlatStyle.Flat;
            cOneButton.Location = new Point(449, 938);
            cOneButton.Margin = new Padding(0);
            cOneButton.Name = "cOneButton";
            cOneButton.Size = new Size(100, 100);
            cOneButton.TabIndex = 64;
            cOneButton.UseVisualStyleBackColor = false;
            cOneButton.Click += Square_Click;
            // 
            // bOneButton
            // 
            bOneButton.BackColor = SystemColors.HighlightText;
            bOneButton.FlatStyle = FlatStyle.Flat;
            bOneButton.Location = new Point(349, 938);
            bOneButton.Margin = new Padding(0);
            bOneButton.Name = "bOneButton";
            bOneButton.Size = new Size(100, 100);
            bOneButton.TabIndex = 63;
            bOneButton.UseVisualStyleBackColor = false;
            bOneButton.Click += Square_Click;
            // 
            // aOneButton
            // 
            aOneButton.BackColor = SystemColors.AppWorkspace;
            aOneButton.FlatStyle = FlatStyle.Flat;
            aOneButton.Location = new Point(249, 938);
            aOneButton.Margin = new Padding(0);
            aOneButton.Name = "aOneButton";
            aOneButton.Size = new Size(100, 100);
            aOneButton.TabIndex = 62;
            aOneButton.UseVisualStyleBackColor = false;
            aOneButton.Click += Square_Click;
            // 
            // selectedPieceLabel
            // 
            selectedPieceLabel.AutoSize = true;
            selectedPieceLabel.Location = new Point(16, 197);
            selectedPieceLabel.Name = "selectedPieceLabel";
            selectedPieceLabel.Size = new Size(209, 41);
            selectedPieceLabel.TabIndex = 80;
            selectedPieceLabel.Text = "Selected Piece";
            // 
            // selectedPiece
            // 
            selectedPiece.Location = new Point(16, 264);
            selectedPiece.Name = "selectedPiece";
            selectedPiece.ReadOnly = true;
            selectedPiece.Size = new Size(209, 47);
            selectedPiece.TabIndex = 81;
            // 
            // deselectPieceButton
            // 
            deselectPieceButton.Location = new Point(13, 342);
            deselectPieceButton.Name = "deselectPieceButton";
            deselectPieceButton.Size = new Size(212, 58);
            deselectPieceButton.TabIndex = 82;
            deselectPieceButton.Text = "Deselect";
            deselectPieceButton.UseVisualStyleBackColor = true;
            deselectPieceButton.Click += deselectPieceButton_Click;
            // 
            // whiteDepth
            // 
            whiteDepth.Location = new Point(116, 64);
            whiteDepth.Name = "whiteDepth";
            whiteDepth.Size = new Size(300, 47);
            whiteDepth.TabIndex = 83;
            // 
            // blackDepth
            // 
            blackDepth.Location = new Point(613, 66);
            blackDepth.Name = "blackDepth";
            blackDepth.Size = new Size(300, 47);
            blackDepth.TabIndex = 84;
            // 
            // PromoteKnightButton
            // 
            PromoteKnightButton.BackColor = SystemColors.AppWorkspace;
            PromoteKnightButton.FlatStyle = FlatStyle.Flat;
            PromoteKnightButton.Image = (Image)resources.GetObject("PromoteKnightButton.Image");
            PromoteKnightButton.Location = new Point(63, 737);
            PromoteKnightButton.Margin = new Padding(0);
            PromoteKnightButton.Name = "PromoteKnightButton";
            PromoteKnightButton.Size = new Size(100, 100);
            PromoteKnightButton.TabIndex = 88;
            PromoteKnightButton.UseVisualStyleBackColor = false;
            PromoteKnightButton.Click += PromoteButton_Click;
            // 
            // PromoteBishopButton
            // 
            PromoteBishopButton.BackColor = SystemColors.HighlightText;
            PromoteBishopButton.FlatStyle = FlatStyle.Flat;
            PromoteBishopButton.Image = (Image)resources.GetObject("PromoteBishopButton.Image");
            PromoteBishopButton.Location = new Point(63, 637);
            PromoteBishopButton.Margin = new Padding(0);
            PromoteBishopButton.Name = "PromoteBishopButton";
            PromoteBishopButton.Size = new Size(100, 100);
            PromoteBishopButton.TabIndex = 87;
            PromoteBishopButton.UseVisualStyleBackColor = false;
            PromoteBishopButton.Click += PromoteButton_Click;
            // 
            // PromoteRookButton
            // 
            PromoteRookButton.BackColor = SystemColors.AppWorkspace;
            PromoteRookButton.FlatStyle = FlatStyle.Flat;
            PromoteRookButton.Image = (Image)resources.GetObject("PromoteRookButton.Image");
            PromoteRookButton.Location = new Point(63, 537);
            PromoteRookButton.Margin = new Padding(0);
            PromoteRookButton.Name = "PromoteRookButton";
            PromoteRookButton.Size = new Size(100, 100);
            PromoteRookButton.TabIndex = 86;
            PromoteRookButton.UseVisualStyleBackColor = false;
            PromoteRookButton.Click += PromoteButton_Click;
            // 
            // PromoteQueenButton
            // 
            PromoteQueenButton.BackColor = SystemColors.HighlightText;
            PromoteQueenButton.FlatStyle = FlatStyle.Flat;
            PromoteQueenButton.Image = (Image)resources.GetObject("PromoteQueenButton.Image");
            PromoteQueenButton.Location = new Point(63, 437);
            PromoteQueenButton.Margin = new Padding(0);
            PromoteQueenButton.Name = "PromoteQueenButton";
            PromoteQueenButton.Size = new Size(100, 100);
            PromoteQueenButton.TabIndex = 85;
            PromoteQueenButton.UseVisualStyleBackColor = false;
            PromoteQueenButton.Click += PromoteButton_Click;
            // 
            // FrontendForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 1057);
            Controls.Add(PromoteKnightButton);
            Controls.Add(PromoteBishopButton);
            Controls.Add(PromoteRookButton);
            Controls.Add(PromoteQueenButton);
            Controls.Add(blackDepth);
            Controls.Add(whiteDepth);
            Controls.Add(deselectPieceButton);
            Controls.Add(selectedPiece);
            Controls.Add(selectedPieceLabel);
            Controls.Add(hTwoButton);
            Controls.Add(gTwoButton);
            Controls.Add(fTwoButton);
            Controls.Add(eTwoButton);
            Controls.Add(dTwoButton);
            Controls.Add(cTwoButton);
            Controls.Add(bTwoButton);
            Controls.Add(aTwoButton);
            Controls.Add(hOneButton);
            Controls.Add(gOneButton);
            Controls.Add(fOneButton);
            Controls.Add(eOneButton);
            Controls.Add(dOneButton);
            Controls.Add(cOneButton);
            Controls.Add(bOneButton);
            Controls.Add(aOneButton);
            Controls.Add(hEightButton);
            Controls.Add(gEightButton);
            Controls.Add(fEightButton);
            Controls.Add(eEightButton);
            Controls.Add(dEightButton);
            Controls.Add(cEightButton);
            Controls.Add(bEightButton);
            Controls.Add(aEightButton);
            Controls.Add(hSevenButton);
            Controls.Add(gSevenButton);
            Controls.Add(fSevenButton);
            Controls.Add(eSevenButton);
            Controls.Add(dSevenButton);
            Controls.Add(cSevenButton);
            Controls.Add(bSevenButton);
            Controls.Add(aSevenButton);
            Controls.Add(hSixButton);
            Controls.Add(gSixButton);
            Controls.Add(fSixButton);
            Controls.Add(eSixButton);
            Controls.Add(dSixButton);
            Controls.Add(cSixButton);
            Controls.Add(bSixButton);
            Controls.Add(aSixButton);
            Controls.Add(hFiveButton);
            Controls.Add(gFiveButton);
            Controls.Add(fFiveButton);
            Controls.Add(eFiveButton);
            Controls.Add(dFiveButton);
            Controls.Add(cFiveButton);
            Controls.Add(bFiveButton);
            Controls.Add(aFiveButton);
            Controls.Add(hFourButton);
            Controls.Add(gFourButton);
            Controls.Add(fFourButton);
            Controls.Add(eFourButton);
            Controls.Add(dFourButton);
            Controls.Add(cFourButton);
            Controls.Add(bFourButton);
            Controls.Add(aFourButton);
            Controls.Add(hThreeButton);
            Controls.Add(gThreeButton);
            Controls.Add(fThreeButton);
            Controls.Add(eThreeButton);
            Controls.Add(dThreeButton);
            Controls.Add(cThreeButton);
            Controls.Add(bThreeButton);
            Controls.Add(aThreeButton);
            Controls.Add(blackDepthLabel);
            Controls.Add(whiteDepthLabel);
            Controls.Add(blackPlayer);
            Controls.Add(whitePlayer);
            Controls.Add(blackLabel);
            Controls.Add(whiteLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1126, 1145);
            MinimumSize = new Size(1126, 1145);
            Name = "FrontendForm";
            Text = "En Passant Chess Engine";
            ((System.ComponentModel.ISupportInitialize)whiteDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)blackDepth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label whiteLabel;
        private Label blackLabel;
        private ComboBox whitePlayer;
        private ComboBox blackPlayer;
        private Label whiteDepthLabel;
        private Label blackDepthLabel;
        private Button aThreeButton;
        private Button bThreeButton;
        private Button dThreeButton;
        private Button cThreeButton;
        private Button hThreeButton;
        private Button gThreeButton;
        private Button fThreeButton;
        private Button eThreeButton;
        private Button hFourButton;
        private Button gFourButton;
        private Button fFourButton;
        private Button eFourButton;
        private Button dFourButton;
        private Button cFourButton;
        private Button bFourButton;
        private Button aFourButton;
        private Button hSixButton;
        private Button gSixButton;
        private Button fSixButton;
        private Button eSixButton;
        private Button dSixButton;
        private Button cSixButton;
        private Button bSixButton;
        private Button aSixButton;
        private Button hFiveButton;
        private Button gFiveButton;
        private Button fFiveButton;
        private Button eFiveButton;
        private Button dFiveButton;
        private Button cFiveButton;
        private Button bFiveButton;
        private Button aFiveButton;
        private Button hEightButton;
        private Button gEightButton;
        private Button fEightButton;
        private Button eEightButton;
        private Button dEightButton;
        private Button cEightButton;
        private Button bEightButton;
        private Button aEightButton;
        private Button hSevenButton;
        private Button gSevenButton;
        private Button fSevenButton;
        private Button eSevenButton;
        private Button dSevenButton;
        private Button cSevenButton;
        private Button bSevenButton;
        private Button aSevenButton;
        private Button hTwoButton;
        private Button gTwoButton;
        private Button fTwoButton;
        private Button eTwoButton;
        private Button dTwoButton;
        private Button cTwoButton;
        private Button bTwoButton;
        private Button aTwoButton;
        private Button hOneButton;
        private Button gOneButton;
        private Button fOneButton;
        private Button eOneButton;
        private Button dOneButton;
        private Button cOneButton;
        private Button bOneButton;
        private Button aOneButton;
        private Label selectedPieceLabel;
        private TextBox selectedPiece;
        private Button deselectPieceButton;
        private NumericUpDown whiteDepth;
        private NumericUpDown blackDepth;
        private Button PromoteKnightButton;
        private Button PromoteBishopButton;
        private Button PromoteRookButton;
        private Button PromoteQueenButton;
    }
}
