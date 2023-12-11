
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
            this.quatCalc = new System.Windows.Forms.TabPage();
            this.quatVecZRes = new System.Windows.Forms.TextBox();
            this.quatVecYRes = new System.Windows.Forms.TextBox();
            this.quatVecXRes = new System.Windows.Forms.TextBox();
            this.quatRealRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quatVecZB = new System.Windows.Forms.TextBox();
            this.quatVecYB = new System.Windows.Forms.TextBox();
            this.quatVecXB = new System.Windows.Forms.TextBox();
            this.quatRealB = new System.Windows.Forms.TextBox();
            this.quatVecZA = new System.Windows.Forms.TextBox();
            this.quatVecYA = new System.Windows.Forms.TextBox();
            this.quatVecXA = new System.Windows.Forms.TextBox();
            this.quatRealA = new System.Windows.Forms.TextBox();
            this.quatLabelB = new System.Windows.Forms.Label();
            this.quatLabelA = new System.Windows.Forms.Label();
            this.quatDiv = new System.Windows.Forms.Button();
            this.quatMult = new System.Windows.Forms.Button();
            this.quatSubstr = new System.Windows.Forms.Button();
            this.quatSum = new System.Windows.Forms.Button();
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
            this.quatCalc.SuspendLayout();
            this.moduleNCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.realCalc);
            this.tabControl1.Controls.Add(this.complexCalc);
            this.tabControl1.Controls.Add(this.quatCalc);
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
            // quatCalc
            // 
            this.quatCalc.Controls.Add(this.quatVecZRes);
            this.quatCalc.Controls.Add(this.quatVecYRes);
            this.quatCalc.Controls.Add(this.quatVecXRes);
            this.quatCalc.Controls.Add(this.quatRealRes);
            this.quatCalc.Controls.Add(this.label2);
            this.quatCalc.Controls.Add(this.quatVecZB);
            this.quatCalc.Controls.Add(this.quatVecYB);
            this.quatCalc.Controls.Add(this.quatVecXB);
            this.quatCalc.Controls.Add(this.quatRealB);
            this.quatCalc.Controls.Add(this.quatVecZA);
            this.quatCalc.Controls.Add(this.quatVecYA);
            this.quatCalc.Controls.Add(this.quatVecXA);
            this.quatCalc.Controls.Add(this.quatRealA);
            this.quatCalc.Controls.Add(this.quatLabelB);
            this.quatCalc.Controls.Add(this.quatLabelA);
            this.quatCalc.Controls.Add(this.quatDiv);
            this.quatCalc.Controls.Add(this.quatMult);
            this.quatCalc.Controls.Add(this.quatSubstr);
            this.quatCalc.Controls.Add(this.quatSum);
            this.quatCalc.Location = new System.Drawing.Point(4, 22);
            this.quatCalc.Name = "quatCalc";
            this.quatCalc.Size = new System.Drawing.Size(392, 143);
            this.quatCalc.TabIndex = 3;
            this.quatCalc.Text = "Кватернионы";
            this.quatCalc.UseVisualStyleBackColor = true;
            // 
            // quatVecZRes
            // 
            this.quatVecZRes.Location = new System.Drawing.Point(181, 106);
            this.quatVecZRes.Name = "quatVecZRes";
            this.quatVecZRes.Size = new System.Drawing.Size(40, 20);
            this.quatVecZRes.TabIndex = 18;
            // 
            // quatVecYRes
            // 
            this.quatVecYRes.Location = new System.Drawing.Point(135, 106);
            this.quatVecYRes.Name = "quatVecYRes";
            this.quatVecYRes.Size = new System.Drawing.Size(40, 20);
            this.quatVecYRes.TabIndex = 17;
            // 
            // quatVecXRes
            // 
            this.quatVecXRes.Location = new System.Drawing.Point(89, 106);
            this.quatVecXRes.Name = "quatVecXRes";
            this.quatVecXRes.Size = new System.Drawing.Size(40, 20);
            this.quatVecXRes.TabIndex = 16;
            // 
            // quatRealRes
            // 
            this.quatRealRes.Location = new System.Drawing.Point(23, 106);
            this.quatRealRes.Name = "quatRealRes";
            this.quatRealRes.Size = new System.Drawing.Size(60, 20);
            this.quatRealRes.TabIndex = 15;
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
            // quatVecZB
            // 
            this.quatVecZB.Location = new System.Drawing.Point(251, 48);
            this.quatVecZB.Name = "quatVecZB";
            this.quatVecZB.Size = new System.Drawing.Size(21, 20);
            this.quatVecZB.TabIndex = 13;
            // 
            // quatVecYB
            // 
            this.quatVecYB.Location = new System.Drawing.Point(224, 48);
            this.quatVecYB.Name = "quatVecYB";
            this.quatVecYB.Size = new System.Drawing.Size(21, 20);
            this.quatVecYB.TabIndex = 12;
            // 
            // quatVecXB
            // 
            this.quatVecXB.Location = new System.Drawing.Point(197, 48);
            this.quatVecXB.Name = "quatVecXB";
            this.quatVecXB.Size = new System.Drawing.Size(21, 20);
            this.quatVecXB.TabIndex = 11;
            // 
            // quatRealB
            // 
            this.quatRealB.Location = new System.Drawing.Point(158, 48);
            this.quatRealB.Name = "quatRealB";
            this.quatRealB.Size = new System.Drawing.Size(33, 20);
            this.quatRealB.TabIndex = 10;
            // 
            // quatVecZA
            // 
            this.quatVecZA.Location = new System.Drawing.Point(116, 48);
            this.quatVecZA.Name = "quatVecZA";
            this.quatVecZA.Size = new System.Drawing.Size(21, 20);
            this.quatVecZA.TabIndex = 9;
            // 
            // quatVecYA
            // 
            this.quatVecYA.Location = new System.Drawing.Point(89, 48);
            this.quatVecYA.Name = "quatVecYA";
            this.quatVecYA.Size = new System.Drawing.Size(21, 20);
            this.quatVecYA.TabIndex = 8;
            // 
            // quatVecXA
            // 
            this.quatVecXA.Location = new System.Drawing.Point(62, 48);
            this.quatVecXA.Name = "quatVecXA";
            this.quatVecXA.Size = new System.Drawing.Size(21, 20);
            this.quatVecXA.TabIndex = 7;
            // 
            // quatRealA
            // 
            this.quatRealA.Location = new System.Drawing.Point(23, 48);
            this.quatRealA.Name = "quatRealA";
            this.quatRealA.Size = new System.Drawing.Size(33, 20);
            this.quatRealA.TabIndex = 6;
            // 
            // quatLabelB
            // 
            this.quatLabelB.AutoSize = true;
            this.quatLabelB.Location = new System.Drawing.Point(155, 24);
            this.quatLabelB.Name = "quatLabelB";
            this.quatLabelB.Size = new System.Drawing.Size(49, 13);
            this.quatLabelB.TabIndex = 5;
            this.quatLabelB.Text = "Число B";
            // 
            // quatLabelA
            // 
            this.quatLabelA.AutoSize = true;
            this.quatLabelA.Location = new System.Drawing.Point(20, 24);
            this.quatLabelA.Name = "quatLabelA";
            this.quatLabelA.Size = new System.Drawing.Size(49, 13);
            this.quatLabelA.TabIndex = 4;
            this.quatLabelA.Text = "Число А";
            // 
            // quatDiv
            // 
            this.quatDiv.Location = new System.Drawing.Point(286, 106);
            this.quatDiv.Name = "quatDiv";
            this.quatDiv.Size = new System.Drawing.Size(100, 23);
            this.quatDiv.TabIndex = 3;
            this.quatDiv.Text = "Частное";
            this.quatDiv.UseVisualStyleBackColor = true;
            this.quatDiv.Click += new System.EventHandler(this.quatDiv_Click);
            // 
            // quatMult
            // 
            this.quatMult.Location = new System.Drawing.Point(286, 77);
            this.quatMult.Name = "quatMult";
            this.quatMult.Size = new System.Drawing.Size(100, 23);
            this.quatMult.TabIndex = 2;
            this.quatMult.Text = "Произведение";
            this.quatMult.UseVisualStyleBackColor = true;
            this.quatMult.Click += new System.EventHandler(this.quatMult_Click);
            // 
            // quatSubstr
            // 
            this.quatSubstr.Location = new System.Drawing.Point(286, 48);
            this.quatSubstr.Name = "quatSubstr";
            this.quatSubstr.Size = new System.Drawing.Size(100, 23);
            this.quatSubstr.TabIndex = 1;
            this.quatSubstr.Text = "Разность";
            this.quatSubstr.UseVisualStyleBackColor = true;
            this.quatSubstr.Click += new System.EventHandler(this.quatSubstr_Click);
            // 
            // quatSum
            // 
            this.quatSum.Location = new System.Drawing.Point(286, 19);
            this.quatSum.Name = "quatSum";
            this.quatSum.Size = new System.Drawing.Size(100, 23);
            this.quatSum.TabIndex = 0;
            this.quatSum.Text = "Сумма";
            this.quatSum.UseVisualStyleBackColor = true;
            this.quatSum.Click += new System.EventHandler(this.quatSum_Click);
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
            this.quatCalc.ResumeLayout(false);
            this.quatCalc.PerformLayout();
            this.moduleNCalc.ResumeLayout(false);
            this.moduleNCalc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage realCalc;
        private System.Windows.Forms.TabPage complexCalc;
        private System.Windows.Forms.TabPage quatCalc;
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
        private System.Windows.Forms.Button quatDiv;
        private System.Windows.Forms.Button quatMult;
        private System.Windows.Forms.Button quatSubstr;
        private System.Windows.Forms.Button quatSum;
        private System.Windows.Forms.Label quatLabelA;
        private System.Windows.Forms.Label quatLabelB;
        private System.Windows.Forms.TextBox quatVecZB;
        private System.Windows.Forms.TextBox quatVecYB;
        private System.Windows.Forms.TextBox quatVecXB;
        private System.Windows.Forms.TextBox quatRealB;
        private System.Windows.Forms.TextBox quatVecZA;
        private System.Windows.Forms.TextBox quatVecYA;
        private System.Windows.Forms.TextBox quatVecXA;
        private System.Windows.Forms.TextBox quatRealA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quatVecZRes;
        private System.Windows.Forms.TextBox quatVecYRes;
        private System.Windows.Forms.TextBox quatVecXRes;
        private System.Windows.Forms.TextBox quatRealRes;
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

