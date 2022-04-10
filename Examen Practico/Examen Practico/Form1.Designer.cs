
namespace Examen_Practico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuote = new System.Windows.Forms.Button();
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelAddressShop = new System.Windows.Forms.Label();
            this.labelHistoryQuotes = new System.Windows.Forms.Label();
            this.labelNameShop = new System.Windows.Forms.Label();
            this.labelLastNameAndSellerCode = new System.Windows.Forms.Label();
            this.radioButtonShirt = new System.Windows.Forms.RadioButton();
            this.radioButtonTrousers = new System.Windows.Forms.RadioButton();
            this.checkBoxShortSleeve = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.checkBoxLongSleeve = new System.Windows.Forms.CheckBox();
            this.groupBoxGarment = new System.Windows.Forms.GroupBox();
            this.labelTittleStock = new System.Windows.Forms.Label();
            this.textDisponibleStock = new System.Windows.Forms.TextBox();
            this.groupBoxStock = new System.Windows.Forms.GroupBox();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.groupBoxQualityGarment = new System.Windows.Forms.GroupBox();
            this.labelIconPrice = new System.Windows.Forms.Label();
            this.labelTittleCount = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.texCount = new System.Windows.Forms.TextBox();
            this.groupBoxUnitPriceAndCount = new System.Windows.Forms.GroupBox();
            this.labelTittleResultQuote = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxGarment.SuspendLayout();
            this.groupBoxStock.SuspendLayout();
            this.groupBoxQualityGarment.SuspendLayout();
            this.groupBoxUnitPriceAndCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuote
            // 
            this.buttonQuote.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonQuote.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuote.FlatAppearance.BorderSize = 2;
            this.buttonQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonQuote.Location = new System.Drawing.Point(17, 471);
            this.buttonQuote.Name = "buttonQuote";
            this.buttonQuote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonQuote.Size = new System.Drawing.Size(178, 54);
            this.buttonQuote.TabIndex = 0;
            this.buttonQuote.Text = "Cotizar";
            this.buttonQuote.UseVisualStyleBackColor = false;
            this.buttonQuote.Click += new System.EventHandler(this.buttonQuote_Click);
            // 
            // labelTittle
            // 
            this.labelTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTittle.BackColor = System.Drawing.Color.BlueViolet;
            this.labelTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTittle.CausesValidation = false;
            this.labelTittle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTittle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelTittle.Location = new System.Drawing.Point(-1, 0);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(3);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTittle.Size = new System.Drawing.Size(481, 83);
            this.labelTittle.TabIndex = 1;
            this.labelTittle.Text = "Cotizador Express";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddressShop
            // 
            this.labelAddressShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddressShop.AutoSize = true;
            this.labelAddressShop.BackColor = System.Drawing.Color.Transparent;
            this.labelAddressShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressShop.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelAddressShop.Location = new System.Drawing.Point(321, 86);
            this.labelAddressShop.Margin = new System.Windows.Forms.Padding(3);
            this.labelAddressShop.Name = "labelAddressShop";
            this.labelAddressShop.Size = new System.Drawing.Size(152, 15);
            this.labelAddressShop.TabIndex = 2;
            this.labelAddressShop.Text = "Direccion de la Tienda";
            this.labelAddressShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistoryQuotes
            // 
            this.labelHistoryQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHistoryQuotes.AutoSize = true;
            this.labelHistoryQuotes.BackColor = System.Drawing.Color.Transparent;
            this.labelHistoryQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoryQuotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHistoryQuotes.Location = new System.Drawing.Point(328, 119);
            this.labelHistoryQuotes.Margin = new System.Windows.Forms.Padding(3);
            this.labelHistoryQuotes.Name = "labelHistoryQuotes";
            this.labelHistoryQuotes.Size = new System.Drawing.Size(142, 15);
            this.labelHistoryQuotes.TabIndex = 2;
            this.labelHistoryQuotes.Text = "Historial Cotizaciones 📃";
            this.labelHistoryQuotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHistoryQuotes.Click += new System.EventHandler(this.labelHistoryQuotes_Click);
            // 
            // labelNameShop
            // 
            this.labelNameShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameShop.AutoSize = true;
            this.labelNameShop.BackColor = System.Drawing.Color.Transparent;
            this.labelNameShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameShop.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelNameShop.Location = new System.Drawing.Point(12, 86);
            this.labelNameShop.Name = "labelNameShop";
            this.labelNameShop.Size = new System.Drawing.Size(142, 15);
            this.labelNameShop.TabIndex = 2;
            this.labelNameShop.Text = "Nombre de la Tienda";
            this.labelNameShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastNameAndSellerCode
            // 
            this.labelLastNameAndSellerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastNameAndSellerCode.AutoSize = true;
            this.labelLastNameAndSellerCode.BackColor = System.Drawing.Color.Transparent;
            this.labelLastNameAndSellerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameAndSellerCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastNameAndSellerCode.Location = new System.Drawing.Point(9, 119);
            this.labelLastNameAndSellerCode.Name = "labelLastNameAndSellerCode";
            this.labelLastNameAndSellerCode.Size = new System.Drawing.Size(267, 15);
            this.labelLastNameAndSellerCode.TabIndex = 2;
            this.labelLastNameAndSellerCode.Text = "Nombre y Apellido Vendedor | Codigo Vendedor";
            this.labelLastNameAndSellerCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonShirt
            // 
            this.radioButtonShirt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonShirt.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonShirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShirt.Location = new System.Drawing.Point(29, 31);
            this.radioButtonShirt.Name = "radioButtonShirt";
            this.radioButtonShirt.Size = new System.Drawing.Size(101, 20);
            this.radioButtonShirt.TabIndex = 0;
            this.radioButtonShirt.Text = "Camisa";
            this.radioButtonShirt.UseVisualStyleBackColor = true;
            this.radioButtonShirt.CheckedChanged += new System.EventHandler(this.radioButtonShirt_CheckedChanged);
            // 
            // radioButtonTrousers
            // 
            this.radioButtonTrousers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTrousers.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonTrousers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrousers.Location = new System.Drawing.Point(29, 72);
            this.radioButtonTrousers.Name = "radioButtonTrousers";
            this.radioButtonTrousers.Size = new System.Drawing.Size(101, 20);
            this.radioButtonTrousers.TabIndex = 0;
            this.radioButtonTrousers.Text = "Pantalon";
            this.radioButtonTrousers.UseVisualStyleBackColor = true;
            this.radioButtonTrousers.CheckedChanged += new System.EventHandler(this.radioButtonTrousers_CheckedChanged);
            // 
            // checkBoxShortSleeve
            // 
            this.checkBoxShortSleeve.AutoSize = true;
            this.checkBoxShortSleeve.Location = new System.Drawing.Point(171, 31);
            this.checkBoxShortSleeve.Name = "checkBoxShortSleeve";
            this.checkBoxShortSleeve.Size = new System.Drawing.Size(104, 20);
            this.checkBoxShortSleeve.TabIndex = 1;
            this.checkBoxShortSleeve.Text = "Manga Corta";
            this.checkBoxShortSleeve.UseVisualStyleBackColor = true;
            this.checkBoxShortSleeve.CheckedChanged += new System.EventHandler(this.checkBoxShortSleeve_CheckedChanged);
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(171, 72);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(68, 20);
            this.checkBoxChupin.TabIndex = 1;
            this.checkBoxChupin.Text = "Chupin";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
            // 
            // checkBoxLongSleeve
            // 
            this.checkBoxLongSleeve.AutoSize = true;
            this.checkBoxLongSleeve.Location = new System.Drawing.Point(313, 31);
            this.checkBoxLongSleeve.Name = "checkBoxLongSleeve";
            this.checkBoxLongSleeve.Size = new System.Drawing.Size(95, 20);
            this.checkBoxLongSleeve.TabIndex = 1;
            this.checkBoxLongSleeve.Text = "Cuello mao";
            this.checkBoxLongSleeve.UseVisualStyleBackColor = true;
            this.checkBoxLongSleeve.CheckedChanged += new System.EventHandler(this.checkBoxLongSleeve_CheckedChanged);
            // 
            // groupBoxGarment
            // 
            this.groupBoxGarment.BackColor = System.Drawing.Color.Indigo;
            this.groupBoxGarment.Controls.Add(this.checkBoxLongSleeve);
            this.groupBoxGarment.Controls.Add(this.checkBoxChupin);
            this.groupBoxGarment.Controls.Add(this.checkBoxShortSleeve);
            this.groupBoxGarment.Controls.Add(this.radioButtonTrousers);
            this.groupBoxGarment.Controls.Add(this.radioButtonShirt);
            this.groupBoxGarment.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxGarment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGarment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxGarment.Location = new System.Drawing.Point(12, 158);
            this.groupBoxGarment.Name = "groupBoxGarment";
            this.groupBoxGarment.Size = new System.Drawing.Size(457, 120);
            this.groupBoxGarment.TabIndex = 3;
            this.groupBoxGarment.TabStop = false;
            this.groupBoxGarment.Text = "Prenda";
            // 
            // labelTittleStock
            // 
            this.labelTittleStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTittleStock.AutoSize = true;
            this.labelTittleStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTittleStock.Location = new System.Drawing.Point(17, 16);
            this.labelTittleStock.Name = "labelTittleStock";
            this.labelTittleStock.Size = new System.Drawing.Size(177, 15);
            this.labelTittleStock.TabIndex = 0;
            this.labelTittleStock.Text = "Unidades de stock disponibles:";
            this.labelTittleStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textDisponibleStock
            // 
            this.textDisponibleStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textDisponibleStock.BackColor = System.Drawing.Color.Indigo;
            this.textDisponibleStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDisponibleStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisponibleStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textDisponibleStock.Location = new System.Drawing.Point(190, 15);
            this.textDisponibleStock.MaxLength = 4;
            this.textDisponibleStock.Name = "textDisponibleStock";
            this.textDisponibleStock.Size = new System.Drawing.Size(53, 21);
            this.textDisponibleStock.TabIndex = 1;
            this.textDisponibleStock.TextChanged += new System.EventHandler(this.textDisponibleStock_TextChanged);
            // 
            // groupBoxStock
            // 
            this.groupBoxStock.Controls.Add(this.textDisponibleStock);
            this.groupBoxStock.Controls.Add(this.labelTittleStock);
            this.groupBoxStock.Location = new System.Drawing.Point(12, 284);
            this.groupBoxStock.Name = "groupBoxStock";
            this.groupBoxStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxStock.Size = new System.Drawing.Size(457, 50);
            this.groupBoxStock.TabIndex = 4;
            this.groupBoxStock.TabStop = false;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(16, 29);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(81, 20);
            this.radioButtonStandard.TabIndex = 0;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            this.radioButtonStandard.CheckedChanged += new System.EventHandler(this.radioButtonStandard_CheckedChanged);
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(113, 29);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(79, 20);
            this.radioButtonPremium.TabIndex = 0;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            this.radioButtonPremium.CheckedChanged += new System.EventHandler(this.radioButtonPremium_CheckedChanged);
            // 
            // groupBoxQualityGarment
            // 
            this.groupBoxQualityGarment.Controls.Add(this.radioButtonPremium);
            this.groupBoxQualityGarment.Controls.Add(this.radioButtonStandard);
            this.groupBoxQualityGarment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQualityGarment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxQualityGarment.Location = new System.Drawing.Point(12, 356);
            this.groupBoxQualityGarment.Name = "groupBoxQualityGarment";
            this.groupBoxQualityGarment.Size = new System.Drawing.Size(218, 74);
            this.groupBoxQualityGarment.TabIndex = 5;
            this.groupBoxQualityGarment.TabStop = false;
            this.groupBoxQualityGarment.Text = "Calidad de la Prenda";
            // 
            // labelIconPrice
            // 
            this.labelIconPrice.AutoSize = true;
            this.labelIconPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIconPrice.Location = new System.Drawing.Point(8, 31);
            this.labelIconPrice.Name = "labelIconPrice";
            this.labelIconPrice.Size = new System.Drawing.Size(18, 20);
            this.labelIconPrice.TabIndex = 0;
            this.labelIconPrice.Text = "$";
            // 
            // labelTittleCount
            // 
            this.labelTittleCount.AutoSize = true;
            this.labelTittleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleCount.Location = new System.Drawing.Point(84, 33);
            this.labelTittleCount.Name = "labelTittleCount";
            this.labelTittleCount.Size = new System.Drawing.Size(62, 16);
            this.labelTittleCount.TabIndex = 0;
            this.labelTittleCount.Text = "Cantidad";
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.Indigo;
            this.textPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textPrice.Location = new System.Drawing.Point(27, 29);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(57, 21);
            this.textPrice.TabIndex = 1;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // texCount
            // 
            this.texCount.BackColor = System.Drawing.Color.Indigo;
            this.texCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.texCount.Location = new System.Drawing.Point(145, 28);
            this.texCount.Name = "texCount";
            this.texCount.Size = new System.Drawing.Size(61, 21);
            this.texCount.TabIndex = 1;
            this.texCount.TextChanged += new System.EventHandler(this.texCount_TextChanged);
            // 
            // groupBoxUnitPriceAndCount
            // 
            this.groupBoxUnitPriceAndCount.Controls.Add(this.texCount);
            this.groupBoxUnitPriceAndCount.Controls.Add(this.textPrice);
            this.groupBoxUnitPriceAndCount.Controls.Add(this.labelTittleCount);
            this.groupBoxUnitPriceAndCount.Controls.Add(this.labelIconPrice);
            this.groupBoxUnitPriceAndCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUnitPriceAndCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxUnitPriceAndCount.Location = new System.Drawing.Point(252, 356);
            this.groupBoxUnitPriceAndCount.Name = "groupBoxUnitPriceAndCount";
            this.groupBoxUnitPriceAndCount.Size = new System.Drawing.Size(217, 74);
            this.groupBoxUnitPriceAndCount.TabIndex = 6;
            this.groupBoxUnitPriceAndCount.TabStop = false;
            this.groupBoxUnitPriceAndCount.Text = "Precio unitario y Cantidad";
            // 
            // labelTittleResultQuote
            // 
            this.labelTittleResultQuote.AutoSize = true;
            this.labelTittleResultQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleResultQuote.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelTittleResultQuote.Location = new System.Drawing.Point(217, 479);
            this.labelTittleResultQuote.Name = "labelTittleResultQuote";
            this.labelTittleResultQuote.Size = new System.Drawing.Size(230, 31);
            this.labelTittleResultQuote.TabIndex = 7;
            this.labelTittleResultQuote.Text = "$ ____________";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelResult.Location = new System.Drawing.Point(239, 476);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(114, 31);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "10.500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(481, 561);
            this.Controls.Add(this.buttonQuote);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTittleResultQuote);
            this.Controls.Add(this.groupBoxUnitPriceAndCount);
            this.Controls.Add(this.groupBoxQualityGarment);
            this.Controls.Add(this.groupBoxStock);
            this.Controls.Add(this.groupBoxGarment);
            this.Controls.Add(this.labelLastNameAndSellerCode);
            this.Controls.Add(this.labelNameShop);
            this.Controls.Add(this.labelHistoryQuotes);
            this.Controls.Add(this.labelAddressShop);
            this.Controls.Add(this.labelTittle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Cotizaciones";
            this.groupBoxGarment.ResumeLayout(false);
            this.groupBoxGarment.PerformLayout();
            this.groupBoxStock.ResumeLayout(false);
            this.groupBoxStock.PerformLayout();
            this.groupBoxQualityGarment.ResumeLayout(false);
            this.groupBoxQualityGarment.PerformLayout();
            this.groupBoxUnitPriceAndCount.ResumeLayout(false);
            this.groupBoxUnitPriceAndCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuote;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label labelAddressShop;
        private System.Windows.Forms.Label labelHistoryQuotes;
        private System.Windows.Forms.Label labelNameShop;
        private System.Windows.Forms.Label labelLastNameAndSellerCode;
        private System.Windows.Forms.RadioButton radioButtonShirt;
        private System.Windows.Forms.RadioButton radioButtonTrousers;
        private System.Windows.Forms.CheckBox checkBoxShortSleeve;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.CheckBox checkBoxLongSleeve;
        private System.Windows.Forms.GroupBox groupBoxGarment;
        private System.Windows.Forms.Label labelTittleStock;
        private System.Windows.Forms.TextBox textDisponibleStock;
        private System.Windows.Forms.GroupBox groupBoxStock;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.GroupBox groupBoxQualityGarment;
        private System.Windows.Forms.Label labelIconPrice;
        private System.Windows.Forms.Label labelTittleCount;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox texCount;
        private System.Windows.Forms.GroupBox groupBoxUnitPriceAndCount;
        private System.Windows.Forms.Label labelTittleResultQuote;
        private System.Windows.Forms.Label labelResult;
    }
}

