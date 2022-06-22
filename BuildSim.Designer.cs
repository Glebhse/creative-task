
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxModelDay = new System.Windows.Forms.TextBox();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDayStatistic = new System.Windows.Forms.RichTextBox();
            this.richTextBoxModelingLog = new System.Windows.Forms.RichTextBox();
            this.btnLastDay = new System.Windows.Forms.Button();
            this.btnStopModeling = new System.Windows.Forms.Button();
            this.btnStartModeling = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxModelDay);
            this.groupBox4.Controls.Add(this.richTextBoxResults);
            this.groupBox4.Controls.Add(this.richTextBoxDayStatistic);
            this.groupBox4.Controls.Add(this.richTextBoxModelingLog);
            this.groupBox4.Controls.Add(this.btnLastDay);
            this.groupBox4.Controls.Add(this.btnStopModeling);
            this.groupBox4.Controls.Add(this.btnStartModeling);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnNextDay);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(728, 37);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1223, 910);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результаты моделирования";
            // 
            // textBoxModelDay
            // 
            this.textBoxModelDay.Enabled = false;
            this.textBoxModelDay.Location = new System.Drawing.Point(167, 80);
            this.textBoxModelDay.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModelDay.Name = "textBoxModelDay";
            this.textBoxModelDay.Size = new System.Drawing.Size(88, 22);
            this.textBoxModelDay.TabIndex = 2;
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(621, 309);
            this.richTextBoxResults.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.ReadOnly = true;
            this.richTextBoxResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxResults.Size = new System.Drawing.Size(592, 586);
            this.richTextBoxResults.TabIndex = 1;
            this.richTextBoxResults.Text = "   ";
            // 
            // richTextBoxDayStatistic
            // 
            this.richTextBoxDayStatistic.Location = new System.Drawing.Point(8, 309);
            this.richTextBoxDayStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDayStatistic.Name = "richTextBoxDayStatistic";
            this.richTextBoxDayStatistic.ReadOnly = true;
            this.richTextBoxDayStatistic.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxDayStatistic.Size = new System.Drawing.Size(604, 586);
            this.richTextBoxDayStatistic.TabIndex = 1;
            this.richTextBoxDayStatistic.Text = "   ";
            // 
            // richTextBoxModelingLog
            // 
            this.richTextBoxModelingLog.Location = new System.Drawing.Point(8, 145);
            this.richTextBoxModelingLog.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxModelingLog.Name = "richTextBoxModelingLog";
            this.richTextBoxModelingLog.ReadOnly = true;
            this.richTextBoxModelingLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxModelingLog.Size = new System.Drawing.Size(880, 141);
            this.richTextBoxModelingLog.TabIndex = 1;
            this.richTextBoxModelingLog.Text = "";
            // 
            // btnLastDay
            // 
            this.btnLastDay.Location = new System.Drawing.Point(739, 33);
            this.btnLastDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnLastDay.Name = "btnLastDay";
            this.btnLastDay.Size = new System.Drawing.Size(151, 28);
            this.btnLastDay.TabIndex = 0;
            this.btnLastDay.Text = "Конец периода";
            this.btnLastDay.UseVisualStyleBackColor = true;
            // 
            // btnStopModeling
            // 
            this.btnStopModeling.Location = new System.Drawing.Point(195, 33);
            this.btnStopModeling.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopModeling.Name = "btnStopModeling";
            this.btnStopModeling.Size = new System.Drawing.Size(215, 28);
            this.btnStopModeling.TabIndex = 0;
            this.btnStopModeling.Text = "Остановить моделирование";
            this.btnStopModeling.UseVisualStyleBackColor = true;
            // 
            // btnStartModeling
            // 
            this.btnStartModeling.Location = new System.Drawing.Point(12, 33);
            this.btnStartModeling.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartModeling.Name = "btnStartModeling";
            this.btnStartModeling.Size = new System.Drawing.Size(175, 28);
            this.btnStartModeling.TabIndex = 0;
            this.btnStartModeling.Text = "Старт моделирования";
            this.btnStartModeling.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(8, 121);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(367, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Расписание на день моделирования:";
            this.label17.UseCompatibleTextRendering = true;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(621, 290);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(457, 30);
            this.label20.TabIndex = 0;
            this.label20.Text = "Общие результаты за весь период моделирования:";
            this.label20.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(8, 290);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(367, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Результаты за день моделирования:";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(581, 33);
            this.btnNextDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(151, 28);
            this.btnNextDay.TabIndex = 0;
            this.btnNextDay.Text = "Следующий день";
            this.btnNextDay.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(8, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "День моделирования: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BuildSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 781);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildSim";
            this.Text = "Имитационное моделирование работы строительных машин";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxModelDay;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.RichTextBox richTextBoxDayStatistic;
        private System.Windows.Forms.RichTextBox richTextBoxModelingLog;
        private System.Windows.Forms.Button btnLastDay;
        private System.Windows.Forms.Button btnStopModeling;
        private System.Windows.Forms.Button btnStartModeling;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Label label15;
    }
}

