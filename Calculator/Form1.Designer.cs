
namespace Calculator
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.realCalc = new System.Windows.Forms.TabPage();
            this.labelRealRes = new System.Windows.Forms.Label();
            this.labelRealB = new System.Windows.Forms.Label();
            this.lableRealA = new System.Windows.Forms.Label();
            this.realRes = new System.Windows.Forms.TextBox();
            this.realDiv = new System.Windows.Forms.Button();
            this.realMult = new System.Windows.Forms.Button();
            this.realSubstr = new System.Windows.Forms.Button();
            this.realSum = new System.Windows.Forms.Button();
            this.realB = new System.Windows.Forms.TextBox();
            this.realA = new System.Windows.Forms.TextBox();
            this.complexCalc = new System.Windows.Forms.TabPage();
            this.complexImgLabelRes = new System.Windows.Forms.Label();
            this.complexImgRes = new System.Windows.Forms.TextBox();
            this.complexRealRes = new System.Windows.Forms.TextBox();
            this.complexResLable = new System.Windows.Forms.Label();
            this.complexBLabel = new System.Windows.Forms.Label();
            this.complexImgLabelB = new System.Windows.Forms.Label();
            this.complexImgLabelA = new System.Windows.Forms.Label();
            this.complexALabel = new System.Windows.Forms.Label();
            this.complexImgB = new System.Windows.Forms.TextBox();
            this.complexRealB = new System.Windows.Forms.TextBox();
            this.complexImgA = new System.Windows.Forms.TextBox();
            this.complexRealA = new System.Windows.Forms.TextBox();
            this.complexDiv = new System.Windows.Forms.Button();
            this.complexMult = new System.Windows.Forms.Button();
            this.complexSubstr = new System.Windows.Forms.Button();
            this.complexSum = new System.Windows.Forms.Button();
            this.quantCalc = new System.Windows.Forms.TabPage();
            this.quantVecZRes = new System.Windows.Forms.TextBox();
            this.quantVecYRes = new System.Windows.Forms.TextBox();
            this.quantVecXRes = new System.Windows.Forms.TextBox();
            this.quantRealRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantVecZB = new System.Windows.Forms.TextBox();
            this.quantVecYB = new System.Windows.Forms.TextBox();
            this.quantVecXB = new System.Windows.Forms.TextBox();
            this.quantRealB = new System.Windows.Forms.TextBox();
            this.quantVecZA = new System.Windows.Forms.TextBox();
            this.quantVecYA = new System.Windows.Forms.TextBox();
            this.quantVecXA = new System.Windows.Forms.TextBox();
            this.quantRealA = new System.Windows.Forms.TextBox();
            this.quantLabelB = new System.Windows.Forms.Label();
            this.quantLabelA = new System.Windows.Forms.Label();
            this.quantDiv = new System.Windows.Forms.Button();
            this.quantMult = new System.Windows.Forms.Button();
            this.quantSubstr = new System.Windows.Forms.Button();
            this.quantSum = new System.Windows.Forms.Button();
            this.moduleNCalc = new System.Windows.Forms.TabPage();
            this.modLabelRes = new System.Windows.Forms.Label();
            this.modRes = new System.Windows.Forms.TextBox();
            this.modDiv = new System.Windows.Forms.Button();
            this.modMult = new System.Windows.Forms.Button();
            this.modSubstr = new System.Windows.Forms.Button();
            this.modSum = new System.Windows.Forms.Button();
            this.modNumN = new System.Windows.Forms.TextBox();
            this.modNumB = new System.Windows.Forms.TextBox();
            this.modNumA = new System.Windows.Forms.TextBox();
            this.modLabelMod = new System.Windows.Forms.Label();
            this.modLabelB = new System.Windows.Forms.Label();
            this.modLabelA = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.realCalc.SuspendLayout();
            this.complexCalc.SuspendLayout();
            this.quantCalc.SuspendLayout();
            this.moduleNCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.realCalc);
            this.tabControl1.Controls.Add(this.complexCalc);
            this.tabControl1.Controls.Add(this.quantCalc);
            this.tabControl1.Controls.Add(this.moduleNCalc);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 169);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // realCalc
            // 
            this.realCalc.Controls.Add(this.labelRealRes);
            this.realCalc.Controls.Add(this.labelRealB);
            this.realCalc.Controls.Add(this.lableRealA);
            this.realCalc.Controls.Add(this.realRes);
            this.realCalc.Controls.Add(this.realDiv);
            this.realCalc.Controls.Add(this.realMult);
            this.realCalc.Controls.Add(this.realSubstr);
            this.realCalc.Controls.Add(this.realSum);
            this.realCalc.Controls.Add(this.realB);
            this.realCalc.Controls.Add(this.realA);
            this.realCalc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.realCalc.Location = new System.Drawing.Point(4, 22);
            this.realCalc.Name = "realCalc";
            this.realCalc.Padding = new System.Windows.Forms.Padding(3);
            this.realCalc.Size = new System.Drawing.Size(392, 143);
            this.realCalc.TabIndex = 1;
            this.realCalc.Text = "Действительные";
            this.realCalc.UseVisualStyleBackColor = true;
            // 
            // labelRealRes
            // 
            this.labelRealRes.AutoSize = true;
            this.labelRealRes.Location = new System.Drawing.Point(20, 87);
            this.labelRealRes.Name = "labelRealRes";
            this.labelRealRes.Size = new System.Drawing.Size(59, 13);
            this.labelRealRes.TabIndex = 9;
            this.labelRealRes.Text = "Результат";
            // 
            // labelRealB
            // 
            this.labelRealB.AutoSize = true;
            this.labelRealB.Location = new System.Drawing.Point(145, 24);
            this.labelRealB.Name = "labelRealB";
            this.labelRealB.Size = new System.Drawing.Size(49, 13);
            this.labelRealB.TabIndex = 8;
            this.labelRealB.Text = "Число B";
            // 
            // lableRealA
            // 
            this.lableRealA.AutoSize = true;
            this.lableRealA.Location = new System.Drawing.Point(20, 24);
            this.lableRealA.Name = "lableRealA";
            this.lableRealA.Size = new System.Drawing.Size(49, 13);
            this.lableRealA.TabIndex = 7;
            this.lableRealA.Text = "Число А";
            // 
            // realRes
            // 
            this.realRes.Location = new System.Drawing.Point(23, 106);
            this.realRes.Name = "realRes";
            this.realRes.Size = new System.Drawing.Size(241, 20);
            this.realRes.TabIndex = 6;
            // 
            // realDiv
            // 
            this.realDiv.Location = new System.Drawing.Point(286, 106);
            this.realDiv.Name = "realDiv";
            this.realDiv.Size = new System.Drawing.Size(100, 23);
            this.realDiv.TabIndex = 5;
            this.realDiv.Text = "Частное";
            this.realDiv.UseVisualStyleBackColor = true;
            this.realDiv.Click += new System.EventHandler(this.realDiv_Click);
            // 
            // realMult
            // 
            this.realMult.Location = new System.Drawing.Point(286, 77);
            this.realMult.Name = "realMult";
            this.realMult.Size = new System.Drawing.Size(100, 23);
            this.realMult.TabIndex = 4;
            this.realMult.Text = "Произведение";
            this.realMult.UseVisualStyleBackColor = true;
            this.realMult.Click += new System.EventHandler(this.realMult_Click);
            // 
            // realSubstr
            // 
            this.realSubstr.Location = new System.Drawing.Point(286, 48);
            this.realSubstr.Name = "realSubstr";
            this.realSubstr.Size = new System.Drawing.Size(100, 23);
            this.realSubstr.TabIndex = 3;
            this.realSubstr.Text = "Разность";
            this.realSubstr.UseVisualStyleBackColor = true;
            this.realSubstr.Click += new System.EventHandler(this.realSubstr_Click);
            // 
            // realSum
            // 
            this.realSum.Location = new System.Drawing.Point(286, 19);
            this.realSum.Name = "realSum";
            this.realSum.Size = new System.Drawing.Size(100, 23);
            this.realSum.TabIndex = 2;
            this.realSum.Text = "Сумма";
            this.realSum.UseVisualStyleBackColor = true;
            this.realSum.Click += new System.EventHandler(this.realSum_Click);
            // 
            // realB
            // 
            this.realB.Location = new System.Drawing.Point(148, 48);
            this.realB.Name = "realB";
            this.realB.Size = new System.Drawing.Size(116, 20);
            this.realB.TabIndex = 1;
            // 
            // realA
            // 
            this.realA.Location = new System.Drawing.Point(23, 48);
            this.realA.Name = "realA";
            this.realA.Size = new System.Drawing.Size(119, 20);
            this.realA.TabIndex = 0;
            // 
            // complexCalc
            // 
            this.complexCalc.Controls.Add(this.complexImgLabelRes);
            this.complexCalc.Controls.Add(this.complexImgRes);
            this.complexCalc.Controls.Add(this.complexRealRes);
            this.complexCalc.Controls.Add(this.complexResLable);
            this.complexCalc.Controls.Add(this.complexBLabel);
            this.complexCalc.Controls.Add(this.complexImgLabelB);
            this.complexCalc.Controls.Add(this.complexImgLabelA);
            this.complexCalc.Controls.Add(this.complexALabel);
            this.complexCalc.Controls.Add(this.complexImgB);
            this.complexCalc.Controls.Add(this.complexRealB);
            this.complexCalc.Controls.Add(this.complexImgA);
            this.complexCalc.Controls.Add(this.complexRealA);
            this.complexCalc.Controls.Add(this.complexDiv);
            this.complexCalc.Controls.Add(this.complexMult);
            this.complexCalc.Controls.Add(this.complexSubstr);
            this.complexCalc.Controls.Add(this.complexSum);
            this.complexCalc.Location = new System.Drawing.Point(4, 22);
            this.complexCalc.Name = "complexCalc";
            this.complexCalc.Size = new System.Drawing.Size(392, 143);
            this.complexCalc.TabIndex = 2;
            this.complexCalc.Text = "Комплексные";
            this.complexCalc.UseVisualStyleBackColor = true;
            // 
            // complexImgLabelRes
            // 
            this.complexImgLabelRes.AutoSize = true;
            this.complexImgLabelRes.Location = new System.Drawing.Point(109, 109);
            this.complexImgLabelRes.Name = "complexImgLabelRes";
            this.complexImgLabelRes.Size = new System.Drawing.Size(18, 13);
            this.complexImgLabelRes.TabIndex = 15;
            this.complexImgLabelRes.Text = "+ i";
            // 
            // complexImgRes
            // 
            this.complexImgRes.Location = new System.Drawing.Point(133, 106);
            this.complexImgRes.Name = "complexImgRes";
            this.complexImgRes.Size = new System.Drawing.Size(111, 20);
            this.complexImgRes.TabIndex = 14;
            // 
            // complexRealRes
            // 
            this.complexRealRes.Location = new System.Drawing.Point(23, 106);
            this.complexRealRes.Name = "complexRealRes";
            this.complexRealRes.Size = new System.Drawing.Size(80, 20);
            this.complexRealRes.TabIndex = 13;
            // 
            // complexResLable
            // 
            this.complexResLable.AutoSize = true;
            this.complexResLable.Location = new System.Drawing.Point(20, 87);
            this.complexResLable.Name = "complexResLable";
            this.complexResLable.Size = new System.Drawing.Size(59, 13);
            this.complexResLable.TabIndex = 12;
            this.complexResLable.Text = "Результат";
            // 
            // complexBLabel
            // 
            this.complexBLabel.AutoSize = true;
            this.complexBLabel.Location = new System.Drawing.Point(157, 24);
            this.complexBLabel.Name = "complexBLabel";
            this.complexBLabel.Size = new System.Drawing.Size(49, 13);
            this.complexBLabel.TabIndex = 11;
            this.complexBLabel.Text = "Число B";
            // 
            // complexImgLabelB
            // 
            this.complexImgLabelB.AutoSize = true;
            this.complexImgLabelB.Location = new System.Drawing.Point(208, 51);
            this.complexImgLabelB.Name = "complexImgLabelB";
            this.complexImgLabelB.Size = new System.Drawing.Size(18, 13);
            this.complexImgLabelB.TabIndex = 10;
            this.complexImgLabelB.Text = "+ i";
            // 
            // complexImgLabelA
            // 
            this.complexImgLabelA.AutoSize = true;
            this.complexImgLabelA.Location = new System.Drawing.Point(71, 51);
            this.complexImgLabelA.Name = "complexImgLabelA";
            this.complexImgLabelA.Size = new System.Drawing.Size(18, 13);
            this.complexImgLabelA.TabIndex = 9;
            this.complexImgLabelA.Text = "+ i";
            // 
            // complexALabel
            // 
            this.complexALabel.AutoSize = true;
            this.complexALabel.Location = new System.Drawing.Point(20, 24);
            this.complexALabel.Name = "complexALabel";
            this.complexALabel.Size = new System.Drawing.Size(49, 13);
            this.complexALabel.TabIndex = 8;
            this.complexALabel.Text = "Число А";
            // 
            // complexImgB
            // 
            this.complexImgB.Location = new System.Drawing.Point(229, 48);
            this.complexImgB.Name = "complexImgB";
            this.complexImgB.Size = new System.Drawing.Size(51, 20);
            this.complexImgB.TabIndex = 7;
            // 
            // complexRealB
            // 
            this.complexRealB.Location = new System.Drawing.Point(160, 48);
            this.complexRealB.Name = "complexRealB";
            this.complexRealB.Size = new System.Drawing.Size(42, 20);
            this.complexRealB.TabIndex = 6;
            // 
            // complexImgA
            // 
            this.complexImgA.Location = new System.Drawing.Point(95, 48);
            this.complexImgA.Name = "complexImgA";
            this.complexImgA.Size = new System.Drawing.Size(51, 20);
            this.complexImgA.TabIndex = 5;
            // 
            // complexRealA
            // 
            this.complexRealA.Location = new System.Drawing.Point(23, 48);
            this.complexRealA.Name = "complexRealA";
            this.complexRealA.Size = new System.Drawing.Size(42, 20);
            this.complexRealA.TabIndex = 4;
            // 
            // complexDiv
            // 
            this.complexDiv.Location = new System.Drawing.Point(286, 106);
            this.complexDiv.Name = "complexDiv";
            this.complexDiv.Size = new System.Drawing.Size(100, 23);
            this.complexDiv.TabIndex = 3;
            this.complexDiv.Text = "Частное";
            this.complexDiv.UseVisualStyleBackColor = true;
            this.complexDiv.Click += new System.EventHandler(this.complexDiv_Click);
            // 
            // complexMult
            // 
            this.complexMult.Location = new System.Drawing.Point(286, 77);
            this.complexMult.Name = "complexMult";
            this.complexMult.Size = new System.Drawing.Size(100, 23);
            this.complexMult.TabIndex = 2;
            this.complexMult.Text = "Произведение";
            this.complexMult.UseVisualStyleBackColor = true;
            this.complexMult.Click += new System.EventHandler(this.complexMult_Click);
            // 
            // complexSubstr
            // 
            this.complexSubstr.Location = new System.Drawing.Point(286, 48);
            this.complexSubstr.Name = "complexSubstr";
            this.complexSubstr.Size = new System.Drawing.Size(100, 23);
            this.complexSubstr.TabIndex = 1;
            this.complexSubstr.Text = "Разность";
            this.complexSubstr.UseVisualStyleBackColor = true;
            this.complexSubstr.Click += new System.EventHandler(this.complexSubstr_Click);
            // 
            // complexSum
            // 
            this.complexSum.Location = new System.Drawing.Point(286, 19);
            this.complexSum.Name = "complexSum";
            this.complexSum.Size = new System.Drawing.Size(100, 23);
            this.complexSum.TabIndex = 0;
            this.complexSum.Text = "Сумма";
            this.complexSum.UseVisualStyleBackColor = true;
            this.complexSum.Click += new System.EventHandler(this.complexSum_Click);
            // 
            // quantCalc
            // 
            this.quantCalc.Controls.Add(this.quantVecZRes);
            this.quantCalc.Controls.Add(this.quantVecYRes);
            this.quantCalc.Controls.Add(this.quantVecXRes);
            this.quantCalc.Controls.Add(this.quantRealRes);
            this.quantCalc.Controls.Add(this.label2);
            this.quantCalc.Controls.Add(this.quantVecZB);
            this.quantCalc.Controls.Add(this.quantVecYB);
            this.quantCalc.Controls.Add(this.quantVecXB);
            this.quantCalc.Controls.Add(this.quantRealB);
            this.quantCalc.Controls.Add(this.quantVecZA);
            this.quantCalc.Controls.Add(this.quantVecYA);
            this.quantCalc.Controls.Add(this.quantVecXA);
            this.quantCalc.Controls.Add(this.quantRealA);
            this.quantCalc.Controls.Add(this.quantLabelB);
            this.quantCalc.Controls.Add(this.quantLabelA);
            this.quantCalc.Controls.Add(this.quantDiv);
            this.quantCalc.Controls.Add(this.quantMult);
            this.quantCalc.Controls.Add(this.quantSubstr);
            this.quantCalc.Controls.Add(this.quantSum);
            this.quantCalc.Location = new System.Drawing.Point(4, 22);
            this.quantCalc.Name = "quantCalc";
            this.quantCalc.Size = new System.Drawing.Size(392, 143);
            this.quantCalc.TabIndex = 3;
            this.quantCalc.Text = "Квантернионы";
            this.quantCalc.UseVisualStyleBackColor = true;
            // 
            // quantVecZRes
            // 
            this.quantVecZRes.Location = new System.Drawing.Point(181, 106);
            this.quantVecZRes.Name = "quantVecZRes";
            this.quantVecZRes.Size = new System.Drawing.Size(40, 20);
            this.quantVecZRes.TabIndex = 18;
            // 
            // quantVecYRes
            // 
            this.quantVecYRes.Location = new System.Drawing.Point(135, 106);
            this.quantVecYRes.Name = "quantVecYRes";
            this.quantVecYRes.Size = new System.Drawing.Size(40, 20);
            this.quantVecYRes.TabIndex = 17;
            // 
            // quantVecXRes
            // 
            this.quantVecXRes.Location = new System.Drawing.Point(89, 106);
            this.quantVecXRes.Name = "quantVecXRes";
            this.quantVecXRes.Size = new System.Drawing.Size(40, 20);
            this.quantVecXRes.TabIndex = 16;
            // 
            // quantRealRes
            // 
            this.quantRealRes.Location = new System.Drawing.Point(23, 106);
            this.quantRealRes.Name = "quantRealRes";
            this.quantRealRes.Size = new System.Drawing.Size(60, 20);
            this.quantRealRes.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Результат";
            // 
            // quantVecZB
            // 
            this.quantVecZB.Location = new System.Drawing.Point(251, 48);
            this.quantVecZB.Name = "quantVecZB";
            this.quantVecZB.Size = new System.Drawing.Size(21, 20);
            this.quantVecZB.TabIndex = 13;
            // 
            // quantVecYB
            // 
            this.quantVecYB.Location = new System.Drawing.Point(224, 48);
            this.quantVecYB.Name = "quantVecYB";
            this.quantVecYB.Size = new System.Drawing.Size(21, 20);
            this.quantVecYB.TabIndex = 12;
            // 
            // quantVecXB
            // 
            this.quantVecXB.Location = new System.Drawing.Point(197, 48);
            this.quantVecXB.Name = "quantVecXB";
            this.quantVecXB.Size = new System.Drawing.Size(21, 20);
            this.quantVecXB.TabIndex = 11;
            // 
            // quantRealB
            // 
            this.quantRealB.Location = new System.Drawing.Point(158, 48);
            this.quantRealB.Name = "quantRealB";
            this.quantRealB.Size = new System.Drawing.Size(33, 20);
            this.quantRealB.TabIndex = 10;
            // 
            // quantVecZA
            // 
            this.quantVecZA.Location = new System.Drawing.Point(116, 48);
            this.quantVecZA.Name = "quantVecZA";
            this.quantVecZA.Size = new System.Drawing.Size(21, 20);
            this.quantVecZA.TabIndex = 9;
            // 
            // quantVecYA
            // 
            this.quantVecYA.Location = new System.Drawing.Point(89, 48);
            this.quantVecYA.Name = "quantVecYA";
            this.quantVecYA.Size = new System.Drawing.Size(21, 20);
            this.quantVecYA.TabIndex = 8;
            // 
            // quantVecXA
            // 
            this.quantVecXA.Location = new System.Drawing.Point(62, 48);
            this.quantVecXA.Name = "quantVecXA";
            this.quantVecXA.Size = new System.Drawing.Size(21, 20);
            this.quantVecXA.TabIndex = 7;
            // 
            // quantRealA
            // 
            this.quantRealA.Location = new System.Drawing.Point(23, 48);
            this.quantRealA.Name = "quantRealA";
            this.quantRealA.Size = new System.Drawing.Size(33, 20);
            this.quantRealA.TabIndex = 6;
            // 
            // quantLabelB
            // 
            this.quantLabelB.AutoSize = true;
            this.quantLabelB.Location = new System.Drawing.Point(155, 24);
            this.quantLabelB.Name = "quantLabelB";
            this.quantLabelB.Size = new System.Drawing.Size(49, 13);
            this.quantLabelB.TabIndex = 5;
            this.quantLabelB.Text = "Число B";
            // 
            // quantLabelA
            // 
            this.quantLabelA.AutoSize = true;
            this.quantLabelA.Location = new System.Drawing.Point(20, 24);
            this.quantLabelA.Name = "quantLabelA";
            this.quantLabelA.Size = new System.Drawing.Size(49, 13);
            this.quantLabelA.TabIndex = 4;
            this.quantLabelA.Text = "Число А";
            // 
            // quantDiv
            // 
            this.quantDiv.Location = new System.Drawing.Point(286, 106);
            this.quantDiv.Name = "quantDiv";
            this.quantDiv.Size = new System.Drawing.Size(100, 23);
            this.quantDiv.TabIndex = 3;
            this.quantDiv.Text = "Частное";
            this.quantDiv.UseVisualStyleBackColor = true;
            this.quantDiv.Click += new System.EventHandler(this.quantDiv_Click);
            // 
            // quantMult
            // 
            this.quantMult.Location = new System.Drawing.Point(286, 77);
            this.quantMult.Name = "quantMult";
            this.quantMult.Size = new System.Drawing.Size(100, 23);
            this.quantMult.TabIndex = 2;
            this.quantMult.Text = "Произведение";
            this.quantMult.UseVisualStyleBackColor = true;
            this.quantMult.Click += new System.EventHandler(this.quantMult_Click);
            // 
            // quantSubstr
            // 
            this.quantSubstr.Location = new System.Drawing.Point(286, 48);
            this.quantSubstr.Name = "quantSubstr";
            this.quantSubstr.Size = new System.Drawing.Size(100, 23);
            this.quantSubstr.TabIndex = 1;
            this.quantSubstr.Text = "Разность";
            this.quantSubstr.UseVisualStyleBackColor = true;
            this.quantSubstr.Click += new System.EventHandler(this.quantSubstr_Click);
            // 
            // quantSum
            // 
            this.quantSum.Location = new System.Drawing.Point(286, 19);
            this.quantSum.Name = "quantSum";
            this.quantSum.Size = new System.Drawing.Size(100, 23);
            this.quantSum.TabIndex = 0;
            this.quantSum.Text = "Сумма";
            this.quantSum.UseVisualStyleBackColor = true;
            this.quantSum.Click += new System.EventHandler(this.quantSum_Click);
            // 
            // moduleNCalc
            // 
            this.moduleNCalc.Controls.Add(this.modLabelRes);
            this.moduleNCalc.Controls.Add(this.modRes);
            this.moduleNCalc.Controls.Add(this.modDiv);
            this.moduleNCalc.Controls.Add(this.modMult);
            this.moduleNCalc.Controls.Add(this.modSubstr);
            this.moduleNCalc.Controls.Add(this.modSum);
            this.moduleNCalc.Controls.Add(this.modNumN);
            this.moduleNCalc.Controls.Add(this.modNumB);
            this.moduleNCalc.Controls.Add(this.modNumA);
            this.moduleNCalc.Controls.Add(this.modLabelMod);
            this.moduleNCalc.Controls.Add(this.modLabelB);
            this.moduleNCalc.Controls.Add(this.modLabelA);
            this.moduleNCalc.Location = new System.Drawing.Point(4, 22);
            this.moduleNCalc.Name = "moduleNCalc";
            this.moduleNCalc.Size = new System.Drawing.Size(392, 143);
            this.moduleNCalc.TabIndex = 4;
            this.moduleNCalc.Text = "Модуль";
            this.moduleNCalc.UseVisualStyleBackColor = true;
            // 
            // modLabelRes
            // 
            this.modLabelRes.AutoSize = true;
            this.modLabelRes.Location = new System.Drawing.Point(20, 87);
            this.modLabelRes.Name = "modLabelRes";
            this.modLabelRes.Size = new System.Drawing.Size(59, 13);
            this.modLabelRes.TabIndex = 11;
            this.modLabelRes.Text = "Результат";
            // 
            // modRes
            // 
            this.modRes.Location = new System.Drawing.Point(23, 106);
            this.modRes.Name = "modRes";
            this.modRes.Size = new System.Drawing.Size(100, 20);
            this.modRes.TabIndex = 10;
            // 
            // modDiv
            // 
            this.modDiv.Location = new System.Drawing.Point(286, 106);
            this.modDiv.Name = "modDiv";
            this.modDiv.Size = new System.Drawing.Size(100, 23);
            this.modDiv.TabIndex = 9;
            this.modDiv.Text = "Частное";
            this.modDiv.UseVisualStyleBackColor = true;
            this.modDiv.Click += new System.EventHandler(this.modDiv_Click);
            // 
            // modMult
            // 
            this.modMult.Location = new System.Drawing.Point(286, 77);
            this.modMult.Name = "modMult";
            this.modMult.Size = new System.Drawing.Size(100, 23);
            this.modMult.TabIndex = 8;
            this.modMult.Text = "Произведение";
            this.modMult.UseVisualStyleBackColor = true;
            this.modMult.Click += new System.EventHandler(this.modMult_Click);
            // 
            // modSubstr
            // 
            this.modSubstr.Location = new System.Drawing.Point(286, 48);
            this.modSubstr.Name = "modSubstr";
            this.modSubstr.Size = new System.Drawing.Size(100, 23);
            this.modSubstr.TabIndex = 7;
            this.modSubstr.Text = "Разность";
            this.modSubstr.UseVisualStyleBackColor = true;
            this.modSubstr.Click += new System.EventHandler(this.modSubstr_Click);
            // 
            // modSum
            // 
            this.modSum.Location = new System.Drawing.Point(286, 19);
            this.modSum.Name = "modSum";
            this.modSum.Size = new System.Drawing.Size(100, 23);
            this.modSum.TabIndex = 6;
            this.modSum.Text = "Сумма";
            this.modSum.UseVisualStyleBackColor = true;
            this.modSum.Click += new System.EventHandler(this.modSum_Click);
            // 
            // modNumN
            // 
            this.modNumN.Location = new System.Drawing.Point(182, 48);
            this.modNumN.Name = "modNumN";
            this.modNumN.Size = new System.Drawing.Size(65, 20);
            this.modNumN.TabIndex = 5;
            // 
            // modNumB
            // 
            this.modNumB.Location = new System.Drawing.Point(99, 48);
            this.modNumB.Name = "modNumB";
            this.modNumB.Size = new System.Drawing.Size(65, 20);
            this.modNumB.TabIndex = 4;
            // 
            // modNumA
            // 
            this.modNumA.Location = new System.Drawing.Point(23, 48);
            this.modNumA.Name = "modNumA";
            this.modNumA.Size = new System.Drawing.Size(65, 20);
            this.modNumA.TabIndex = 3;
            // 
            // modLabelMod
            // 
            this.modLabelMod.AutoSize = true;
            this.modLabelMod.Location = new System.Drawing.Point(179, 24);
            this.modLabelMod.Name = "modLabelMod";
            this.modLabelMod.Size = new System.Drawing.Size(45, 13);
            this.modLabelMod.TabIndex = 2;
            this.modLabelMod.Text = "Модуль";
            // 
            // modLabelB
            // 
            this.modLabelB.AutoSize = true;
            this.modLabelB.Location = new System.Drawing.Point(96, 24);
            this.modLabelB.Name = "modLabelB";
            this.modLabelB.Size = new System.Drawing.Size(49, 13);
            this.modLabelB.TabIndex = 1;
            this.modLabelB.Text = "Число B";
            // 
            // modLabelA
            // 
            this.modLabelA.AutoSize = true;
            this.modLabelA.Location = new System.Drawing.Point(20, 24);
            this.modLabelA.Name = "modLabelA";
            this.modLabelA.Size = new System.Drawing.Size(49, 13);
            this.modLabelA.TabIndex = 0;
            this.modLabelA.Text = "Число A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 196);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.realCalc.ResumeLayout(false);
            this.realCalc.PerformLayout();
            this.complexCalc.ResumeLayout(false);
            this.complexCalc.PerformLayout();
            this.quantCalc.ResumeLayout(false);
            this.quantCalc.PerformLayout();
            this.moduleNCalc.ResumeLayout(false);
            this.moduleNCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage realCalc;
        private System.Windows.Forms.TabPage complexCalc;
        private System.Windows.Forms.TabPage quantCalc;
        private System.Windows.Forms.TabPage moduleNCalc;
        private System.Windows.Forms.TextBox realRes;
        private System.Windows.Forms.Button realDiv;
        private System.Windows.Forms.Button realMult;
        private System.Windows.Forms.Button realSubstr;
        private System.Windows.Forms.Button realSum;
        private System.Windows.Forms.TextBox realB;
        private System.Windows.Forms.TextBox realA;
        private System.Windows.Forms.Label labelRealRes;
        private System.Windows.Forms.Label labelRealB;
        private System.Windows.Forms.Label lableRealA;
        private System.Windows.Forms.Button complexDiv;
        private System.Windows.Forms.Button complexMult;
        private System.Windows.Forms.Button complexSubstr;
        private System.Windows.Forms.Button complexSum;
        private System.Windows.Forms.TextBox complexImgB;
        private System.Windows.Forms.TextBox complexRealB;
        private System.Windows.Forms.TextBox complexImgA;
        private System.Windows.Forms.TextBox complexRealA;
        private System.Windows.Forms.Label complexALabel;
        private System.Windows.Forms.Label complexResLable;
        private System.Windows.Forms.Label complexBLabel;
        private System.Windows.Forms.Label complexImgLabelB;
        private System.Windows.Forms.Label complexImgLabelA;
        private System.Windows.Forms.Label complexImgLabelRes;
        private System.Windows.Forms.TextBox complexImgRes;
        private System.Windows.Forms.TextBox complexRealRes;
        private System.Windows.Forms.Button quantDiv;
        private System.Windows.Forms.Button quantMult;
        private System.Windows.Forms.Button quantSubstr;
        private System.Windows.Forms.Button quantSum;
        private System.Windows.Forms.Label quantLabelA;
        private System.Windows.Forms.Label quantLabelB;
        private System.Windows.Forms.TextBox quantVecZB;
        private System.Windows.Forms.TextBox quantVecYB;
        private System.Windows.Forms.TextBox quantVecXB;
        private System.Windows.Forms.TextBox quantRealB;
        private System.Windows.Forms.TextBox quantVecZA;
        private System.Windows.Forms.TextBox quantVecYA;
        private System.Windows.Forms.TextBox quantVecXA;
        private System.Windows.Forms.TextBox quantRealA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantVecZRes;
        private System.Windows.Forms.TextBox quantVecYRes;
        private System.Windows.Forms.TextBox quantVecXRes;
        private System.Windows.Forms.TextBox quantRealRes;
        private System.Windows.Forms.Label modLabelA;
        private System.Windows.Forms.Button modDiv;
        private System.Windows.Forms.Button modMult;
        private System.Windows.Forms.Button modSubstr;
        private System.Windows.Forms.Button modSum;
        private System.Windows.Forms.TextBox modNumN;
        private System.Windows.Forms.TextBox modNumB;
        private System.Windows.Forms.TextBox modNumA;
        private System.Windows.Forms.Label modLabelMod;
        private System.Windows.Forms.Label modLabelB;
        private System.Windows.Forms.Label modLabelRes;
        private System.Windows.Forms.TextBox modRes;
    }
}

