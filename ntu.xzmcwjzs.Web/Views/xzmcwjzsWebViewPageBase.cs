using Abp.Web.Mvc.Views;

namespace ntu.xzmcwjzs.Web.Views
{
    public abstract class xzmcwjzsWebViewPageBase : xzmcwjzsWebViewPageBase<dynamic>
    {

    }

    public abstract class xzmcwjzsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected xzmcwjzsWebViewPageBase()
        {
            LocalizationSourceName = xzmcwjzsConsts.LocalizationSourceName;
        }
    }
}