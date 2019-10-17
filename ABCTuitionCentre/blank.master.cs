using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class blank : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.Params["MsgContent"] != null)
            {
                string MsgContent = Convert.ToString(Request.Params["MsgContent"]).Trim();
                MainRadNotification.Text = MsgContent;
                MainRadNotification.Title = "ABC Tuition Center";
                if (Request.Params["MsgTitle"] != null)
                {
                    MainRadNotification.Title = Convert.ToString(Request.Params["MsgTitle"]).Trim();
                }
                MainRadNotification.TitleIcon = "info";
                MainRadNotification.ContentIcon = "info";
                if (Request.Params["MsgType"] != null)
                {
                    string MsgType = Convert.ToString(Request.Params["MsgType"]).Trim();
                    MainRadNotification.TitleIcon = MsgType;
                    MainRadNotification.ContentIcon = MsgType;
                }

                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.Center;
                if (Request.Params["MsgPos"] != null)
                {
                    switch (Convert.ToString(Request.Params["MsgPos"]).Trim().ToUpper())
                    {
                        case "1":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.TopLeft;
                                break;
                            }
                        case "2":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.TopCenter;
                                break;
                            }
                        case "3":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.TopRight;
                                break;
                            }
                        case "4":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.MiddleLeft;
                                break;
                            }
                        case "5":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.Center;
                                break;
                            }
                        case "6":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.MiddleRight;
                                break;
                            }
                        case "7":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.BottomLeft;
                                break;
                            }
                        case "8":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.BottomCenter;
                                break;
                            }
                        case "9":
                            {
                                MainRadNotification.Position = Telerik.Web.UI.NotificationPosition.BottomRight;
                                break;
                            }
                    }

                }
                MainRadNotification.Animation = Telerik.Web.UI.NotificationAnimation.Fade;
                MainRadNotification.Show();
            }
        }
    }
}
