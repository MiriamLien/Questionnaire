﻿using questionnaire.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace questionnaire.BackAdmin
{
    public partial class listPageA : System.Web.UI.Page
    {
        private QuesContentsManager _mgrQuesContents = new QuesContentsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            string keyword = string.Empty;
            var quesList = this._mgrQuesContents.GetQuesContentsList(keyword);
            this.rptList.DataSource = quesList;
            this.rptList.DataBind();
        }

        protected void ImgBtnDel_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImgBtnAdd_Click(object sender, ImageClickEventArgs e)
        {
            //導至新建頁面
            Response.Redirect("mainPageA.aspx");
        }
    }
}