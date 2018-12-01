using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPrac3Exer2
{
    public partial class ConfirmOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                lblTimeNow.Text = "Ordered received at " + DateTime.Now.ToString();
            }

            if(PreviousPage !=null && PreviousPage.IsCrossPagePostBack)
            {
                RadioButtonList radioSetSelected = PreviousPage.FindControl("rblSet") as RadioButtonList;
                CheckBox checkBoxSet1 = PreviousPage.FindControl("cbSet1") as CheckBox;
                TextBox txtQty1 = PreviousPage.FindControl("txtSet1") as TextBox;
                CheckBox checkBoxSet2 = PreviousPage.FindControl("cbSet2") as CheckBox;
                TextBox txtQty2 = PreviousPage.FindControl("txtSet2") as TextBox;
                CheckBox checkBoxSet3 = PreviousPage.FindControl("cbSet3") as CheckBox;
                TextBox txtQty3 = PreviousPage.FindControl("txtSet3") as TextBox;
                Label lblPrice1 = PreviousPage.FindControl("lblPriceSet1") as Label;
                Label lblPrice2 = PreviousPage.FindControl("lblPriceSet2") as Label;
                Label lblPrice3 = PreviousPage.FindControl("lblPriceSet3") as Label;
                Label lblTotal = PreviousPage.FindControl("lblTotalPrice") as Label;

                if (checkBoxSet1.Checked == true)
                {
                    lblOrder.Text += txtQty1.Text + " * Set 1 ordered     Price : RM" + lblPrice1.Text + "<br/>";
                }

                if (checkBoxSet2.Checked == true)
                {
                    lblOrder.Text += txtQty2.Text + " * Set 2 ordered     Price : RM" + lblPrice2.Text + "<br/>";
                }

                if (checkBoxSet3.Checked == true)
                {
                    lblOrder.Text += txtQty3.Text + " * Set 3 ordered     Price : RM" + lblPrice3.Text + "<br/>";
                }

                lblOrder.Text += "<br/>Total == > RM " + lblTotal.Text;

                DateTime receiveTime = DateTime.Now;
                DateTime x25later = receiveTime.AddMinutes(25);

                lblReceiveTime.Text = "Order will be sent at = " + x25later.ToString();
                
                
            }
        }
    }
}