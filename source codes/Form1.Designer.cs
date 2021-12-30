
namespace PizzaCalcultor
{






    partial class PizzaCalculator
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("chkLstToppings");
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPizzaSize = new System.Windows.Forms.GroupBox();
            this.radiXtraLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.grpPizzaType = new System.Windows.Forms.GroupBox();
            this.radBrooklyn = new System.Windows.Forms.RadioButton();
            this.radPan = new System.Windows.Forms.RadioButton();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.radHandTossed = new System.Windows.Forms.RadioButton();
            this.lblChsToppings = new System.Windows.Forms.Label();
            this.chkLstToppings = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radCarryOut = new System.Windows.Forms.RadioButton();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPizzaClubMember = new System.Windows.Forms.CheckBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.lblUsernaame = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.grpPizzaSize.SuspendLayout();
            this.grpPizzaType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // grpPizzaSize
            // 
            this.grpPizzaSize.Controls.Add(this.radiXtraLarge);
            this.grpPizzaSize.Controls.Add(this.radMedium);
            this.grpPizzaSize.Controls.Add(this.radLarge);
            this.grpPizzaSize.Controls.Add(this.radSmall);
            this.grpPizzaSize.Location = new System.Drawing.Point(13, 65);
            this.grpPizzaSize.Name = "grpPizzaSize";
            this.grpPizzaSize.Size = new System.Drawing.Size(170, 146);
            this.grpPizzaSize.TabIndex = 2;
            this.grpPizzaSize.TabStop = false;
            this.grpPizzaSize.Text = "CHOOSE YOUR SIZE";
            // 
            // radiXtraLarge
            // 
            this.radiXtraLarge.AutoSize = true;
            this.radiXtraLarge.Location = new System.Drawing.Point(6, 112);
            this.radiXtraLarge.Name = "radiXtraLarge";
            this.radiXtraLarge.Size = new System.Drawing.Size(127, 19);
            this.radiXtraLarge.TabIndex = 5;
            this.radiXtraLarge.TabStop = true;
            this.radiXtraLarge.Text = "Xtra Large - 16 inch";
            this.radiXtraLarge.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(6, 62);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(119, 19);
            this.radMedium.TabIndex = 4;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium - 12 inch";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(6, 87);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(103, 19);
            this.radLarge.TabIndex = 3;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large - 14 inch";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(6, 37);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(103, 19);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small - 10 inch";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // grpPizzaType
            // 
            this.grpPizzaType.Controls.Add(this.radBrooklyn);
            this.grpPizzaType.Controls.Add(this.radPan);
            this.grpPizzaType.Controls.Add(this.radThin);
            this.grpPizzaType.Controls.Add(this.radHandTossed);
            this.grpPizzaType.Location = new System.Drawing.Point(12, 235);
            this.grpPizzaType.Name = "grpPizzaType";
            this.grpPizzaType.Size = new System.Drawing.Size(171, 141);
            this.grpPizzaType.TabIndex = 3;
            this.grpPizzaType.TabStop = false;
            this.grpPizzaType.Text = "CHOOSE YOUR CRUST";
            // 
            // radBrooklyn
            // 
            this.radBrooklyn.AutoSize = true;
            this.radBrooklyn.Location = new System.Drawing.Point(7, 101);
            this.radBrooklyn.Name = "radBrooklyn";
            this.radBrooklyn.Size = new System.Drawing.Size(100, 19);
            this.radBrooklyn.TabIndex = 3;
            this.radBrooklyn.TabStop = true;
            this.radBrooklyn.Text = "Brooklyn Style";
            this.radBrooklyn.UseVisualStyleBackColor = true;
            // 
            // radPan
            // 
            this.radPan.AutoSize = true;
            this.radPan.Location = new System.Drawing.Point(7, 75);
            this.radPan.Name = "radPan";
            this.radPan.Size = new System.Drawing.Size(107, 19);
            this.radPan.TabIndex = 2;
            this.radPan.TabStop = true;
            this.radPan.Text = "Handmade Pan";
            this.radPan.UseVisualStyleBackColor = true;
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Location = new System.Drawing.Point(7, 22);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(97, 19);
            this.radThin.TabIndex = 1;
            this.radThin.TabStop = true;
            this.radThin.Text = "Crunchy Thin";
            this.radThin.UseVisualStyleBackColor = true;
            // 
            // radHandTossed
            // 
            this.radHandTossed.AutoSize = true;
            this.radHandTossed.Location = new System.Drawing.Point(7, 47);
            this.radHandTossed.Name = "radHandTossed";
            this.radHandTossed.Size = new System.Drawing.Size(94, 19);
            this.radHandTossed.TabIndex = 0;
            this.radHandTossed.TabStop = true;
            this.radHandTossed.Text = "Hand Tossed";
            this.radHandTossed.UseVisualStyleBackColor = true;
            // 
            // lblChsToppings
            // 
            this.lblChsToppings.AutoSize = true;
            this.lblChsToppings.Location = new System.Drawing.Point(19, 393);
            this.lblChsToppings.Name = "lblChsToppings";
            this.lblChsToppings.Size = new System.Drawing.Size(147, 15);
            this.lblChsToppings.TabIndex = 4;
            this.lblChsToppings.Text = "CHOOSE YOUR TOPPINGS";
            // 
            // chkLstToppings
            // 
            this.chkLstToppings.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.chkLstToppings.CheckBoxes = true;
            this.chkLstToppings.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.chkLstToppings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.chkLstToppings.Location = new System.Drawing.Point(12, 411);
            this.chkLstToppings.Name = "chkLstToppings";
            this.chkLstToppings.Size = new System.Drawing.Size(183, 183);
            this.chkLstToppings.TabIndex = 5;
            this.chkLstToppings.UseCompatibleStateImageBehavior = false;
            this.chkLstToppings.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDelivery);
            this.groupBox1.Controls.Add(this.radCarryOut);
            this.groupBox1.Location = new System.Drawing.Point(215, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARRY OUT/DELIVERY?";
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(89, 23);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(67, 19);
            this.radDelivery.TabIndex = 1;
            this.radDelivery.TabStop = true;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            // 
            // radCarryOut
            // 
            this.radCarryOut.AutoSize = true;
            this.radCarryOut.Location = new System.Drawing.Point(7, 23);
            this.radCarryOut.Name = "radCarryOut";
            this.radCarryOut.Size = new System.Drawing.Size(76, 19);
            this.radCarryOut.TabIndex = 0;
            this.radCarryOut.TabStop = true;
            this.radCarryOut.Text = "Carry Out";
            this.radCarryOut.UseVisualStyleBackColor = true;
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(396, 57);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(145, 30);
            this.btnProcessOrder.TabIndex = 7;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(396, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(474, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPizzaClubMember);
            this.groupBox2.Controls.Add(this.txtZip);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(215, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 133);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENTER YOUR INFO";
            // 
            // chkPizzaClubMember
            // 
            this.chkPizzaClubMember.AutoSize = true;
            this.chkPizzaClubMember.Location = new System.Drawing.Point(195, 103);
            this.chkPizzaClubMember.Name = "chkPizzaClubMember";
            this.chkPizzaClubMember.Size = new System.Drawing.Size(128, 19);
            this.chkPizzaClubMember.TabIndex = 8;
            this.chkPizzaClubMember.Text = "Pizza Club Member";
            this.chkPizzaClubMember.UseVisualStyleBackColor = true;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(84, 101);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(91, 23);
            this.txtZip.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(84, 72);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(215, 23);
            this.txtCity.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 45);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 23);
            this.txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Zipcode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(222, 295);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(95, 15);
            this.labelOutput.TabIndex = 11;
            this.labelOutput.Text = "Your Order Total";
            // 
            // lblUsernaame
            // 
            this.lblUsernaame.AutoSize = true;
            this.lblUsernaame.Location = new System.Drawing.Point(474, 9);
            this.lblUsernaame.Name = "lblUsernaame";
            this.lblUsernaame.Size = new System.Drawing.Size(60, 15);
            this.lblUsernaame.TabIndex = 13;
            this.lblUsernaame.Text = "Username";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(222, 314);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(301, 259);
            this.lstOutput.TabIndex = 14;
            // 
            // PizzaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 606);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblUsernaame);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkLstToppings);
            this.Controls.Add(this.lblChsToppings);
            this.Controls.Add(this.grpPizzaType);
            this.Controls.Add(this.grpPizzaSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Name = "PizzaCalculator";
            this.Text = "Pizza Calculator";
            this.Load += new System.EventHandler(this.PizzaCalculator_Load);
            this.grpPizzaSize.ResumeLayout(false);
            this.grpPizzaSize.PerformLayout();
            this.grpPizzaType.ResumeLayout(false);
            this.grpPizzaType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPizzaSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radiXtraLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.GroupBox grpPizzaType;
        private System.Windows.Forms.RadioButton radBrooklyn;
        private System.Windows.Forms.RadioButton radPan;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.RadioButton radHandTossed;
        private System.Windows.Forms.Label lblChsToppings;
        private System.Windows.Forms.ListView chkLstToppings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radCarryOut;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label lblUsernaame;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.CheckBox chkPizzaClubMember;
        private System.Windows.Forms.ListBox lstOutput;
    }



    /*************************************************
 * Author: Alenzy
 * This class is used for all menu items as the
 * parent class.
 * 
 ***************************************************/



    class Menu_Item
    {
        private string itemName;
        public string ItemName
        {

            get { return itemName; }
            set { itemName = value; }


        }
        public string ItemDescription { get; set; }

    }







    /*************************************************
 * Author: Alenzy
 * This class is used for all pizza menu items and
 * inherits from the menu item class as its child. It
 * contains ll properties and methods that relate to
 * Pizza menu items.
 * 
 ***************************************************/
    class Pizza : Menu_Item
    {

        public string Size { get; set; }

        public string CrustType { get; set; }

        public float Price { get; set; }

        public int NumberOfToppings { get; set; }

        private const float Price_Small = 6.00F;
        private const float Price_Medium = 8.00F;
        private const float Price_Large = 10.00F;
        private const float Price_XtraLarge = 12.00F;

        private const float Crust_Hand_Tossed = 0.00F;
        private const float Crust_Thin = 1.00F;
        private const float Crust_Pan = 1.50F;
        private const float Crust_Brooklyn = 2.00F;

        private const float Topping = 0.50F;


        internal static float CalculatePriceOfPizza(Pizza customerPizza)
        {

            float toppingCost = 0F;
            float pizzaPrice = 0F;



            switch (customerPizza.Size)
            {
                case "Small":

                    toppingCost = customerPizza.NumberOfToppings * Topping;
                    if (customerPizza.CrustType == "Crunchy Thin")

                    {

                        pizzaPrice = Price_Small + Crust_Thin + toppingCost;

                    }

                    else if (customerPizza.CrustType == "Hand Tossed")
                    {

                        pizzaPrice = Price_Small + Crust_Hand_Tossed + toppingCost;

                    }
                    else
                    {


                        pizzaPrice = Price_Small + Crust_Pan + toppingCost;

                    }

                    break;


                case "Medium":
                    toppingCost = (customerPizza.NumberOfToppings * Topping) * 1.25F;
                    if (customerPizza.CrustType == "Crunchy Thin")

                    {
                        pizzaPrice = Price_Medium + Crust_Thin + toppingCost;


                    }
                    else if (customerPizza.CrustType == "Hand Tossed")
                    {

                        pizzaPrice = Price_Medium + Crust_Hand_Tossed + toppingCost;

                    }
                    else
                    {

                        pizzaPrice = Price_Medium + Crust_Pan + toppingCost;

                    }

                    break;

                case "Large":
                    toppingCost = (customerPizza.NumberOfToppings * Topping) * 1.50F;
                    if (customerPizza.CrustType == "Crunchy Thin")

                    {
                        pizzaPrice = Price_Large + Crust_Thin + toppingCost;


                    }
                    else if (customerPizza.CrustType == "Hand Tossed")
                    {

                        pizzaPrice = Price_Large + Crust_Hand_Tossed + toppingCost;

                    }
                    else if (customerPizza.CrustType == "Brooklyn")
                    {
                        pizzaPrice = Price_Large + Crust_Brooklyn + toppingCost;
                    }
                    else
                    {

                        pizzaPrice = Price_Large + Crust_Pan + toppingCost;

                    }

                    break;


                case "Xtra Large":
                    toppingCost = (customerPizza.NumberOfToppings * Topping) * 2.00F;
                    pizzaPrice = Price_XtraLarge + Crust_Brooklyn + toppingCost;
                    break;

                default:
                    pizzaPrice = 0F;
                    break;


            }
            return pizzaPrice;


        }





    }


}

