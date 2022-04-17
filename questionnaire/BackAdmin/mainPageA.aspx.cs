using questionnaire.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace questionnaire.BackAdmin
{
    public partial class mainPageA : System.Web.UI.Page
    {
        private bool _isEditMode = false;

        private QuesContentsManager _mgrQuesContents = new QuesContentsManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            // 做編輯模式或新增模式的判斷
            if (!string.IsNullOrWhiteSpace(this.Request.QueryString["ID"]))
                this._isEditMode = true;
            else
                this._isEditMode = false;


            if (this._isEditMode)
                this.InitEditMode();
            else
                this.InitCreateMode();

        }

        /// <summary> 新增模式初始化 </summary>
        private void InitCreateMode()
        {
            this.txtStartDate.Text = DateTime.Now.ToString();
            this.txtEndDate.Text = string.Empty;
            this.ckbPaper.Checked = true;
        }
        /// <summary> 編輯模式初始化 </summary>
        private void InitEditMode()
        {
            string idText = this.Request.QueryString["ID"];
            string url = this.Request.Url.LocalPath + "?ID=" + idText;
            this.Response.Redirect(url);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}