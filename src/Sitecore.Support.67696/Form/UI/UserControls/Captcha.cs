using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Resources.Media;
using System;

namespace Sitecore.Support.Form.UI.UserControls
{
  public class Captcha : Sitecore.Form.UI.UserControls.Captcha
  {
    protected override void OnInit(EventArgs e)
    {
      base.OnInit(e);
      //modified part of code: 
      if (LinkManager.AlwaysIncludeServerUrl)
      {
        Item innerItem = Sitecore.Context.Database.GetItem("/sitecore/media library/web forms for marketers/icons/refresh");
        if (innerItem != null)
        {
          base.captchaCode.CaptchaRefreshButton.ImageUrl = MediaManager.GetMediaUrl(new MediaItem(innerItem));
        }
        innerItem = Sitecore.Context.Database.GetItem("/sitecore/media library/web forms for marketers/icons/loudspeaker");
        if (innerItem != null)
        {
          base.captchaCode.CaptchaPlayButton.ImageUrl = MediaManager.GetMediaUrl(new MediaItem(innerItem));
        }
      }
      //end of the modified part
    }
  }
}
