﻿using Abp.Web.Mvc.Views;

namespace SimpleTask.Web.Views
{
    public abstract class SimpleTaskWebViewPageBase : SimpleTaskWebViewPageBase<dynamic>
    {

    }

    public abstract class SimpleTaskWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SimpleTaskWebViewPageBase()
        {
            LocalizationSourceName = SimpleTaskConsts.LocalizationSourceName;
        }
    }
}