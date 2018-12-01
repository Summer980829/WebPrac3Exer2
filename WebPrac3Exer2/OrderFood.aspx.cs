using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPrac3Exer2
{
    public partial class OrderFood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void rblSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblSet.SelectedIndex == 0)
            {
                lblSetDetail.Text = "<u>Menu for Set 1</u><br/>Nasi Lemak<br/>Chicken Rendang<br/>Teh Tarik<br/><b>RM 12.50</b>";

            } else if(rblSet.SelectedIndex == 1){
                lblSetDetail.Text = "<u>Menu for Set 2</u><br/>Mee Goreng<br/>Fried Egg<br/>Teh Tarik<br/><b>RM 8.50</b>";
            }
            else
            {
                lblSetDetail.Text = "<u>Menu for Set 3</u><br/>Chicken Sausages<br/>Omelette<br/>Read Beans<br/>Cofee<br/><b>RM 10.50</b>";
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double q1, q2, q3, total=0;
            double q1Total, q2Total, q3Total;

            if (cbSet1.Checked == true)
            {
                if (txtSet1.Text == "")
                {
                    q1Total = 0.00;
                    txtSet1.Text = "0";
                }
                else
                {
                    q1 = int.Parse(txtSet1.Text);
                    q1Total = q1 * 12.50;
                    total += q1Total;
                }
                lblPriceSet1.Text = q1Total.ToString("0.00");

            }
            //else { txtSet1.Text = "0"; }
           

            if (cbSet2.Checked == true)
            {
                if (txtSet2.Text == "")
                {
                    q2Total = 0.00;
                    txtSet2.Text = "0";
                }
                else
                {
                    q2 = int.Parse(txtSet2.Text);
                    q2Total = q2 * 8.50;
                    total += q2Total;
                }
                lblPriceSet2.Text = q2Total.ToString("0.00");

            }
            //else { txtSet2.Text = "0"; }



            if (cbSet3.Checked == true)
            {
                if (txtSet3.Text == "")
                {
                    q3Total = 0;
                    txtSet3.Text = "0";
                }
                else
                {
                    q3 = int.Parse(txtSet3.Text);
                    q3Total = q3 * 10.50;
                    total += q3Total;
                }
                lblPriceSet3.Text = q3Total.ToString("0.00");

            }
            //else { txtSet3.Text = "0"; }


            if (cbSet1.Checked == false && cbSet2.Checked ==false && cbSet3.Checked == false)
            {
                total += 0;
            }
            lblTotalPrice.Text = total.ToString("0.00");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            rblSet.ClearSelection();
            lblSetDetail.Text = "";

            cbSet1.Checked = false;
            txtSet1.Text = "";
            lblPriceSet1.Text = "";

            cbSet2.Checked = false;
            txtSet2.Text = "";
            lblPriceSet2.Text = "";

            cbSet3.Checked = false;
            txtSet3.Text = "";
            lblPriceSet3.Text = "";

            lblTotalPrice.Text = "";

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}