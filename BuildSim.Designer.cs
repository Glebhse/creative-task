
namespace SimulationBuilding
{
    partial class BuildSim
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMachinesParams = new System.Windows.Forms.GroupBox();
            this.numericUpDownBullProfit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExcProfit = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBullLoss = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExcLoss = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExpWorkBulldozer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExpWorkExcavator = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMachinesParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBullProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExcProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBullLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExcLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpWorkBulldozer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpWorkExcavator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMachinesParams
            // 
            this.groupBoxMachinesParams.Controls.Add(this.numericUpDownBullProfit);
            this.groupBoxMachinesParams.Controls.Add(this.numericUpDownExcProfit);
            this.groupBoxMachinesParams.Controls.Add(this.numericUpDownBullLoss);
            this.groupBoxMachinesParams.Controls.Add(this.numericUpDownExcLoss);
            this.groupBoxMachinesParams.Controls.Add(this.numericUpDownExpWorkBulldozer);
            this.groupBoxMachinesParams.Controls.Add(this.numericUpDownExpWorkExcavator);
            this.groupBoxMachinesParams.Controls.Add(this.label2);
            this.groupBoxMachinesParams.Controls.Add(this.label5);
            this.groupBoxMachinesParams.Controls.Add(this.label4);
            this.groupBoxMachinesParams.Controls.Add(this.label3);
            this.groupBoxMachinesParams.Controls.Add(this.label1);
            this.groupBoxMachinesParams.Location = new System.Drawing.Point(36, 37);
            this.groupBoxMachinesParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMachinesParams.Name = "groupBoxMachinesParams";
            this.groupBoxMachinesParams.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMachinesParams.Size = new System.Drawing.Size(792, 229);
            this.groupBoxMachinesParams.TabIndex = 1;
            this.groupBoxMachinesParams.TabStop = false;
            this.groupBoxMachinesParams.Text = "Параметры работы оборудования";
            // 
            // numericUpDownBullProfit
            // 
            this.numericUpDownBullProfit.Location = new System.Drawing.Point(610, 169);
            this.numericUpDownBullProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownBullProfit.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownBullProfit.Name = "numericUpDownBullProfit";
            this.numericUpDownBullProfit.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownBullProfit.TabIndex = 1;
            this.numericUpDownBullProfit.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownExcProfit
            // 
            this.numericUpDownExcProfit.Location = new System.Drawing.Point(406, 169);
            this.numericUpDownExcProfit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownExcProfit.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownExcProfit.Name = "numericUpDownExcProfit";
            this.numericUpDownExcProfit.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownExcProfit.TabIndex = 1;
            this.numericUpDownExcProfit.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericUpDownBullLoss
            // 
            this.numericUpDownBullLoss.Location = new System.Drawing.Point(610, 115);
            this.numericUpDownBullLoss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownBullLoss.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownBullLoss.Name = "numericUpDownBullLoss";
            this.numericUpDownBullLoss.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownBullLoss.TabIndex = 1;
            this.numericUpDownBullLoss.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownExcLoss
            // 
            this.numericUpDownExcLoss.Location = new System.Drawing.Point(406, 115);
            this.numericUpDownExcLoss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownExcLoss.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownExcLoss.Name = "numericUpDownExcLoss";
            this.numericUpDownExcLoss.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownExcLoss.TabIndex = 1;
            this.numericUpDownExcLoss.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericUpDownExpWorkBulldozer
            // 
            this.numericUpDownExpWorkBulldozer.Location = new System.Drawing.Point(610, 68);
            this.numericUpDownExpWorkBulldozer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownExpWorkBulldozer.Name = "numericUpDownExpWorkBulldozer";
            this.numericUpDownExpWorkBulldozer.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownExpWorkBulldozer.TabIndex = 1;
            this.numericUpDownExpWorkBulldozer.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDownExpWorkExcavator
            // 
            this.numericUpDownExpWorkExcavator.Location = new System.Drawing.Point(406, 68);
            this.numericUpDownExpWorkExcavator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownExpWorkExcavator.Name = "numericUpDownExpWorkExcavator";
            this.numericUpDownExpWorkExcavator.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownExpWorkExcavator.TabIndex = 1;
            this.numericUpDownExpWorkExcavator.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(606, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Бульдозер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Размер прибыли в час, руб.";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(412, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Размер убытков в час, руб.";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Математическое ожидание времени работы, час";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(402, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Экскаватор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuildSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 781);
            this.Controls.Add(this.groupBoxMachinesParams);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildSim";
            this.Text = "Имитационное моделирование работы строительных машин";
            this.groupBoxMachinesParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBullProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExcProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBullLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExcLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpWorkBulldozer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpWorkExcavator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMachinesParams;
        private System.Windows.Forms.NumericUpDown numericUpDownBullProfit;
        private System.Windows.Forms.NumericUpDown numericUpDownExcProfit;
        private System.Windows.Forms.NumericUpDown numericUpDownBullLoss;
        private System.Windows.Forms.NumericUpDown numericUpDownExcLoss;
        private System.Windows.Forms.NumericUpDown numericUpDownExpWorkBulldozer;
        private System.Windows.Forms.NumericUpDown numericUpDownExpWorkExcavator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

